// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WS_DATETIME" /> struct.</summary>
    public static unsafe class WS_DATETIMETests
    {
        /// <summary>Validates that the <see cref="WS_DATETIME" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WS_DATETIME>(), Is.EqualTo(sizeof(WS_DATETIME)));
        }

        /// <summary>Validates that the <see cref="WS_DATETIME" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WS_DATETIME).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WS_DATETIME" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(WS_DATETIME), Is.EqualTo(16));
        }
    }
}
