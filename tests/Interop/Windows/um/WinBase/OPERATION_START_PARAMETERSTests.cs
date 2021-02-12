// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="OPERATION_START_PARAMETERS" /> struct.</summary>
    public static unsafe class OPERATION_START_PARAMETERSTests
    {
        /// <summary>Validates that the <see cref="OPERATION_START_PARAMETERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<OPERATION_START_PARAMETERS>(), Is.EqualTo(sizeof(OPERATION_START_PARAMETERS)));
        }

        /// <summary>Validates that the <see cref="OPERATION_START_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(OPERATION_START_PARAMETERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="OPERATION_START_PARAMETERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(OPERATION_START_PARAMETERS), Is.EqualTo(12));
        }
    }
}
