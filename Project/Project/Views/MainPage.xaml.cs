using ProjectModel;
using ProjectModel.ViewModels;
using System;
using Xamarin.Forms;

namespace Project
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      this.BindingContext = new MainPageViewModel(new PageService());
    }

    private void DeleteContext_Clicked(object sender, EventArgs e)
    {
      ArtistViewModel artist = (sender as MenuItem).CommandParameter as ArtistViewModel;
      (BindingContext as MainPageViewModel).DeleteFromListCommand.Execute(artist);
    }

    private void ViewOneArtistSelected(object sender, SelectedItemChangedEventArgs e)
    {
      (BindingContext as MainPageViewModel).SelectOneArtist(e.SelectedItem as ArtistViewModel);
      // could do this even smarter by using the setter on the SelectedItem
      // property in the view model. Can then avoid this method altogether

    }
  }
}
