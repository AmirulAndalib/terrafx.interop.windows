// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="STORAGE_PRIORITY_HINT_SUPPORT" /> struct.</summary>
    public static unsafe class STORAGE_PRIORITY_HINT_SUPPORTTests
    {
        /// <summary>Validates that the <see cref="STORAGE_PRIORITY_HINT_SUPPORT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<STORAGE_PRIORITY_HINT_SUPPORT>(), Is.EqualTo(sizeof(STORAGE_PRIORITY_HINT_SUPPORT)));
        }

        /// <summary>Validates that the <see cref="STORAGE_PRIORITY_HINT_SUPPORT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(STORAGE_PRIORITY_HINT_SUPPORT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="STORAGE_PRIORITY_HINT_SUPPORT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(STORAGE_PRIORITY_HINT_SUPPORT), Is.EqualTo(4));
        }
    }
}
