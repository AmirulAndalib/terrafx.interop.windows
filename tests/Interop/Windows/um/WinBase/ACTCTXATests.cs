// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ACTCTXA" /> struct.</summary>
    public static unsafe class ACTCTXATests
    {
        /// <summary>Validates that the <see cref="ACTCTXA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ACTCTXA>(), Is.EqualTo(sizeof(ACTCTXA)));
        }

        /// <summary>Validates that the <see cref="ACTCTXA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ACTCTXA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ACTCTXA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ACTCTXA), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(ACTCTXA), Is.EqualTo(32));
            }
        }
    }
}
