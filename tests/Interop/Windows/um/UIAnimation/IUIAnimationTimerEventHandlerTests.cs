// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IUIAnimationTimerEventHandler" /> struct.</summary>
    public static unsafe class IUIAnimationTimerEventHandlerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IUIAnimationTimerEventHandler" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IUIAnimationTimerEventHandler).GUID, Is.EqualTo(IID_IUIAnimationTimerEventHandler));
        }

        /// <summary>Validates that the <see cref="IUIAnimationTimerEventHandler" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IUIAnimationTimerEventHandler>(), Is.EqualTo(sizeof(IUIAnimationTimerEventHandler)));
        }

        /// <summary>Validates that the <see cref="IUIAnimationTimerEventHandler" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IUIAnimationTimerEventHandler).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IUIAnimationTimerEventHandler" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IUIAnimationTimerEventHandler), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IUIAnimationTimerEventHandler), Is.EqualTo(4));
            }
        }
    }
}
