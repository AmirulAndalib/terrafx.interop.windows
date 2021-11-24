// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ITfCompartment" /> struct.</summary>
public static unsafe partial class ITfCompartmentTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITfCompartment" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfCompartment).GUID, Is.EqualTo(IID_ITfCompartment));
    }

    /// <summary>Validates that the <see cref="ITfCompartment" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfCompartment>(), Is.EqualTo(sizeof(ITfCompartment)));
    }

    /// <summary>Validates that the <see cref="ITfCompartment" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfCompartment).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ITfCompartment" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfCompartment), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfCompartment), Is.EqualTo(4));
        }
    }
}
