using Project;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjectModel.ViewModels
{
  public class MainPageViewModel : BaseViewModel
  {
    #region == private fields ==
    private ObservableCollection<ArtistViewModel> artistList;
    private ArtistViewModel selectedArtist;
    #endregion

    #region == Public Properties ==
    public ObservableCollection<ArtistViewModel> ArtistList
    {
      get { return artistList; }
      set { SetValue(ref artistList, value); }
    }
    public ArtistViewModel SelectedArtist
    {
      get { return selectedArtist; }
      set
      {
        SetValue(ref selectedArtist, value);

      }
    }
    #endregion

    #region == Command Properties ==
    // ICommand is an interface with two methods
    // can execute and execute
    public ICommand ReadListCommand { get; private set; }
    public ICommand SaveListCommand { get; private set; }
    public ICommand DeleteFromListCommand { get; private set; }
    #endregion

    #region == public events ==
    private readonly IPageService _pageService;
    public MainPageViewModel(IPageService pageService)
    {
      _pageService = pageService;
      ReadList();
      ReadListCommand = new Command(ReadList);
      SaveListCommand = new Command(SaveList);
      DeleteFromListCommand = new Command<ArtistViewModel>(DeleteFromList);
    }

    private void SaveList()
    {
      ArtistViewModel.SaveArtistData(ArtistList);
    }

    private void ReadList()
    {
      ArtistList = ArtistViewModel.ReadArtistData();
    }

    private void DeleteFromList(ArtistViewModel ar)
    {
      ArtistList.Remove(ar);
      selectedArtist = null;
    }

    public async Task SelectOneArtist(ArtistViewModel artist)
    {
      // can't use a command directly as there is only a commandRefresh
      // attribute

      if (artistList == null)
        return;
      //await Navigation.PushAsync(new DogDetailsPage(dog));
      /*
       * select a dog, go to the page
       * no Navigation property in the view model
       * member of the page class - same as the DisplayAlert
       * Use an interface
       */
      await _pageService.PushAsnyc(new ArtistDetailPage(artist));

    }

    #endregion
  }
}
