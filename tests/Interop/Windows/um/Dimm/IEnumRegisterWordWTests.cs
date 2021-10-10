// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IEnumRegisterWordW" /> struct.</summary>
    public static unsafe class IEnumRegisterWordWTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumRegisterWordW" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IEnumRegisterWordW).GUID, Is.EqualTo(IID_IEnumRegisterWordW));
        }

        /// <summary>Validates that the <see cref="IEnumRegisterWordW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IEnumRegisterWordW>(), Is.EqualTo(sizeof(IEnumRegisterWordW)));
        }

        /// <summary>Validates that the <see cref="IEnumRegisterWordW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IEnumRegisterWordW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IEnumRegisterWordW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IEnumRegisterWordW), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IEnumRegisterWordW), Is.EqualTo(4));
            }
        }
    }
}
