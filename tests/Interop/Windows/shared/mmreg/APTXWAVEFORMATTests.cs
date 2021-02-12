// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="APTXWAVEFORMAT" /> struct.</summary>
    public static unsafe class APTXWAVEFORMATTests
    {
        /// <summary>Validates that the <see cref="APTXWAVEFORMAT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<APTXWAVEFORMAT>(), Is.EqualTo(sizeof(APTXWAVEFORMAT)));
        }

        /// <summary>Validates that the <see cref="APTXWAVEFORMAT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(APTXWAVEFORMAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="APTXWAVEFORMAT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(APTXWAVEFORMAT), Is.EqualTo(18));
        }
    }
}
