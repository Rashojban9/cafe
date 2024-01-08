using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bislerium_cafe
{
    public partial class nav : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse

     );
        public nav()
        {
            InitializeComponent(); Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);

            lblTabTitle.Text = "Dashboard";
            this.pnlContent.Controls.Clear();
            Dashboard FrmDashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void ButtonColorReset(Button button)
        {
            Color activeColor = Color.FromArgb(31, 27, 48);
            Color btnColor = Color.FromArgb(26, 23, 40);
            btnDashboard.BackColor = btnColor;
           
            btnEmployees.BackColor = btnColor;
            btnCustomers.BackColor = btnColor;
            btnReprts.BackColor = btnColor;
            btnCoffee.BackColor = btnColor;
            btnAddons.BackColor = btnColor;


            btnSettings.BackColor = btnColor;
            button.BackColor = activeColor;
        }

       
        

       

       
        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void panelevent_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnDashboard_Click_2(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnDashboard.Height;
            pnlNavIndicator.Top = btnDashboard.Top;
            pnlNavIndicator.Left = btnDashboard.Left;
            ButtonColorReset(btnDashboard);
            lblTabTitle.Text = "Dashboard";
            this.pnlContent.Controls.Clear();
            Dashboard FrmDashboard_Vrb = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            pnlNavIndicator.Height = btnCustomers.Height;
            pnlNavIndicator.Top = btnCustomers.Top;
            pnlNavIndicator.Left = btnCustomers.Left;
            ButtonColorReset(btnCustomers);
            lblTabTitle.Text = "Customer";
            this.pnlContent.Controls.Clear();
            Adminemployee FrmDashboard_Vrb = new Adminemployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlContent.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
    }

