﻿//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System.IO;
using System.Threading.Tasks;

namespace ImageMagick
{
  internal static partial class FileHelper
  {
    public static string CheckForBaseDirectory(string fileName)
    {
      return fileName;
    }

    public static void Delete(FileInfo file)
    {
      if (!file.Exists)
        return;

      int retries = 10;

      while (retries != 0)
      {
        try
        {
          file.Delete();
          return;
        }
        catch (IOException)
        {
          retries--;
          Task.Delay(1).Wait();
        }
      }
    }
  }
}