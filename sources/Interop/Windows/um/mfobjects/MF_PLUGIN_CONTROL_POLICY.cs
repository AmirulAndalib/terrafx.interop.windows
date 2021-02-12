// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_PLUGIN_CONTROL_POLICY
    {
        MF_PLUGIN_CONTROL_POLICY_USE_ALL_PLUGINS = 0,
        MF_PLUGIN_CONTROL_POLICY_USE_APPROVED_PLUGINS = 1,
        MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS = 2,
        MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS_EDGEMODE = 3,
    }
}
