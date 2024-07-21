// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ADPCMEWAVEFORMAT.xml' path='doc/member[@name="ADPCMEWAVEFORMAT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ADPCMEWAVEFORMAT
{
    /// <include file='ADPCMEWAVEFORMAT.xml' path='doc/member[@name="ADPCMEWAVEFORMAT.wfx"]/*' />
    public WAVEFORMATEX wfx;

    /// <include file='ADPCMEWAVEFORMAT.xml' path='doc/member[@name="ADPCMEWAVEFORMAT.wSamplesPerBlock"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSamplesPerBlock;
}
