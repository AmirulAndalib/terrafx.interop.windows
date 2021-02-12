// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CONFIG_CI_PROV_INFO_RESULT" /> struct.</summary>
    public static unsafe class CONFIG_CI_PROV_INFO_RESULTTests
    {
        /// <summary>Validates that the <see cref="CONFIG_CI_PROV_INFO_RESULT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CONFIG_CI_PROV_INFO_RESULT>(), Is.EqualTo(sizeof(CONFIG_CI_PROV_INFO_RESULT)));
        }

        /// <summary>Validates that the <see cref="CONFIG_CI_PROV_INFO_RESULT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CONFIG_CI_PROV_INFO_RESULT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CONFIG_CI_PROV_INFO_RESULT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CONFIG_CI_PROV_INFO_RESULT), Is.EqualTo(16));
        }
    }
}
