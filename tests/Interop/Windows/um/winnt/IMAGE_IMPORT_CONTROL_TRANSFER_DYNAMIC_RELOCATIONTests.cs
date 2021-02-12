// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION" /> struct.</summary>
    public static unsafe class IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATIONTests
    {
        /// <summary>Validates that the <see cref="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION>(), Is.EqualTo(sizeof(IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION)));
        }

        /// <summary>Validates that the <see cref="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION), Is.EqualTo(4));
        }
    }
}
