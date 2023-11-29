using LanguageCenterManage.DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageCenterManage.Services.ExcelService
{
    public class ExcelService
    {
        public bool ExportUserDto(List<List<UserDTO>> listUserDTOs)
        {
			try
			{
                using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Excel workbook|*.xls" })
                {
                    if (sdf.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = sdf.FileName;
                        Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                        Workbook workbook = application.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet worksheet = (Worksheet)application.ActiveSheet;
                        application.Visible = false;
                        int index = 1;
                        worksheet.Cells[1, 1] = nameof(UserDTO.Id);
                        worksheet.Cells[1, 2] = nameof(UserDTO.FirstName);
                        worksheet.Cells[1, 3] = nameof(UserDTO.LastName);
                        worksheet.Cells[1, 4] = nameof(UserDTO.Email);
                        worksheet.Cells[1, 5] = nameof(UserDTO.Phone);
                        worksheet.Cells[1, 6] = nameof(UserDTO.Birth);
                        worksheet.Cells[1, 7] = nameof(UserDTO.Band);

                        int groupNumber = 1;
                        foreach (var userDTOs in listUserDTOs)
                        {
                            index++;
                            worksheet.Cells[index, 1] = "Nhom " + groupNumber.ToString();
                            foreach (var user in userDTOs)
                            {
                                index++;
                                worksheet.Cells[index, 1] = user.Id;
                                worksheet.Cells[index, 2] = user.FirstName;
                                worksheet.Cells[index, 3] = user.LastName;
                                worksheet.Cells[index, 4] = user.Email;
                                worksheet.Cells[index, 5] = user.Phone;
                                worksheet.Cells[index, 6] = user.Birth;
                                worksheet.Cells[index, 7] = user.Band;
                            }
                            groupNumber++;
                        }

                        worksheet.SaveAs(fileName);
                        application.Quit();
                        return true;
                    }
                    return false;
                }
            }
			catch (Exception)
			{
                MessageBox.Show("SystemError", "500", MessageBoxButtons.OK);
                return false;
			}
        }
    }
}
