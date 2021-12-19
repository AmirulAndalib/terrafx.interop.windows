// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DispDOMStorageEvent" /> struct.</summary>
public static unsafe partial class DispDOMStorageEventTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispDOMStorageEvent" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispDOMStorageEvent).GUID, Is.EqualTo(IID_DispDOMStorageEvent));
    }

    /// <summary>Validates that the <see cref="DispDOMStorageEvent" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispDOMStorageEvent>(), Is.EqualTo(sizeof(DispDOMStorageEvent)));
    }

    /// <summary>Validates that the <see cref="DispDOMStorageEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispDOMStorageEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DispDOMStorageEvent" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispDOMStorageEvent), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispDOMStorageEvent), Is.EqualTo(4));
        }
    }
}
