// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SCM_PD_DESCRIPTOR_HEADER" /> struct.</summary>
    public static unsafe class SCM_PD_DESCRIPTOR_HEADERTests
    {
        /// <summary>Validates that the <see cref="SCM_PD_DESCRIPTOR_HEADER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SCM_PD_DESCRIPTOR_HEADER>(), Is.EqualTo(sizeof(SCM_PD_DESCRIPTOR_HEADER)));
        }

        /// <summary>Validates that the <see cref="SCM_PD_DESCRIPTOR_HEADER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SCM_PD_DESCRIPTOR_HEADER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SCM_PD_DESCRIPTOR_HEADER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SCM_PD_DESCRIPTOR_HEADER), Is.EqualTo(8));
        }
    }
}
