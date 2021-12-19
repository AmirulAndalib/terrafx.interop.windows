// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFMediaEngineNotify" /> struct.</summary>
[SupportedOSPlatform("windows8.0")]
public static unsafe partial class IMFMediaEngineNotifyTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaEngineNotify" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMediaEngineNotify).GUID, Is.EqualTo(IID_IMFMediaEngineNotify));
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineNotify" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMediaEngineNotify>(), Is.EqualTo(sizeof(IMFMediaEngineNotify)));
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineNotify" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMediaEngineNotify).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineNotify" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMediaEngineNotify), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMediaEngineNotify), Is.EqualTo(4));
        }
    }
}
