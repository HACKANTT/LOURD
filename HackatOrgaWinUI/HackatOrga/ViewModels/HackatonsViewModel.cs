using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using HackatOrga.Contracts.ViewModels;
using HackatOrga.Core.Contracts.Services;
using HackatOrga.Core.Models;

namespace HackatOrga.ViewModels;

public class HackatonsViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public HackatonsViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
