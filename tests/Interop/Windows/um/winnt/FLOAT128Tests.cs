// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FLOAT128" /> struct.</summary>
    public static unsafe class FLOAT128Tests
    {
        /// <summary>Validates that the <see cref="FLOAT128" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FLOAT128>(), Is.EqualTo(sizeof(FLOAT128)));
        }

        /// <summary>Validates that the <see cref="FLOAT128" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FLOAT128).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FLOAT128" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FLOAT128), Is.EqualTo(16));
        }
    }
}
