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
    public partial class AppStartInterface : Form
    {

        public void loadForm(object fi)
        {
            if (this.ChangingPanel.Controls.Count > 0)
            {
                this.ChangingPanel.Controls.RemoveAt(0);
            }

            Form f = fi as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.ChangingPanel.Controls.Add(f); ;
            this.ChangingPanel.Tag = f;
            f.Show();
        }
        public AppStartInterface()
        {
            InitializeComponent();
            initFonts();
            loadForm(new StudentsInterface());
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
            Marshal.Copy(fontdata3, 0, data4, fontLength4);
            pfc.AddMemoryFont(data, fontLength);
            pfc2.AddMemoryFont(data2, fontLength2);
            pfc3.AddMemoryFont(data3, fontLength3);
            pfc4.AddMemoryFont(data4, fontLength4);
            AppTitle.Font = new Font(pfc.Families[0], AppTitle.Font.Size);
            AppTitle.Text = "LearnyCraft ";
            StudentMenutxt.Font = new Font(pfc3.Families[0], StudentMenutxt.Font.Size);
            StudentMenutxt.Text = "Students";
            ModulesMenuTxt.Font = new Font(pfc3.Families[0], ModulesMenuTxt.Font.Size);
            ModulesMenuTxt.Text = "Modules";
            ClassroomMenuTxt.Font = new Font(pfc3.Families[0], ClassroomMenuTxt.Font.Size);
            ClassroomMenuTxt.Text = "Grades";
            MarksMenutxt.Font = new Font(pfc3.Families[0], MarksMenutxt.Font.Size);
            MarksMenutxt.Text = "Marks";


        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadForm(new StudentsInterface());
        }

        private void StudntsIconBox_Click(object sender, EventArgs e)
        {
            loadForm(new StudentsInterface());
        }

        private void BooksPicturebox_Click(object sender, EventArgs e)
        {
            loadForm(new ModuleInterface());
        }

        private void ClassRoomPicturebox_Click(object sender, EventArgs e)
        {
            loadForm(new ClassesInterface());
        }

        private void ChangingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MarksDisplay_Click(object sender, EventArgs e)
        {
            loadForm(new MarksForms());
        }

        private void AppTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
