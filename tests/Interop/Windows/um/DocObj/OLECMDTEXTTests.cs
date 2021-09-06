// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="OLECMDTEXT" /> struct.</summary>
    public static unsafe class OLECMDTEXTTests
    {
        /// <summary>Validates that the <see cref="OLECMDTEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<OLECMDTEXT>(), Is.EqualTo(sizeof(OLECMDTEXT)));
        }

        /// <summary>Validates that the <see cref="OLECMDTEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(OLECMDTEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="OLECMDTEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(OLECMDTEXT), Is.EqualTo(16));
        }
    }
}
