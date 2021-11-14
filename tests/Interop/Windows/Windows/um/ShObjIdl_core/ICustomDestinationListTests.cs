// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICustomDestinationList" /> struct.</summary>
    public static unsafe partial class ICustomDestinationListTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICustomDestinationList" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ICustomDestinationList).GUID, Is.EqualTo(IID_ICustomDestinationList));
        }

        /// <summary>Validates that the <see cref="ICustomDestinationList" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICustomDestinationList>(), Is.EqualTo(sizeof(ICustomDestinationList)));
        }

        /// <summary>Validates that the <see cref="ICustomDestinationList" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICustomDestinationList).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICustomDestinationList" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICustomDestinationList), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ICustomDestinationList), Is.EqualTo(4));
            }
        }
    }
}
