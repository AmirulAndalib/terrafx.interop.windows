// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CREDENTIAL_PROVIDER_FIELD_STATE
    {
        CPFS_HIDDEN = 0,
        CPFS_DISPLAY_IN_SELECTED_TILE = (CPFS_HIDDEN + 1),
        CPFS_DISPLAY_IN_DESELECTED_TILE = (CPFS_DISPLAY_IN_SELECTED_TILE + 1),
        CPFS_DISPLAY_IN_BOTH = (CPFS_DISPLAY_IN_DESELECTED_TILE + 1),
    }
}