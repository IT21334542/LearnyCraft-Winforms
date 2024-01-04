using LearnyCraft.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnyCraft.DAO
{
    internal class StudentDAO
    {
        private MySqlConnection dbinst;
        private String ConStr = "server=127.0.0.1; username=root; database=learnycraft; password=";

        public StudentDAO() 
        {

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
                MessageBox.Show("Connection not made! error : "+ex.Message);
                return false; 
            }
        }

        //return true is add sucess
        //return false if add fails
        public bool addNewStudent(StudentModel s)
        {
            if(isDbOpen())
            {
                String query = "insert into student(studentid,studentname,studentage,studentcontact,studentclass) values('" +
                    s.StudentId + "','" +
                    s.StudentName + "'," +
                    s.StudentAge + ",'" +
                    s.ContactNumber + "','" +
                    s.StudentClass + "')";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query,dbinst);
                    cmd.ExecuteReader();
                    dbinst.Close();
                    return true;
                }
                catch(Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error found : "+ex.Message );
                    return false;
                }
            }
            return false;
        }


        //return true is delete sucessfull
        //return false if delete fails

        public bool deleteStudent(String sid)
        {
            if (isDbOpen())
            {
                String query = "delete from student where studentid = '" + sid + "'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    cmd.ExecuteReader();
                    dbinst.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error found : " + ex.Message);
                    return false;
                }
            }
            return false;
        }



        //return true is update sucessfull
        //return false if update fails
        public bool updateStudent(StudentModel s)
        {
            if (isDbOpen())
            {
                //studentname,studentage,studentcontact,studentclass
                String query = "update student set studentname='"+s.StudentName+ "',studentage = "+s.StudentAge+ ",studentcontact = '"+s.ContactNumber+ "',studentclass = '"+s.StudentClass+"' where" +
                    " studentid = '"+s.StudentId+"'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    cmd.ExecuteReader();
                    dbinst.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    dbinst.Close();
                    MessageBox.Show("Error found : " + ex.Message);
                    return false;
                }
            }
            return false;
        }


        //return null if student db is empty
        public List<StudentModel> getAllStudent()
        {
            if (isDbOpen())
            {
                //studentname,studentage,studentcontact,studentclass
                String query = "select * from student";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows)
                    {
                        List<StudentModel> list = new List<StudentModel>(); 
                        while (reader.Read())
                        {
                            StudentModel student = new StudentModel();
                            student.StudentId = reader.GetString("studentid");
                            student.StudentName = reader.GetString("studentname");
                            student.StudentClass = reader.GetString("studentclass");
                            student.ContactNumber = reader.GetString("studentcontact");
                            student.StudentAge = reader.GetInt16("studentage");
                            list.Add(student);
                        }
                        reader.Close();
                        dbinst.Close();
                        return list;
                    }
                    else
                    {
                        
                        dbinst.Close();
                        MessageBox.Show("No Students Available");
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



        //return null if student not available,
        //if student is available return studentModel related to the id
        public StudentModel getStudentByid(String sid)
        {
            if (isDbOpen())
            {
                //studentname,studentage,studentcontact,studentclass
                String query = "select * from student where studentid='"+sid+"'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        StudentModel newStudent = new StudentModel();
                        while (reader.Read())
                        {
                            StudentModel student = new StudentModel();
                            student.StudentId = reader.GetString("studentid");
                            student.StudentName = reader.GetString("studentname");
                            student.StudentClass = reader.GetString("studentclass");
                            student.ContactNumber = reader.GetString("studentcontact");
                            student.StudentAge = reader.GetInt16("studentage");
                            newStudent = student;
                        }
                        reader.Close();
                        dbinst.Close();
                        return newStudent;
                    }
                    else
                    {

                        dbinst.Close();
                        MessageBox.Show("No Students Available");
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



        //return null if student not available,
        //if student is available return list of the student
        public List<StudentModel> getStudentByGrade(String grade)
        {
            if (isDbOpen())
            {
                //studentname,studentage,studentcontact,studentclass
                String query = "select * from student where studentclass like '"+grade+"%'";
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbinst);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        List<StudentModel> list = new List<StudentModel>();
                        while (reader.Read())
                        {
                            StudentModel student = new StudentModel();
                            student.StudentId = reader.GetString("studentid");
                            student.StudentName = reader.GetString("studentname");
                            student.StudentClass = reader.GetString("studentclass");
                            student.ContactNumber = reader.GetString("studentcontact");
                            student.StudentAge = reader.GetInt16("studentage");
                            list.Add(student);
                        }
                        reader.Close();
                        dbinst.Close();
                        return list;
                    }
                    else
                    {

                        dbinst.Close();
                        MessageBox.Show("No Students Available");
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
