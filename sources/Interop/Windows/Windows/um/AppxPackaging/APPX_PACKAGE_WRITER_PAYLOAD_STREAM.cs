// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='APPX_PACKAGE_WRITER_PAYLOAD_STREAM.xml' path='doc/member[@name="APPX_PACKAGE_WRITER_PAYLOAD_STREAM"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct APPX_PACKAGE_WRITER_PAYLOAD_STREAM
{
    /// <include file='APPX_PACKAGE_WRITER_PAYLOAD_STREAM.xml' path='doc/member[@name="APPX_PACKAGE_WRITER_PAYLOAD_STREAM.inputStream"]/*' />
    public IStream* inputStream;

    /// <include file='APPX_PACKAGE_WRITER_PAYLOAD_STREAM.xml' path='doc/member[@name="APPX_PACKAGE_WRITER_PAYLOAD_STREAM.fileName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* fileName;

    /// <include file='APPX_PACKAGE_WRITER_PAYLOAD_STREAM.xml' path='doc/member[@name="APPX_PACKAGE_WRITER_PAYLOAD_STREAM.contentType"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* contentType;

    /// <include file='APPX_PACKAGE_WRITER_PAYLOAD_STREAM.xml' path='doc/member[@name="APPX_PACKAGE_WRITER_PAYLOAD_STREAM.compressionOption"]/*' />
    public APPX_COMPRESSION_OPTION compressionOption;
}
