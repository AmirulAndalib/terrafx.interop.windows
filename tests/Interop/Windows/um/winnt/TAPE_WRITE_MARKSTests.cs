// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TAPE_WRITE_MARKS" /> struct.</summary>
    public static unsafe class TAPE_WRITE_MARKSTests
    {
        /// <summary>Validates that the <see cref="TAPE_WRITE_MARKS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TAPE_WRITE_MARKS>(), Is.EqualTo(sizeof(TAPE_WRITE_MARKS)));
        }

        /// <summary>Validates that the <see cref="TAPE_WRITE_MARKS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TAPE_WRITE_MARKS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TAPE_WRITE_MARKS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TAPE_WRITE_MARKS), Is.EqualTo(12));
        }
    }
}
