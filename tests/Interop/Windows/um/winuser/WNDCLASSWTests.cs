// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WNDCLASSW" /> struct.</summary>
    public static unsafe class WNDCLASSWTests
    {
        /// <summary>Validates that the <see cref="WNDCLASSW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WNDCLASSW>(), Is.EqualTo(sizeof(WNDCLASSW)));
        }

        /// <summary>Validates that the <see cref="WNDCLASSW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WNDCLASSW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WNDCLASSW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(WNDCLASSW), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(WNDCLASSW), Is.EqualTo(40));
            }
        }
    }
}
