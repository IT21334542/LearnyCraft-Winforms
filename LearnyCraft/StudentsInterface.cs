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
    public partial class StudentsInterface : Form
    {
        public StudentsInterface()
        {
            InitializeComponent();
            initFonts();
            initGrid();
        }

        private void initGrid()
        {
            StudentController sc = new StudentController();
            sc.assignGrid(StudentDataGrid);
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
            /*AppTitle.Font = new Font(pfc.Families[0], AppTitle.Font.Size);
            AppTitle.Text = "LearnyCraft ";*/
            /*StudentMenutxt.Font = new Font(pfc3.Families[0], StudentMenutxt.Font.Size);
            StudentMenutxt.Text = "Students";
            ModulesMenuTxt.Font = new Font(pfc3.Families[0], ModulesMenuTxt.Font.Size);
            ModulesMenuTxt.Text = "Modules";
            ClassroomMenuTxt.Font = new Font(pfc3.Families[0], ClassroomMenuTxt.Font.Size);
            ClassroomMenuTxt.Text = "Grades";*/

            AddStudentButton.Font = new Font(pfc3.Families[0], AddStudentButton.Font.Size);
            AddStudentButton.Text = "+ Add New Student";



        }

        private void buttonContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddnewStudent form = new AddnewStudent(StudentDataGrid);
            form.ShowDialog();
        }

        private void StudentDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());
            if(e.ColumnIndex == 0)
            {
                //update
                StudentController sc =new StudentController();
                StudentModel st =new StudentModel();
                st.StudentId = StudentDataGrid.Rows[e.RowIndex].Cells["StudentIdColumn"].Value.ToString();
                /*                st.StudentName = StudentDataGrid.Rows[e.RowIndex].Cells["StudentNameColumn"].Value.ToString();
                                st.StudentAge = Convert.ToInt16(StudentDataGrid.Rows[e.RowIndex].Cells["StudentAgeCol"].Value.ToString());
                                st.ContactNumber = StudentDataGrid.Rows[e.RowIndex].Cells["StudentContactcol"].Value.ToString();
                                st.StudentClass = StudentDataGrid.Rows[e.RowIndex].Cells["StudentContactcol"].Value.ToString();
                                */
                AddnewStudent f = new AddnewStudent(StudentDataGrid);
                f.makeFormUpdate(st.StudentId);
                f.ShowDialog();



            }
            else if(e.ColumnIndex == 1) 
            {
                //delete
                StudentController sc = new StudentController();
                if(sc.delete(StudentDataGrid.Rows[e.RowIndex].Cells["StudentIdColumn"].Value.ToString()))
                {
                    initGrid();
                }
            }
            else
            {

            }
        }
    }
}
