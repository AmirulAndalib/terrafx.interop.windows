// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NMBCDROPDOWN" /> struct.</summary>
    public static unsafe class NMBCDROPDOWNTests
    {
        /// <summary>Validates that the <see cref="NMBCDROPDOWN" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NMBCDROPDOWN>(), Is.EqualTo(sizeof(NMBCDROPDOWN)));
        }

        /// <summary>Validates that the <see cref="NMBCDROPDOWN" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NMBCDROPDOWN).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NMBCDROPDOWN" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(NMBCDROPDOWN), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(NMBCDROPDOWN), Is.EqualTo(28));
            }
        }
    }
}
