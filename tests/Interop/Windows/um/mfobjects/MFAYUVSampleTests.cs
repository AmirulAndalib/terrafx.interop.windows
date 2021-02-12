// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MFAYUVSample" /> struct.</summary>
    public static unsafe class MFAYUVSampleTests
    {
        /// <summary>Validates that the <see cref="MFAYUVSample" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MFAYUVSample>(), Is.EqualTo(sizeof(MFAYUVSample)));
        }

        /// <summary>Validates that the <see cref="MFAYUVSample" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MFAYUVSample).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MFAYUVSample" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MFAYUVSample), Is.EqualTo(4));
        }
    }
}
