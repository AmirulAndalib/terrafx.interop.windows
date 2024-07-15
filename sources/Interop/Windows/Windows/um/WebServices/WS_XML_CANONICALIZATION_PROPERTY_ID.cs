// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_XML_CANONICALIZATION_PROPERTY_ID.xml' path='doc/member[@name="WS_XML_CANONICALIZATION_PROPERTY_ID"]/*' />
public enum WS_XML_CANONICALIZATION_PROPERTY_ID
{
    /// <include file='WS_XML_CANONICALIZATION_PROPERTY_ID.xml' path='doc/member[@name="WS_XML_CANONICALIZATION_PROPERTY_ID.WS_XML_CANONICALIZATION_PROPERTY_ALGORITHM"]/*' />
    WS_XML_CANONICALIZATION_PROPERTY_ALGORITHM = 0,

    /// <include file='WS_XML_CANONICALIZATION_PROPERTY_ID.xml' path='doc/member[@name="WS_XML_CANONICALIZATION_PROPERTY_ID.WS_XML_CANONICALIZATION_PROPERTY_INCLUSIVE_PREFIXES"]/*' />
    WS_XML_CANONICALIZATION_PROPERTY_INCLUSIVE_PREFIXES = 1,

    /// <include file='WS_XML_CANONICALIZATION_PROPERTY_ID.xml' path='doc/member[@name="WS_XML_CANONICALIZATION_PROPERTY_ID.WS_XML_CANONICALIZATION_PROPERTY_OMITTED_ELEMENT"]/*' />
    WS_XML_CANONICALIZATION_PROPERTY_OMITTED_ELEMENT = 2,

    /// <include file='WS_XML_CANONICALIZATION_PROPERTY_ID.xml' path='doc/member[@name="WS_XML_CANONICALIZATION_PROPERTY_ID.WS_XML_CANONICALIZATION_PROPERTY_OUTPUT_BUFFER_SIZE"]/*' />
    WS_XML_CANONICALIZATION_PROPERTY_OUTPUT_BUFFER_SIZE = 3,
}
