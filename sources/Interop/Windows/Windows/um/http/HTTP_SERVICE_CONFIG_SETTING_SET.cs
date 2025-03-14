// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_SETTING_SET.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SETTING_SET"]/*' />
public partial struct HTTP_SERVICE_CONFIG_SETTING_SET
{
    /// <include file='HTTP_SERVICE_CONFIG_SETTING_SET.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SETTING_SET.KeyDesc"]/*' />
    public HTTP_SERVICE_CONFIG_SETTING_KEY KeyDesc;

    /// <include file='HTTP_SERVICE_CONFIG_SETTING_SET.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SETTING_SET.ParamDesc"]/*' />
    [NativeTypeName("HTTP_SERVICE_CONFIG_SETTING_PARAM")]
    public uint ParamDesc;
}
