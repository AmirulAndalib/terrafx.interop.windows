// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISpObjectToken" /> struct.</summary>
    public static unsafe class ISpObjectTokenTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISpObjectToken" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISpObjectToken).GUID, Is.EqualTo(IID_ISpObjectToken));
        }

        /// <summary>Validates that the <see cref="ISpObjectToken" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISpObjectToken>(), Is.EqualTo(sizeof(ISpObjectToken)));
        }

        /// <summary>Validates that the <see cref="ISpObjectToken" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISpObjectToken).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISpObjectToken" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISpObjectToken), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISpObjectToken), Is.EqualTo(4));
            }
        }
    }
}
