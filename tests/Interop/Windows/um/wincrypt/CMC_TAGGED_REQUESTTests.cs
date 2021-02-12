// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CMC_TAGGED_REQUEST" /> struct.</summary>
    public static unsafe class CMC_TAGGED_REQUESTTests
    {
        /// <summary>Validates that the <see cref="CMC_TAGGED_REQUEST" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CMC_TAGGED_REQUEST>(), Is.EqualTo(sizeof(CMC_TAGGED_REQUEST)));
        }

        /// <summary>Validates that the <see cref="CMC_TAGGED_REQUEST" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CMC_TAGGED_REQUEST).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CMC_TAGGED_REQUEST" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CMC_TAGGED_REQUEST), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(CMC_TAGGED_REQUEST), Is.EqualTo(8));
            }
        }
    }
}
