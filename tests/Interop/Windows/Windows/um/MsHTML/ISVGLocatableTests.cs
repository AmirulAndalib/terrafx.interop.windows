// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISVGLocatable" /> struct.</summary>
    public static unsafe partial class ISVGLocatableTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISVGLocatable" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISVGLocatable).GUID, Is.EqualTo(IID_ISVGLocatable));
        }

        /// <summary>Validates that the <see cref="ISVGLocatable" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISVGLocatable>(), Is.EqualTo(sizeof(ISVGLocatable)));
        }

        /// <summary>Validates that the <see cref="ISVGLocatable" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISVGLocatable).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISVGLocatable" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISVGLocatable), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISVGLocatable), Is.EqualTo(4));
            }
        }
    }
}
