// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MOUSEINPUT" /> struct.</summary>
    public static unsafe class MOUSEINPUTTests
    {
        /// <summary>Validates that the <see cref="MOUSEINPUT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MOUSEINPUT>(), Is.EqualTo(sizeof(MOUSEINPUT)));
        }

        /// <summary>Validates that the <see cref="MOUSEINPUT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MOUSEINPUT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MOUSEINPUT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(MOUSEINPUT), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(MOUSEINPUT), Is.EqualTo(24));
            }
        }
    }
}
