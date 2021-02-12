// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PPM_THERMAL_POLICY_EVENT" /> struct.</summary>
    public static unsafe class PPM_THERMAL_POLICY_EVENTTests
    {
        /// <summary>Validates that the <see cref="PPM_THERMAL_POLICY_EVENT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PPM_THERMAL_POLICY_EVENT>(), Is.EqualTo(sizeof(PPM_THERMAL_POLICY_EVENT)));
        }

        /// <summary>Validates that the <see cref="PPM_THERMAL_POLICY_EVENT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PPM_THERMAL_POLICY_EVENT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PPM_THERMAL_POLICY_EVENT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PPM_THERMAL_POLICY_EVENT), Is.EqualTo(16));
        }
    }
}
