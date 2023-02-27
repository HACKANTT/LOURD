using CommunityToolkit.WinUI.UI.Controls;

using HackatOrga.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace HackatOrga.Views;

public sealed partial class ConferencePage : Page
{
    public ConferenceViewModel ViewModel
    {
        get;
    }

    public ConferencePage()
    {
        ViewModel = App.GetService<ConferenceViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
