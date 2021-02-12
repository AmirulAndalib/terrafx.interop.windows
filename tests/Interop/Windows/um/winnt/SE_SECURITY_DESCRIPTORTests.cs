// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SE_SECURITY_DESCRIPTOR" /> struct.</summary>
    public static unsafe class SE_SECURITY_DESCRIPTORTests
    {
        /// <summary>Validates that the <see cref="SE_SECURITY_DESCRIPTOR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SE_SECURITY_DESCRIPTOR>(), Is.EqualTo(sizeof(SE_SECURITY_DESCRIPTOR)));
        }

        /// <summary>Validates that the <see cref="SE_SECURITY_DESCRIPTOR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SE_SECURITY_DESCRIPTOR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SE_SECURITY_DESCRIPTOR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SE_SECURITY_DESCRIPTOR), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(SE_SECURITY_DESCRIPTOR), Is.EqualTo(12));
            }
        }
    }
}
