// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MFT_STREAM_STATE_PARAM.xml' path='doc/member[@name="MFT_STREAM_STATE_PARAM"]/*' />
public partial struct MFT_STREAM_STATE_PARAM
{
    /// <include file='MFT_STREAM_STATE_PARAM.xml' path='doc/member[@name="MFT_STREAM_STATE_PARAM.StreamId"]/*' />
    [NativeTypeName("DWORD")]
    public uint StreamId;

    /// <include file='MFT_STREAM_STATE_PARAM.xml' path='doc/member[@name="MFT_STREAM_STATE_PARAM.State"]/*' />
    public MF_STREAM_STATE State;
}
