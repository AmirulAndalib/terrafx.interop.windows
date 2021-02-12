// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TOKEN_STATISTICS" /> struct.</summary>
    public static unsafe class TOKEN_STATISTICSTests
    {
        /// <summary>Validates that the <see cref="TOKEN_STATISTICS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TOKEN_STATISTICS>(), Is.EqualTo(sizeof(TOKEN_STATISTICS)));
        }

        /// <summary>Validates that the <see cref="TOKEN_STATISTICS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TOKEN_STATISTICS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TOKEN_STATISTICS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TOKEN_STATISTICS), Is.EqualTo(56));
        }
    }
}
