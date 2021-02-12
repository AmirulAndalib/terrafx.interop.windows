// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFTimedTextBinary" /> struct.</summary>
    public static unsafe class IMFTimedTextBinaryTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFTimedTextBinary" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFTimedTextBinary).GUID, Is.EqualTo(IID_IMFTimedTextBinary));
        }

        /// <summary>Validates that the <see cref="IMFTimedTextBinary" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFTimedTextBinary>(), Is.EqualTo(sizeof(IMFTimedTextBinary)));
        }

        /// <summary>Validates that the <see cref="IMFTimedTextBinary" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFTimedTextBinary).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFTimedTextBinary" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFTimedTextBinary), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFTimedTextBinary), Is.EqualTo(4));
            }
        }
    }
}
