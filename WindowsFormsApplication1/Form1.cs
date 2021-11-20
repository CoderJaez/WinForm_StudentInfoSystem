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
using WindowsFormsApplication1.Repositories;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private StudentViewModel viewModel;
        public DataGridView DgStudent { get { return dgStudent; } }
        public TextBox StudentId { get { return tbStudentId; } }

        public Form1()
        {
            InitializeComponent();
            viewModel = new StudentViewModel();
            viewModel.form = this;
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(viewModel.model == null)
            {
                viewModel.model = new StudentModel {
                    UserId = tbStudentId.Text,
                    Lastname = tbLastname.Text,
                    Middlename = tbMidlename.Text,
                    Firstname = tbFirstname.Text,
                    Gender = cbGender.Text,
                    Birthday = dtpBirthday.Value.ToString()
                };
                 viewModel.AddStudent();
            } else
            {
                 viewModel.UpdateStudent();
            }

        }

        public void ClearField()
        {
            tbStudentId.Clear();
            tbFirstname.Clear();
            tbLastname.Clear();
            tbMidlename.Clear();

        }

        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgStudent.Rows.Count > 0)
            {
                var currentRow = dgStudent.CurrentRow;
                switch(dgStudent.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                        tbStudentId.Enabled = false;
                        tbStudentId.Text = currentRow.Cells["UserId"].Value.ToString();
                        tbLastname.Text = currentRow.Cells["Lastname"].Value.ToString();
                        tbFirstname.Text = currentRow.Cells["Firstname"].Value.ToString();
                        tbMidlename.Text = currentRow.Cells["Middlename"].Value.ToString();
                        cbGender.Text = currentRow.Cells["Gender"].Value.ToString();
                        viewModel.model = new StudentModel
                        {
                            UserId = tbStudentId.Text,
                            Firstname = tbStudentId.Text,
                            Lastname = tbLastname.Text,
                        };
                        break;
                }
            }
        }

        public void LoadData()
        {
            dgStudent.Rows.Clear();
            DataAccess.Get<StudentModel>("studnet.txt").ForEach(student =>
            {
                dgStudent.Rows.Add(
                    student.UserId,
                    student.Lastname,
                    student,Firstname,
                    student.Middlename,
                    student.Gender,
                    student.Birthday
                    );
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<StudentModel>();
            foreach (DataGridViewRow row in dgStudent.Rows)
            {
                list.Add(new StudentModel
                {
                    UserId = row.Cells["UserId"].Value.ToString(),
                    Firstname = row.Cells["Firstname"].Value.ToString(),
                    Middlename = row.Cells["Middlename"].Value.ToString(),
                    Lastname = row.Cells["Lastname"].Value.ToString(),
                    Gender = row.Cells["Gender"].Value.ToString(),
                    Birthday = row.Cells["Birthday"].Value.ToString()
                });
            }

            DataAccess.SaveToTextFile(list, "studnet.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
    
}
