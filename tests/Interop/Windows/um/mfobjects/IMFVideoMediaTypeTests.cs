// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFVideoMediaType" /> struct.</summary>
    public static unsafe class IMFVideoMediaTypeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFVideoMediaType" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFVideoMediaType).GUID, Is.EqualTo(IID_IMFVideoMediaType));
        }

        /// <summary>Validates that the <see cref="IMFVideoMediaType" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFVideoMediaType>(), Is.EqualTo(sizeof(IMFVideoMediaType)));
        }

        /// <summary>Validates that the <see cref="IMFVideoMediaType" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFVideoMediaType).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFVideoMediaType" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFVideoMediaType), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFVideoMediaType), Is.EqualTo(4));
            }
        }
    }
}
