// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CONTROLINFO" /> struct.</summary>
    public static unsafe class CONTROLINFOTests
    {
        /// <summary>Validates that the <see cref="CONTROLINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CONTROLINFO>(), Is.EqualTo(sizeof(CONTROLINFO)));
        }

        /// <summary>Validates that the <see cref="CONTROLINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CONTROLINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CONTROLINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CONTROLINFO), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(CONTROLINFO), Is.EqualTo(16));
            }
        }
    }
}
