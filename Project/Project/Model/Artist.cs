using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModel
{
    class Artist
    {
      #region == Public Properties ==
      public string Artists { get; set; }
      public string Genre { get; set; }
      public string Album { get; set; }
      public int Sales { get; set; }

      #endregion
      #region == constructors ==
      public Artist()
      {

      }
      public Artist(string ar, string g, string al, int s)
      {
        Artists = ar;
        Genre = g;
        Album = al;
        Sales = s;
      }
      #endregion
  }
}
