using ProjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewArtistPage : ContentPage
	{
    public Artist Artist { get; set; }

    public NewArtistPage ()
		{
			InitializeComponent ();

      Artist = new Artist
      {
        Artists = "Joe Blogs",
        Genre = "Rap",
        Album = "Abc",
        Sales = 100
    };

      BindingContext = this;
    }

    private void BtnSaveNewFile_Clicked(object sender, EventArgs e)
    {
      MessagingCenter.Send(this, "AddItem", Artist);
      Navigation.PopModalAsync();
    }

    private void BtnCancelFile_Clicked(object sender, EventArgs e)
    {
      Navigation.PushModalAsync(new NavigationPage(new MainPage()));
    }
  }
}
