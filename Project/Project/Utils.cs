using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using ProjectModel;    // to access the dogs class
using Newtonsoft.Json;  // for json functions

namespace Utils
{
    class MyUtils
    {
      public const string JSON_ARTIST_FILE = "myArtist.txt";
      public const string MAINPAGE_IMAGE = "travis.jpg";
      public const string UWP_IMG_FOLDER = "Images/";
      //UWP_IMG_FOLDER + MAINPAGE_IMAGE
    }
}
