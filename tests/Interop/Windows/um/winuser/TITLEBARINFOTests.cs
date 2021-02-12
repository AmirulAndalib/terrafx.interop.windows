// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TITLEBARINFO" /> struct.</summary>
    public static unsafe class TITLEBARINFOTests
    {
        /// <summary>Validates that the <see cref="TITLEBARINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TITLEBARINFO>(), Is.EqualTo(sizeof(TITLEBARINFO)));
        }

        /// <summary>Validates that the <see cref="TITLEBARINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TITLEBARINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TITLEBARINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TITLEBARINFO), Is.EqualTo(44));
        }
    }
}
