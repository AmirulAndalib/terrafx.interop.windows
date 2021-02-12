// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGE_FUNCTION_ENTRY64" /> struct.</summary>
    public static unsafe class IMAGE_FUNCTION_ENTRY64Tests
    {
        /// <summary>Validates that the <see cref="IMAGE_FUNCTION_ENTRY64" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGE_FUNCTION_ENTRY64>(), Is.EqualTo(sizeof(IMAGE_FUNCTION_ENTRY64)));
        }

        /// <summary>Validates that the <see cref="IMAGE_FUNCTION_ENTRY64" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMAGE_FUNCTION_ENTRY64).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGE_FUNCTION_ENTRY64" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGE_FUNCTION_ENTRY64), Is.EqualTo(24));
        }
    }
}
