using System.Windows.Forms;

namespace project1
{
    internal static class Program
    {
        [STAThread]
       public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}