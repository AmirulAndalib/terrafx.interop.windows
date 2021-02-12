// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="OBJECT_TYPE_LIST" /> struct.</summary>
    public static unsafe class OBJECT_TYPE_LISTTests
    {
        /// <summary>Validates that the <see cref="OBJECT_TYPE_LIST" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<OBJECT_TYPE_LIST>(), Is.EqualTo(sizeof(OBJECT_TYPE_LIST)));
        }

        /// <summary>Validates that the <see cref="OBJECT_TYPE_LIST" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(OBJECT_TYPE_LIST).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="OBJECT_TYPE_LIST" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(OBJECT_TYPE_LIST), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(OBJECT_TYPE_LIST), Is.EqualTo(8));
            }
        }
    }
}
