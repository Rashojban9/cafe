using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Bislerium_cafe
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new nav().Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usern.Text;
                string password = passw.Text;
                
                bool errorMessage = true;

                string excelPath = "C:\\Users\\rasho\\Desktop\\Application development\\staff_login_data.xlsx";

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage(new FileInfo(excelPath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 1; row <= rowCount; row++)
                    {
                        string username_ = worksheet.Cells[row, 6].Text;
                        string password_ = worksheet.Cells[row, 7].Text;
                        string auth = worksheet.Cells[row, 8].Text;

                        if (!string.IsNullOrEmpty(username_) && username_ == username && password_ == password)
                        {
                            new nav().Show();
                            this.Hide();

                            

                            
                        }
                    }

                    if (errorMessage)
                    {
                       
                    }
                }
            }
            catch (Exception ex)
            {
                
        }
    }
    }
}
