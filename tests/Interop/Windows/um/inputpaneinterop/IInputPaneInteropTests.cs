// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inputpaneinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IInputPaneInterop" /> struct.</summary>
    public static unsafe class IInputPaneInteropTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IInputPaneInterop" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IInputPaneInterop).GUID, Is.EqualTo(IID_IInputPaneInterop));
        }

        /// <summary>Validates that the <see cref="IInputPaneInterop" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IInputPaneInterop>(), Is.EqualTo(sizeof(IInputPaneInterop)));
        }

        /// <summary>Validates that the <see cref="IInputPaneInterop" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IInputPaneInterop).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IInputPaneInterop" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IInputPaneInterop), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IInputPaneInterop), Is.EqualTo(4));
            }
        }
    }
}
