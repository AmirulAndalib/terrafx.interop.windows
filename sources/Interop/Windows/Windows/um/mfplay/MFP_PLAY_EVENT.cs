// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MFP_PLAY_EVENT.xml' path='doc/member[@name="MFP_PLAY_EVENT"]/*' />
public unsafe partial struct MFP_PLAY_EVENT
{
    /// <include file='MFP_PLAY_EVENT.xml' path='doc/member[@name="MFP_PLAY_EVENT.header"]/*' />
    public MFP_EVENT_HEADER header;

    /// <include file='MFP_PLAY_EVENT.xml' path='doc/member[@name="MFP_PLAY_EVENT.pMediaItem"]/*' />
    public IMFPMediaItem* pMediaItem;
}
