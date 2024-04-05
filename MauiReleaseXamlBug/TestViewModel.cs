using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiReleaseXamlBug;

public sealed partial class TestViewModel : ObservableObject
{
    [ObservableProperty] int minHeightPx = 0;
    [ObservableProperty] int minWidthPx = 0;
    [ObservableProperty] decimal minWidthHeightRatio = 0;
    [ObservableProperty] string maxFileSizeBytes = "";
    [ObservableProperty] int minPictures = 0;
    [ObservableProperty] int maxPictures = 0;
    [ObservableProperty] int currentImages = 0;
    [ObservableProperty] int remainingImages = 0;

    public ObservableCollection<string> Images { get; set; } = [];

    [RelayCommand(FlowExceptionsToTaskScheduler = true)]
    async Task OpenImagePickerDialog()
    {
    }

    [RelayCommand(FlowExceptionsToTaskScheduler = true)]
    async Task CapturePhoto()
    {
    }
    [RelayCommand(FlowExceptionsToTaskScheduler = true)]
    async Task Submit()
    {
    }
}