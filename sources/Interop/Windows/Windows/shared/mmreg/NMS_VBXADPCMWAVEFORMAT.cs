// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='NMS_VBXADPCMWAVEFORMAT.xml' path='doc/member[@name="NMS_VBXADPCMWAVEFORMAT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NMS_VBXADPCMWAVEFORMAT
{
    /// <include file='NMS_VBXADPCMWAVEFORMAT.xml' path='doc/member[@name="NMS_VBXADPCMWAVEFORMAT.wfx"]/*' />
    public WAVEFORMATEX wfx;

    /// <include file='NMS_VBXADPCMWAVEFORMAT.xml' path='doc/member[@name="NMS_VBXADPCMWAVEFORMAT.wSamplesPerBlock"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSamplesPerBlock;
}
