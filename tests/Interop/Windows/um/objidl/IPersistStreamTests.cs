// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IPersistStream" /> struct.</summary>
    public static unsafe class IPersistStreamTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPersistStream" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IPersistStream).GUID, Is.EqualTo(IID_IPersistStream));
        }

        /// <summary>Validates that the <see cref="IPersistStream" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IPersistStream>(), Is.EqualTo(sizeof(IPersistStream)));
        }

        /// <summary>Validates that the <see cref="IPersistStream" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IPersistStream).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IPersistStream" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IPersistStream), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IPersistStream), Is.EqualTo(4));
            }
        }
    }
}
