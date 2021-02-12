// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ACTIVATION_CONTEXT_RUN_LEVEL_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint ulFlags;

        public ACTCTX_REQUESTED_RUN_LEVEL RunLevel;

        [NativeTypeName("DWORD")]
        public uint UiAccess;
    }
}
