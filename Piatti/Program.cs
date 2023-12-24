using System.Collections.Generic;

namespace Piatti
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 



        [STAThread]
        static void Main()
        {
            Directory.SetCurrentDirectory(@"..\..\..");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Principale FormPrincipale = new Principale();
            Application.Run(FormPrincipale);
            Application.Run(FormPrincipale.RunForm);
        }
    }

}