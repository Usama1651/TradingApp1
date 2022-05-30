namespace New_Form
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
      //  public static bool ValidLogin = false;
        [STAThread]


        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //if (ValidLogin) { 
            //Application.Run(new Form1());
            
            //}
        }
    }
}