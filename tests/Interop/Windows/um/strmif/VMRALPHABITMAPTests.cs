// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VMRALPHABITMAP" /> struct.</summary>
    public static unsafe class VMRALPHABITMAPTests
    {
        /// <summary>Validates that the <see cref="VMRALPHABITMAP" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VMRALPHABITMAP>(), Is.EqualTo(sizeof(VMRALPHABITMAP)));
        }

        /// <summary>Validates that the <see cref="VMRALPHABITMAP" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VMRALPHABITMAP).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VMRALPHABITMAP" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VMRALPHABITMAP), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(VMRALPHABITMAP), Is.EqualTo(52));
            }
        }
    }
}
