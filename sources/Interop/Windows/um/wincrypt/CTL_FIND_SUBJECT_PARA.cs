// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CTL_FIND_SUBJECT_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PCTL_FIND_USAGE_PARA")]
        public CTL_FIND_USAGE_PARA* pUsagePara;

        [NativeTypeName("DWORD")]
        public uint dwSubjectType;

        [NativeTypeName("void *")]
        public void* pvSubject;
    }
}
