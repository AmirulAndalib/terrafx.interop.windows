// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT"]/*' />
public unsafe partial struct WS_SECURITY_BINDING_CONSTRAINT
{
    /// <include file='WS_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT.type"]/*' />
    public WS_SECURITY_BINDING_CONSTRAINT_TYPE type;

    /// <include file='WS_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT.propertyConstraints"]/*' />
    public WS_SECURITY_BINDING_PROPERTY_CONSTRAINT* propertyConstraints;

    /// <include file='WS_SECURITY_BINDING_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_CONSTRAINT.propertyConstraintCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint propertyConstraintCount;
}
