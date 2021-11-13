// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IHTMLChangeLog" /> struct.</summary>
    public static unsafe partial class IHTMLChangeLogTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHTMLChangeLog" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IHTMLChangeLog).GUID, Is.EqualTo(IID_IHTMLChangeLog));
        }

        /// <summary>Validates that the <see cref="IHTMLChangeLog" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IHTMLChangeLog>(), Is.EqualTo(sizeof(IHTMLChangeLog)));
        }

        /// <summary>Validates that the <see cref="IHTMLChangeLog" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IHTMLChangeLog).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IHTMLChangeLog" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IHTMLChangeLog), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IHTMLChangeLog), Is.EqualTo(4));
            }
        }
    }
}
