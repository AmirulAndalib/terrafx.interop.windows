// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("03CB2711-24D7-4DB6-A17F-F3A7A479A536")]
    [NativeTypeName("struct IMFPresentationDescriptor : IMFAttributes")]
    [NativeInheritance("IMFAttributes")]
    public unsafe partial struct IMFPresentationDescriptor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, void**, int>)(lpVtbl[0]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, uint>)(lpVtbl[1]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, uint>)(lpVtbl[2]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, uint*, int>)(lpVtbl[7]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, double*, int>)(lpVtbl[9]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, uint*, int>)(lpVtbl[11]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, uint*, int>)(lpVtbl[14]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, int>)(lpVtbl[19]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DeleteAllItems()
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, int>)(lpVtbl[20]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, uint, int>)(lpVtbl[21]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ulong, int>)(lpVtbl[22]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, double, int>)(lpVtbl[23]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT LockStore()
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, int>)(lpVtbl[28]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT UnlockStore()
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, int>)(lpVtbl[29]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, uint*, int>)(lpVtbl[30]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CopyAllItems(IMFAttributes* pDest)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, IMFAttributes*, int>)(lpVtbl[32]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetStreamDescriptorCount([NativeTypeName("DWORD *")] uint* pdwDescriptorCount)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, uint*, int>)(lpVtbl[33]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), pdwDescriptorCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetStreamDescriptorByIndex([NativeTypeName("DWORD")] uint dwIndex, BOOL* pfSelected, IMFStreamDescriptor** ppDescriptor)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, uint, BOOL*, IMFStreamDescriptor**, int>)(lpVtbl[34]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), dwIndex, pfSelected, ppDescriptor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT SelectStream([NativeTypeName("DWORD")] uint dwDescriptorIndex)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, uint, int>)(lpVtbl[35]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), dwDescriptorIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT DeselectStream([NativeTypeName("DWORD")] uint dwDescriptorIndex)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, uint, int>)(lpVtbl[36]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), dwDescriptorIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT Clone(IMFPresentationDescriptor** ppPresentationDescriptor)
        {
            return ((delegate* unmanaged<IMFPresentationDescriptor*, IMFPresentationDescriptor**, int>)(lpVtbl[37]))((IMFPresentationDescriptor*)Unsafe.AsPointer(ref this), ppPresentationDescriptor);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int> GetItem;

            [NativeTypeName("HRESULT (const GUID &, MF_ATTRIBUTE_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, MF_ATTRIBUTE_TYPE*, int> GetItemType;

            [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, PROPVARIANT*, BOOL*, int> CompareItem;

            [NativeTypeName("HRESULT (IMFAttributes *, MF_ATTRIBUTES_MATCH_TYPE, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int> Compare;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, uint*, int> GetUINT32;

            [NativeTypeName("HRESULT (const GUID &, UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ulong*, int> GetUINT64;

            [NativeTypeName("HRESULT (const GUID &, double *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, double*, int> GetDouble;

            [NativeTypeName("HRESULT (const GUID &, GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, Guid*, int> GetGUID;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, uint*, int> GetStringLength;

            [NativeTypeName("HRESULT (const GUID &, LPWSTR, UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ushort*, uint, uint*, int> GetString;

            [NativeTypeName("HRESULT (const GUID &, LPWSTR *, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ushort**, uint*, int> GetAllocatedString;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, uint*, int> GetBlobSize;

            [NativeTypeName("HRESULT (const GUID &, UINT8 *, UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, byte*, uint, uint*, int> GetBlob;

            [NativeTypeName("HRESULT (const GUID &, UINT8 **, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, byte**, uint*, int> GetAllocatedBlob;

            [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, Guid*, void**, int> GetUnknown;

            [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, PROPVARIANT*, int> SetItem;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, int> DeleteItem;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, int> DeleteAllItems;

            [NativeTypeName("HRESULT (const GUID &, UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, uint, int> SetUINT32;

            [NativeTypeName("HRESULT (const GUID &, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ulong, int> SetUINT64;

            [NativeTypeName("HRESULT (const GUID &, double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, double, int> SetDouble;

            [NativeTypeName("HRESULT (const GUID &, const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, Guid*, int> SetGUID;

            [NativeTypeName("HRESULT (const GUID &, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, ushort*, int> SetString;

            [NativeTypeName("HRESULT (const GUID &, const UINT8 *, UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, byte*, uint, int> SetBlob;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, Guid*, IUnknown*, int> SetUnknown;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, int> LockStore;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, int> UnlockStore;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT32, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, uint, Guid*, PROPVARIANT*, int> GetItemByIndex;

            [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, IMFAttributes*, int> CopyAllItems;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, uint*, int> GetStreamDescriptorCount;

            [NativeTypeName("HRESULT (DWORD, BOOL *, IMFStreamDescriptor **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, uint, BOOL*, IMFStreamDescriptor**, int> GetStreamDescriptorByIndex;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, uint, int> SelectStream;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, uint, int> DeselectStream;

            [NativeTypeName("HRESULT (IMFPresentationDescriptor **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPresentationDescriptor*, IMFPresentationDescriptor**, int> Clone;
        }
    }
}
