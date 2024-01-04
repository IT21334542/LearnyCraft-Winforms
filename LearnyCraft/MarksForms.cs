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
    public partial class MarksForms : Form
    {
        public MarksForms()
        {
            InitializeComponent();
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

            label1.Font = new Font(pfc4.Families[0], label1.Font.Size);
            label1.Text = "Select a grade of the student";
            label2.Font = new Font(pfc3.Families[0], label2.Font.Size);
            label2.Text = "Grade 1";
            label3.Font = new Font(pfc3.Families[0], label3.Font.Size);
            label3.Text = "Grade 2";
            label4.Font = new Font(pfc3.Families[0], label4.Font.Size);
            label4.Text = "Grade 3";
            label5.Font = new Font(pfc3.Families[0], label5.Font.Size);
            label5.Text = "Grade 4";
            label6.Font = new Font(pfc3.Families[0], label6.Font.Size);
            label6.Text = "Grade 5";
            label7.Font = new Font(pfc3.Families[0], label7.Font.Size);
            label7.Text = "Grade 6";
            label8.Font = new Font(pfc3.Families[0], label8.Font.Size);
            label8.Text = "Grade 7";
            label9.Font = new Font(pfc3.Families[0], label9.Font.Size);
            label9.Text = "Grade 8";
            label10.Font = new Font(pfc3.Families[0], label10.Font.Size);
            label10.Text = "Grade 9";
            label11.Font = new Font(pfc3.Families[0], label10.Font.Size);
            label11.Text = "Grade 10";
            label12.Font = new Font(pfc3.Families[0], label12.Font.Size);
            label12.Text = "Grade 11";
            label13.Font = new Font(pfc3.Families[0], label13.Font.Size);
            label13.Text = "Grade 12";


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show("Hello");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("2"));
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public void visibleAll()
        {
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;  
            panel10.Visible = true;
            panel11.Visible = true;
            panel12.Visible = true;
            panel13.Visible = true;
            panel14.Visible = true;

        }
        public void HideAll()
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;

        }

        private void loadAssiner(MarksAssiging f)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            this.HideAll();
            f.Show();
            


        }

        //starthere
        private void panel3_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("01"));

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("02"));
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("03"));
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("04"));
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("05"));
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("06"));
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("07"));
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("08"));
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("09"));
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("10"));
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("11"));
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("12"));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("01"));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("03"));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("04"));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("05"));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("06"));
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("07"));
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("08"));
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("09"));
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            loadAssiner(new MarksAssiging("10"));
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("11"));
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            loadAssiner(new MarksAssiging("12"));
        }
    }
}
