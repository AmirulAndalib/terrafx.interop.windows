// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="QUOTA_LIMITS" /> struct.</summary>
    public static unsafe class QUOTA_LIMITSTests
    {
        /// <summary>Validates that the <see cref="QUOTA_LIMITS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<QUOTA_LIMITS>(), Is.EqualTo(sizeof(QUOTA_LIMITS)));
        }

        /// <summary>Validates that the <see cref="QUOTA_LIMITS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(QUOTA_LIMITS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="QUOTA_LIMITS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(QUOTA_LIMITS), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(QUOTA_LIMITS), Is.EqualTo(32));
            }
        }
    }
}
