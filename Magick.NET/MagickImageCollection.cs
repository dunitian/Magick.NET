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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ImageMagick
{
  public sealed partial class MagickImageCollection
  {
    private void SetFormat(ImageFormat format)
    {
      SetFormat(MagickFormatInfo.GetFormat(format));
    }

    ///<summary>
    /// Converts the images in this instance to a bitmap using ImageFormat.Tiff.
    ///</summary>
    public Bitmap ToBitmap()
    {
      return ToBitmap(ImageFormat.Tiff);
    }

    ///<summary>
    /// Converts the images in this instance to a bitmap using the specified ImageFormat.
    /// Supported formats are: Gif, Icon, Tiff.
    ///</summary>
    public Bitmap ToBitmap(ImageFormat imageFormat)
    {
      SetFormat(imageFormat);

      MemoryStream memStream = new MemoryStream();
      Write(memStream);
      memStream.Position = 0;
      /* Do not dispose the memStream, the bitmap owns it. */
      return new Bitmap(memStream);
    }
  }
}