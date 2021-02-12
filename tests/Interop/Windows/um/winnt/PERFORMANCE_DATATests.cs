// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PERFORMANCE_DATA" /> struct.</summary>
    public static unsafe class PERFORMANCE_DATATests
    {
        /// <summary>Validates that the <see cref="PERFORMANCE_DATA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PERFORMANCE_DATA>(), Is.EqualTo(sizeof(PERFORMANCE_DATA)));
        }

        /// <summary>Validates that the <see cref="PERFORMANCE_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PERFORMANCE_DATA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PERFORMANCE_DATA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PERFORMANCE_DATA), Is.EqualTo(288));
        }
    }
}
