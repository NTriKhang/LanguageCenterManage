using LanguageCenterManage.DAL;
using LanguageCenterManage.DTO;
using LanguageCenterManage.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Services.Kmean
{
    public partial class StudentEachYear : Form
    {
        private AppDbContext _db;
        public int Year { set; get; }   
        public int Quantity { set; get; }
        public StudentEachYear()
        {
            _db = new AppDbContext();
            InitializeComponent();
        }

        private void StudentEachYear_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CenterConnectionString"].ConnectionString;
            var studentEachYears = new List<StudentEachYearDTO>();
            using (var sqlConn = new SqlConnection(connectionString))
            {
                var sqlcmd = new SqlCommand("GetQuantityByYear", sqlConn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlConn.Open();
                var sdr = sqlcmd.ExecuteReader();
                while (sdr.Read())
                {
                    var studentEachYear = new StudentEachYearDTO
                    {
                        Quantity = Convert.ToInt32(sdr["quantity"]),
                        Year = Convert.ToInt32(sdr["year"])
                    };
                    studentEachYears.Add(studentEachYear);
                }
            }
            studentEachYearDTOBindingSource.DataSource = studentEachYears;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowSelected = (studentEachYearDTOBindingSource.DataSource as List<StudentEachYearDTO>).ElementAtOrDefault(e.RowIndex);
            Year = rowSelected.Year;
            Quantity = rowSelected.Quantity;
            Close();
        }
    }
}
