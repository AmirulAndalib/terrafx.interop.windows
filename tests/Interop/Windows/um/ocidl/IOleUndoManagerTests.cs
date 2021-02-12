// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IOleUndoManager" /> struct.</summary>
    public static unsafe class IOleUndoManagerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IOleUndoManager" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IOleUndoManager).GUID, Is.EqualTo(IID_IOleUndoManager));
        }

        /// <summary>Validates that the <see cref="IOleUndoManager" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IOleUndoManager>(), Is.EqualTo(sizeof(IOleUndoManager)));
        }

        /// <summary>Validates that the <see cref="IOleUndoManager" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IOleUndoManager).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IOleUndoManager" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IOleUndoManager), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IOleUndoManager), Is.EqualTo(4));
            }
        }
    }
}
