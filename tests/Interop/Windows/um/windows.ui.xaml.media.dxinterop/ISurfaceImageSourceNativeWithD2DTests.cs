// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISurfaceImageSourceNativeWithD2D" /> struct.</summary>
    public static unsafe class ISurfaceImageSourceNativeWithD2DTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISurfaceImageSourceNativeWithD2D" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISurfaceImageSourceNativeWithD2D).GUID, Is.EqualTo(IID_ISurfaceImageSourceNativeWithD2D));
        }

        /// <summary>Validates that the <see cref="ISurfaceImageSourceNativeWithD2D" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISurfaceImageSourceNativeWithD2D>(), Is.EqualTo(sizeof(ISurfaceImageSourceNativeWithD2D)));
        }

        /// <summary>Validates that the <see cref="ISurfaceImageSourceNativeWithD2D" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISurfaceImageSourceNativeWithD2D).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISurfaceImageSourceNativeWithD2D" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISurfaceImageSourceNativeWithD2D), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISurfaceImageSourceNativeWithD2D), Is.EqualTo(4));
            }
        }
    }
}
