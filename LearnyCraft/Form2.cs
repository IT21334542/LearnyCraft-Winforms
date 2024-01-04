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
    public partial class Form2 : Form
    {
        private String Classid;
        private DataGridView dk;

        public Form2(DataGridView d)
        {
            InitializeComponent();
            this.dk = d;
            initFonts();
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
            Title.Font = new Font(pfc.Families[0], Title.Font.Size);
            Title.Text = "LearnyCraft ";
            Instruction.Font = new Font(pfc4.Families[0], Instruction.Font.Size);
            Instruction.Text = "Update class name";
            btnSave.Font = new Font(pfc3.Families[0], btnSave.Font.Size);
            btnSave.Text = "Save Change";
        }


        public void setClassid(String s)
        {
            this.Classid = s;
        }
   

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClassDAO dao = new ClassDAO();
            ClassModle cl = new ClassModle();
            ClassController cc =new ClassController();
            cl.ClassId = this.Classid;
            cl.ClassName=textBox1.Text;
            if(dao.updateClass(cl))
            {
                //MessageBox.Show("Update Sucessful");
                cc.refreshGrid(dk);
                this.Close();
            }
           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

    


    }
}
