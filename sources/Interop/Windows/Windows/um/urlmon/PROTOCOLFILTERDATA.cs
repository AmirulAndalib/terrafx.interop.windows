// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PROTOCOLFILTERDATA.xml' path='doc/member[@name="PROTOCOLFILTERDATA"]/*' />
public unsafe partial struct PROTOCOLFILTERDATA
{
    /// <include file='PROTOCOLFILTERDATA.xml' path='doc/member[@name="PROTOCOLFILTERDATA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='PROTOCOLFILTERDATA.xml' path='doc/member[@name="PROTOCOLFILTERDATA.pProtocolSink"]/*' />
    public IInternetProtocolSink* pProtocolSink;

    /// <include file='PROTOCOLFILTERDATA.xml' path='doc/member[@name="PROTOCOLFILTERDATA.pProtocol"]/*' />
    public IInternetProtocol* pProtocol;

    /// <include file='PROTOCOLFILTERDATA.xml' path='doc/member[@name="PROTOCOLFILTERDATA.pUnk"]/*' />
    public IUnknown* pUnk;

    /// <include file='PROTOCOLFILTERDATA.xml' path='doc/member[@name="PROTOCOLFILTERDATA.dwFilterFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFilterFlags;
}
