// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="REGFILTERPINS" /> struct.</summary>
    public static unsafe class REGFILTERPINSTests
    {
        /// <summary>Validates that the <see cref="REGFILTERPINS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<REGFILTERPINS>(), Is.EqualTo(sizeof(REGFILTERPINS)));
        }

        /// <summary>Validates that the <see cref="REGFILTERPINS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(REGFILTERPINS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="REGFILTERPINS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(REGFILTERPINS), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(REGFILTERPINS), Is.EqualTo(36));
            }
        }
    }
}
