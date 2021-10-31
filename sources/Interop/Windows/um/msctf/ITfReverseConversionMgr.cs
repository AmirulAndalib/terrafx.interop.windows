// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B643C236-C493-41B6-ABB3-692412775CC4")]
    [NativeTypeName("struct ITfReverseConversionMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfReverseConversionMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfReverseConversionMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfReverseConversionMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfReverseConversionMgr*, uint>)(lpVtbl[1]))((ITfReverseConversionMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfReverseConversionMgr*, uint>)(lpVtbl[2]))((ITfReverseConversionMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetReverseConversion([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("DWORD")] uint dwflag, ITfReverseConversion** ppReverseConversion)
        {
            return ((delegate* unmanaged<ITfReverseConversionMgr*, ushort, Guid*, uint, ITfReverseConversion**, int>)(lpVtbl[3]))((ITfReverseConversionMgr*)Unsafe.AsPointer(ref this), langid, guidProfile, dwflag, ppReverseConversion);
        }
    }
}
