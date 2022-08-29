// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='JOBOBJECT_BASIC_PROCESS_ID_LIST.xml' path='doc/member[@name="JOBOBJECT_BASIC_PROCESS_ID_LIST"]/*' />
public partial struct JOBOBJECT_BASIC_PROCESS_ID_LIST
{
    /// <include file='JOBOBJECT_BASIC_PROCESS_ID_LIST.xml' path='doc/member[@name="JOBOBJECT_BASIC_PROCESS_ID_LIST.NumberOfAssignedProcesses"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfAssignedProcesses;

    /// <include file='JOBOBJECT_BASIC_PROCESS_ID_LIST.xml' path='doc/member[@name="JOBOBJECT_BASIC_PROCESS_ID_LIST.NumberOfProcessIdsInList"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfProcessIdsInList;

    /// <include file='JOBOBJECT_BASIC_PROCESS_ID_LIST.xml' path='doc/member[@name="JOBOBJECT_BASIC_PROCESS_ID_LIST.ProcessIdList"]/*' />
    [NativeTypeName("ULONG_PTR[1]")]
    public _ProcessIdList_e__FixedBuffer ProcessIdList;

    /// <include file='_ProcessIdList_e__FixedBuffer.xml' path='doc/member[@name="_ProcessIdList_e__FixedBuffer"]/*' />
    public partial struct _ProcessIdList_e__FixedBuffer
    {
        public nuint e0;

        [UnscopedRef]
        public ref nuint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<nuint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
