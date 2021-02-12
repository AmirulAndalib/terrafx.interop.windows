// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TOUCH_HIT_TESTING_PROXIMITY_EVALUATION" /> struct.</summary>
    public static unsafe class TOUCH_HIT_TESTING_PROXIMITY_EVALUATIONTests
    {
        /// <summary>Validates that the <see cref="TOUCH_HIT_TESTING_PROXIMITY_EVALUATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TOUCH_HIT_TESTING_PROXIMITY_EVALUATION>(), Is.EqualTo(sizeof(TOUCH_HIT_TESTING_PROXIMITY_EVALUATION)));
        }

        /// <summary>Validates that the <see cref="TOUCH_HIT_TESTING_PROXIMITY_EVALUATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TOUCH_HIT_TESTING_PROXIMITY_EVALUATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TOUCH_HIT_TESTING_PROXIMITY_EVALUATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TOUCH_HIT_TESTING_PROXIMITY_EVALUATION), Is.EqualTo(12));
        }
    }
}
