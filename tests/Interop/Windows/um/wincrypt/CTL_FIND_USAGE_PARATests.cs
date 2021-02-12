// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CTL_FIND_USAGE_PARA" /> struct.</summary>
    public static unsafe class CTL_FIND_USAGE_PARATests
    {
        /// <summary>Validates that the <see cref="CTL_FIND_USAGE_PARA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CTL_FIND_USAGE_PARA>(), Is.EqualTo(sizeof(CTL_FIND_USAGE_PARA)));
        }

        /// <summary>Validates that the <see cref="CTL_FIND_USAGE_PARA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CTL_FIND_USAGE_PARA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CTL_FIND_USAGE_PARA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CTL_FIND_USAGE_PARA), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(CTL_FIND_USAGE_PARA), Is.EqualTo(24));
            }
        }
    }
}
