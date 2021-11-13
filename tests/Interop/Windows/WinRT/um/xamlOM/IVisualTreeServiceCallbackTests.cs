// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.WinRT.WinRT;

namespace TerraFX.Interop.WinRT.UnitTests
{
    /// <summary>Provides validation of the <see cref="IVisualTreeServiceCallback" /> struct.</summary>
    [SupportedOSPlatform("windows10.0")]
    public static unsafe partial class IVisualTreeServiceCallbackTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IVisualTreeServiceCallback" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IVisualTreeServiceCallback).GUID, Is.EqualTo(IID_IVisualTreeServiceCallback));
        }

        /// <summary>Validates that the <see cref="IVisualTreeServiceCallback" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IVisualTreeServiceCallback>(), Is.EqualTo(sizeof(IVisualTreeServiceCallback)));
        }

        /// <summary>Validates that the <see cref="IVisualTreeServiceCallback" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IVisualTreeServiceCallback).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IVisualTreeServiceCallback" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IVisualTreeServiceCallback), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IVisualTreeServiceCallback), Is.EqualTo(4));
            }
        }
    }
}
