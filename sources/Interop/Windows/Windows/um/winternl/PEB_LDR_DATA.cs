// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PEB_LDR_DATA.xml' path='doc/member[@name="PEB_LDR_DATA"]/*' />
public partial struct PEB_LDR_DATA
{
    /// <include file='PEB_LDR_DATA.xml' path='doc/member[@name="PEB_LDR_DATA.Reserved1"]/*' />
    [NativeTypeName("BYTE[8]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    /// <include file='PEB_LDR_DATA.xml' path='doc/member[@name="PEB_LDR_DATA.Reserved2"]/*' />
    [NativeTypeName("PVOID[3]")]
    public _Reserved2_e__FixedBuffer Reserved2;

    /// <include file='PEB_LDR_DATA.xml' path='doc/member[@name="PEB_LDR_DATA.InMemoryOrderModuleList"]/*' />
    public LIST_ENTRY InMemoryOrderModuleList;

    /// <include file='_Reserved1_e__FixedBuffer.xml' path='doc/member[@name="_Reserved1_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved2_e__FixedBuffer.xml' path='doc/member[@name="_Reserved2_e__FixedBuffer"]/*' />
    public unsafe partial struct _Reserved2_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;

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
