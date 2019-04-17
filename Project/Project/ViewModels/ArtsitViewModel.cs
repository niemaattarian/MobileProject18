using Newtonsoft.Json;
using Project;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using Utils;

namespace ProjectModel
{
  public class ArtistViewModel : BaseViewModel
  {
    #region == Public Properties ==
    public string Artist { get; set; }
    private string _genre;
    public string Genre
    {
      get { return _genre; }
      set { SetValue(ref _genre, value); }
    }
    private string _album;
    public string Album
    {
      get { return _album; }
      set { SetValue(ref _album, value); }
    }
    public int Sales { get; set; }

    #endregion


    #region == Methods ==
    public static ObservableCollection<ArtistViewModel> ReadArtistData()
    {
      ObservableCollection<ArtistViewModel> myList = new ObservableCollection<ArtistViewModel>();
      string jsonText;

      try  // reading the localApplicationFolder first
      {
        string path = Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData);
        string filename = Path.Combine(path, MyUtils.JSON_ARTIST_FILE);
        using (var reader = new StreamReader(filename))
        {
          jsonText = reader.ReadToEnd();
          // need json library
        }
      }
      catch // fallback is to read the default file
      {
        var assembly = IntrospectionExtensions.GetTypeInfo(
                                        typeof(MainPage)).Assembly;
        // create the stream
        Stream stream = assembly.GetManifestResourceStream(
                            "Project.Data.myArtist.txt");
        using (var reader = new StreamReader(stream))
        {
          jsonText = reader.ReadToEnd();
          // include JSON library now
        }
      }

      myList = JsonConvert.DeserializeObject<ObservableCollection<ArtistViewModel>>(jsonText);

      return myList;
    }

    public static void SaveArtistData(ObservableCollection<ArtistViewModel> saveList)
    {
      // need the path to the file
      string path = Environment.GetFolderPath(
          Environment.SpecialFolder.LocalApplicationData);
      string filename = Path.Combine(path, MyUtils.JSON_ARTIST_FILE);
      // use a stream writer to write the list
      using (var writer = new StreamWriter(filename, false))
      {
        // stringify equivalent
        string jsonText = JsonConvert.SerializeObject(saveList);
        writer.WriteLine(jsonText);
      }
    }

    #endregion

  }
}
