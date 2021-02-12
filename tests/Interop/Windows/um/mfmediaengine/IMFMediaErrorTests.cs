// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFMediaError" /> struct.</summary>
    public static unsafe class IMFMediaErrorTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaError" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFMediaError).GUID, Is.EqualTo(IID_IMFMediaError));
        }

        /// <summary>Validates that the <see cref="IMFMediaError" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFMediaError>(), Is.EqualTo(sizeof(IMFMediaError)));
        }

        /// <summary>Validates that the <see cref="IMFMediaError" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFMediaError).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFMediaError" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFMediaError), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFMediaError), Is.EqualTo(4));
            }
        }
    }
}
