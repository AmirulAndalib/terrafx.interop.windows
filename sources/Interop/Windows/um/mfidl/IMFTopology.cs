// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83CF873A-F6DA-4BC8-823F-BACFD55DC433")]
    [NativeTypeName("struct IMFTopology : IMFAttributes")]
    [NativeInheritance("IMFAttributes")]
    public unsafe partial struct IMFTopology
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopology*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTopology*, uint>)(lpVtbl[1]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTopology*, uint>)(lpVtbl[2]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFTopology*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFTopology*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, uint*, int>)(lpVtbl[7]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, double*, int>)(lpVtbl[9]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, uint*, int>)(lpVtbl[11]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, uint*, int>)(lpVtbl[14]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, int>)(lpVtbl[19]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DeleteAllItems()
        {
            return ((delegate* unmanaged<IMFTopology*, int>)(lpVtbl[20]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, uint, int>)(lpVtbl[21]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, ulong, int>)(lpVtbl[22]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, double, int>)(lpVtbl[23]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFTopology*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT LockStore()
        {
            return ((delegate* unmanaged<IMFTopology*, int>)(lpVtbl[28]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT UnlockStore()
        {
            return ((delegate* unmanaged<IMFTopology*, int>)(lpVtbl[29]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged<IMFTopology*, uint*, int>)(lpVtbl[30]))((IMFTopology*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFTopology*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFTopology*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CopyAllItems(IMFAttributes* pDest)
        {
            return ((delegate* unmanaged<IMFTopology*, IMFAttributes*, int>)(lpVtbl[32]))((IMFTopology*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetTopologyID([NativeTypeName("TOPOID *")] ulong* pID)
        {
            return ((delegate* unmanaged<IMFTopology*, ulong*, int>)(lpVtbl[33]))((IMFTopology*)Unsafe.AsPointer(ref this), pID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT AddNode(IMFTopologyNode* pNode)
        {
            return ((delegate* unmanaged<IMFTopology*, IMFTopologyNode*, int>)(lpVtbl[34]))((IMFTopology*)Unsafe.AsPointer(ref this), pNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT RemoveNode(IMFTopologyNode* pNode)
        {
            return ((delegate* unmanaged<IMFTopology*, IMFTopologyNode*, int>)(lpVtbl[35]))((IMFTopology*)Unsafe.AsPointer(ref this), pNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetNodeCount([NativeTypeName("WORD *")] ushort* pwNodes)
        {
            return ((delegate* unmanaged<IMFTopology*, ushort*, int>)(lpVtbl[36]))((IMFTopology*)Unsafe.AsPointer(ref this), pwNodes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT GetNode([NativeTypeName("WORD")] ushort wIndex, IMFTopologyNode** ppNode)
        {
            return ((delegate* unmanaged<IMFTopology*, ushort, IMFTopologyNode**, int>)(lpVtbl[37]))((IMFTopology*)Unsafe.AsPointer(ref this), wIndex, ppNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT Clear()
        {
            return ((delegate* unmanaged<IMFTopology*, int>)(lpVtbl[38]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT CloneFrom(IMFTopology* pTopology)
        {
            return ((delegate* unmanaged<IMFTopology*, IMFTopology*, int>)(lpVtbl[39]))((IMFTopology*)Unsafe.AsPointer(ref this), pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT GetNodeByID([NativeTypeName("TOPOID")] ulong qwTopoNodeID, IMFTopologyNode** ppNode)
        {
            return ((delegate* unmanaged<IMFTopology*, ulong, IMFTopologyNode**, int>)(lpVtbl[40]))((IMFTopology*)Unsafe.AsPointer(ref this), qwTopoNodeID, ppNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT GetSourceNodeCollection(IMFCollection** ppCollection)
        {
            return ((delegate* unmanaged<IMFTopology*, IMFCollection**, int>)(lpVtbl[41]))((IMFTopology*)Unsafe.AsPointer(ref this), ppCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT GetOutputNodeCollection(IMFCollection** ppCollection)
        {
            return ((delegate* unmanaged<IMFTopology*, IMFCollection**, int>)(lpVtbl[42]))((IMFTopology*)Unsafe.AsPointer(ref this), ppCollection);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, PROPVARIANT*, int> GetItem;

            [NativeTypeName("HRESULT (const GUID &, MF_ATTRIBUTE_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, MF_ATTRIBUTE_TYPE*, int> GetItemType;

            [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, PROPVARIANT*, BOOL*, int> CompareItem;

            [NativeTypeName("HRESULT (IMFAttributes *, MF_ATTRIBUTES_MATCH_TYPE, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int> Compare;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, uint*, int> GetUINT32;

            [NativeTypeName("HRESULT (const GUID &, UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, ulong*, int> GetUINT64;

            [NativeTypeName("HRESULT (const GUID &, double *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, double*, int> GetDouble;

            [NativeTypeName("HRESULT (const GUID &, GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, Guid*, int> GetGUID;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, uint*, int> GetStringLength;

            [NativeTypeName("HRESULT (const GUID &, LPWSTR, UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, ushort*, uint, uint*, int> GetString;

            [NativeTypeName("HRESULT (const GUID &, LPWSTR *, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, ushort**, uint*, int> GetAllocatedString;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, uint*, int> GetBlobSize;

            [NativeTypeName("HRESULT (const GUID &, UINT8 *, UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, byte*, uint, uint*, int> GetBlob;

            [NativeTypeName("HRESULT (const GUID &, UINT8 **, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, byte**, uint*, int> GetAllocatedBlob;

            [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, Guid*, void**, int> GetUnknown;

            [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, PROPVARIANT*, int> SetItem;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, int> DeleteItem;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, int> DeleteAllItems;

            [NativeTypeName("HRESULT (const GUID &, UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, uint, int> SetUINT32;

            [NativeTypeName("HRESULT (const GUID &, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, ulong, int> SetUINT64;

            [NativeTypeName("HRESULT (const GUID &, double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, double, int> SetDouble;

            [NativeTypeName("HRESULT (const GUID &, const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, Guid*, int> SetGUID;

            [NativeTypeName("HRESULT (const GUID &, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, ushort*, int> SetString;

            [NativeTypeName("HRESULT (const GUID &, const UINT8 *, UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, byte*, uint, int> SetBlob;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, Guid*, IUnknown*, int> SetUnknown;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, int> LockStore;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, int> UnlockStore;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT32, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, uint, Guid*, PROPVARIANT*, int> GetItemByIndex;

            [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, IMFAttributes*, int> CopyAllItems;

            [NativeTypeName("HRESULT (TOPOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, ulong*, int> GetTopologyID;

            [NativeTypeName("HRESULT (IMFTopologyNode *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, IMFTopologyNode*, int> AddNode;

            [NativeTypeName("HRESULT (IMFTopologyNode *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, IMFTopologyNode*, int> RemoveNode;

            [NativeTypeName("HRESULT (WORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, ushort*, int> GetNodeCount;

            [NativeTypeName("HRESULT (WORD, IMFTopologyNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, ushort, IMFTopologyNode**, int> GetNode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, int> Clear;

            [NativeTypeName("HRESULT (IMFTopology *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, IMFTopology*, int> CloneFrom;

            [NativeTypeName("HRESULT (TOPOID, IMFTopologyNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, ulong, IMFTopologyNode**, int> GetNodeByID;

            [NativeTypeName("HRESULT (IMFCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, IMFCollection**, int> GetSourceNodeCollection;

            [NativeTypeName("HRESULT (IMFCollection **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFTopology*, IMFCollection**, int> GetOutputNodeCollection;
        }
    }
}
