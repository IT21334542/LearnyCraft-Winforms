using LearnyCraft.DAO;
using LearnyCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.Controllers
{
    internal class ModuleControllers
    {
        public ModuleControllers() 
        { 
        }

        public void AssignGrid(DataGridView grid)
        {
            ModuleDao mDAO = new ModuleDao();
            List<ModulesModel> list= mDAO.getAllModules();
            grid.DataSource = list;
        }


        public void refreshGrid(DataGridView grid)
        {
            AssignGrid(grid);
        }



        public ModulesModel getTopThree() 
        {
            ModuleDao mDAO = new ModuleDao();
            List<ModulesModel> list = mDAO.getAllModules();
            return list[2];
        }

        public ModulesModel getTopTwo()
        {
            ModuleDao mDAO = new ModuleDao();
            List<ModulesModel> list = mDAO.getAllModules();
            return list[1];
        }


        public ModulesModel getTopOne()
        {
            ModuleDao mDAO = new ModuleDao();
            List<ModulesModel> list = mDAO.getAllModules();
            return list[0];
        }


        public bool addModule (ModulesModel module)
        {
            ModuleDao mDAO = new ModuleDao();
            Random rand = new Random();
            List<String> mCodeList = mDAO.getAllModuleCodes();
            string ModuleCode = "MOD"+rand.Next(0,9999);
            if (mCodeList != null)
            {
                while (mCodeList.Contains(ModuleCode))
                {
                    ModuleCode = "MOD" + rand.Next(0, 9999);
                }
            }
            module.ModuleCode = ModuleCode;
            return mDAO.addNewModule(module);


        }



        public bool Delete(String mcode)
        {
            ModuleDao mDAO = new ModuleDao();
            return mDAO.deleteModule(mcode);
           
        }



    }
}
