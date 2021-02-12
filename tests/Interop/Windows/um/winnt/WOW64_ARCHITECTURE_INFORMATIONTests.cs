// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WOW64_ARCHITECTURE_INFORMATION" /> struct.</summary>
    public static unsafe class WOW64_ARCHITECTURE_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="WOW64_ARCHITECTURE_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WOW64_ARCHITECTURE_INFORMATION>(), Is.EqualTo(sizeof(WOW64_ARCHITECTURE_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="WOW64_ARCHITECTURE_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WOW64_ARCHITECTURE_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WOW64_ARCHITECTURE_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(WOW64_ARCHITECTURE_INFORMATION), Is.EqualTo(4));
        }
    }
}
