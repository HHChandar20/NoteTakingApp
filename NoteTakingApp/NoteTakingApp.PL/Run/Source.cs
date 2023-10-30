using NoteTakingApp.PL.Views;

namespace NoteTakingApp.PL.Run
{
    internal static class Source
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            MainMenu mainMenuForm = MainMenu.GetInstance();
            Application.Run(mainMenuForm);
        }
    }
}
