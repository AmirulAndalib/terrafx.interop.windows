// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WNDCLASSA" /> struct.</summary>
    public static unsafe class WNDCLASSATests
    {
        /// <summary>Validates that the <see cref="WNDCLASSA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WNDCLASSA>(), Is.EqualTo(sizeof(WNDCLASSA)));
        }

        /// <summary>Validates that the <see cref="WNDCLASSA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WNDCLASSA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WNDCLASSA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(WNDCLASSA), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(WNDCLASSA), Is.EqualTo(40));
            }
        }
    }
}
