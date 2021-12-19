// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MIB_TCP6ROW" /> struct.</summary>
public static unsafe partial class MIB_TCP6ROWTests
{
    /// <summary>Validates that the <see cref="MIB_TCP6ROW" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_TCP6ROW>(), Is.EqualTo(sizeof(MIB_TCP6ROW)));
    }

    /// <summary>Validates that the <see cref="MIB_TCP6ROW" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_TCP6ROW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MIB_TCP6ROW" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIB_TCP6ROW), Is.EqualTo(52));
    }
}
