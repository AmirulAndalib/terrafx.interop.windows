// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FILE_NOTIFY_INFORMATION" /> struct.</summary>
    public static unsafe class FILE_NOTIFY_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="FILE_NOTIFY_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FILE_NOTIFY_INFORMATION>(), Is.EqualTo(sizeof(FILE_NOTIFY_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="FILE_NOTIFY_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FILE_NOTIFY_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FILE_NOTIFY_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FILE_NOTIFY_INFORMATION), Is.EqualTo(16));
        }
    }
}
