// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IPersistFolder" /> struct.</summary>
    public static unsafe class IPersistFolderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPersistFolder" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IPersistFolder).GUID, Is.EqualTo(IID_IPersistFolder));
        }

        /// <summary>Validates that the <see cref="IPersistFolder" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IPersistFolder>(), Is.EqualTo(sizeof(IPersistFolder)));
        }

        /// <summary>Validates that the <see cref="IPersistFolder" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IPersistFolder).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IPersistFolder" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IPersistFolder), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IPersistFolder), Is.EqualTo(4));
            }
        }
    }
}
