// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PRJ_STARTVIRTUALIZING_OPTIONS" /> struct.</summary>
    public static unsafe class PRJ_STARTVIRTUALIZING_OPTIONSTests
    {
        /// <summary>Validates that the <see cref="PRJ_STARTVIRTUALIZING_OPTIONS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PRJ_STARTVIRTUALIZING_OPTIONS>(), Is.EqualTo(sizeof(PRJ_STARTVIRTUALIZING_OPTIONS)));
        }

        /// <summary>Validates that the <see cref="PRJ_STARTVIRTUALIZING_OPTIONS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PRJ_STARTVIRTUALIZING_OPTIONS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PRJ_STARTVIRTUALIZING_OPTIONS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PRJ_STARTVIRTUALIZING_OPTIONS), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(PRJ_STARTVIRTUALIZING_OPTIONS), Is.EqualTo(20));
            }
        }
    }
}
