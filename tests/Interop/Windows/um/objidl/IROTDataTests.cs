// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IROTData" /> struct.</summary>
    public static unsafe class IROTDataTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IROTData" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IROTData).GUID, Is.EqualTo(IID_IROTData));
        }

        /// <summary>Validates that the <see cref="IROTData" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IROTData>(), Is.EqualTo(sizeof(IROTData)));
        }

        /// <summary>Validates that the <see cref="IROTData" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IROTData).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IROTData" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IROTData), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IROTData), Is.EqualTo(4));
            }
        }
    }
}
