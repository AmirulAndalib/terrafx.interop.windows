// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="THREAD_POWER_THROTTLING_STATE" /> struct.</summary>
    public static unsafe class THREAD_POWER_THROTTLING_STATETests
    {
        /// <summary>Validates that the <see cref="THREAD_POWER_THROTTLING_STATE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<THREAD_POWER_THROTTLING_STATE>(), Is.EqualTo(sizeof(THREAD_POWER_THROTTLING_STATE)));
        }

        /// <summary>Validates that the <see cref="THREAD_POWER_THROTTLING_STATE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(THREAD_POWER_THROTTLING_STATE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="THREAD_POWER_THROTTLING_STATE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(THREAD_POWER_THROTTLING_STATE), Is.EqualTo(12));
        }
    }
}
