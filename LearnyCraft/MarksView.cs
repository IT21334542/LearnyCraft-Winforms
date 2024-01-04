using LearnyCraft.Controllers;
using LearnyCraft.DAO;
using LearnyCraft.Models;
using MySqlX.XDevAPI.Relational;
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
    public partial class MarksView : Form
    {
        private String sid;
        private String grade;
        private MarksController mc;

        public MarksView(String id, string grade)
        {
            
            InitializeComponent();
            initFonts();
            sid = id;
            this.grade = grade;
            initgrid();
            InitLabels();
        }

        private void InitLabels()
        {
            mc = new MarksController();
            label2.Text = mc.getStudentName(sid);
            label3.Text = mc.getTotal(sid, grade).Total.ToString();
            label6.Text = mc.getTotal(sid, grade).Avg.ToString();

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
            label1.Text = "LearnyCraft";
            label2.Font = new Font(pfc3.Families[0], label2.Font.Size);
            label2.Text = "StudentName";

            label3.Font = new Font(pfc4.Families[0], label3.Font.Size);
            label3.Text = "Total";
            label4.Font = new Font(pfc4.Families[0], label4.Font.Size);
            label4.Text = "Total";
            label5.Font = new Font(pfc4.Families[0], label5.Font.Size);
            label5.Text = "Average";
            label6.Font = new Font(pfc4.Families[0], label6.Font.Size);
            label6.Text = "StudentName";

            button1.Font = new Font(pfc3.Families[0], button1.Font.Size);
            button1.Text = "Edit Marks";
            button2.Font = new Font(pfc3.Families[0], button2.Font.Size);
            button2.Text = "Close View";


        }


        public void initgrid()
        {
            mc = new MarksController();
            mc.refreshMarksgrid(ModuleDAtaGRid, sid, grade);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text.Equals("Edit Marks"))
            {
                ModuleDAtaGRid.ReadOnly = false;
                //ModuleDAtaGRid.Columns["Coulmn3"].ReadOnly = false;
                button1.Text = "Save Changes";
            }
            else if(button1.Text.Equals("Save Changes"))
            {
                int modluecount = 0;
                int sum = 0;
                MarksController mc = new MarksController();
                ClassDAO cl = new ClassDAO();
                List<MarksHolder> list = new List<MarksHolder>();

                foreach(DataGridViewRow row in ModuleDAtaGRid.Rows)
                {
                    modluecount++;
                    MarksHolder marksHolder = new MarksHolder();
                    marksHolder.StudentId = sid;
                    marksHolder.StudentName = row.Cells["Column3"].Value.ToString();
                    marksHolder.ModuleName = row.Cells["column1"].Value.ToString();
                    marksHolder.ModuleCode = row.Cells["Coumn2"].Value.ToString();
                    marksHolder.Marks = Convert.ToInt16(row.Cells["Coulmn3"].Value.ToString());
                    sum = sum + marksHolder.Marks;
                    list.Add(marksHolder);
                }

                GPAmodel g = new GPAmodel();
                
                g.Studentid = sid;
                g.Grade = grade;
                g.Total = sum;
                g.Avg  = sum/modluecount;

                if(g.Total>100)
                {
                    MessageBox.Show("Total Can not be Over than 100");
                }
                else
                {
                    if(mc.isAlreadyHaveMarks(sid,grade))
                    {
                        
                        mc.updateTotal(g);
                        mc.updateMarks(list);
                        this.Close();
                    }
                    else
                    {
                        
                        mc.addTotal(g);
                        mc.addMarks(list);
                        this.Close();
                    }



                }


               



            }
            else
            {

            }
            
        }

        private void ModuleDAtaGRid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
