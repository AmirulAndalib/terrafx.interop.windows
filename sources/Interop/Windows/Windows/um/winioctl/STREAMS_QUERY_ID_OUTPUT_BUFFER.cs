// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STREAMS_QUERY_ID_OUTPUT_BUFFER.xml' path='doc/member[@name="STREAMS_QUERY_ID_OUTPUT_BUFFER"]/*' />
public partial struct STREAMS_QUERY_ID_OUTPUT_BUFFER
{
    /// <include file='STREAMS_QUERY_ID_OUTPUT_BUFFER.xml' path='doc/member[@name="STREAMS_QUERY_ID_OUTPUT_BUFFER.StreamId"]/*' />
    [NativeTypeName("DWORD")]
    public uint StreamId;
}
