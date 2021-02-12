// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DVINFO" /> struct.</summary>
    public static unsafe class DVINFOTests
    {
        /// <summary>Validates that the <see cref="DVINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DVINFO>(), Is.EqualTo(sizeof(DVINFO)));
        }

        /// <summary>Validates that the <see cref="DVINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DVINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DVINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DVINFO), Is.EqualTo(32));
        }
    }
}
