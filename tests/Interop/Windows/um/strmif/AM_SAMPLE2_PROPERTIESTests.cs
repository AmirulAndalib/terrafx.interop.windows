// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="AM_SAMPLE2_PROPERTIES" /> struct.</summary>
    public static unsafe class AM_SAMPLE2_PROPERTIESTests
    {
        /// <summary>Validates that the <see cref="AM_SAMPLE2_PROPERTIES" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<AM_SAMPLE2_PROPERTIES>(), Is.EqualTo(sizeof(AM_SAMPLE2_PROPERTIES)));
        }

        /// <summary>Validates that the <see cref="AM_SAMPLE2_PROPERTIES" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(AM_SAMPLE2_PROPERTIES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="AM_SAMPLE2_PROPERTIES" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(AM_SAMPLE2_PROPERTIES), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(AM_SAMPLE2_PROPERTIES), Is.EqualTo(48));
            }
        }
    }
}
