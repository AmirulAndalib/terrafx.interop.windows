// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SecPkgContext_EarlyStart" /> struct.</summary>
    public static unsafe class SecPkgContext_EarlyStartTests
    {
        /// <summary>Validates that the <see cref="SecPkgContext_EarlyStart" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SecPkgContext_EarlyStart>(), Is.EqualTo(sizeof(SecPkgContext_EarlyStart)));
        }

        /// <summary>Validates that the <see cref="SecPkgContext_EarlyStart" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SecPkgContext_EarlyStart).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SecPkgContext_EarlyStart" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SecPkgContext_EarlyStart), Is.EqualTo(4));
        }
    }
}
