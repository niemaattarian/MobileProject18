using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModel
{
    class Artist
    {
      #region == Public Properties ==
      public string Artists { get; set; }
      public int Age { get; set; }
      public string Genre { get; set; }
      public string Album { get; set; }
      public int Sales { get; set; }

      #endregion
      #region == constructors ==
      public Artist()
      {

      }
      public Artist(string ar, int ag, string g, string al, int s)
      {
        Artists = ar;
        Age = ag;
        Genre = g;
        Album = al;
        Sales = s;
      }
      #endregion
  }
}
