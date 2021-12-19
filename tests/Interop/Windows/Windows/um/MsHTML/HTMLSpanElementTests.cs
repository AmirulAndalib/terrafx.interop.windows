// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="HTMLSpanElement" /> struct.</summary>
public static unsafe partial class HTMLSpanElementTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="HTMLSpanElement" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLSpanElement).GUID, Is.EqualTo(IID_HTMLSpanElement));
    }

    /// <summary>Validates that the <see cref="HTMLSpanElement" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLSpanElement>(), Is.EqualTo(sizeof(HTMLSpanElement)));
    }

    /// <summary>Validates that the <see cref="HTMLSpanElement" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLSpanElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="HTMLSpanElement" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLSpanElement), Is.EqualTo(1));
    }
}
