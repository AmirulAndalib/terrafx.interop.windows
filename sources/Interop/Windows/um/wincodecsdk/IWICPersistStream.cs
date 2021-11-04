// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00675040-6908-45F8-86A3-49C7DFD6D9AD")]
    [NativeTypeName("struct IWICPersistStream : IPersistStream")]
    [NativeInheritance("IPersistStream")]
    public unsafe partial struct IWICPersistStream : IWICPersistStream.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICPersistStream*, Guid*, void**, int>)(lpVtbl[0]))((IWICPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICPersistStream*, uint>)(lpVtbl[1]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICPersistStream*, uint>)(lpVtbl[2]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IWICPersistStream*, Guid*, int>)(lpVtbl[3]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsDirty()
        {
            return ((delegate* unmanaged<IWICPersistStream*, int>)(lpVtbl[4]))((IWICPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Load(IStream* pStm)
        {
            return ((delegate* unmanaged<IWICPersistStream*, IStream*, int>)(lpVtbl[5]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Save(IStream* pStm, BOOL fClearDirty)
        {
            return ((delegate* unmanaged<IWICPersistStream*, IStream*, BOOL, int>)(lpVtbl[6]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
        {
            return ((delegate* unmanaged<IWICPersistStream*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT LoadEx(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions)
        {
            return ((delegate* unmanaged<IWICPersistStream*, IStream*, Guid*, uint, int>)(lpVtbl[8]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, pguidPreferredVendor, dwPersistOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SaveEx(IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, BOOL fClearDirty)
        {
            return ((delegate* unmanaged<IWICPersistStream*, IStream*, uint, BOOL, int>)(lpVtbl[9]))((IWICPersistStream*)Unsafe.AsPointer(ref this), pIStream, dwPersistOptions, fClearDirty);
        }

        public interface Interface : IPersistStream.Interface
        {
            [VtblIndex(8)]
            HRESULT LoadEx(IStream* pIStream, [NativeTypeName("const GUID *")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions);

            [VtblIndex(9)]
            HRESULT SaveEx(IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, BOOL fClearDirty);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, int> IsDirty;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, IStream*, int> Load;

            [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, IStream*, BOOL, int> Save;

            [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, ULARGE_INTEGER*, int> GetSizeMax;

            [NativeTypeName("HRESULT (IStream *, const GUID *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, IStream*, Guid*, uint, int> LoadEx;

            [NativeTypeName("HRESULT (IStream *, DWORD, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICPersistStream*, IStream*, uint, BOOL, int> SaveEx;
        }
    }
}
