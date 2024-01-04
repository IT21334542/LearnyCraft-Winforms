using LearnyCraft.DAO;
using LearnyCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.Controllers
{
    
    internal class MarksController
    {
        private DataGridView grid;

        public MarksController()
        {
            
        }

        public void RefreshGrid(DataGridView g,String grade)
        {
           
            StudentDAO stDao = new StudentDAO();
            gpaDAO gpaDao = new gpaDAO();
            List<MGridGuider> gridList = new List<MGridGuider>();
            grid = g;
            List<StudentModel> stlist = stDao.getStudentByGrade(grade);
            if (stlist != null)
            {
                foreach (StudentModel st in stlist)
                {
                    MGridGuider newRow = new MGridGuider();
                    GPAmodel gpa = gpaDao.getTotals(st.StudentId, grade);
                    
                    newRow.StudentName = st.StudentName;
                    newRow.Studentid = st.StudentId;
                    if (gpa != null)
                    {
                        
                        newRow.Total = gpa.Total;
                        newRow.Average = gpa.Avg;
                    }
                    else
                    {
                        newRow.Total = 0;
                        newRow.Average = 0;
                    }
                    gridList.Add(newRow);
                }
                grid.DataSource = gridList;
            }
            
        }

        public void refreshMarksgrid(DataGridView g, String sid,String Grade)
        {
            //modname modecode marks
            MarksDao mDao = new MarksDao();
            ModuleDao modDao = new ModuleDao();
            StudentDAO stDao = new StudentDAO();
            List<MarksHolder> mHlist = new List<MarksHolder>();
            //List<MarksModel> marksList= mDao.getMarksofoneStudent(sid);

            List<ModulesModel> modulesForSem = modDao.getModulesByGrade(Grade);

            if(modulesForSem!=null)
            {
                foreach (ModulesModel module in modulesForSem)
                {
                    MarksHolder mH = new MarksHolder();
                    mH.StudentName = stDao.getStudentByid(sid).StudentName;
                    mH.StudentId = sid;
                    mH.ModuleCode = module.ModuleCode;
                    mH.ModuleName = module.ModuleName;
                    mH.Marks = mDao.getMarksofOneStudent(mH.StudentId,mH.ModuleCode);
                    mHlist.Add(mH);
                }
                g.DataSource = mHlist;

            }
            else
            {
                //no modules available for this selected sem
                MessageBox.Show("No Modules offering for this grade");
                g.DataSource = mHlist;
            }

            /*
            if(marksList != null)
            {
                foreach(MarksModel mark in marksList)
                {
                    MarksHolder mH = new MarksHolder();
                    mH.StudentId = mark.Studentid;
                    mH.ModuleCode = mark.ModuleId;
                    mH.ModuleName = modDao.getModuleName(mark.ModuleId);
                    mH.Marks = mark.Marks;
                    mHlist.Add(mH);
                }
                
            }
            else
            {
                MarksHolder mH = new MarksHolder();
                mH.StudentId = sid;
                mH.ModuleCode = "MOD0000";
                mH.ModuleName = "NOT_FOUND";
                mH.Marks = mark.Marks;
                mHlist.Add(mH);

            }*/

        }

        public String getStudentName(String sid)
        {
            StudentDAO studentDAO = new StudentDAO();
            return studentDAO.getStudentByid(sid).StudentName;
        }

        public void addMarks(List<MarksHolder> mHlist)
        {
            MarksDao mdao = new MarksDao();
            foreach (MarksHolder mH in mHlist)
            {
                MarksModel marks = new MarksModel();
                marks.Studentid = mH.StudentId;
                marks.ModuleId = mH.ModuleCode;
                marks.Marks = mH.Marks;
                mdao.AddMarks(marks);
            }
        }


        public void updateMarks(List<MarksHolder> mHlist)
        {
            MarksDao mdao = new MarksDao();
            List<MarksModel> mlixt = new List<MarksModel>();
            foreach (MarksHolder mH in mHlist)
            {
                MarksModel marks = new MarksModel();
                marks.Studentid = mH.StudentId;
                marks.ModuleId = mH.ModuleCode;
                marks.Marks = mH.Marks;
                mlixt.Add(marks);
            }
            mdao.updateMarksofStudent(mlixt);
        }

        public void addTotal(GPAmodel gp)
        {
            
            gpaDAO gdao = new gpaDAO();
            gdao.addGPA(gp);

        }


        public void updateTotal(GPAmodel gp)
        {
            gpaDAO gdao = new gpaDAO();
            gdao.update(gp);

        }


        public bool isAlreadyHaveMarks(String sid,String grade)
        {
            gpaDAO gpaDAO = new gpaDAO();
            if (gpaDAO.getTotals(sid, grade) !=null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

  


        public GPAmodel getTotal(String sid,String grade)
        {
            gpaDAO gDao = new gpaDAO();
            GPAmodel a = gDao.getTotals(sid, grade);
            if(a != null)
            { return a; }
            else
            {
                a = new GPAmodel();
                a.Studentid = sid;
                a.Grade = grade;
                a.Total = 0;
                a.Avg = 0;
                return a;
            }
        }

    }
}
