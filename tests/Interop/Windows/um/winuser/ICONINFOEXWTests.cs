// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICONINFOEXW" /> struct.</summary>
    public static unsafe class ICONINFOEXWTests
    {
        /// <summary>Validates that the <see cref="ICONINFOEXW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICONINFOEXW>(), Is.EqualTo(sizeof(ICONINFOEXW)));
        }

        /// <summary>Validates that the <see cref="ICONINFOEXW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICONINFOEXW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICONINFOEXW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICONINFOEXW), Is.EqualTo(1080));
            }
            else
            {
                Assert.That(sizeof(ICONINFOEXW), Is.EqualTo(1068));
            }
        }
    }
}
