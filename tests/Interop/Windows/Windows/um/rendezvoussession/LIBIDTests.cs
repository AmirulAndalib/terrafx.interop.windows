// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.LIBID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="LIBID" /> class.</summary>
public static partial class LIBIDTests
{
    /// <summary>Validates that the value of the <see cref="LIBID_RendezvousSessionLib" /> property is correct.</summary>
    [Test]
    public static void LIBID_RendezvousSessionLibTest()
    {
        Assert.That(LIBID_RendezvousSessionLib, Is.EqualTo(new Guid(0xEFD856A4, 0x5A85, 0x4A1B, 0xAD, 0xD5, 0x2E, 0xAD, 0xAC, 0xE6, 0xF6, 0xA2)));
    }
}
