using NoteTakingApp.PL.Views;

namespace NoteTakingApp.PL.Run
{
    internal static class Source
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}
