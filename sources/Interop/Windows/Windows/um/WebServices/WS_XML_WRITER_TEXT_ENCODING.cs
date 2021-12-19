// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_XML_WRITER_TEXT_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_TEXT_ENCODING"]/*' />
public partial struct WS_XML_WRITER_TEXT_ENCODING
{
    /// <include file='WS_XML_WRITER_TEXT_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_TEXT_ENCODING.encoding"]/*' />
    public WS_XML_WRITER_ENCODING encoding;

    /// <include file='WS_XML_WRITER_TEXT_ENCODING.xml' path='doc/member[@name="WS_XML_WRITER_TEXT_ENCODING.charSet"]/*' />
    public WS_CHARSET charSet;
}
