using LearnyCraft.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.DAO
{
    internal class MarksDao
    {
/*        try
                {

                }
                catch (Exception ex)
                {

                }*/

    private MySqlConnection DBInstance;
        private String ConnString ="server=127.0.0.1; username=root; database=learnycraft; password=";
        public MarksDao() { 
        DBInstance = new MySqlConnection(ConnString);     
        }

        public bool Open()
        {
            try
            {
                DBInstance.Open();
                return true;
            }
            catch  (Exception ex) 
            { 
                MessageBox.Show("Connection failed! "+ex.Message);
                return false;
            }

        }

        public bool AddMarks(MarksModel marks)
        {
            if(Open())
            {
                String S = "insert into marks(Studentid,Moduleid,Marks) values('" + marks.Studentid + "','" + marks.ModuleId + "'," + marks.Marks + ")";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(S,DBInstance);
                    cmd.ExecuteReader();
                    DBInstance.Close();
                    return true;
                }
                catch(Exception ex)
                {
                    DBInstance.Close();
                    MessageBox.Show("Addition Failed"+ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool updateMarksofStudent(List<MarksModel> markslist)
        {
            String studentid = markslist[0].Studentid;


            if(Open())
            {
                foreach (MarksModel mark in markslist)
                {
                    String s = "update marks set Marks=" + mark.Marks + " where Studentid='" + mark.Studentid + "' and Moduleid = '" + mark.ModuleId + "'";
                    try
                    {

                        MessageBox.Show("Update sucessfull");
                        MySqlCommand cmd = new MySqlCommand(s,DBInstance);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        dataReader.Close();
                        //DBInstance.Close();
                    }
                    catch(Exception ex)
                    {
                        
                        DBInstance.Close();
                        MessageBox.Show("update error : " + ex.Message);
                        return false;
                    }
                }
                
                DBInstance.Close();
                return true;

            }
            else
            {
                return false;

            }

        }

        public bool deleteMarksofStudent(String sid)
        {
            String s = "delete from marks where Studentid = '"+sid+"'";
            if (Open())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, DBInstance);
                    cmd.ExecuteReader().Close();
                    DBInstance.Close();
                   
                }
                catch (Exception ex)
                {
                    DBInstance.Close();
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<MarksModel> getMarksofoneStudent(String sid)
        {
            String s = "select * from marks where Studentid='"+sid+ "' order by Moduleid";
            if (Open())
            {
                List<MarksModel> list = new List<MarksModel>();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, DBInstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MarksModel mm = new MarksModel();
                        mm.Studentid = sid;
                        mm.ModuleId = reader.GetString("Moduleid");
                        mm.Marks = reader.GetInt16("Marks");
                        list.Add(mm);
                    }
                    DBInstance.Close();
                    return list;
                }
                catch (Exception ex)
                {
                    DBInstance.Close();
                    MessageBox.Show(ex.Message);
                    return null;

                }

            }
            else
            {
                return null;

            }

        }


        public List<MarksModel> getAllMarks()
        {
            String s = "select * from marks order by Studentid";
            if (Open())
            {
                List<MarksModel> list = new List<MarksModel>();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(s, DBInstance);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        MarksModel mm = new MarksModel();
                        mm.Studentid = reader.GetString("Studentid");
                        mm.ModuleId = reader.GetString("Moduleid");
                        mm.Marks = reader.GetInt16("Marks");
                        list.Add(mm);
                    }
                    DBInstance.Close();
                    return list;
                }
                catch (Exception ex)
                {
                    DBInstance.Close();
                    MessageBox.Show(ex.Message);
                    return null;

                }

            }
            else
            {
                return null;

            }

        }

        public List<MarksModel> getTheMarksofListofStudent(List<StudentModel> slist)
        {
            if (Open())
            {
                List<MarksModel> mlist = new List<MarksModel>();
                foreach (StudentModel s in slist)
                {
                    String q = "select * from marks where Studentid='" + s.StudentId + "' order by Moduleid";
                    try
                    {
                        MySqlCommand sk = new MySqlCommand (q, DBInstance);
                        MySqlDataReader reader = sk.ExecuteReader();
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                MarksModel mm = new MarksModel();
                                mm.Studentid = reader.GetString("Studentid");
                                mm.ModuleId = reader.GetString("Moduleid");
                                mm.Marks = reader.GetInt16("Marks");
                                mlist.Add(mm);
                                //reader.Close();
                            }

                        }
                        else
                        {
                            DBInstance.Close();
                            reader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        DBInstance.Close ();
                        MessageBox.Show("update 'getTheMarksofListofStudent' " + ex.Message);

                    }


                }
                return mlist;
            }
            else
            {
                return null;

            }
        }



        public int getMarksofOneStudent(String sid,String mCode)
        {
            if (Open())
            {

                String q = "select * from marks where Studentid='"+ sid + "' and Moduleid ='"+mCode+"'";
                try
                {
                        MySqlCommand sk = new MySqlCommand(q, DBInstance);
                        MySqlDataReader reader = sk.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                MarksModel mm = new MarksModel();
                                mm.Studentid = reader.GetString("Studentid");
                                mm.ModuleId = reader.GetString("Moduleid");
                                mm.Marks = reader.GetInt16("Marks");
                                DBInstance.Close();
                                return mm.Marks;
                            }

                        }
                        else
                        {
                            DBInstance.Close();
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                DBInstance.Close();
                return 0;
            }
            else
            {
                return 0;

            }

        }

    }
}
