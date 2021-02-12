// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITextStoreACPServices" /> struct.</summary>
    public static unsafe class ITextStoreACPServicesTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITextStoreACPServices" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITextStoreACPServices).GUID, Is.EqualTo(IID_ITextStoreACPServices));
        }

        /// <summary>Validates that the <see cref="ITextStoreACPServices" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITextStoreACPServices>(), Is.EqualTo(sizeof(ITextStoreACPServices)));
        }

        /// <summary>Validates that the <see cref="ITextStoreACPServices" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITextStoreACPServices).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITextStoreACPServices" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITextStoreACPServices), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITextStoreACPServices), Is.EqualTo(4));
            }
        }
    }
}
