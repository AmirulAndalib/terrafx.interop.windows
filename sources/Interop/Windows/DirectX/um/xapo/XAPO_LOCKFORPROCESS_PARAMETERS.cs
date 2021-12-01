// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='XAPO_LOCKFORPROCESS_PARAMETERS.xml' path='doc/member[@name="XAPO_LOCKFORPROCESS_PARAMETERS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAPO_LOCKFORPROCESS_PARAMETERS
{
    /// <include file='XAPO_LOCKFORPROCESS_PARAMETERS.xml' path='doc/member[@name="XAPO_LOCKFORPROCESS_PARAMETERS.pFormat"]/*' />
    [NativeTypeName("const WAVEFORMATEX *")]
    public WAVEFORMATEX* pFormat;

    /// <include file='XAPO_LOCKFORPROCESS_PARAMETERS.xml' path='doc/member[@name="XAPO_LOCKFORPROCESS_PARAMETERS.MaxFrameCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint MaxFrameCount;
}
