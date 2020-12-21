// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IUIAnimationPriorityComparison" /> struct.</summary>
    public static unsafe class IUIAnimationPriorityComparisonTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IUIAnimationPriorityComparison" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IUIAnimationPriorityComparison).GUID, Is.EqualTo(IID_IUIAnimationPriorityComparison));
        }

        /// <summary>Validates that the <see cref="IUIAnimationPriorityComparison" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IUIAnimationPriorityComparison>(), Is.EqualTo(sizeof(IUIAnimationPriorityComparison)));
        }

        /// <summary>Validates that the <see cref="IUIAnimationPriorityComparison" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IUIAnimationPriorityComparison).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IUIAnimationPriorityComparison" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IUIAnimationPriorityComparison), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IUIAnimationPriorityComparison), Is.EqualTo(4));
            }
        }
    }
}
