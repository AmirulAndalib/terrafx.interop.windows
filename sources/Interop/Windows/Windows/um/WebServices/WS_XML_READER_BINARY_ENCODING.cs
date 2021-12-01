// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_XML_READER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_READER_BINARY_ENCODING"]/*' />
public unsafe partial struct WS_XML_READER_BINARY_ENCODING
{
    /// <include file='WS_XML_READER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_READER_BINARY_ENCODING.encoding"]/*' />
    public WS_XML_READER_ENCODING encoding;

    /// <include file='WS_XML_READER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_READER_BINARY_ENCODING.staticDictionary"]/*' />
    public WS_XML_DICTIONARY* staticDictionary;

    /// <include file='WS_XML_READER_BINARY_ENCODING.xml' path='doc/member[@name="WS_XML_READER_BINARY_ENCODING.dynamicDictionary"]/*' />
    public WS_XML_DICTIONARY* dynamicDictionary;
}
