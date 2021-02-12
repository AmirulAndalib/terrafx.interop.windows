// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/heapapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HEAP_SUMMARY" /> struct.</summary>
    public static unsafe class HEAP_SUMMARYTests
    {
        /// <summary>Validates that the <see cref="HEAP_SUMMARY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HEAP_SUMMARY>(), Is.EqualTo(sizeof(HEAP_SUMMARY)));
        }

        /// <summary>Validates that the <see cref="HEAP_SUMMARY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HEAP_SUMMARY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HEAP_SUMMARY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HEAP_SUMMARY), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(HEAP_SUMMARY), Is.EqualTo(20));
            }
        }
    }
}
