> [!WARNING]
> This repository was origianlly a proof of concept. As of September 21st 2024, this repository is now in archive mode.  [Akaadream](https://github.com/akaadream) has a fork that is being maintained and shoudl be used going forward and not this repository.  https://github.com/akaadream/MonoGame.Avalonia

# MonoGame Avalonia Example

## Usage
1. Add reference to `MonoGame.Avalonia` project
2. Add `Game` Property to ViewModel with new instance of game to run
3. Add `MonoGameControl` to view

```xml
<monoGame:MonoGameControl 
	Game="{Binding Game}"
	BackBufferWidth="1920"
	BackBufferHeight="1080"
	IsPaused="False"/>
```

See Examples in `MonoGame.Avalonia.Example.Desktop` and `MonoGame.Avalonia.Example.Desktop.Desktop`  projects

## License
- NeonShooter is licensed under the Microsoft Public License (Ms-PL).  You can find the license text for this in the [/source/NeonShooter/LICENSE.TXT](/source/NeonShooter/LICENSE.TXT) file.
- MonoGame.Avalonia is licensed under the MIT license.  You can find the license text in the [LICENSE](LICENSE).


