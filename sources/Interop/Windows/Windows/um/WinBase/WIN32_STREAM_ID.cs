// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WIN32_STREAM_ID.xml' path='doc/member[@name="WIN32_STREAM_ID"]/*' />
public unsafe partial struct WIN32_STREAM_ID
{
    /// <include file='WIN32_STREAM_ID.xml' path='doc/member[@name="WIN32_STREAM_ID.dwStreamId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStreamId;

    /// <include file='WIN32_STREAM_ID.xml' path='doc/member[@name="WIN32_STREAM_ID.dwStreamAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStreamAttributes;

    /// <include file='WIN32_STREAM_ID.xml' path='doc/member[@name="WIN32_STREAM_ID.Size"]/*' />
    public LARGE_INTEGER Size;

    /// <include file='WIN32_STREAM_ID.xml' path='doc/member[@name="WIN32_STREAM_ID.dwStreamNameSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStreamNameSize;

    /// <include file='WIN32_STREAM_ID.xml' path='doc/member[@name="WIN32_STREAM_ID.cStreamName"]/*' />
    [NativeTypeName("WCHAR [1]")]
    public fixed ushort cStreamName[1];
}
