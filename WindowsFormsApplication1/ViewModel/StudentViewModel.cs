using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.ViewModel
{
    class StudentViewModel
    {
        public StudentModel model;
        public Form1 form;

        public void GetStudents()
        {

        }

        public void AddStudent()
        {
            form.DgStudent.Rows.Add(
                model.UserId,
                model.Lastname,
                model.Firstname,
                model.Middlename,
                model.Gender,
                model.Birthday
                );
            model = null;
            form.ClearField();
        }

        public void  UpdateStudent()
        {

            for (int index = 0; index < form.DgStudent.Rows.Count; index++)
            { 
                if (form.DgStudent.Rows[index].Cells["UserId"].Value.ToString() == model.UserId)
                {
                    form.DgStudent.Rows[index].Cells["Lastname"].Value = model.Lastname;
                    break;
                }
            }
           

            model = null;
            form.StudentId.Enabled = true;
           
        }
    }
}
