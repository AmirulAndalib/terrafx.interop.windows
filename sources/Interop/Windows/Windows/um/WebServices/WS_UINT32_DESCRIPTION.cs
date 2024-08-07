// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_UINT32_DESCRIPTION.xml' path='doc/member[@name="WS_UINT32_DESCRIPTION"]/*' />
public partial struct WS_UINT32_DESCRIPTION
{
    /// <include file='WS_UINT32_DESCRIPTION.xml' path='doc/member[@name="WS_UINT32_DESCRIPTION.minValue"]/*' />
    [NativeTypeName("ULONG")]
    public uint minValue;

    /// <include file='WS_UINT32_DESCRIPTION.xml' path='doc/member[@name="WS_UINT32_DESCRIPTION.maxValue"]/*' />
    [NativeTypeName("ULONG")]
    public uint maxValue;
}
