// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IFillLockBytes" /> struct.</summary>
    public static unsafe class IFillLockBytesTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IFillLockBytes" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IFillLockBytes).GUID, Is.EqualTo(IID_IFillLockBytes));
        }

        /// <summary>Validates that the <see cref="IFillLockBytes" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IFillLockBytes>(), Is.EqualTo(sizeof(IFillLockBytes)));
        }

        /// <summary>Validates that the <see cref="IFillLockBytes" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IFillLockBytes).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IFillLockBytes" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IFillLockBytes), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IFillLockBytes), Is.EqualTo(4));
            }
        }
    }
}
