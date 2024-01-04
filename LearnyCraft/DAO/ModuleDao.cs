using LearnyCraft.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.DAO
{
    internal class ModuleDao
    {
        private MySqlConnection dbinst;
        private String ConStr = "server=127.0.0.1; username=root; database=learnycraft; password=";
        public ModuleDao() {
            dbinst = new MySqlConnection(ConStr);
        }


        public bool isDbOpen()
        {
            try
            {
                dbinst.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection not made! error : " + ex.Message);
                return false;
            }
        }


        public bool addNewModule(ModulesModel m)
        {
            if (isDbOpen()) {

                String s = "insert into modules(modulecode,modulename,graderelated) values('"+m.ModuleCode+"','"+m.ModuleName+"','"+m.GardeRelated+"')";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(s,dbinst);
                    cmd.ExecuteReader();
                    dbinst.Close();
                    return true;

                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error insertion :"+ex.Message);
                    return false;
                }



            }
            return false;
        }

        public bool deleteModule(String mid)
        {
            if (isDbOpen())
            {

                String s = "delete from modules where modulecode = '" + mid + "'";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinst);
                    cmd.ExecuteReader();
                    dbinst.Close();
                    return true;

                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error insertion :" + ex.Message);
                    return false;
                }



            }
            return false;
        }



        public bool updateModule(ModulesModel m)
        {
            if (isDbOpen())
            {

                String s = "update modules set modulename='"+m.ModuleName+ "',graderelated='"+m.GardeRelated+"' where modulecode = '" + m.ModuleCode + "'";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinst);
                    cmd.ExecuteReader();
                    dbinst.Close();
                    return true;

                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error insertion :" + ex.Message);
                    return false;
                }



            }
            return false;
        }



        public String getModuleName(String mcode)
        {
            if (isDbOpen())
            {

                String query = "select * from modules where modulecode = '"+mcode+"'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        ModulesModel newModule = new ModulesModel();
                        while (reader.Read())
                        {
                           
                            newModule.ModuleCode = reader.GetString("modulecode");
                            newModule.ModuleName = reader.GetString("modulename");
                            newModule.GardeRelated = reader.GetString("graderelated");
                           
                        }
                        reader.Close();
                        dbinst.Close();
                        return newModule.ModuleName;
                    }
                    else
                    {

                        dbinst.Close();
                        MessageBox.Show("No Module Available");
                        return "";

                    }

                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error found : " + ex.Message);
                    return "";
                }
            }
            return "";
        }


        public List<ModulesModel> getAllModules()
        {
            if (isDbOpen())
            {
                
                String query = "select * from modules";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        List<ModulesModel> list = new List<ModulesModel>();
                        while (reader.Read())
                        {
                            ModulesModel newModule = new ModulesModel();
                            newModule.ModuleCode = reader.GetString("modulecode");
                            newModule.ModuleName = reader.GetString("modulename");
                            newModule.GardeRelated = reader.GetString("graderelated");
                            list.Add(newModule);
                        }
                        reader.Close();
                        dbinst.Close();
                        return list;
                    }
                    else
                    {

                        dbinst.Close();
                        MessageBox.Show("No Modules Available");
                        return null;

                    }

                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error found : " + ex.Message);
                    return null;
                }
            }
            return null;
        }


        public List<ModulesModel> getModulesByGrade(String grade)
        {
            if (isDbOpen())
            {

                String query = "select * from modules where graderelated='"+grade+"'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        List<ModulesModel> list = new List<ModulesModel>();
                        while (reader.Read())
                        {
                            ModulesModel newModule = new ModulesModel();
                            newModule.ModuleCode = reader.GetString("modulecode");
                            newModule.ModuleName = reader.GetString("modulename");
                            newModule.GardeRelated = reader.GetString("graderelated");
                            list.Add(newModule);
                        }
                        reader.Close();
                        dbinst.Close();
                        return list;
                    }
                    else
                    {

                        dbinst.Close();
                        MessageBox.Show("No Modules Available");
                        return null;

                    }

                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error found : " + ex.Message);
                    return null;
                }
            }
            return null;
        }


        public List<String> getAllModuleCodes()
        {
            if (isDbOpen())
            {

                String query = "select modulecode from modules";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        List<String> list = new List<String>();
                        while (reader.Read())
                        {
                            //ModulesModel newModule = new ModulesModel();
                            //newModule.ModuleCode = reader.GetString("modulecode");
                            //newModule.ModuleName = reader.GetString("modulename");
                            //newModule.GardeRelated = reader.GetString("graderelated");
                            list.Add(reader.GetString("modulecode"));
                        }
                        reader.Close();
                        dbinst.Close();
                        return list;
                    }
                    else
                    {

                        dbinst.Close();
                        MessageBox.Show("No Modules Available");
                        return null;

                    }

                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error found : " + ex.Message);
                    return null;
                }
            }
            return null;
        }



    }
}
