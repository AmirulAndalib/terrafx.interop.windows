// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PROPSHEETPAGEW_V1" /> struct.</summary>
    public static unsafe class PROPSHEETPAGEW_V1Tests
    {
        /// <summary>Validates that the <see cref="PROPSHEETPAGEW_V1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PROPSHEETPAGEW_V1>(), Is.EqualTo(sizeof(PROPSHEETPAGEW_V1)));
        }

        /// <summary>Validates that the <see cref="PROPSHEETPAGEW_V1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PROPSHEETPAGEW_V1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PROPSHEETPAGEW_V1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PROPSHEETPAGEW_V1), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(PROPSHEETPAGEW_V1), Is.EqualTo(40));
            }
        }
    }
}
