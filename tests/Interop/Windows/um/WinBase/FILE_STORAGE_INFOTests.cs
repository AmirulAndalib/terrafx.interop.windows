// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FILE_STORAGE_INFO" /> struct.</summary>
    public static unsafe class FILE_STORAGE_INFOTests
    {
        /// <summary>Validates that the <see cref="FILE_STORAGE_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FILE_STORAGE_INFO>(), Is.EqualTo(sizeof(FILE_STORAGE_INFO)));
        }

        /// <summary>Validates that the <see cref="FILE_STORAGE_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FILE_STORAGE_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FILE_STORAGE_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FILE_STORAGE_INFO), Is.EqualTo(28));
        }
    }
}
