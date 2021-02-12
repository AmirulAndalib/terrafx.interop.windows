// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CAUI" /> struct.</summary>
    public static unsafe class CAUITests
    {
        /// <summary>Validates that the <see cref="CAUI" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CAUI>(), Is.EqualTo(sizeof(CAUI)));
        }

        /// <summary>Validates that the <see cref="CAUI" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CAUI).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CAUI" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CAUI), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(CAUI), Is.EqualTo(8));
            }
        }
    }
}
