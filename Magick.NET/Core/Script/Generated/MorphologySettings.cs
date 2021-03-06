//=================================================================================================
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
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
  public sealed partial class MagickScript
  {
    private MorphologySettings CreateMorphologySettings(XmlElement element)
    {
      if (element == null)
        return null;
      MorphologySettings result = new MorphologySettings();
      result.Channels = Variables.GetValue<Channels>(element, "channels");
      result.ConvolveBias = Variables.GetValue<Nullable<Percentage>>(element, "convolveBias");
      result.ConvolveScale = Variables.GetValue<MagickGeometry>(element, "convolveScale");
      result.Iterations = Variables.GetValue<Int32>(element, "iterations");
      result.Kernel = Variables.GetValue<Kernel>(element, "kernel");
      result.KernelArguments = Variables.GetValue<String>(element, "kernelArguments");
      result.Method = Variables.GetValue<MorphologyMethod>(element, "method");
      result.UserKernel = Variables.GetValue<String>(element, "userKernel");
      return result;
    }
  }
}
