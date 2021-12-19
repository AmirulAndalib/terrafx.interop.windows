// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="NONCLIENTMETRICSA" /> struct.</summary>
public static unsafe partial class NONCLIENTMETRICSATests
{
    /// <summary>Validates that the <see cref="NONCLIENTMETRICSA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NONCLIENTMETRICSA>(), Is.EqualTo(sizeof(NONCLIENTMETRICSA)));
    }

    /// <summary>Validates that the <see cref="NONCLIENTMETRICSA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NONCLIENTMETRICSA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="NONCLIENTMETRICSA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NONCLIENTMETRICSA), Is.EqualTo(344));
    }
}
