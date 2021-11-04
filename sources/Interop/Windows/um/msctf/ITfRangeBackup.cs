// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("463A506D-6992-49D2-9B88-93D55E70BB16")]
    [NativeTypeName("struct ITfRangeBackup : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfRangeBackup
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfRangeBackup*, Guid*, void**, int>)(lpVtbl[0]))((ITfRangeBackup*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfRangeBackup*, uint>)(lpVtbl[1]))((ITfRangeBackup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfRangeBackup*, uint>)(lpVtbl[2]))((ITfRangeBackup*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Restore([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange)
        {
            return ((delegate* unmanaged<ITfRangeBackup*, uint, ITfRange*, int>)(lpVtbl[3]))((ITfRangeBackup*)Unsafe.AsPointer(ref this), ec, pRange);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRangeBackup*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRangeBackup*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRangeBackup*, uint> Release;

            [NativeTypeName("HRESULT (TfEditCookie, ITfRange *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfRangeBackup*, uint, ITfRange*, int> Restore;
        }
    }
}
