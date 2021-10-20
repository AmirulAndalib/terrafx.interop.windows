// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NMSEARCHWEB" /> struct.</summary>
    public static unsafe partial class NMSEARCHWEBTests
    {
        /// <summary>Validates that the <see cref="NMSEARCHWEB" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NMSEARCHWEB>(), Is.EqualTo(sizeof(NMSEARCHWEB)));
        }

        /// <summary>Validates that the <see cref="NMSEARCHWEB" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NMSEARCHWEB).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NMSEARCHWEB" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(NMSEARCHWEB), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(NMSEARCHWEB), Is.EqualTo(24));
            }
        }
    }
}