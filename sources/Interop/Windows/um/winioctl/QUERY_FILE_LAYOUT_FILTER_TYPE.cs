// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum QUERY_FILE_LAYOUT_FILTER_TYPE
    {
        QUERY_FILE_LAYOUT_FILTER_TYPE_NONE = 0,
        QUERY_FILE_LAYOUT_FILTER_TYPE_CLUSTERS = 1,
        QUERY_FILE_LAYOUT_FILTER_TYPE_FILEID = 2,
        QUERY_FILE_LAYOUT_FILTER_TYPE_STORAGE_RESERVE_ID = 3,
        QUERY_FILE_LAYOUT_NUM_FILTER_TYPES,
    }
}
