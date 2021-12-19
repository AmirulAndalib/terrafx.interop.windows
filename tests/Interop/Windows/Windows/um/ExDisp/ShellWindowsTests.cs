// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ShellWindows" /> struct.</summary>
public static unsafe partial class ShellWindowsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ShellWindows" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ShellWindows).GUID, Is.EqualTo(IID_ShellWindows));
    }

    /// <summary>Validates that the <see cref="ShellWindows" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ShellWindows>(), Is.EqualTo(sizeof(ShellWindows)));
    }

    /// <summary>Validates that the <see cref="ShellWindows" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ShellWindows).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ShellWindows" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ShellWindows), Is.EqualTo(1));
    }
}
