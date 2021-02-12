// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CHANGER_ELEMENT_STATUS_EX" /> struct.</summary>
    public static unsafe class CHANGER_ELEMENT_STATUS_EXTests
    {
        /// <summary>Validates that the <see cref="CHANGER_ELEMENT_STATUS_EX" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CHANGER_ELEMENT_STATUS_EX>(), Is.EqualTo(sizeof(CHANGER_ELEMENT_STATUS_EX)));
        }

        /// <summary>Validates that the <see cref="CHANGER_ELEMENT_STATUS_EX" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CHANGER_ELEMENT_STATUS_EX).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CHANGER_ELEMENT_STATUS_EX" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CHANGER_ELEMENT_STATUS_EX), Is.EqualTo(156));
        }
    }
}
