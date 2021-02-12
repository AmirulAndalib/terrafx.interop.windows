// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TOKEN_PRIVILEGES" /> struct.</summary>
    public static unsafe class TOKEN_PRIVILEGESTests
    {
        /// <summary>Validates that the <see cref="TOKEN_PRIVILEGES" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TOKEN_PRIVILEGES>(), Is.EqualTo(sizeof(TOKEN_PRIVILEGES)));
        }

        /// <summary>Validates that the <see cref="TOKEN_PRIVILEGES" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TOKEN_PRIVILEGES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TOKEN_PRIVILEGES" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TOKEN_PRIVILEGES), Is.EqualTo(16));
        }
    }
}
