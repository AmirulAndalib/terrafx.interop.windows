// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_PARAMETER_TYPE.xml' path='doc/member[@name="WS_PARAMETER_TYPE"]/*' />
public enum WS_PARAMETER_TYPE
{
    /// <include file='WS_PARAMETER_TYPE.xml' path='doc/member[@name="WS_PARAMETER_TYPE.WS_PARAMETER_TYPE_NORMAL"]/*' />
    WS_PARAMETER_TYPE_NORMAL = 0,

    /// <include file='WS_PARAMETER_TYPE.xml' path='doc/member[@name="WS_PARAMETER_TYPE.WS_PARAMETER_TYPE_ARRAY"]/*' />
    WS_PARAMETER_TYPE_ARRAY = 1,

    /// <include file='WS_PARAMETER_TYPE.xml' path='doc/member[@name="WS_PARAMETER_TYPE.WS_PARAMETER_TYPE_ARRAY_COUNT"]/*' />
    WS_PARAMETER_TYPE_ARRAY_COUNT = 2,

    /// <include file='WS_PARAMETER_TYPE.xml' path='doc/member[@name="WS_PARAMETER_TYPE.WS_PARAMETER_TYPE_MESSAGES"]/*' />
    WS_PARAMETER_TYPE_MESSAGES = 3,
}
