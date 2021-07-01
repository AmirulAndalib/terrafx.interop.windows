// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TF_PRESERVEDKEY" /> struct.</summary>
    public static unsafe class TF_PRESERVEDKEYTests
    {
        /// <summary>Validates that the <see cref="TF_PRESERVEDKEY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TF_PRESERVEDKEY>(), Is.EqualTo(sizeof(TF_PRESERVEDKEY)));
        }

        /// <summary>Validates that the <see cref="TF_PRESERVEDKEY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TF_PRESERVEDKEY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TF_PRESERVEDKEY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TF_PRESERVEDKEY), Is.EqualTo(8));
        }
    }
}
