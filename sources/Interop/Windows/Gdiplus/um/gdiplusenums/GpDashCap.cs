// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='GpDashCap.xml' path='doc/member[@name="GpDashCap"]/*' />
public enum GpDashCap
{
    /// <include file='GpDashCap.xml' path='doc/member[@name="GpDashCap.DashCapFlat"]/*' />
    DashCapFlat = 0,

    /// <include file='GpDashCap.xml' path='doc/member[@name="GpDashCap.DashCapRound"]/*' />
    DashCapRound = 2,

    /// <include file='GpDashCap.xml' path='doc/member[@name="GpDashCap.DashCapTriangle"]/*' />
    DashCapTriangle = 3,
}