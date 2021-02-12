// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SYSTEM_BATTERY_STATE" /> struct.</summary>
    public static unsafe class SYSTEM_BATTERY_STATETests
    {
        /// <summary>Validates that the <see cref="SYSTEM_BATTERY_STATE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SYSTEM_BATTERY_STATE>(), Is.EqualTo(sizeof(SYSTEM_BATTERY_STATE)));
        }

        /// <summary>Validates that the <see cref="SYSTEM_BATTERY_STATE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SYSTEM_BATTERY_STATE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SYSTEM_BATTERY_STATE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SYSTEM_BATTERY_STATE), Is.EqualTo(32));
        }
    }
}
