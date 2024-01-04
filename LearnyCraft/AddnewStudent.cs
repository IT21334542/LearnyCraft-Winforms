using LearnyCraft.Controllers;
using LearnyCraft.DAO;
using LearnyCraft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnyCraft
{
    public partial class AddnewStudent : Form
    {
        private DataGridView dk;
        private StudentModel updateM;
        public AddnewStudent(DataGridView dk)
        {
            InitializeComponent();
            initFonts();
            initComboCoz();
            this.dk = dk;
        }

        private void initComboCoz()
        {
            ClassController cc = new ClassController();
            List<String> classnamelist = cc.getClassNameList();

            foreach (String classname in classnamelist)
            {
                comboBox1.Items.Add(classname);
            }

        }

        private void initFonts()
        {

            PrivateFontCollection pfc = new PrivateFontCollection();
            PrivateFontCollection pfc2 = new PrivateFontCollection();
            PrivateFontCollection pfc3 = new PrivateFontCollection();
            PrivateFontCollection pfc4 = new PrivateFontCollection();
            int fontLength = FontResources.Pacifico.Length;
            int fontLength2 = FontResources.Livvic.Length;
            int fontLength3 = FontResources.Sm.Length;
            int fontLength4 = FontResources.med.Length;
            byte[] fontdata = FontResources.Pacifico;
            byte[] fontdata2 = FontResources.Livvic;
            byte[] fontdata3 = FontResources.Sm;
            byte[] fontdata4 = FontResources.med;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            System.IntPtr data2 = Marshal.AllocCoTaskMem(fontLength2);
            System.IntPtr data3 = Marshal.AllocCoTaskMem(fontLength3);
            System.IntPtr data4 = Marshal.AllocCoTaskMem(fontLength4);
            Marshal.Copy(fontdata, 0, data, fontLength);
            Marshal.Copy(fontdata2, 0, data2, fontLength2);
            Marshal.Copy(fontdata3, 0, data3, fontLength3);
            Marshal.Copy(fontdata4, 0, data4, fontLength4);
            pfc.AddMemoryFont(data, fontLength);
            pfc2.AddMemoryFont(data2, fontLength2);
            pfc3.AddMemoryFont(data3, fontLength3);
            pfc4.AddMemoryFont(data4, fontLength4);
            /*AppTitle.Font = new Font(pfc.Families[0], AppTitle.Font.Size);
            AppTitle.Text = "LearnyCraft ";*/
            /*StudentMenutxt.Font = new Font(pfc3.Families[0], StudentMenutxt.Font.Size);
            StudentMenutxt.Text = "Students";
            ModulesMenuTxt.Font = new Font(pfc3.Families[0], ModulesMenuTxt.Font.Size);
            ModulesMenuTxt.Text = "Modules";
            ClassroomMenuTxt.Font = new Font(pfc3.Families[0], ClassroomMenuTxt.Font.Size);
            ClassroomMenuTxt.Text = "Grades";*/
            label1.Font = new Font(pfc.Families[0], label1.Font.Size);
            label1.Text = "LearnyCraft ";
            label2.Font = new Font(pfc4.Families[0], label2.Font.Size);
            label2.Text = "Add new Student";

            label3.Font = new Font(pfc4.Families[0], label3.Font.Size);
            label3.Text = "Student Name";
            textBox1.Font = new Font(pfc2.Families[0], textBox1.Font.Size);

            label4.Font = new Font(pfc4.Families[0], label4.Font.Size);
            label4.Text = "Student Contact ";
            textBox2.Font = new Font(pfc2.Families[0], textBox2.Font.Size);

            label5.Font = new Font(pfc4.Families[0], label5.Font.Size);
            label5.Text = "Student Age ";
            textBox3.Font = new Font(pfc2.Families[0], textBox3.Font.Size);

            label6.Font = new Font(pfc4.Families[0], label6.Font.Size);
            label6.Text = "Select Class";
            comboBox1.Font = new Font(pfc2.Families[0], comboBox1.Font.Size);

            button1.Font = new Font(pfc3.Families[0], button1.Font.Size);
            button1.Text = "Add new Student";



        }

        public void makeFormUpdate(String id)
        {
            label2.Text = "Update Student";
            button1.Text = "Update";
            StudentDAO dao = new StudentDAO();
            updateM = dao.getStudentByid(id);
            textBox1.Text = updateM.StudentName;
            textBox2.Text = updateM.ContactNumber;
            textBox3.Text = updateM.StudentAge.ToString();
            comboBox1.Text = updateM.StudentClass.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text.Equals("Update Student"))
            {
                StudentController sc = new StudentController();
                StudentModel stn = new StudentModel();
                stn.StudentId = updateM.StudentId;
                stn.StudentName = textBox1.Text;
                stn.ContactNumber = textBox2.Text;
                stn.StudentAge = Convert.ToInt16(textBox3.Text);
                stn.StudentClass = comboBox1.Text;
                if(sc.update(stn))
                {
                    sc.refreshGrid(dk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update fails");
                }
            }
            else
            {
                StudentModel st = new StudentModel();
                StudentController sc = new StudentController();
                st.StudentName = textBox1.Text;
                st.ContactNumber = textBox2.Text;
                st.StudentAge = Convert.ToInt16(textBox3.Text);
                st.StudentClass = comboBox1.Text;
                if (sc.addnewst(st))
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    sc.refreshGrid(dk);

                }
            }


        }
    }
}
