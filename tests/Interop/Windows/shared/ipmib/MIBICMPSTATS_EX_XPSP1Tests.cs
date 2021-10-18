// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIBICMPSTATS_EX_XPSP1" /> struct.</summary>
    public static unsafe partial class MIBICMPSTATS_EX_XPSP1Tests
    {
        /// <summary>Validates that the <see cref="MIBICMPSTATS_EX_XPSP1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIBICMPSTATS_EX_XPSP1>(), Is.EqualTo(sizeof(MIBICMPSTATS_EX_XPSP1)));
        }

        /// <summary>Validates that the <see cref="MIBICMPSTATS_EX_XPSP1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIBICMPSTATS_EX_XPSP1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIBICMPSTATS_EX_XPSP1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MIBICMPSTATS_EX_XPSP1), Is.EqualTo(1032));
        }
    }
}
