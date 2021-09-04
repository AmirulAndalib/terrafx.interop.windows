// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NMTTDISPINFOW" /> struct.</summary>
    public static unsafe class NMTTDISPINFOWTests
    {
        /// <summary>Validates that the <see cref="NMTTDISPINFOW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NMTTDISPINFOW>(), Is.EqualTo(sizeof(NMTTDISPINFOW)));
        }

        /// <summary>Validates that the <see cref="NMTTDISPINFOW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NMTTDISPINFOW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NMTTDISPINFOW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(NMTTDISPINFOW), Is.EqualTo(216));
            }
            else
            {
                Assert.That(sizeof(NMTTDISPINFOW), Is.EqualTo(188));
            }
        }
    }
}
