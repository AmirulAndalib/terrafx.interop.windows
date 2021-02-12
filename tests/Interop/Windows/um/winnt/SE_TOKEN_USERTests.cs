// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SE_TOKEN_USER" /> struct.</summary>
    public static unsafe class SE_TOKEN_USERTests
    {
        /// <summary>Validates that the <see cref="SE_TOKEN_USER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SE_TOKEN_USER>(), Is.EqualTo(sizeof(SE_TOKEN_USER)));
        }

        /// <summary>Validates that the <see cref="SE_TOKEN_USER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SE_TOKEN_USER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SE_TOKEN_USER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SE_TOKEN_USER), Is.EqualTo(88));
            }
            else
            {
                Assert.That(sizeof(SE_TOKEN_USER), Is.EqualTo(76));
            }
        }
    }
}
