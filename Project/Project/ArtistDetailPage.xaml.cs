using ProjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ArtistDetailPage : ContentPage
  {
    ArtistViewModel _artist;
    public ArtistDetailPage(ArtistViewModel artist)
    {
      InitializeComponent();
      _artist = artist;
      this.Title = _artist.Artist;
    }
  }
}
