// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAMTimecodeReader" /> struct.</summary>
    public static unsafe class IAMTimecodeReaderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAMTimecodeReader" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAMTimecodeReader).GUID, Is.EqualTo(IID_IAMTimecodeReader));
        }

        /// <summary>Validates that the <see cref="IAMTimecodeReader" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAMTimecodeReader>(), Is.EqualTo(sizeof(IAMTimecodeReader)));
        }

        /// <summary>Validates that the <see cref="IAMTimecodeReader" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAMTimecodeReader).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAMTimecodeReader" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAMTimecodeReader), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAMTimecodeReader), Is.EqualTo(4));
            }
        }
    }
}
