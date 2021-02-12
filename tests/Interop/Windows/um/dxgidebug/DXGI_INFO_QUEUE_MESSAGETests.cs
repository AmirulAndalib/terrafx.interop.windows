// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_INFO_QUEUE_MESSAGE" /> struct.</summary>
    public static unsafe class DXGI_INFO_QUEUE_MESSAGETests
    {
        /// <summary>Validates that the <see cref="DXGI_INFO_QUEUE_MESSAGE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_INFO_QUEUE_MESSAGE>(), Is.EqualTo(sizeof(DXGI_INFO_QUEUE_MESSAGE)));
        }

        /// <summary>Validates that the <see cref="DXGI_INFO_QUEUE_MESSAGE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_INFO_QUEUE_MESSAGE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DXGI_INFO_QUEUE_MESSAGE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DXGI_INFO_QUEUE_MESSAGE), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(DXGI_INFO_QUEUE_MESSAGE), Is.EqualTo(36));
            }
        }
    }
}
