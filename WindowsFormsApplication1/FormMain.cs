using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.View;

namespace WindowsFormsApplication1
{
    public partial class FormMain : Form
    {
        private DashboardUC dashboarUC;
        private UserUC userUC;

        public FormMain()
        {
            InitializeComponent();
        }



        private void Menu_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch(btn.Text)
            {
                case "Dashboard":
                    if(!MainPanel.Controls.ContainsKey("DashboardUC"))
                    {
                        dashboarUC = new DashboardUC();
                        dashboarUC.Dock = DockStyle.Fill;
                        MainPanel.Controls.Add(dashboarUC);
                    }
                    MainPanel.Controls["DashboardUC"].BringToFront();
                    break;
                case "User":
                    if (!MainPanel.Controls.ContainsKey("UserUC"))
                    {
                        userUC = new UserUC();
                        userUC.Dock = DockStyle.Fill;
                        MainPanel.Controls.Add(userUC);
                    }
                    userUC.LoadData();
                    MainPanel.Controls["UserUC"].BringToFront();
                    break;
            }
        }
    }
}
