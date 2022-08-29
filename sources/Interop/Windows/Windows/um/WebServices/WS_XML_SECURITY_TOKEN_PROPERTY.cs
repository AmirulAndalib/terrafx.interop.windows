// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_XML_SECURITY_TOKEN_PROPERTY.xml' path='doc/member[@name="WS_XML_SECURITY_TOKEN_PROPERTY"]/*' />
public unsafe partial struct WS_XML_SECURITY_TOKEN_PROPERTY
{
    /// <include file='WS_XML_SECURITY_TOKEN_PROPERTY.xml' path='doc/member[@name="WS_XML_SECURITY_TOKEN_PROPERTY.id"]/*' />
    public WS_XML_SECURITY_TOKEN_PROPERTY_ID id;

    /// <include file='WS_XML_SECURITY_TOKEN_PROPERTY.xml' path='doc/member[@name="WS_XML_SECURITY_TOKEN_PROPERTY.value"]/*' />
    public void* value;

    /// <include file='WS_XML_SECURITY_TOKEN_PROPERTY.xml' path='doc/member[@name="WS_XML_SECURITY_TOKEN_PROPERTY.valueSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint valueSize;
}
