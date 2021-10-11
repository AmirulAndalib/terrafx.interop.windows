// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITfFnGetLinguisticAlternates" /> struct.</summary>
    public static unsafe partial class ITfFnGetLinguisticAlternatesTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITfFnGetLinguisticAlternates" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITfFnGetLinguisticAlternates).GUID, Is.EqualTo(IID_ITfFnGetLinguisticAlternates));
        }

        /// <summary>Validates that the <see cref="ITfFnGetLinguisticAlternates" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITfFnGetLinguisticAlternates>(), Is.EqualTo(sizeof(ITfFnGetLinguisticAlternates)));
        }

        /// <summary>Validates that the <see cref="ITfFnGetLinguisticAlternates" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITfFnGetLinguisticAlternates).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITfFnGetLinguisticAlternates" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITfFnGetLinguisticAlternates), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITfFnGetLinguisticAlternates), Is.EqualTo(4));
            }
        }
    }
}
