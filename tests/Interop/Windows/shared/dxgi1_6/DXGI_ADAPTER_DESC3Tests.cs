// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_ADAPTER_DESC3" /> struct.</summary>
    public static unsafe class DXGI_ADAPTER_DESC3Tests
    {
        /// <summary>Validates that the <see cref="DXGI_ADAPTER_DESC3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_ADAPTER_DESC3>(), Is.EqualTo(sizeof(DXGI_ADAPTER_DESC3)));
        }

        /// <summary>Validates that the <see cref="DXGI_ADAPTER_DESC3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_ADAPTER_DESC3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DXGI_ADAPTER_DESC3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DXGI_ADAPTER_DESC3), Is.EqualTo(320));
            }
            else
            {
                Assert.That(sizeof(DXGI_ADAPTER_DESC3), Is.EqualTo(304));
            }
        }
    }
}
