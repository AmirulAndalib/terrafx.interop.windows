// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SE_ADT_ACCESS_REASON" /> struct.</summary>
public static unsafe partial class SE_ADT_ACCESS_REASONTests
{
    /// <summary>Validates that the <see cref="SE_ADT_ACCESS_REASON" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SE_ADT_ACCESS_REASON>(), Is.EqualTo(sizeof(SE_ADT_ACCESS_REASON)));
    }

    /// <summary>Validates that the <see cref="SE_ADT_ACCESS_REASON" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SE_ADT_ACCESS_REASON).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SE_ADT_ACCESS_REASON" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SE_ADT_ACCESS_REASON), Is.EqualTo(152));
        }
        else
        {
            Assert.That(sizeof(SE_ADT_ACCESS_REASON), Is.EqualTo(144));
        }
    }
}
