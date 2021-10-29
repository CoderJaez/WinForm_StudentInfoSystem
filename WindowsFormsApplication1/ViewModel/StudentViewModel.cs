using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
