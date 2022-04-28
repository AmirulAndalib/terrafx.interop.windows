// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROCESS_BASIC_INFORMATION.xml' path='doc/member[@name="PROCESS_BASIC_INFORMATION"]/*' />
public unsafe partial struct PROCESS_BASIC_INFORMATION
{
    /// <include file='PROCESS_BASIC_INFORMATION.xml' path='doc/member[@name="PROCESS_BASIC_INFORMATION.Reserved1"]/*' />
    [NativeTypeName("PVOID")]
    public void* Reserved1;

    /// <include file='PROCESS_BASIC_INFORMATION.xml' path='doc/member[@name="PROCESS_BASIC_INFORMATION.PebBaseAddress"]/*' />
    [NativeTypeName("PPEB")]
    public PEB* PebBaseAddress;

    /// <include file='PROCESS_BASIC_INFORMATION.xml' path='doc/member[@name="PROCESS_BASIC_INFORMATION.Reserved2"]/*' />
    [NativeTypeName("PVOID[2]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='PROCESS_BASIC_INFORMATION.xml' path='doc/member[@name="PROCESS_BASIC_INFORMATION.UniqueProcessId"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint UniqueProcessId;

    /// <include file='PROCESS_BASIC_INFORMATION.xml' path='doc/member[@name="PROCESS_BASIC_INFORMATION.Reserved3"]/*' />
    [NativeTypeName("PVOID")]
    public void* Reserved3;

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    public unsafe partial struct _Reserved2_e__FixedBuffer
    {
        public void* e0;
        public void* e1;

        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
