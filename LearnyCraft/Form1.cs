using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace LearnyCraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initFonts();
            CircularPb.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initFonts();
        }

        private void initFonts()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            PrivateFontCollection pfc2 = new PrivateFontCollection();
            int fontLength = FontResources.Pacifico.Length;
            int fontLength2 = FontResources.Livvic.Length;
            byte[] fontdata = FontResources.Pacifico;
            byte[] fontdata2 = FontResources.Livvic;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            System.IntPtr data2 = Marshal.AllocCoTaskMem(fontLength2);
            Marshal.Copy(fontdata, 0, data, fontLength);
            Marshal.Copy(fontdata2, 0, data2, fontLength2);
            pfc.AddMemoryFont(data, fontLength);
            pfc2.AddMemoryFont(data2, fontLength2);
            AppNameSplash.Font = new Font(pfc.Families[0], AppNameSplash.Font.Size);
            AppNameSplash.Text = "LearnyCraft ";
            SubText.Font = new Font(pfc2.Families[0], SubText.Font.Size);
            SubText.Text = "Elevate Skills, Ignite Passion with LearnyCraft";

        }

        private void Splashtimer_Tick(object sender, EventArgs e)
        {
            CircularPb.Value += 2;
            CircularPb.Text = CircularPb.Value.ToString();
            if (CircularPb.Value == 100)
            {
                Splashtimer.Enabled = false;
                AppStartInterface StartApp = new AppStartInterface();
                this.Hide();
                //Application.Run(new AppStartInterface());
                StartApp.ShowDialog();
                //this.Close();
            }
        }

        private void AppNameSplash_Click(object sender, EventArgs e)
        {

        }
    }
}
