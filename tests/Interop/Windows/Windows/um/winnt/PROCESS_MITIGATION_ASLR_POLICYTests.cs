// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PROCESS_MITIGATION_ASLR_POLICY" /> struct.</summary>
[SupportedOSPlatform("windows8.0")]
public static unsafe partial class PROCESS_MITIGATION_ASLR_POLICYTests
{
    /// <summary>Validates that the <see cref="PROCESS_MITIGATION_ASLR_POLICY" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROCESS_MITIGATION_ASLR_POLICY>(), Is.EqualTo(sizeof(PROCESS_MITIGATION_ASLR_POLICY)));
    }

    /// <summary>Validates that the <see cref="PROCESS_MITIGATION_ASLR_POLICY" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROCESS_MITIGATION_ASLR_POLICY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PROCESS_MITIGATION_ASLR_POLICY" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PROCESS_MITIGATION_ASLR_POLICY), Is.EqualTo(4));
    }
}
