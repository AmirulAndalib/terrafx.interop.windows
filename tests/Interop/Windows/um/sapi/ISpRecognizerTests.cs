// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISpRecognizer" /> struct.</summary>
    public static unsafe class ISpRecognizerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISpRecognizer" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISpRecognizer).GUID, Is.EqualTo(IID_ISpRecognizer));
        }

        /// <summary>Validates that the <see cref="ISpRecognizer" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISpRecognizer>(), Is.EqualTo(sizeof(ISpRecognizer)));
        }

        /// <summary>Validates that the <see cref="ISpRecognizer" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISpRecognizer).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISpRecognizer" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISpRecognizer), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISpRecognizer), Is.EqualTo(4));
            }
        }
    }
}
