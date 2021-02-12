// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PROV_ENUMALGS" /> struct.</summary>
    public static unsafe class PROV_ENUMALGSTests
    {
        /// <summary>Validates that the <see cref="PROV_ENUMALGS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PROV_ENUMALGS>(), Is.EqualTo(sizeof(PROV_ENUMALGS)));
        }

        /// <summary>Validates that the <see cref="PROV_ENUMALGS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PROV_ENUMALGS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PROV_ENUMALGS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PROV_ENUMALGS), Is.EqualTo(32));
        }
    }
}
