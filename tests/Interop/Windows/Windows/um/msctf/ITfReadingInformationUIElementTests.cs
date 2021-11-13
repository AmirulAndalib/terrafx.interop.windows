// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITfReadingInformationUIElement" /> struct.</summary>
    public static unsafe partial class ITfReadingInformationUIElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITfReadingInformationUIElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITfReadingInformationUIElement).GUID, Is.EqualTo(IID_ITfReadingInformationUIElement));
        }

        /// <summary>Validates that the <see cref="ITfReadingInformationUIElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITfReadingInformationUIElement>(), Is.EqualTo(sizeof(ITfReadingInformationUIElement)));
        }

        /// <summary>Validates that the <see cref="ITfReadingInformationUIElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITfReadingInformationUIElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITfReadingInformationUIElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITfReadingInformationUIElement), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITfReadingInformationUIElement), Is.EqualTo(4));
            }
        }
    }
}
