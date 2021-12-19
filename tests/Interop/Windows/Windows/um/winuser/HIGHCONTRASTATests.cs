// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="HIGHCONTRASTA" /> struct.</summary>
public static unsafe partial class HIGHCONTRASTATests
{
    /// <summary>Validates that the <see cref="HIGHCONTRASTA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HIGHCONTRASTA>(), Is.EqualTo(sizeof(HIGHCONTRASTA)));
    }

    /// <summary>Validates that the <see cref="HIGHCONTRASTA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HIGHCONTRASTA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="HIGHCONTRASTA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HIGHCONTRASTA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(HIGHCONTRASTA), Is.EqualTo(12));
        }
    }
}
