// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="COMPOSITION_TARGET_ID" /> struct.</summary>
public static unsafe partial class COMPOSITION_TARGET_IDTests
{
    /// <summary>Validates that the <see cref="COMPOSITION_TARGET_ID" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COMPOSITION_TARGET_ID>(), Is.EqualTo(sizeof(COMPOSITION_TARGET_ID)));
    }

    /// <summary>Validates that the <see cref="COMPOSITION_TARGET_ID" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COMPOSITION_TARGET_ID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="COMPOSITION_TARGET_ID" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(COMPOSITION_TARGET_ID), Is.EqualTo(28));
    }
}
