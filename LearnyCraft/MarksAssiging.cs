using LearnyCraft.Controllers;
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
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace LearnyCraft
{
    public partial class MarksAssiging : Form
    {
        private String Grade;
        private MarksController mm;
        public MarksAssiging(String grd)
        {
            InitializeComponent();
            this.Grade = grd;
            initFonts();
            initgrid();
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
            label1.Text = "Marks of student" + Grade;
            label2.Font = new Font(pfc3.Families[0], label2.Font.Size);
            label2.Text = "Double Click the Cell to update marks of the student" + Grade;



        }

        private void initgrid()
        {
            mm = new MarksController();
            mm.RefreshGrid(ModuleDAtaGRid, Grade);
            
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ModuleDAtaGRid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(Grade);
            MarksView form = new MarksView(ModuleDAtaGRid.Rows[e.RowIndex].Cells[1].Value.ToString(),Grade);
            form.ShowDialog();
        }
    }
}
