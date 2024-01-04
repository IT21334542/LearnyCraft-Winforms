using LearnyCraft.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.DAO
{
    internal class gpaDAO
    {
 /*       try
                {

                }
                catch(Exception ex)
                {

                }
 */


    private String ConStr = "server=127.0.0.1; username=root; database=LearnyCraft; password=";
        private MySqlConnection dbinstance;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public gpaDAO() { 
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
                MessageBox.Show("connectionlost" + ex.Message);
                return false;
            }
        }


        public bool  addGPA(GPAmodel model) 
        {
            if(isOpen())
            {
                String s = "insert into avarage(Studentid,Grade,Total,Avg) values('"+model.Studentid+"','"+model.Grade+"',"+model.Total+","+model.Avg+")";


                try
                {
                    cmd = new MySqlCommand(s,dbinstance);
                    reader = cmd.ExecuteReader();
                    dbinstance.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("error : "+ex.Message);
                    dbinstance.Close();
                    return false;
                }
                return true;
            }
            else
            {
                
                return false;

            }
        
        
        }

        public bool delete(String id) {
            if (isOpen())
            {
                String s = "delete from avarage where Studentid='"+id+"'";


                try
                {
                    cmd = new MySqlCommand(s, dbinstance);
                    reader = cmd.ExecuteReader();
                    dbinstance.Close();

                }
                catch (Exception ex)
                {
                    dbinstance.Close();
                    return false;
                }
                return true;
            }
            else
            {
                return false;

            }

        }


        public bool update(GPAmodel model)
        {
            if (isOpen())
            {
                //String s = "insert into avarage(Studentid,Grade,Total,Avg) values('" + model.Studentid + "','" + model.Grade + "'," + model.Total + "," + model.Avg + ")";
                String s = "update avarage set Grade='"+ model.Grade + "',Total ="+ model.Total+ ",Avg="+ model.Avg + " where Studentid='"+ model.Studentid+ "'";

                try
                {
                    cmd = new MySqlCommand(s, dbinstance);
                    reader = cmd.ExecuteReader();
                    dbinstance.Close();

                }
                catch (Exception ex)
                {
                    dbinstance.Close();
                    return false;
                }
                return true;
            }
            else
            {
                return false;

            }

        }

        public GPAmodel getTotals(String id,String Grade) 
        { 
            if (isOpen()) 
            { 
                string s = "select * from avarage where Studentid='"+id+"' and Grade like '"+Grade+"'";
                try
                {
                    cmd = new MySqlCommand(s, dbinstance);
                    reader = cmd.ExecuteReader();
                    GPAmodel g = new GPAmodel();
                   // MessageBox.Show(Grade);
                    if (reader.HasRows)
                    {
                        
                        while (reader.Read())
                        {
                            
                            g.Studentid = reader.GetString("Studentid");
                            g.Grade = reader.GetString("Grade");
                            g.Total = reader.GetFloat("Total");
                            g.Avg = reader.GetFloat("Avg");
                            
                        }
                        reader.Close();
                        dbinstance.Close();
                        return g;
                    }
                    else
                    {
                        reader.Close();
                        dbinstance.Close();
                        return null;
                    }
                    
                }
                catch (Exception ex)
                {
                    reader.Close();
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
