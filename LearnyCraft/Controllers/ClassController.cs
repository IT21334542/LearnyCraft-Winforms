using LearnyCraft.DAO;
using LearnyCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.Controllers
{
    internal class ClassController
    {
            
        public ClassController() 
        { 

        }

        public void assignDatatoGrid(DataGridView grid)
        {
            ClassDAO dataObj = new ClassDAO();

            List<ClassModle> classlist = dataObj.getAllClasses();

            grid.DataSource = classlist;
        }


        public void refreshGrid(DataGridView grid)
        {
            assignDatatoGrid((DataGridView)grid);
        }

        public bool update(ClassModle c)
        {
            ClassDAO dao = new ClassDAO();
            return dao.updateClass(c);
        }


        public bool delete(String s)
        {
            ClassDAO classdao = new ClassDAO();
            return classdao.deleteClass(s);
        }


        public bool addNewClass(String s)
        {
            ClassDAO classdao = new ClassDAO();
            Random rand = new Random();
            String ClassId ="CL"+rand.Next(0,99).ToString();
            List<String> idList = classdao.getAllClassIds();
            while(idList.Contains(ClassId))
            {
                ClassId = "CL" + rand.Next(0, 99).ToString();
            }
            ClassModle c = new ClassModle();
            c.ClassName = s;
            c.ClassId = ClassId;
            return classdao.addClass(c);


        }


        public List<String> getClassNameList()
        {
            ClassDAO cDAO = new ClassDAO();
            return cDAO.getAllClassNames();

        }

        
    }
}
