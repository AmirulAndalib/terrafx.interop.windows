// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SYSTEM_POWER_POLICY" /> struct.</summary>
    public static unsafe class SYSTEM_POWER_POLICYTests
    {
        /// <summary>Validates that the <see cref="SYSTEM_POWER_POLICY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SYSTEM_POWER_POLICY>(), Is.EqualTo(sizeof(SYSTEM_POWER_POLICY)));
        }

        /// <summary>Validates that the <see cref="SYSTEM_POWER_POLICY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SYSTEM_POWER_POLICY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SYSTEM_POWER_POLICY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SYSTEM_POWER_POLICY), Is.EqualTo(232));
        }
    }
}
