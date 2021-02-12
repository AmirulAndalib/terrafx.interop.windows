// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HARDWAREHOOKSTRUCT" /> struct.</summary>
    public static unsafe class HARDWAREHOOKSTRUCTTests
    {
        /// <summary>Validates that the <see cref="HARDWAREHOOKSTRUCT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HARDWAREHOOKSTRUCT>(), Is.EqualTo(sizeof(HARDWAREHOOKSTRUCT)));
        }

        /// <summary>Validates that the <see cref="HARDWAREHOOKSTRUCT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HARDWAREHOOKSTRUCT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HARDWAREHOOKSTRUCT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HARDWAREHOOKSTRUCT), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(HARDWAREHOOKSTRUCT), Is.EqualTo(16));
            }
        }
    }
}
