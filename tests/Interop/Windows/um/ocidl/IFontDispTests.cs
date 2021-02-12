// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IFontDisp" /> struct.</summary>
    public static unsafe class IFontDispTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IFontDisp" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IFontDisp).GUID, Is.EqualTo(IID_IFontDisp));
        }

        /// <summary>Validates that the <see cref="IFontDisp" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IFontDisp>(), Is.EqualTo(sizeof(IFontDisp)));
        }

        /// <summary>Validates that the <see cref="IFontDisp" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IFontDisp).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IFontDisp" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IFontDisp), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IFontDisp), Is.EqualTo(4));
            }
        }
    }
}
