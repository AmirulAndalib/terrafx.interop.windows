// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SAFEARRAY" /> struct.</summary>
    public static unsafe class SAFEARRAYTests
    {
        /// <summary>Validates that the <see cref="SAFEARRAY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SAFEARRAY>(), Is.EqualTo(sizeof(SAFEARRAY)));
        }

        /// <summary>Validates that the <see cref="SAFEARRAY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SAFEARRAY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SAFEARRAY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SAFEARRAY), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(SAFEARRAY), Is.EqualTo(24));
            }
        }
    }
}
