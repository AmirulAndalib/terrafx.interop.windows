// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HD_TEXTFILTERW" /> struct.</summary>
    public static unsafe class HD_TEXTFILTERWTests
    {
        /// <summary>Validates that the <see cref="HD_TEXTFILTERW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HD_TEXTFILTERW>(), Is.EqualTo(sizeof(HD_TEXTFILTERW)));
        }

        /// <summary>Validates that the <see cref="HD_TEXTFILTERW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HD_TEXTFILTERW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HD_TEXTFILTERW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HD_TEXTFILTERW), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(HD_TEXTFILTERW), Is.EqualTo(8));
            }
        }
    }
}
