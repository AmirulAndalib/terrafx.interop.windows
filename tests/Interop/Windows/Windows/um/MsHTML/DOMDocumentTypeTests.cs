// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="DOMDocumentType" /> struct.</summary>
    public static unsafe partial class DOMDocumentTypeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DOMDocumentType" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DOMDocumentType).GUID, Is.EqualTo(IID_DOMDocumentType));
        }

        /// <summary>Validates that the <see cref="DOMDocumentType" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DOMDocumentType>(), Is.EqualTo(sizeof(DOMDocumentType)));
        }

        /// <summary>Validates that the <see cref="DOMDocumentType" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DOMDocumentType).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DOMDocumentType" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DOMDocumentType), Is.EqualTo(1));
        }
    }
}
