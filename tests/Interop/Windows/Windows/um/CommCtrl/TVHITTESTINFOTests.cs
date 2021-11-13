// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="TVHITTESTINFO" /> struct.</summary>
    public static unsafe partial class TVHITTESTINFOTests
    {
        /// <summary>Validates that the <see cref="TVHITTESTINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TVHITTESTINFO>(), Is.EqualTo(sizeof(TVHITTESTINFO)));
        }

        /// <summary>Validates that the <see cref="TVHITTESTINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TVHITTESTINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TVHITTESTINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(TVHITTESTINFO), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(TVHITTESTINFO), Is.EqualTo(16));
            }
        }
    }
}
