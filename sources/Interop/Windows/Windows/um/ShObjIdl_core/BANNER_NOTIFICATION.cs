// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='BANNER_NOTIFICATION.xml' path='doc/member[@name="BANNER_NOTIFICATION"]/*' />
public unsafe partial struct BANNER_NOTIFICATION
{
    /// <include file='BANNER_NOTIFICATION.xml' path='doc/member[@name="BANNER_NOTIFICATION.@event"]/*' />
    public BANNER_NOTIFICATION_EVENT @event;

    /// <include file='BANNER_NOTIFICATION.xml' path='doc/member[@name="BANNER_NOTIFICATION.providerIdentity"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* providerIdentity;

    /// <include file='BANNER_NOTIFICATION.xml' path='doc/member[@name="BANNER_NOTIFICATION.contentId"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* contentId;
}
