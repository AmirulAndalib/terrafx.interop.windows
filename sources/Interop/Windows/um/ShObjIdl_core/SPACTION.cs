// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPACTION
    {
        SPACTION_NONE = 0,
        SPACTION_MOVING = (SPACTION_NONE + 1),
        SPACTION_COPYING = (SPACTION_MOVING + 1),
        SPACTION_RECYCLING = (SPACTION_COPYING + 1),
        SPACTION_APPLYINGATTRIBS = (SPACTION_RECYCLING + 1),
        SPACTION_DOWNLOADING = (SPACTION_APPLYINGATTRIBS + 1),
        SPACTION_SEARCHING_INTERNET = (SPACTION_DOWNLOADING + 1),
        SPACTION_CALCULATING = (SPACTION_SEARCHING_INTERNET + 1),
        SPACTION_UPLOADING = (SPACTION_CALCULATING + 1),
        SPACTION_SEARCHING_FILES = (SPACTION_UPLOADING + 1),
        SPACTION_DELETING = (SPACTION_SEARCHING_FILES + 1),
        SPACTION_RENAMING = (SPACTION_DELETING + 1),
        SPACTION_FORMATTING = (SPACTION_RENAMING + 1),
        SPACTION_COPY_MOVING = (SPACTION_FORMATTING + 1),
    }
}
