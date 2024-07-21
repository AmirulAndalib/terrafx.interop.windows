// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_MESSAGE_DESCRIPTION.xml' path='doc/member[@name="WS_MESSAGE_DESCRIPTION"]/*' />
public unsafe partial struct WS_MESSAGE_DESCRIPTION
{
    /// <include file='WS_MESSAGE_DESCRIPTION.xml' path='doc/member[@name="WS_MESSAGE_DESCRIPTION.action"]/*' />
    public WS_XML_STRING* action;

    /// <include file='WS_MESSAGE_DESCRIPTION.xml' path='doc/member[@name="WS_MESSAGE_DESCRIPTION.bodyElementDescription"]/*' />
    public WS_ELEMENT_DESCRIPTION* bodyElementDescription;
}
