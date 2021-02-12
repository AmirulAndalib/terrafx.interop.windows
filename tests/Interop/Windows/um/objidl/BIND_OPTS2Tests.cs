// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="BIND_OPTS2" /> struct.</summary>
    public static unsafe class BIND_OPTS2Tests
    {
        /// <summary>Validates that the <see cref="BIND_OPTS2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<BIND_OPTS2>(), Is.EqualTo(sizeof(BIND_OPTS2)));
        }

        /// <summary>Validates that the <see cref="BIND_OPTS2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(BIND_OPTS2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="BIND_OPTS2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(BIND_OPTS2), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(BIND_OPTS2), Is.EqualTo(32));
            }
        }
    }
}
