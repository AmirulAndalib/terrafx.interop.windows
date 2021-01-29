// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITfInputScope" /> struct.</summary>
    public static unsafe class ITfInputScopeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITfInputScope" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITfInputScope).GUID, Is.EqualTo(IID_ITfInputScope));
        }

        /// <summary>Validates that the <see cref="ITfInputScope" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITfInputScope>(), Is.EqualTo(sizeof(ITfInputScope)));
        }

        /// <summary>Validates that the <see cref="ITfInputScope" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITfInputScope).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITfInputScope" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITfInputScope), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITfInputScope), Is.EqualTo(4));
            }
        }
    }
}
