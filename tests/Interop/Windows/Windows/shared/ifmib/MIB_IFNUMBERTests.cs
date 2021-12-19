// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifmib.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MIB_IFNUMBER" /> struct.</summary>
public static unsafe partial class MIB_IFNUMBERTests
{
    /// <summary>Validates that the <see cref="MIB_IFNUMBER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_IFNUMBER>(), Is.EqualTo(sizeof(MIB_IFNUMBER)));
    }

    /// <summary>Validates that the <see cref="MIB_IFNUMBER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_IFNUMBER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MIB_IFNUMBER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIB_IFNUMBER), Is.EqualTo(4));
    }
}
