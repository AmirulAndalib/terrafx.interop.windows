// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="COSERVERINFO" /> struct.</summary>
    public static unsafe class COSERVERINFOTests
    {
        /// <summary>Validates that the <see cref="COSERVERINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<COSERVERINFO>(), Is.EqualTo(sizeof(COSERVERINFO)));
        }

        /// <summary>Validates that the <see cref="COSERVERINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(COSERVERINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="COSERVERINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(COSERVERINFO), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(COSERVERINFO), Is.EqualTo(16));
            }
        }
    }
}
