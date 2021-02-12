// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="KEY_TYPE_SUBTYPE" /> struct.</summary>
    public static unsafe class KEY_TYPE_SUBTYPETests
    {
        /// <summary>Validates that the <see cref="KEY_TYPE_SUBTYPE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<KEY_TYPE_SUBTYPE>(), Is.EqualTo(sizeof(KEY_TYPE_SUBTYPE)));
        }

        /// <summary>Validates that the <see cref="KEY_TYPE_SUBTYPE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(KEY_TYPE_SUBTYPE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="KEY_TYPE_SUBTYPE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(KEY_TYPE_SUBTYPE), Is.EqualTo(36));
        }
    }
}
