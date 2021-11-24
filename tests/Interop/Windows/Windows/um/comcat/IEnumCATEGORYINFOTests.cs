// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/comcat.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IEnumCATEGORYINFO" /> struct.</summary>
public static unsafe partial class IEnumCATEGORYINFOTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumCATEGORYINFO" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumCATEGORYINFO).GUID, Is.EqualTo(IID_IEnumCATEGORYINFO));
    }

    /// <summary>Validates that the <see cref="IEnumCATEGORYINFO" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEnumCATEGORYINFO>(), Is.EqualTo(sizeof(IEnumCATEGORYINFO)));
    }

    /// <summary>Validates that the <see cref="IEnumCATEGORYINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEnumCATEGORYINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IEnumCATEGORYINFO" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEnumCATEGORYINFO), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEnumCATEGORYINFO), Is.EqualTo(4));
        }
    }
}
