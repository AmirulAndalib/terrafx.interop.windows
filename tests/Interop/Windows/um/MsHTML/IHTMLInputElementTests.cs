// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IHTMLInputElement" /> struct.</summary>
    public static unsafe partial class IHTMLInputElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLInputElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IHTMLInputElement).GUID, Is.EqualTo(IID_IHTMLInputElement));
        }

        /// <summary>Validates that the <see cref="IHTMLInputElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IHTMLInputElement>(), Is.EqualTo(sizeof(IHTMLInputElement)));
        }

        /// <summary>Validates that the <see cref="IHTMLInputElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IHTMLInputElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IHTMLInputElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IHTMLInputElement), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IHTMLInputElement), Is.EqualTo(4));
            }
        }
    }
}
