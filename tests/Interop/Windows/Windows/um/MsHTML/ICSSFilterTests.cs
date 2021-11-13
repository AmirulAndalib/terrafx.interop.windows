// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICSSFilter" /> struct.</summary>
    public static unsafe partial class ICSSFilterTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICSSFilter" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ICSSFilter).GUID, Is.EqualTo(IID_ICSSFilter));
        }

        /// <summary>Validates that the <see cref="ICSSFilter" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICSSFilter>(), Is.EqualTo(sizeof(ICSSFilter)));
        }

        /// <summary>Validates that the <see cref="ICSSFilter" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICSSFilter).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICSSFilter" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICSSFilter), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ICSSFilter), Is.EqualTo(4));
            }
        }
    }
}
