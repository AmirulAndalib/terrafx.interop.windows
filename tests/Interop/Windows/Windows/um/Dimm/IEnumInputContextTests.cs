// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IEnumInputContext" /> struct.</summary>
    public static unsafe partial class IEnumInputContextTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumInputContext" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IEnumInputContext).GUID, Is.EqualTo(IID_IEnumInputContext));
        }

        /// <summary>Validates that the <see cref="IEnumInputContext" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IEnumInputContext>(), Is.EqualTo(sizeof(IEnumInputContext)));
        }

        /// <summary>Validates that the <see cref="IEnumInputContext" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IEnumInputContext).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IEnumInputContext" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IEnumInputContext), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IEnumInputContext), Is.EqualTo(4));
            }
        }
    }
}
