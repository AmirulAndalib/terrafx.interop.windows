// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="KSDATAFORMAT_SUBTYPE_PCM" /> struct.</summary>
public static unsafe partial class KSDATAFORMAT_SUBTYPE_PCMTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="KSDATAFORMAT_SUBTYPE_PCM" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(KSDATAFORMAT_SUBTYPE_PCM).GUID, Is.EqualTo(IID_KSDATAFORMAT_SUBTYPE_PCM));
    }
}
