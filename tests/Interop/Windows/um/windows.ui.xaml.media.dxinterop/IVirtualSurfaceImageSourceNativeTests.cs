// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IVirtualSurfaceImageSourceNative" /> struct.</summary>
    public static unsafe class IVirtualSurfaceImageSourceNativeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IVirtualSurfaceImageSourceNative" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IVirtualSurfaceImageSourceNative).GUID, Is.EqualTo(IID_IVirtualSurfaceImageSourceNative));
        }

        /// <summary>Validates that the <see cref="IVirtualSurfaceImageSourceNative" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IVirtualSurfaceImageSourceNative>(), Is.EqualTo(sizeof(IVirtualSurfaceImageSourceNative)));
        }

        /// <summary>Validates that the <see cref="IVirtualSurfaceImageSourceNative" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IVirtualSurfaceImageSourceNative).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IVirtualSurfaceImageSourceNative" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IVirtualSurfaceImageSourceNative), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IVirtualSurfaceImageSourceNative), Is.EqualTo(4));
            }
        }
    }
}
