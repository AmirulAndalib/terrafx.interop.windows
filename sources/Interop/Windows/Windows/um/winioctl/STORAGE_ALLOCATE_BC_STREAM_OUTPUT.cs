// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct STORAGE_ALLOCATE_BC_STREAM_OUTPUT
    {
        [NativeTypeName("DWORDLONG")]
        public ulong RequestSize;

        [NativeTypeName("DWORD")]
        public uint NumOutStandingRequests;
    }
}