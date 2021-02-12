// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IO_COUNTERS" /> struct.</summary>
    public static unsafe class IO_COUNTERSTests
    {
        /// <summary>Validates that the <see cref="IO_COUNTERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IO_COUNTERS>(), Is.EqualTo(sizeof(IO_COUNTERS)));
        }

        /// <summary>Validates that the <see cref="IO_COUNTERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IO_COUNTERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IO_COUNTERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IO_COUNTERS), Is.EqualTo(48));
        }
    }
}
