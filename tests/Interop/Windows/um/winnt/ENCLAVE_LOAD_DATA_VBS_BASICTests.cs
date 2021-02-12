// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ENCLAVE_LOAD_DATA_VBS_BASIC" /> struct.</summary>
    public static unsafe class ENCLAVE_LOAD_DATA_VBS_BASICTests
    {
        /// <summary>Validates that the <see cref="ENCLAVE_LOAD_DATA_VBS_BASIC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ENCLAVE_LOAD_DATA_VBS_BASIC>(), Is.EqualTo(sizeof(ENCLAVE_LOAD_DATA_VBS_BASIC)));
        }

        /// <summary>Validates that the <see cref="ENCLAVE_LOAD_DATA_VBS_BASIC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ENCLAVE_LOAD_DATA_VBS_BASIC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ENCLAVE_LOAD_DATA_VBS_BASIC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ENCLAVE_LOAD_DATA_VBS_BASIC), Is.EqualTo(4));
        }
    }
}
