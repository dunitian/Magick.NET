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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

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
  public partial class MagickSettings
  {
    private static class NativeMethods
    {
      public static class X64
      {
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MagickSettings+NativeMethods.X64#.cctor()")]
        static X64() { NativeLibraryLoader.Load(); }
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_Create();
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Dispose(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_BackgroundColor_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_BackgroundColor_Set(IntPtr instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickSettings_ColorSpace_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_ColorSpace_Set(IntPtr instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickSettings_ColorType_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_ColorType_Set(IntPtr instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickSettings_CompressionMethod_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_CompressionMethod_Set(IntPtr instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickSettings_Debug_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Debug_Set(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_Density_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Density_Set(IntPtr instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickSettings_Endian_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Endian_Set(IntPtr instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_Format_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Format_Set(IntPtr instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_Font_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Font_Set(IntPtr instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double MagickSettings_FontPointsize_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_FontPointsize_Set(IntPtr instance, double value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickSettings_Monochrome_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Monochrome_Set(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickSettings_Verbose_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Verbose_Set(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetColorFuzz(IntPtr Instance, double value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetFileName(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetInterlace(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetNumberScenes(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetOption(IntPtr Instance, IntPtr key, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetPage(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetPing(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetQuality(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetScenes(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetScene(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetSize(IntPtr Instance, IntPtr value);
      }
      public static class X86
      {
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MagickSettings+NativeMethods.X86#.cctor()")]
        static X86() { NativeLibraryLoader.Load(); }
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_Create();
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Dispose(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_BackgroundColor_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_BackgroundColor_Set(IntPtr instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickSettings_ColorSpace_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_ColorSpace_Set(IntPtr instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickSettings_ColorType_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_ColorType_Set(IntPtr instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickSettings_CompressionMethod_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_CompressionMethod_Set(IntPtr instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickSettings_Debug_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Debug_Set(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_Density_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Density_Set(IntPtr instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickSettings_Endian_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Endian_Set(IntPtr instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_Format_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Format_Set(IntPtr instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickSettings_Font_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Font_Set(IntPtr instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double MagickSettings_FontPointsize_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_FontPointsize_Set(IntPtr instance, double value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickSettings_Monochrome_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Monochrome_Set(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool MagickSettings_Verbose_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_Verbose_Set(IntPtr instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetColorFuzz(IntPtr Instance, double value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetFileName(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetInterlace(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetNumberScenes(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetOption(IntPtr Instance, IntPtr key, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetPage(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetPing(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetQuality(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetScenes(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetScene(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickSettings_SetSize(IntPtr Instance, IntPtr value);
      }
    }
    private sealed class NativeMagickSettings : NativeInstance
    {
      private IntPtr _Instance = IntPtr.Zero;
      protected override void Dispose(IntPtr instance)
      {
        DisposeInstance(instance);
      }
      public static void DisposeInstance(IntPtr instance)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MagickSettings_Dispose(instance);
        else
          NativeMethods.X86.MagickSettings_Dispose(instance);
      }
      public NativeMagickSettings()
      {
        if (NativeLibrary.Is64Bit)
          _Instance = NativeMethods.X64.MagickSettings_Create();
        else
          _Instance = NativeMethods.X86.MagickSettings_Create();
        if (_Instance == IntPtr.Zero)
          throw new InvalidOperationException();
      }
      public override IntPtr Instance
      {
        get
        {
          if (_Instance == IntPtr.Zero)
            throw new ObjectDisposedException(typeof(MagickSettings).ToString());
          return _Instance;
        }
        set
        {
          if (_Instance != IntPtr.Zero)
            Dispose(_Instance);
          _Instance = value;
        }
      }
      public MagickColor BackgroundColor
      {
        get
        {
          IntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_BackgroundColor_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_BackgroundColor_Get(Instance);
          return MagickColor.CreateInstance(result);
        }
        set
        {
          using (INativeInstance valueNative = MagickColor.CreateInstance(value))
          {
            if (NativeLibrary.Is64Bit)
              NativeMethods.X64.MagickSettings_BackgroundColor_Set(Instance, valueNative.Instance);
            else
              NativeMethods.X86.MagickSettings_BackgroundColor_Set(Instance, valueNative.Instance);
          }
        }
      }
      public ColorSpace ColorSpace
      {
        get
        {
          UIntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_ColorSpace_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_ColorSpace_Get(Instance);
          return (ColorSpace)result;
        }
        set
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_ColorSpace_Set(Instance, (UIntPtr)value);
          else
            NativeMethods.X86.MagickSettings_ColorSpace_Set(Instance, (UIntPtr)value);
        }
      }
      public ColorType ColorType
      {
        get
        {
          UIntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_ColorType_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_ColorType_Get(Instance);
          return (ColorType)result;
        }
        set
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_ColorType_Set(Instance, (UIntPtr)value);
          else
            NativeMethods.X86.MagickSettings_ColorType_Set(Instance, (UIntPtr)value);
        }
      }
      public CompressionMethod CompressionMethod
      {
        get
        {
          UIntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_CompressionMethod_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_CompressionMethod_Get(Instance);
          return (CompressionMethod)result;
        }
        set
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_CompressionMethod_Set(Instance, (UIntPtr)value);
          else
            NativeMethods.X86.MagickSettings_CompressionMethod_Set(Instance, (UIntPtr)value);
        }
      }
      public bool Debug
      {
        get
        {
          bool result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_Debug_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_Debug_Get(Instance);
          return result;
        }
        set
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_Debug_Set(Instance, value);
          else
            NativeMethods.X86.MagickSettings_Debug_Set(Instance, value);
        }
      }
      public string Density
      {
        get
        {
          IntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_Density_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_Density_Get(Instance);
          return UTF8Marshaler.NativeToManaged(result);
        }
        set
        {
          using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
          {
            if (NativeLibrary.Is64Bit)
              NativeMethods.X64.MagickSettings_Density_Set(Instance, valueNative.Instance);
            else
              NativeMethods.X86.MagickSettings_Density_Set(Instance, valueNative.Instance);
          }
        }
      }
      public Endian Endian
      {
        get
        {
          UIntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_Endian_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_Endian_Get(Instance);
          return (Endian)result;
        }
        set
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_Endian_Set(Instance, (UIntPtr)value);
          else
            NativeMethods.X86.MagickSettings_Endian_Set(Instance, (UIntPtr)value);
        }
      }
      public string Format
      {
        get
        {
          IntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_Format_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_Format_Get(Instance);
          return UTF8Marshaler.NativeToManaged(result);
        }
        set
        {
          using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
          {
            if (NativeLibrary.Is64Bit)
              NativeMethods.X64.MagickSettings_Format_Set(Instance, valueNative.Instance);
            else
              NativeMethods.X86.MagickSettings_Format_Set(Instance, valueNative.Instance);
          }
        }
      }
      public string Font
      {
        get
        {
          IntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_Font_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_Font_Get(Instance);
          return UTF8Marshaler.NativeToManaged(result);
        }
        set
        {
          using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
          {
            if (NativeLibrary.Is64Bit)
              NativeMethods.X64.MagickSettings_Font_Set(Instance, valueNative.Instance);
            else
              NativeMethods.X86.MagickSettings_Font_Set(Instance, valueNative.Instance);
          }
        }
      }
      public double FontPointsize
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_FontPointsize_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_FontPointsize_Get(Instance);
          return result;
        }
        set
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_FontPointsize_Set(Instance, value);
          else
            NativeMethods.X86.MagickSettings_FontPointsize_Set(Instance, value);
        }
      }
      public bool Monochrome
      {
        get
        {
          bool result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_Monochrome_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_Monochrome_Get(Instance);
          return result;
        }
        set
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_Monochrome_Set(Instance, value);
          else
            NativeMethods.X86.MagickSettings_Monochrome_Set(Instance, value);
        }
      }
      public bool Verbose
      {
        get
        {
          bool result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.MagickSettings_Verbose_Get(Instance);
          else
            result = NativeMethods.X86.MagickSettings_Verbose_Get(Instance);
          return result;
        }
        set
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_Verbose_Set(Instance, value);
          else
            NativeMethods.X86.MagickSettings_Verbose_Set(Instance, value);
        }
      }
      public void SetColorFuzz(double value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MagickSettings_SetColorFuzz(Instance, value);
        else
          NativeMethods.X86.MagickSettings_SetColorFuzz(Instance, value);
      }
      public void SetFileName(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_SetFileName(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MagickSettings_SetFileName(Instance, valueNative.Instance);
        }
      }
      public void SetInterlace(Interlace value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MagickSettings_SetInterlace(Instance, (UIntPtr)value);
        else
          NativeMethods.X86.MagickSettings_SetInterlace(Instance, (UIntPtr)value);
      }
      public void SetNumberScenes(int value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MagickSettings_SetNumberScenes(Instance, (UIntPtr)value);
        else
          NativeMethods.X86.MagickSettings_SetNumberScenes(Instance, (UIntPtr)value);
      }
      public void SetOption(string key, string value)
      {
        using (INativeInstance keyNative = UTF8Marshaler.CreateInstance(key))
        {
          using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
          {
            if (NativeLibrary.Is64Bit)
              NativeMethods.X64.MagickSettings_SetOption(Instance, keyNative.Instance, valueNative.Instance);
            else
              NativeMethods.X86.MagickSettings_SetOption(Instance, keyNative.Instance, valueNative.Instance);
          }
        }
      }
      public void SetPage(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_SetPage(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MagickSettings_SetPage(Instance, valueNative.Instance);
        }
      }
      public void SetPing(bool value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MagickSettings_SetPing(Instance, value);
        else
          NativeMethods.X86.MagickSettings_SetPing(Instance, value);
      }
      public void SetQuality(int value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MagickSettings_SetQuality(Instance, (UIntPtr)value);
        else
          NativeMethods.X86.MagickSettings_SetQuality(Instance, (UIntPtr)value);
      }
      public void SetScenes(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_SetScenes(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MagickSettings_SetScenes(Instance, valueNative.Instance);
        }
      }
      public void SetScene(int value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MagickSettings_SetScene(Instance, (UIntPtr)value);
        else
          NativeMethods.X86.MagickSettings_SetScene(Instance, (UIntPtr)value);
      }
      public void SetSize(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MagickSettings_SetSize(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MagickSettings_SetSize(Instance, valueNative.Instance);
        }
      }
    }
    internal static INativeInstance CreateInstance(MagickSettings instance)
    {
      if (instance == null)
        return NativeInstance.Zero;
      return instance.CreateNativeInstance();
    }
  }
}
