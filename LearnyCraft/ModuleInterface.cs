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
using System.Windows.Forms;

namespace LearnyCraft
{
    public partial class ModuleInterface : Form
    {
        public ModuleInterface()
        {
            InitializeComponent();
            initFonts();
            initGrid();
            initPinPanels();
        }

        private void initPinPanels()
        {
            ModuleControllers mc = new ModuleControllers();
            try
            {
                //TOP 3 MODULES
                ModulesModel one = mc.getTopOne();
                ModulesModel two = mc.getTopTwo();
                ModulesModel three = mc.getTopThree();

                ModuleCode.Text = one.ModuleCode;
                ModCod2.Text = two.ModuleCode;
                modcod3.Text = three.ModuleCode;


                ModuleName.Text = one.ModuleName;
                modName2.Text = two.ModuleName;
                modname3.Text = three.ModuleName;

            }
            catch (Exception ex)
            {

            }
        }

        private void initGrid()
        {
            ModuleControllers mc = new ModuleControllers();
            mc.AssignGrid(ModuleDAtaGRid);
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

            Pinned.Font = new Font(pfc4.Families[0], Pinned.Font.Size);
            Pinned.Text = "Pinned Modules";
            AllModules.Font = new Font(pfc4.Families[0], AllModules.Font.Size);
            AllModules.Text = "All Modules";
            ModuleCode.Font = new Font(pfc4.Families[0], ModuleCode.Font.Size);
            ModuleCode.Text = "ModuleCode";
            ModCod2.Font = new Font(pfc4.Families[0], ModCod2.Font.Size);
            ModCod2.Text = "ModuleCode";
            modcod3.Font = new Font(pfc4.Families[0], modcod3.Font.Size);
            modcod3.Text = "ModuleCode";

            ModuleName.Font = new Font(pfc4.Families[0], ModuleName.Font.Size);
            ModuleName.Text = "Module Name";
            modName2.Font = new Font(pfc4.Families[0], modName2.Font.Size);
            modName2.Text = "Module Name";
            modname3.Font = new Font(pfc4.Families[0], modname3.Font.Size);
            modname3.Text = "Module Name";


            Instruction.Font = new Font(pfc3.Families[0], Instruction.Font.Size);
            Instruction.Text = "to delete/update the module info  double click the cell";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PinedMiddlePAnel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add Module
            addNewModule f = new addNewModule(ModuleDAtaGRid);
            f.ShowDialog();
        }

        private void ModuleDAtaGRid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModulesModel mm = new ModulesModel();
            ModuleControllers mc = new ModuleControllers();
            //MessageBox.Show(e.ColumnIndex.ToString());
            DialogResult res = MessageBox.Show("Do You Wish To Update the Selection?", "LearnyCraft", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                //update


            }
            else
            {
                //delete
                DialogResult rest = MessageBox.Show("Sure!, Do you wish to delete Selection", "LearnyCraft", MessageBoxButtons.YesNo);
                if (rest == DialogResult.Yes)
                {
                    //Yes Delete

                    if (mc.Delete(ModuleDAtaGRid.Rows[e.RowIndex].Cells[0].Value.ToString()))
                        mc.refreshGrid(ModuleDAtaGRid);

                }
                else
                {
                    //No Delete


                }

            }
        }

        private void PinedMod1_Click(object sender, EventArgs e)
        {

        }
    }
}
