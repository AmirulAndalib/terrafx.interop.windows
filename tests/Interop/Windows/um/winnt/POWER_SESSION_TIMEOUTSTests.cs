// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="POWER_SESSION_TIMEOUTS" /> struct.</summary>
    public static unsafe class POWER_SESSION_TIMEOUTSTests
    {
        /// <summary>Validates that the <see cref="POWER_SESSION_TIMEOUTS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<POWER_SESSION_TIMEOUTS>(), Is.EqualTo(sizeof(POWER_SESSION_TIMEOUTS)));
        }

        /// <summary>Validates that the <see cref="POWER_SESSION_TIMEOUTS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(POWER_SESSION_TIMEOUTS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="POWER_SESSION_TIMEOUTS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(POWER_SESSION_TIMEOUTS), Is.EqualTo(8));
        }
    }
}
