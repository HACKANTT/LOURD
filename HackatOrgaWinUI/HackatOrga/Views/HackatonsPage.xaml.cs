using HackatOrga.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace HackatOrga.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class HackatonsPage : Page
{
    public HackatonsViewModel ViewModel
    {
        get;
    }

    public HackatonsPage()
    {
        ViewModel = App.GetService<HackatonsViewModel>();
        InitializeComponent();
    }
}
