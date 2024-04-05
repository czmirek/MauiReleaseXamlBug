namespace MauiReleaseXamlBug;

public partial class App : Application
{
    public static string ExceptionContent = "";
    public App()
    {
        InitializeComponent();

        TaskScheduler.UnobservedTaskException += (object? sender, UnobservedTaskExceptionEventArgs e) =>
        {
            Exception baseException = e.Exception.GetBaseException();
            ExceptionContent += baseException.Message + " /// " + baseException.ToString();
            e.SetObserved();
        };

        MainPage = new AppShell();
    }
}
