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

namespace ImageMagick
{
  ///<summary>
  /// Used to obtain font metrics for text string given current font, pointsize, and density settings.
  ///</summary>
  public sealed partial class TypeMetric
  {
    private TypeMetric(NativeTypeMetric instance)
    {
      Ascent = instance.Ascent;
      Descent = instance.Descent;
      MaxHorizontalAdvance = instance.MaxHorizontalAdvance;
      TextHeight = instance.TextHeight;
      TextWidth = instance.TextWidth;
      UnderlinePosition = instance.UnderlinePosition;
      UnderlineThickness = instance.UnderlineThickness;
    }

    internal static void Dispose(IntPtr instance)
    {
      NativeTypeMetric.DisposeInstance(instance);
    }

    ///<summary>
    /// Ascent, the distance in pixels from the text baseline to the highest/upper grid coordinate
    /// used to place an outline point.
    ///</summary>
    public double Ascent
    {
      get;
      private set;
    }

    ///<summary>
    /// Descent, the distance in pixels from the baseline to the lowest grid coordinate used to
    /// place an outline point. Always a negative value.
    ///</summary>
    public double Descent
    {
      get;
      private set;
    }

    ///<summary>
    /// Maximum horizontal advance in pixels.
    ///</summary>
    public double MaxHorizontalAdvance
    {
      get;
      private set;
    }

    ///<summary>
    /// Text height in pixels.
    ///</summary>
    public double TextHeight
    {
      get;
      private set;
    }

    ///<summary>
    /// Text width in pixels.
    ///</summary>
    public double TextWidth
    {
      get;
      private set;
    }

    ///<summary>
    /// Underline position.
    ///</summary>
    public double UnderlinePosition
    {
      get;
      private set;
    }

    ///<summary>
    /// Underline thickness.
    ///</summary>
    public double UnderlineThickness
    {
      get;
      private set;
    }
  }
}