// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SD_CHANGE_MACHINE_SID_OUTPUT
    {
        [NativeTypeName("DWORDLONG")]
        public ulong NumSDChangedSuccess;

        [NativeTypeName("DWORDLONG")]
        public ulong NumSDChangedFail;

        [NativeTypeName("DWORDLONG")]
        public ulong NumSDUnused;

        [NativeTypeName("DWORDLONG")]
        public ulong NumSDTotal;

        [NativeTypeName("DWORDLONG")]
        public ulong NumMftSDChangedSuccess;

        [NativeTypeName("DWORDLONG")]
        public ulong NumMftSDChangedFail;

        [NativeTypeName("DWORDLONG")]
        public ulong NumMftSDTotal;
    }
}
