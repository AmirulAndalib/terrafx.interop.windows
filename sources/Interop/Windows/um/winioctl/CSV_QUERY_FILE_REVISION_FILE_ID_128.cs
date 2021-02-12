// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CSV_QUERY_FILE_REVISION_FILE_ID_128
    {
        public FILE_ID_128 FileId;

        [NativeTypeName("LONGLONG [3]")]
        public fixed long FileRevision[3];
    }
}
