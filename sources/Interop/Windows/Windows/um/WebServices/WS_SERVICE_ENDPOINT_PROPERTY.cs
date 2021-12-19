// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SERVICE_ENDPOINT_PROPERTY.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY"]/*' />
public unsafe partial struct WS_SERVICE_ENDPOINT_PROPERTY
{
    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY.id"]/*' />
    public WS_SERVICE_ENDPOINT_PROPERTY_ID id;

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY.value"]/*' />
    public void* value;

    /// <include file='WS_SERVICE_ENDPOINT_PROPERTY.xml' path='doc/member[@name="WS_SERVICE_ENDPOINT_PROPERTY.valueSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint valueSize;
}
