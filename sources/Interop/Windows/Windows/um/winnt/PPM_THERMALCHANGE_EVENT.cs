// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PPM_THERMALCHANGE_EVENT.xml' path='doc/member[@name="PPM_THERMALCHANGE_EVENT"]/*' />
public partial struct PPM_THERMALCHANGE_EVENT
{
    /// <include file='PPM_THERMALCHANGE_EVENT.xml' path='doc/member[@name="PPM_THERMALCHANGE_EVENT.ThermalConstraint"]/*' />
    [NativeTypeName("DWORD")]
    public uint ThermalConstraint;

    /// <include file='PPM_THERMALCHANGE_EVENT.xml' path='doc/member[@name="PPM_THERMALCHANGE_EVENT.Processors"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Processors;
}
