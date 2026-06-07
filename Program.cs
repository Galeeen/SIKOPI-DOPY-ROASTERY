using SIKOPI_DOPY_ROASTERY.Views;

namespace SIKOPI_DOPY_ROASTERY
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin());   // aplikasi selalu mulai dari Login
        }
    }
}