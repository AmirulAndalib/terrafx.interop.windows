// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="HTMLFrameSetSite" /> struct.</summary>
public static unsafe partial class HTMLFrameSetSiteTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="HTMLFrameSetSite" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLFrameSetSite).GUID, Is.EqualTo(IID_HTMLFrameSetSite));
    }

    /// <summary>Validates that the <see cref="HTMLFrameSetSite" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLFrameSetSite>(), Is.EqualTo(sizeof(HTMLFrameSetSite)));
    }

    /// <summary>Validates that the <see cref="HTMLFrameSetSite" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLFrameSetSite).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="HTMLFrameSetSite" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLFrameSetSite), Is.EqualTo(1));
    }
}
