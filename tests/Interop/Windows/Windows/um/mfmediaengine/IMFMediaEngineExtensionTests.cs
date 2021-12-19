// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFMediaEngineExtension" /> struct.</summary>
[SupportedOSPlatform("windows8.0")]
public static unsafe partial class IMFMediaEngineExtensionTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaEngineExtension" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMediaEngineExtension).GUID, Is.EqualTo(IID_IMFMediaEngineExtension));
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineExtension" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMediaEngineExtension>(), Is.EqualTo(sizeof(IMFMediaEngineExtension)));
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineExtension" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMediaEngineExtension).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineExtension" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMediaEngineExtension), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMediaEngineExtension), Is.EqualTo(4));
        }
    }
}
