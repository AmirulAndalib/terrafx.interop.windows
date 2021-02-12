// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TIMECODE" /> struct.</summary>
    public static unsafe class TIMECODETests
    {
        /// <summary>Validates that the <see cref="TIMECODE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TIMECODE>(), Is.EqualTo(sizeof(TIMECODE)));
        }

        /// <summary>Validates that the <see cref="TIMECODE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(TIMECODE).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="TIMECODE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TIMECODE), Is.EqualTo(8));
        }
    }
}
