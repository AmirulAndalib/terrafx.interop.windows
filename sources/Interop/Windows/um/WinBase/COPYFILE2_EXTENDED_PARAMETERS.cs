// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct COPYFILE2_EXTENDED_PARAMETERS
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwCopyFlags;

        [NativeTypeName("BOOL *")]
        public int* pfCancel;

        [NativeTypeName("PCOPYFILE2_PROGRESS_ROUTINE")]
        public delegate* unmanaged<COPYFILE2_MESSAGE*, void*, COPYFILE2_MESSAGE_ACTION> pProgressRoutine;

        [NativeTypeName("PVOID")]
        public void* pvCallbackContext;
    }
}
