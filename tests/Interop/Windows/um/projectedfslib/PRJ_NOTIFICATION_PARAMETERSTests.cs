// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PRJ_NOTIFICATION_PARAMETERS" /> struct.</summary>
    public static unsafe class PRJ_NOTIFICATION_PARAMETERSTests
    {
        /// <summary>Validates that the <see cref="PRJ_NOTIFICATION_PARAMETERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PRJ_NOTIFICATION_PARAMETERS>(), Is.EqualTo(sizeof(PRJ_NOTIFICATION_PARAMETERS)));
        }

        /// <summary>Validates that the <see cref="PRJ_NOTIFICATION_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(PRJ_NOTIFICATION_PARAMETERS).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="PRJ_NOTIFICATION_PARAMETERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PRJ_NOTIFICATION_PARAMETERS), Is.EqualTo(4));
        }
    }
}
