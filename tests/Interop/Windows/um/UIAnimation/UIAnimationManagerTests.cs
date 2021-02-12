// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="UIAnimationManager" /> struct.</summary>
    public static unsafe class UIAnimationManagerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="UIAnimationManager" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(UIAnimationManager).GUID, Is.EqualTo(CLSID_UIAnimationManager));
        }

        /// <summary>Validates that the <see cref="UIAnimationManager" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<UIAnimationManager>(), Is.EqualTo(sizeof(UIAnimationManager)));
        }

        /// <summary>Validates that the <see cref="UIAnimationManager" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(UIAnimationManager).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="UIAnimationManager" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(UIAnimationManager), Is.EqualTo(1));
        }
    }
}
