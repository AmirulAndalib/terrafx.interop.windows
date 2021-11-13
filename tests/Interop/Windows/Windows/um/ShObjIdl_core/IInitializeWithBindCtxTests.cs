// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IInitializeWithBindCtx" /> struct.</summary>
    public static unsafe partial class IInitializeWithBindCtxTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IInitializeWithBindCtx" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IInitializeWithBindCtx).GUID, Is.EqualTo(IID_IInitializeWithBindCtx));
        }

        /// <summary>Validates that the <see cref="IInitializeWithBindCtx" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IInitializeWithBindCtx>(), Is.EqualTo(sizeof(IInitializeWithBindCtx)));
        }

        /// <summary>Validates that the <see cref="IInitializeWithBindCtx" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IInitializeWithBindCtx).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IInitializeWithBindCtx" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IInitializeWithBindCtx), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IInitializeWithBindCtx), Is.EqualTo(4));
            }
        }
    }
}
