// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct JIT_DEBUG_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwProcessorArchitecture;

        [NativeTypeName("DWORD")]
        public uint dwThreadID;

        [NativeTypeName("DWORD")]
        public uint dwReserved0;

        [NativeTypeName("ULONG64")]
        public ulong lpExceptionAddress;

        [NativeTypeName("ULONG64")]
        public ulong lpExceptionRecord;

        [NativeTypeName("ULONG64")]
        public ulong lpContextRecord;
    }
}
