// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_TCP_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_TCP_BINDING_TEMPLATE"]/*' />
public partial struct WS_TCP_BINDING_TEMPLATE
{
    /// <include file='WS_TCP_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_TCP_BINDING_TEMPLATE.channelProperties"]/*' />
    public WS_CHANNEL_PROPERTIES channelProperties;
}
