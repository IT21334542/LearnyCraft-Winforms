using LearnyCraft.DAO;
using LearnyCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.Controllers
{
    internal class StudentController
    {
        private DataGridView grid;
        private StudentDAO sDAO;
        public StudentController() 
        {
            
            sDAO = new StudentDAO();
        }

        public void assignGrid(DataGridView g)
        {
            this.grid = g;
            List<StudentModel> list = sDAO.getAllStudent();
            this.grid.DataSource = list;
        }

        public void refreshGrid(DataGridView g)
        {
            assignGrid(g);
        }


        public bool addnewst(StudentModel st)
        {
            Random rnd = new Random();
            String sid = "STD"+rnd.Next(0,999);
            st.StudentId = sid;
            return sDAO.addNewStudent(st);
        }

        public bool update(StudentModel st)
        {
            return sDAO.updateStudent(st);
        }

        public bool delete(String stid)
        {
            return sDAO.deleteStudent(stid);
        }


        
    }
}
