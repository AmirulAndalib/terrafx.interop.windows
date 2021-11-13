// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IHTMLAreaElement" /> struct.</summary>
    public static unsafe partial class IHTMLAreaElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLAreaElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IHTMLAreaElement).GUID, Is.EqualTo(IID_IHTMLAreaElement));
        }

        /// <summary>Validates that the <see cref="IHTMLAreaElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IHTMLAreaElement>(), Is.EqualTo(sizeof(IHTMLAreaElement)));
        }

        /// <summary>Validates that the <see cref="IHTMLAreaElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IHTMLAreaElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IHTMLAreaElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IHTMLAreaElement), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IHTMLAreaElement), Is.EqualTo(4));
            }
        }
    }
}
