using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.View
{
    public partial class UserUC : UserControl
    {
        public UserUC()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            MessageBox.Show("Rendering Data...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = new StudentModel { Lastname = tbLastname.Text, Firstname = tbFirstname.Text };
            var context = new ValidationContext(student);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(student, context, results, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (var result in results)
                    errorMsg.Append($"{result}\n");

                MessageBox.Show(errorMsg.ToString());
                return;
            }

            MessageBox.Show("Success");

            
        }
    }
}
