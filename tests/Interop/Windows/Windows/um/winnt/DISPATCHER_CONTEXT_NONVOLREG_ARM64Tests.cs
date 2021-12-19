// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DISPATCHER_CONTEXT_NONVOLREG_ARM64" /> struct.</summary>
public static unsafe partial class DISPATCHER_CONTEXT_NONVOLREG_ARM64Tests
{
    /// <summary>Validates that the <see cref="DISPATCHER_CONTEXT_NONVOLREG_ARM64" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISPATCHER_CONTEXT_NONVOLREG_ARM64>(), Is.EqualTo(sizeof(DISPATCHER_CONTEXT_NONVOLREG_ARM64)));
    }

    /// <summary>Validates that the <see cref="DISPATCHER_CONTEXT_NONVOLREG_ARM64" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(DISPATCHER_CONTEXT_NONVOLREG_ARM64).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref="DISPATCHER_CONTEXT_NONVOLREG_ARM64" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISPATCHER_CONTEXT_NONVOLREG_ARM64), Is.EqualTo(152));
    }
}
