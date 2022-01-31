namespace XamlExtension;

public class App : Application
{
    public App()
    {
    }

    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime classicDesktop:
                var window = new Window
                {
                    Content = new HeaderContent()
                };
                break;
        }

        base.OnFrameworkInitializationCompleted();
    }
}