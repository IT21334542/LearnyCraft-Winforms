﻿using LearnyCraft.Controllers;
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
    public partial class addNewModule : Form
    {
        private DataGridView DK;
        public addNewModule(DataGridView dK)
        {
            InitializeComponent();
            initFonts();
            DK = dK;
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

            titleNew.Font = new Font(pfc.Families[0], titleNew.Font.Size);
            titleNew.Text = "LearnyCraft ";
            label1.Font = new Font(pfc4.Families[0], label1.Font.Size);
            label1.Text = "Enter new Module Name";
            label2.Font = new Font(pfc4.Families[0], label2.Font.Size);
            label2.Text = "Select Grade module relates";
            button1.Font = new Font(pfc3.Families[0], button1.Font.Size);
            button1.Text = "Add new Module ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModuleControllers mc =new ModuleControllers();
            ModulesModel mm =new ModulesModel();
            mm.ModuleName = textBox1.Text;
            mm.GardeRelated = textBox2.Text;
            if (mc.addModule(mm))
            {
                mc.refreshGrid(DK);
                textBox1.Text = "";
                textBox2.Text = "";            }
        }
    }
}
