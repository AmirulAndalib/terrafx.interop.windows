// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IXMLDOMElement" /> struct.</summary>
    public static unsafe class IXMLDOMElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IXMLDOMElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IXMLDOMElement).GUID, Is.EqualTo(IID_IXMLDOMElement));
        }

        /// <summary>Validates that the <see cref="IXMLDOMElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IXMLDOMElement>(), Is.EqualTo(sizeof(IXMLDOMElement)));
        }

        /// <summary>Validates that the <see cref="IXMLDOMElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IXMLDOMElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IXMLDOMElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IXMLDOMElement), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IXMLDOMElement), Is.EqualTo(4));
            }
        }
    }
}
