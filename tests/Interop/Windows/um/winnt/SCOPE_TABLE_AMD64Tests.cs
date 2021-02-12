// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SCOPE_TABLE_AMD64" /> struct.</summary>
    public static unsafe class SCOPE_TABLE_AMD64Tests
    {
        /// <summary>Validates that the <see cref="SCOPE_TABLE_AMD64" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SCOPE_TABLE_AMD64>(), Is.EqualTo(sizeof(SCOPE_TABLE_AMD64)));
        }

        /// <summary>Validates that the <see cref="SCOPE_TABLE_AMD64" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SCOPE_TABLE_AMD64).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SCOPE_TABLE_AMD64" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SCOPE_TABLE_AMD64), Is.EqualTo(20));
        }
    }
}
