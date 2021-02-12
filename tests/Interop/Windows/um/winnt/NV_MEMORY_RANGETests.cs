// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NV_MEMORY_RANGE" /> struct.</summary>
    public static unsafe class NV_MEMORY_RANGETests
    {
        /// <summary>Validates that the <see cref="NV_MEMORY_RANGE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NV_MEMORY_RANGE>(), Is.EqualTo(sizeof(NV_MEMORY_RANGE)));
        }

        /// <summary>Validates that the <see cref="NV_MEMORY_RANGE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NV_MEMORY_RANGE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NV_MEMORY_RANGE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(NV_MEMORY_RANGE), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(NV_MEMORY_RANGE), Is.EqualTo(8));
            }
        }
    }
}
