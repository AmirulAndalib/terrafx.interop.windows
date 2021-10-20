// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IContactCollection" /> struct.</summary>
    public static unsafe partial class IContactCollectionTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IContactCollection" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IContactCollection).GUID, Is.EqualTo(IID_IContactCollection));
        }

        /// <summary>Validates that the <see cref="IContactCollection" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IContactCollection>(), Is.EqualTo(sizeof(IContactCollection)));
        }

        /// <summary>Validates that the <see cref="IContactCollection" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IContactCollection).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IContactCollection" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IContactCollection), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IContactCollection), Is.EqualTo(4));
            }
        }
    }
}