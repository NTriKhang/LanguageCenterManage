using LanguageCenterManage.DAL;
using LanguageCenterManage.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Forms
{
    public partial class BillDetail : MaterialForm
    {
        AppDbContext db = new AppDbContext();
        Bill bill = new Bill();
        string UserId = USER.UserId.ToString();
        public string JoinId { get; set; }
        public string StudentId { get; set; }
        public BillDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void initBill(string JoinId)
        {
            bill.Id = Guid.NewGuid().ToString().Substring(0, 7);
            bill.DatePay = null;
            bill.UserConfirmId = UserId;
            bill.Cost = db.Bills.Include(nameof(Bill.Join))
                                   .Include(nameof(Join.Class))
                                   .Include(nameof(Class.Course))
                                   .Where(x => x.Join.Id == JoinId)
                                   .Select(x => x.Join.Class.Course.TuiTion)
                                   .FirstOrDefault();
            bill.State = false;
            bill.JoinId = JoinId;
            db.Bills.Add(bill);
            db.SaveChanges();
        }
        public void deleteBill(string JoinId)
        {
            bill = db.Bills.Include(nameof(Bill.Join)).Where(x => x.Join.Id == JoinId).FirstOrDefault();
            db.Bills.Remove(bill);
            db.SaveChanges();
        }
        public void updateBill()
        {
            bill.Id = txtBillId.Text;
            if(DateTime.TryParseExact(txtDatePay.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                bill.DatePay = date;
            }
            else
            {
                bill.DatePay = null;
            }
            bill.UserConfirmId = UserId;
            bill.Cost = Decimal.Parse(txtCost.Text);
            bill.State = CheckBoxState.Checked;
            bill.JoinId = JoinId;
            db.SaveChanges();
        }
        private void BillDetail_Load(object sender, EventArgs e)
        {
            bill = db.Bills.Include(nameof(Bill.Join)).Where(x => x.Join.Id == JoinId).FirstOrDefault();
            if(bill != null)
            {
                txtBillId.Text = bill.Id;
                if (bill.State == false)
                {
                    txtDatePay.Text = "--/--/----";
                }
                else
                {
                    txtDatePay.Text = DateTime.Now.ToString("MM/dd/yyyy");
                }
                txtUserConfirmId.Text = bill.UserConfirmId.ToString();
                txtUserConfirmName.Text = db.Users.Where(x => x.Id == UserId)
                                                  .Select(x => x.LastName + " " + x.FirstName)
                                                  .FirstOrDefault().ToString();
                txtCost.Text = bill.Cost.ToString();
                txtCourseName.Text = db.Bills
                                       .Include(nameof(Bill.Join))
                                       .Include(nameof(Join.Class))
                                       .Include(nameof(Class.Course))
                                       .Where(x => x.Join.Id == JoinId)
                                       .Select(x => x.Join.Class.Course.Name)
                                       .FirstOrDefault().ToString();
                txtStudentName.Text = db.Students
                                       .Where(x => x.Id == StudentId)
                                       .Select(x => x.LastName + " " + x.FirstName)
                                       .FirstOrDefault().ToString();
                CheckBoxState.Checked = bill.State;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CheckBoxState_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxState.Checked)
            {
                txtDatePay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                txtDatePay.Text = "--/--/----";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateBill();
            MessageBox.Show("Update successfully", "Bill have updated to db", MessageBoxButtons.OK);
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(PanelBill.Width, PanelBill.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                PanelBill.DrawToBitmap(bmp, new Rectangle(0, 0, PanelBill.Width, PanelBill.Height));
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Files (*.png)|*png|All Files (*.*)|*.*";
                saveDialog.DefaultExt = "png";
                saveDialog.AddExtension = true;

                if(saveDialog.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("The image has been exported");
                }
            }
        }

        private void PanelBill_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}