// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="LMR_QUERY_SESSION_INFO" /> struct.</summary>
public static unsafe partial class LMR_QUERY_SESSION_INFOTests
{
    /// <summary>Validates that the <see cref="LMR_QUERY_SESSION_INFO" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LMR_QUERY_SESSION_INFO>(), Is.EqualTo(sizeof(LMR_QUERY_SESSION_INFO)));
    }

    /// <summary>Validates that the <see cref="LMR_QUERY_SESSION_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LMR_QUERY_SESSION_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="LMR_QUERY_SESSION_INFO" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(LMR_QUERY_SESSION_INFO), Is.EqualTo(8));
    }
}