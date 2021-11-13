// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="KCRM_PROTOCOL_BLOB" /> struct.</summary>
    public static unsafe partial class KCRM_PROTOCOL_BLOBTests
    {
        /// <summary>Validates that the <see cref="KCRM_PROTOCOL_BLOB" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<KCRM_PROTOCOL_BLOB>(), Is.EqualTo(sizeof(KCRM_PROTOCOL_BLOB)));
        }

        /// <summary>Validates that the <see cref="KCRM_PROTOCOL_BLOB" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(KCRM_PROTOCOL_BLOB).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="KCRM_PROTOCOL_BLOB" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(KCRM_PROTOCOL_BLOB), Is.EqualTo(32));
        }
    }
}
