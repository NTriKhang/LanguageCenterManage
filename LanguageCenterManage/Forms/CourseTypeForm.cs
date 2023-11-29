using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Forms.SubForm;
using LanguageCenterManage.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Forms
{
    public partial class CourseTypeForm : MaterialForm
    {
        private CourseType _courseType;
        private readonly AppDbContext _db;
        public CourseTypeForm()
        {
            _db = new AppDbContext();
            InitializeComponent();
        }
        public CourseTypeForm(string languageId)
        {
            _db = new AppDbContext();
            _courseType = _db.CourseType.SingleOrDefault(x => x.Id == languageId);
            InitializeComponent();
        }

        private void LanguageDetail_Load(object sender, EventArgs e)
        {
            if (_courseType != null)
            {
                idTextbox.Text = _courseType.Id;
                nameTextbox.Text = _courseType.Name;
                btnCreate.Visible = false;
                bandDTOBindingSource.DataSource = _db.Bands.Where(x => x.CourseTypeId == _courseType.Id)
                                                            .Select(x => new BandDTO
                                                            {
                                                                Band = x.BandNumber
                                                            })
                                                            .OrderBy(x => x.Band)
                                                            .ToList();
                dataGridView1.ReadOnly = true;
            }
            else
            {
                idTextbox.Text = Guid.NewGuid().ToString().Substring(0, 7);
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                EditBandBtn.Visible = false;
                bandDTOBindingSource.DataSource = new List<BandDTO>();
            }

        }
        private void InsertBands(string languageId)
        {
            List<Band> bands = new List<Band>();
            foreach (var bandDTO in bandDTOBindingSource.DataSource as List<BandDTO>)
            {
                bands.Add(new Band
                {
                    Id = Guid.NewGuid().ToString().Substring(0, 4),
                    BandNumber = bandDTO.Band,
                    CourseTypeId = languageId,
                });
            }
            _db.Bands.AddRange(bands);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            try
            {
                if (isModelValid())
                {
                    var language = new CourseType()
                    {
                        Id = idTextbox.Text,
                        Name = nameTextbox.Text,
                    };
                    _db.CourseType.Add(language);
                    InsertBands(language.Id);
                    _db.SaveChanges();
                    DialogResult box = MessageBox.Show("New Language was added to db", "Create successfully", MessageBoxButtons.OK);
                    Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isModelValid())
                {
                    var language = new CourseType() { Id = idTextbox.Text, Name = nameTextbox.Text };
                    _db.CourseType.AddOrUpdate(language);
                    if (dataGridView1.Enabled)
                    {
                        var bands = _db.Bands.Where(x => x.CourseType.Id == language.Id).ToList();
                        _db.Bands.RemoveRange(bands);
                        InsertBands(language.Id);
                    }
                    _db.SaveChanges();
                    DialogResult box = MessageBox.Show("Language was updated to db", "Update successfully", MessageBoxButtons.OK);
                    Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private bool isModelValid()
        {
            if (nameTextbox.Text.Trim() == "")
            {
                DialogResult box = MessageBox.Show("Name should not be empty", "400", MessageBoxButtons.OK);
                return false;
            }
            else if((bandDTOBindingSource.DataSource as List<BandDTO>).Count == 0)
            {
                DialogResult box = MessageBox.Show("Must define bands for this type", "Conflict", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Are you sure to delete it ?", "Sure ?", MessageBoxButtons.YesNo);

            if (box == DialogResult.Yes)
            {
                _db.CourseType.Remove(_courseType);
                var bands = _db.Bands.Where(x => x.CourseType.Id == _courseType.Id).ToList();
                _db.Bands.RemoveRange(bands);
                
                _db.SaveChanges();
                Close();
            }
        }

        private void EditBandBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }
    }
}
