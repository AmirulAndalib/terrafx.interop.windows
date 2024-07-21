// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='EMRSELECTPALETTE.xml' path='doc/member[@name="EMRSELECTPALETTE"]/*' />
public partial struct EMRSELECTPALETTE
{
    /// <include file='EMRSELECTPALETTE.xml' path='doc/member[@name="EMRSELECTPALETTE.emr"]/*' />
    public EMR emr;

    /// <include file='EMRSELECTPALETTE.xml' path='doc/member[@name="EMRSELECTPALETTE.ihPal"]/*' />
    [NativeTypeName("DWORD")]
    public uint ihPal;
}
