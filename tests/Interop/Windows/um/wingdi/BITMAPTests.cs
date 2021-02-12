// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="BITMAP" /> struct.</summary>
    public static unsafe class BITMAPTests
    {
        /// <summary>Validates that the <see cref="BITMAP" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<BITMAP>(), Is.EqualTo(sizeof(BITMAP)));
        }

        /// <summary>Validates that the <see cref="BITMAP" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(BITMAP).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="BITMAP" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(BITMAP), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(BITMAP), Is.EqualTo(24));
            }
        }
    }
}
