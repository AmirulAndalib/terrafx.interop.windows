// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SECURITY_DESCRIPTOR_RELATIVE" /> struct.</summary>
    public static unsafe class SECURITY_DESCRIPTOR_RELATIVETests
    {
        /// <summary>Validates that the <see cref="SECURITY_DESCRIPTOR_RELATIVE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SECURITY_DESCRIPTOR_RELATIVE>(), Is.EqualTo(sizeof(SECURITY_DESCRIPTOR_RELATIVE)));
        }

        /// <summary>Validates that the <see cref="SECURITY_DESCRIPTOR_RELATIVE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SECURITY_DESCRIPTOR_RELATIVE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SECURITY_DESCRIPTOR_RELATIVE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SECURITY_DESCRIPTOR_RELATIVE), Is.EqualTo(20));
        }
    }
}
