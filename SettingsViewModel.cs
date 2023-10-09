using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiTest;

public partial class SettingsViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isBroadTogl;
    
    [RelayCommand]
    private void OnBroadcastingToggled(ToggledEventArgs e)
    {
        var a = 5;
    }
}