using LearnyCraft.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.DAO
{
    internal class ClassDAO
    {
        private String ConStr = "server=127.0.0.1; username=root; database=LearnyCraft; password=";
        private MySqlConnection dbinstance;
        public ClassDAO() 
        {
            dbinstance = new MySqlConnection(ConStr);
        }

        public bool isOpen()
        {
            try
            {
                dbinstance.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool addClass(ClassModle cl)
        {
            String s = "Insert into class(classid,class) values('" + cl.ClassId + "','" + cl.ClassName + "')";
            if(isOpen())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    dbinstance.Close();
                    return true;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error in Adding new data :" + ex.Message);
                    dbinstance.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }


        }



        public bool updateClass(ClassModle cl)
        {
            String s = "update class set class='"+cl.ClassName + "' where classid='" + cl.ClassId + "'";
            if (isOpen())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    dbinstance.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Updating data :" + ex.Message);
                    dbinstance.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool deleteClass(String id)
        {
            String s = "delete from class where classid='"+id+ "'";
            if (isOpen())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                    dbinstance.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Deletion of data :" + ex.Message);
                    dbinstance.Close();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public List<ClassModle> getAllClasses() 
        {
            String s = "select * from class";
            if (isOpen())
            {
                List<ClassModle> list = new List<ClassModle>();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ClassModle cl = new ClassModle();
                            cl.ClassId = reader.GetString("classid");
                            cl.ClassName = reader.GetString("class");
                            list.Add(cl);
                        }
                        reader.Close();
                        dbinstance.Close();
                        return list;
                    }
                    else
                    {
                        MessageBox.Show("DB is Empty");
                        return null;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Fetching data :" +ex.Message);
                    dbinstance.Close();
                    return null;
                }
            }
            else
            {
                return null;
            }

        }



        public ClassModle getClass(String classid)
        {
            String s = "select * from class where classid = '"+classid+"'";
            if (isOpen())
            {
                ClassModle list = new ClassModle();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ClassModle cl = new ClassModle();
                            cl.ClassId = reader.GetString("classid");
                            cl.ClassName = reader.GetString("class");
                            list = cl;
                        }
                        reader.Close();
                        dbinstance.Close();
                        return list;
                    }
                    else
                    {
                        MessageBox.Show("DB is Empty");
                        return null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Fetching one data :" + ex.Message);
                    dbinstance.Close();
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public List<String> getAllClassIds()
        {
            String s = "select classid from class";
            if (isOpen())
            {
                List<String> list = new List<String>();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //ClassModle cl = new ClassModle();
                            //cl.ClassId = reader.GetString("classid");
                            //cl.ClassName = reader.GetString("class");
                            list.Add(reader.GetString("classid"));
                        }
                        reader.Close();
                        dbinstance.Close();
                        return list;
                    }
                    else
                    {
                        MessageBox.Show("DB is Empty");
                        return null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Fetching data :" + ex.Message);
                    dbinstance.Close();
                    return null;
                }
            }
            else
            {
                return null;
            }

        }


        public List<String> getAllClassNames()
        {

            String s = "select class from class";
            if (isOpen())
            {
                List<String> list = new List<String>();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, dbinstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //ClassModle cl = new ClassModle();
                            //cl.ClassId = reader.GetString("classid");
                            //cl.ClassName = reader.GetString("class");
                            list.Add(reader.GetString("class"));
                        }
                        reader.Close();
                        dbinstance.Close();
                        return list;
                    }
                    else
                    {
                        MessageBox.Show("DB is Empty");
                        return null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Fetching data :" + ex.Message);
                    dbinstance.Close();
                    return null;
                }
            }
            else
            {
                return null;
            }

        }





    }
}
