using CommunityToolkit.WinUI.UI.Controls;

using HackatOrga.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace HackatOrga.Views;

public sealed partial class AtelierPage : Page
{
    public AtelierViewModel ViewModel
    {
        get;
    }

    public AtelierPage()
    {
        ViewModel = App.GetService<AtelierViewModel>();
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
