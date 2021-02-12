// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CAFILETIME" /> struct.</summary>
    public static unsafe class CAFILETIMETests
    {
        /// <summary>Validates that the <see cref="CAFILETIME" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CAFILETIME>(), Is.EqualTo(sizeof(CAFILETIME)));
        }

        /// <summary>Validates that the <see cref="CAFILETIME" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CAFILETIME).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CAFILETIME" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CAFILETIME), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(CAFILETIME), Is.EqualTo(8));
            }
        }
    }
}
