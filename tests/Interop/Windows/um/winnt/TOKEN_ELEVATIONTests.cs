// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TOKEN_ELEVATION" /> struct.</summary>
    public static unsafe class TOKEN_ELEVATIONTests
    {
        /// <summary>Validates that the <see cref="TOKEN_ELEVATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TOKEN_ELEVATION>(), Is.EqualTo(sizeof(TOKEN_ELEVATION)));
        }

        /// <summary>Validates that the <see cref="TOKEN_ELEVATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TOKEN_ELEVATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TOKEN_ELEVATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TOKEN_ELEVATION), Is.EqualTo(4));
        }
    }
}
