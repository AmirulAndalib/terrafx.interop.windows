// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TF_SELECTION" /> struct.</summary>
    public static unsafe class TF_SELECTIONTests
    {
        /// <summary>Validates that the <see cref="TF_SELECTION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TF_SELECTION>(), Is.EqualTo(sizeof(TF_SELECTION)));
        }

        /// <summary>Validates that the <see cref="TF_SELECTION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TF_SELECTION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TF_SELECTION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(TF_SELECTION), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(TF_SELECTION), Is.EqualTo(12));
            }
        }
    }
}
