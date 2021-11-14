// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IOpenControlPanel" /> struct.</summary>
    public static unsafe partial class IOpenControlPanelTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IOpenControlPanel" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IOpenControlPanel).GUID, Is.EqualTo(IID_IOpenControlPanel));
        }

        /// <summary>Validates that the <see cref="IOpenControlPanel" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IOpenControlPanel>(), Is.EqualTo(sizeof(IOpenControlPanel)));
        }

        /// <summary>Validates that the <see cref="IOpenControlPanel" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IOpenControlPanel).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IOpenControlPanel" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IOpenControlPanel), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IOpenControlPanel), Is.EqualTo(4));
            }
        }
    }
}
