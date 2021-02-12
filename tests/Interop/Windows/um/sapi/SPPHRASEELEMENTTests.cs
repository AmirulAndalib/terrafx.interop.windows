// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SPPHRASEELEMENT" /> struct.</summary>
    public static unsafe class SPPHRASEELEMENTTests
    {
        /// <summary>Validates that the <see cref="SPPHRASEELEMENT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SPPHRASEELEMENT>(), Is.EqualTo(sizeof(SPPHRASEELEMENT)));
        }

        /// <summary>Validates that the <see cref="SPPHRASEELEMENT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SPPHRASEELEMENT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SPPHRASEELEMENT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SPPHRASEELEMENT), Is.EqualTo(56));
            }
            else
            {
                Assert.That(sizeof(SPPHRASEELEMENT), Is.EqualTo(44));
            }
        }
    }
}
