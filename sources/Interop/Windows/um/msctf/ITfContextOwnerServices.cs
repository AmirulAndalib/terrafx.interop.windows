// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B23EB630-3E1C-11D3-A745-0050040AB407")]
    [NativeTypeName("struct ITfContextOwnerServices : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfContextOwnerServices
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, uint>)(lpVtbl[1]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, uint>)(lpVtbl[2]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnLayoutChange()
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, int>)(lpVtbl[3]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, uint, int>)(lpVtbl[4]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnAttributeChange([NativeTypeName("const GUID &")] Guid* rguidAttribute)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, Guid*, int>)(lpVtbl[5]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), rguidAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Serialize(ITfProperty* pProp, ITfRange* pRange, TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr, IStream* pStream)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, ITfProperty*, ITfRange*, TF_PERSISTENT_PROPERTY_HEADER_ACP*, IStream*, int>)(lpVtbl[6]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), pProp, pRange, pHdr, pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Unserialize(ITfProperty* pProp, [NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")] TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr, IStream* pStream, ITfPersistentPropertyLoaderACP* pLoader)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, ITfProperty*, TF_PERSISTENT_PROPERTY_HEADER_ACP*, IStream*, ITfPersistentPropertyLoaderACP*, int>)(lpVtbl[7]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), pProp, pHdr, pStream, pLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ForceLoadProperty(ITfProperty* pProp)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, ITfProperty*, int>)(lpVtbl[8]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), pProp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateRange([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, ITfRangeACP** ppRange)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, int, int, ITfRangeACP**, int>)(lpVtbl[9]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), acpStart, acpEnd, ppRange);
        }
    }
}
