// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_XML_FLOAT_TEXT.xml' path='doc/member[@name="WS_XML_FLOAT_TEXT"]/*' />
public partial struct WS_XML_FLOAT_TEXT
{
    /// <include file='WS_XML_FLOAT_TEXT.xml' path='doc/member[@name="WS_XML_FLOAT_TEXT.text"]/*' />
    public WS_XML_TEXT text;

    /// <include file='WS_XML_FLOAT_TEXT.xml' path='doc/member[@name="WS_XML_FLOAT_TEXT.value"]/*' />
    public float value;
}
