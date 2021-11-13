// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IHTMLMimeTypesCollection" /> struct.</summary>
    public static unsafe partial class IHTMLMimeTypesCollectionTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLMimeTypesCollection" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IHTMLMimeTypesCollection).GUID, Is.EqualTo(IID_IHTMLMimeTypesCollection));
        }

        /// <summary>Validates that the <see cref="IHTMLMimeTypesCollection" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IHTMLMimeTypesCollection>(), Is.EqualTo(sizeof(IHTMLMimeTypesCollection)));
        }

        /// <summary>Validates that the <see cref="IHTMLMimeTypesCollection" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IHTMLMimeTypesCollection).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IHTMLMimeTypesCollection" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IHTMLMimeTypesCollection), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IHTMLMimeTypesCollection), Is.EqualTo(4));
            }
        }
    }
}
