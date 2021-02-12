// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISurfaceImageSourceNative" /> struct.</summary>
    public static unsafe class ISurfaceImageSourceNativeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISurfaceImageSourceNative" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISurfaceImageSourceNative).GUID, Is.EqualTo(IID_ISurfaceImageSourceNative));
        }

        /// <summary>Validates that the <see cref="ISurfaceImageSourceNative" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISurfaceImageSourceNative>(), Is.EqualTo(sizeof(ISurfaceImageSourceNative)));
        }

        /// <summary>Validates that the <see cref="ISurfaceImageSourceNative" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISurfaceImageSourceNative).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISurfaceImageSourceNative" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISurfaceImageSourceNative), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISurfaceImageSourceNative), Is.EqualTo(4));
            }
        }
    }
}
