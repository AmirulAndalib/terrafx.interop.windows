// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDocumentRange" /> struct.</summary>
    public static unsafe partial class IDocumentRangeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDocumentRange" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDocumentRange).GUID, Is.EqualTo(IID_IDocumentRange));
        }

        /// <summary>Validates that the <see cref="IDocumentRange" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDocumentRange>(), Is.EqualTo(sizeof(IDocumentRange)));
        }

        /// <summary>Validates that the <see cref="IDocumentRange" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDocumentRange).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDocumentRange" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDocumentRange), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDocumentRange), Is.EqualTo(4));
            }
        }
    }
}
