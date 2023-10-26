using NeonShooter;

namespace MonoGame.Avalonia.Example.Desktop.ViewModels;

public class MainViewModel : ViewModelBase
{
    private NeonShooterGame _game = new NeonShooterGame();
    public NeonShooterGame Game
    {
        get => _game;
        set => _game = value;
    }
}
