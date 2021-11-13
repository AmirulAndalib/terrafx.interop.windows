// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests
{
    /// <summary>Provides validation of the <see cref="IRoSimpleMetaDataBuilder" /> struct.</summary>
    public static unsafe partial class IRoSimpleMetaDataBuilderTests
    {
        /// <summary>Validates that the <see cref="IRoSimpleMetaDataBuilder" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IRoSimpleMetaDataBuilder>(), Is.EqualTo(sizeof(IRoSimpleMetaDataBuilder)));
        }

        /// <summary>Validates that the <see cref="IRoSimpleMetaDataBuilder" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IRoSimpleMetaDataBuilder).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IRoSimpleMetaDataBuilder" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IRoSimpleMetaDataBuilder), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IRoSimpleMetaDataBuilder), Is.EqualTo(4));
            }
        }
    }
}
