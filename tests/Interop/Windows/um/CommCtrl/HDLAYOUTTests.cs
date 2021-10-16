// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HDLAYOUT" /> struct.</summary>
    public static unsafe partial class HDLAYOUTTests
    {
        /// <summary>Validates that the <see cref="HDLAYOUT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HDLAYOUT>(), Is.EqualTo(sizeof(HDLAYOUT)));
        }

        /// <summary>Validates that the <see cref="HDLAYOUT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HDLAYOUT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HDLAYOUT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HDLAYOUT), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(HDLAYOUT), Is.EqualTo(8));
            }
        }
    }
}
