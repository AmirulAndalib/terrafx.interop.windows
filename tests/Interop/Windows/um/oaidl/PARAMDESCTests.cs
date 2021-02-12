// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PARAMDESC" /> struct.</summary>
    public static unsafe class PARAMDESCTests
    {
        /// <summary>Validates that the <see cref="PARAMDESC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PARAMDESC>(), Is.EqualTo(sizeof(PARAMDESC)));
        }

        /// <summary>Validates that the <see cref="PARAMDESC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PARAMDESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PARAMDESC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PARAMDESC), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(PARAMDESC), Is.EqualTo(8));
            }
        }
    }
}
