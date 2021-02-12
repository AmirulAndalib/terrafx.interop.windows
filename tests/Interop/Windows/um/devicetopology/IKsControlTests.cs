// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IKsControl" /> struct.</summary>
    public static unsafe class IKsControlTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IKsControl" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IKsControl).GUID, Is.EqualTo(IID_IKsControl));
        }

        /// <summary>Validates that the <see cref="IKsControl" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IKsControl>(), Is.EqualTo(sizeof(IKsControl)));
        }

        /// <summary>Validates that the <see cref="IKsControl" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IKsControl).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IKsControl" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IKsControl), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IKsControl), Is.EqualTo(4));
            }
        }
    }
}
