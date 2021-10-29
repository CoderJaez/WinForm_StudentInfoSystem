using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ViewModel;
using WindowsFormsApplication1.Model;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private StudentViewModel viewModel;
        public DataGridView DgStudent { get { return dgStudent; } }
        public Form1()
        {
            InitializeComponent();
            viewModel = new StudentViewModel();
            viewModel.form = this;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(viewModel.model == null)
            {
                viewModel.model = new StudentModel {
                    Lastname = tbLastname.Text,
                    Middlename = tbMidlename.Text,
                    Firstname = tbFirstname.Text,
                    Gender = cbGender.Text,
                    Birthday = dtpBirthday.Value
                };
                 viewModel.AddStudent();
            }

        }

        public void ClearField()
        {
            tbFirstname.Clear();
            tbLastname.Clear();
            tbMidlename.Clear();

        }
    }
}
