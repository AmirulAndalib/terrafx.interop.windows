// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFSensorStream.xml' path='doc/member[@name="IMFSensorStream"]/*' />
[Guid("E9A42171-C56E-498A-8B39-EDA5A070B7FC")]
[NativeTypeName("struct IMFSensorStream : IMFAttributes")]
[NativeInheritance("IMFAttributes")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSensorStream : IMFSensorStream.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IMFSensorStream;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSensorStream*, uint>)(lpVtbl[1]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorStream*, uint>)(lpVtbl[2]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFAttributes.GetItem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pValue);
    }

    /// <inheritdoc cref="IMFAttributes.GetItemType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pType);
    }

    /// <inheritdoc cref="IMFAttributes.CompareItem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
    }

    /// <inheritdoc cref="IMFAttributes.Compare" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
    {
        return ((delegate* unmanaged<IMFSensorStream*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFSensorStream*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
    }

    /// <inheritdoc cref="IMFAttributes.GetUINT32" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, uint*, int>)(lpVtbl[7]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, punValue);
    }

    /// <inheritdoc cref="IMFAttributes.GetUINT64" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, punValue);
    }

    /// <inheritdoc cref="IMFAttributes.GetDouble" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, double*, int>)(lpVtbl[9]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pfValue);
    }

    /// <inheritdoc cref="IMFAttributes.GetGUID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
    }

    /// <inheritdoc cref="IMFAttributes.GetStringLength" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, uint*, int>)(lpVtbl[11]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
    }

    /// <inheritdoc cref="IMFAttributes.GetString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
    }

    /// <inheritdoc cref="IMFAttributes.GetAllocatedString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
    }

    /// <inheritdoc cref="IMFAttributes.GetBlobSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, uint*, int>)(lpVtbl[14]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
    }

    /// <inheritdoc cref="IMFAttributes.GetBlob" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
    }

    /// <inheritdoc cref="IMFAttributes.GetAllocatedBlob" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
    }

    /// <inheritdoc cref="IMFAttributes.GetUnknown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
    }

    /// <inheritdoc cref="IMFAttributes.SetItem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, Value);
    }

    /// <inheritdoc cref="IMFAttributes.DeleteItem" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, int>)(lpVtbl[19]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey);
    }

    /// <inheritdoc cref="IMFAttributes.DeleteAllItems" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DeleteAllItems()
    {
        return ((delegate* unmanaged<IMFSensorStream*, int>)(lpVtbl[20]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFAttributes.SetUINT32" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, uint, int>)(lpVtbl[21]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, unValue);
    }

    /// <inheritdoc cref="IMFAttributes.SetUINT64" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, ulong, int>)(lpVtbl[22]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, unValue);
    }

    /// <inheritdoc cref="IMFAttributes.SetDouble" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, double, int>)(lpVtbl[23]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, fValue);
    }

    /// <inheritdoc cref="IMFAttributes.SetGUID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, guidValue);
    }

    /// <inheritdoc cref="IMFAttributes.SetString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, wszValue);
    }

    /// <inheritdoc cref="IMFAttributes.SetBlob" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
    }

    /// <inheritdoc cref="IMFAttributes.SetUnknown" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IMFSensorStream*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
    }

    /// <inheritdoc cref="IMFAttributes.LockStore" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT LockStore()
    {
        return ((delegate* unmanaged<IMFSensorStream*, int>)(lpVtbl[28]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFAttributes.UnlockStore" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT UnlockStore()
    {
        return ((delegate* unmanaged<IMFSensorStream*, int>)(lpVtbl[29]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFAttributes.GetCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
    {
        return ((delegate* unmanaged<IMFSensorStream*, uint*, int>)(lpVtbl[30]))((IMFSensorStream*)Unsafe.AsPointer(ref this), pcItems);
    }

    /// <inheritdoc cref="IMFAttributes.GetItemByIndex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IMFSensorStream*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFSensorStream*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
    }

    /// <inheritdoc cref="IMFAttributes.CopyAllItems" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CopyAllItems(IMFAttributes* pDest)
    {
        return ((delegate* unmanaged<IMFSensorStream*, IMFAttributes*, int>)(lpVtbl[32]))((IMFSensorStream*)Unsafe.AsPointer(ref this), pDest);
    }

    /// <include file='IMFSensorStream.xml' path='doc/member[@name="IMFSensorStream.GetMediaTypeCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IMFSensorStream*, uint*, int>)(lpVtbl[33]))((IMFSensorStream*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='IMFSensorStream.xml' path='doc/member[@name="IMFSensorStream.GetMediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetMediaType([NativeTypeName("DWORD")] uint dwIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFSensorStream*, uint, IMFMediaType**, int>)(lpVtbl[34]))((IMFSensorStream*)Unsafe.AsPointer(ref this), dwIndex, ppMediaType);
    }

    /// <include file='IMFSensorStream.xml' path='doc/member[@name="IMFSensorStream.CloneSensorStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT CloneSensorStream(IMFSensorStream** ppStream)
    {
        return ((delegate* unmanaged<IMFSensorStream*, IMFSensorStream**, int>)(lpVtbl[35]))((IMFSensorStream*)Unsafe.AsPointer(ref this), ppStream);
    }

    public interface Interface : IMFAttributes.Interface
    {
        [VtblIndex(33)]
        HRESULT GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(34)]
        HRESULT GetMediaType([NativeTypeName("DWORD")] uint dwIndex, IMFMediaType** ppMediaType);

        [VtblIndex(35)]
        HRESULT CloneSensorStream(IMFSensorStream** ppStream);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> GetItem;

        [NativeTypeName("HRESULT (const GUID &, MF_ATTRIBUTE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, MF_ATTRIBUTE_TYPE*, int> GetItemType;

        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, BOOL*, int> CompareItem;

        [NativeTypeName("HRESULT (IMFAttributes *, MF_ATTRIBUTES_MATCH_TYPE, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int> Compare;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetUINT32;

        [NativeTypeName("HRESULT (const GUID &, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ulong*, int> GetUINT64;

        [NativeTypeName("HRESULT (const GUID &, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, double*, int> GetDouble;

        [NativeTypeName("HRESULT (const GUID &, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetStringLength;

        [NativeTypeName("HRESULT (const GUID &, LPWSTR, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, uint, uint*, int> GetString;

        [NativeTypeName("HRESULT (const GUID &, LPWSTR *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint*, int> GetAllocatedString;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetBlobSize;

        [NativeTypeName("HRESULT (const GUID &, UINT8 *, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, uint*, int> GetBlob;

        [NativeTypeName("HRESULT (const GUID &, UINT8 **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte**, uint*, int> GetAllocatedBlob;

        [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> GetUnknown;

        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> SetItem;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> DeleteItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DeleteAllItems;

        [NativeTypeName("HRESULT (const GUID &, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> SetUINT32;

        [NativeTypeName("HRESULT (const GUID &, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ulong, int> SetUINT64;

        [NativeTypeName("HRESULT (const GUID &, double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, double, int> SetDouble;

        [NativeTypeName("HRESULT (const GUID &, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> SetGUID;

        [NativeTypeName("HRESULT (const GUID &, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, int> SetString;

        [NativeTypeName("HRESULT (const GUID &, const UINT8 *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, int> SetBlob;

        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetUnknown;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockStore;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockStore;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT32, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, PROPVARIANT*, int> GetItemByIndex;

        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> CopyAllItems;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMediaTypeCount;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetMediaType;

        [NativeTypeName("HRESULT (IMFSensorStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSensorStream**, int> CloneSensorStream;
    }
}
