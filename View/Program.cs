namespace View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.ThreadException += Application_ThreadException;
            Application.Run(new MainForm());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
