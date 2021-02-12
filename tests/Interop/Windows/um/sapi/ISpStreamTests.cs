// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISpStream" /> struct.</summary>
    public static unsafe class ISpStreamTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISpStream" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISpStream).GUID, Is.EqualTo(IID_ISpStream));
        }

        /// <summary>Validates that the <see cref="ISpStream" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISpStream>(), Is.EqualTo(sizeof(ISpStream)));
        }

        /// <summary>Validates that the <see cref="ISpStream" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISpStream).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISpStream" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISpStream), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISpStream), Is.EqualTo(4));
            }
        }
    }
}
