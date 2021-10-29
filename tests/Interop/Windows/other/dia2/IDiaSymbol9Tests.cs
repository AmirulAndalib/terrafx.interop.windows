// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDiaSymbol9" /> struct.</summary>
    public static unsafe partial class IDiaSymbol9Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDiaSymbol9" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDiaSymbol9).GUID, Is.EqualTo(IID_IDiaSymbol9));
        }

        /// <summary>Validates that the <see cref="IDiaSymbol9" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDiaSymbol9>(), Is.EqualTo(sizeof(IDiaSymbol9)));
        }

        /// <summary>Validates that the <see cref="IDiaSymbol9" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDiaSymbol9).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDiaSymbol9" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDiaSymbol9), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDiaSymbol9), Is.EqualTo(4));
            }
        }
    }
}
