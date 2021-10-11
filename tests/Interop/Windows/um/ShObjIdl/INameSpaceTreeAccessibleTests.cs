// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="INameSpaceTreeAccessible" /> struct.</summary>
    public static unsafe partial class INameSpaceTreeAccessibleTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="INameSpaceTreeAccessible" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(INameSpaceTreeAccessible).GUID, Is.EqualTo(IID_INameSpaceTreeAccessible));
        }

        /// <summary>Validates that the <see cref="INameSpaceTreeAccessible" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<INameSpaceTreeAccessible>(), Is.EqualTo(sizeof(INameSpaceTreeAccessible)));
        }

        /// <summary>Validates that the <see cref="INameSpaceTreeAccessible" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(INameSpaceTreeAccessible).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="INameSpaceTreeAccessible" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(INameSpaceTreeAccessible), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(INameSpaceTreeAccessible), Is.EqualTo(4));
            }
        }
    }
}
