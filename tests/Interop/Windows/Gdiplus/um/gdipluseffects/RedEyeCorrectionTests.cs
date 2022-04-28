// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus.UnitTests;

/// <summary>Provides validation of the <see cref="RedEyeCorrection" /> struct.</summary>
public static unsafe partial class RedEyeCorrectionTests
{
    /// <summary>Validates that the <see cref="RedEyeCorrection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RedEyeCorrection>(), Is.EqualTo(sizeof(RedEyeCorrection)));
    }

    /// <summary>Validates that the <see cref="RedEyeCorrection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RedEyeCorrection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RedEyeCorrection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RedEyeCorrection), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(RedEyeCorrection), Is.EqualTo(20));
        }
    }
}