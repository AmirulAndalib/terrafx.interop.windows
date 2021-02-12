// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IVirtualSurfaceUpdatesCallbackNative" /> struct.</summary>
    public static unsafe class IVirtualSurfaceUpdatesCallbackNativeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IVirtualSurfaceUpdatesCallbackNative" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IVirtualSurfaceUpdatesCallbackNative).GUID, Is.EqualTo(IID_IVirtualSurfaceUpdatesCallbackNative));
        }

        /// <summary>Validates that the <see cref="IVirtualSurfaceUpdatesCallbackNative" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IVirtualSurfaceUpdatesCallbackNative>(), Is.EqualTo(sizeof(IVirtualSurfaceUpdatesCallbackNative)));
        }

        /// <summary>Validates that the <see cref="IVirtualSurfaceUpdatesCallbackNative" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IVirtualSurfaceUpdatesCallbackNative).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IVirtualSurfaceUpdatesCallbackNative" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IVirtualSurfaceUpdatesCallbackNative), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IVirtualSurfaceUpdatesCallbackNative), Is.EqualTo(4));
            }
        }
    }
}
