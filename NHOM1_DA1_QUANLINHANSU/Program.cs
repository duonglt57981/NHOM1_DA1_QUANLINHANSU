using NHOM1_DA1_QUANLINHANSU.GUI;

namespace NHOM1_DA1_QUANLINHANSU
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TrangChu());
        }
    }
}