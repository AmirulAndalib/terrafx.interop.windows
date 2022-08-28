// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_HEAP_PROPERTIES.xml' path='doc/member[@name="WS_HEAP_PROPERTIES"]/*' />
public unsafe partial struct WS_HEAP_PROPERTIES
{
    /// <include file='WS_HEAP_PROPERTIES.xml' path='doc/member[@name="WS_HEAP_PROPERTIES.properties"]/*' />
    public WS_HEAP_PROPERTY* properties;

    /// <include file='WS_HEAP_PROPERTIES.xml' path='doc/member[@name="WS_HEAP_PROPERTIES.propertyCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint propertyCount;
}
