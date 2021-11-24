// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("14056581-E16C-11D2-BB90-00C04F8EE6C0")]
[NativeTypeName("struct ISpDataKey : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpDataKey : ISpDataKey.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpDataKey*, Guid*, void**, int>)(lpVtbl[0]))((ISpDataKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpDataKey*, uint>)(lpVtbl[1]))((ISpDataKey*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpDataKey*, uint>)(lpVtbl[2]))((ISpDataKey*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, uint, byte*, int>)(lpVtbl[3]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, uint*, byte*, int>)(lpVtbl[4]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, uint, int>)(lpVtbl[7]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, uint*, int>)(lpVtbl[8]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, ISpDataKey**, int>)(lpVtbl[9]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, ISpDataKey**, int>)(lpVtbl[10]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, int>)(lpVtbl[11]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName)
    {
        return ((delegate* unmanaged<ISpDataKey*, ushort*, int>)(lpVtbl[12]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName)
    {
        return ((delegate* unmanaged<ISpDataKey*, uint, ushort**, int>)(lpVtbl[13]))((ISpDataKey*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName)
    {
        return ((delegate* unmanaged<ISpDataKey*, uint, ushort**, int>)(lpVtbl[14]))((ISpDataKey*)Unsafe.AsPointer(ref this), Index, ppszValueName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData);

        [VtblIndex(4)]
        HRESULT GetData([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData);

        [VtblIndex(5)]
        HRESULT SetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPCWSTR")] ushort* pszValue);

        [VtblIndex(6)]
        HRESULT GetStringValue([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("LPWSTR *")] ushort** ppszValue);

        [VtblIndex(7)]
        HRESULT SetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD")] uint dwValue);

        [VtblIndex(8)]
        HRESULT GetDWORD([NativeTypeName("LPCWSTR")] ushort* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue);

        [VtblIndex(9)]
        HRESULT OpenKey([NativeTypeName("LPCWSTR")] ushort* pszSubKeyName, ISpDataKey** ppSubKey);

        [VtblIndex(10)]
        HRESULT CreateKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey, ISpDataKey** ppSubKey);

        [VtblIndex(11)]
        HRESULT DeleteKey([NativeTypeName("LPCWSTR")] ushort* pszSubKey);

        [VtblIndex(12)]
        HRESULT DeleteValue([NativeTypeName("LPCWSTR")] ushort* pszValueName);

        [VtblIndex(13)]
        HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszSubKeyName);

        [VtblIndex(14)]
        HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] ushort** ppszValueName);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, uint, byte*, int> SetData;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, uint*, byte*, int> GetData;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, ushort*, int> SetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, ushort**, int> GetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, uint, int> SetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, uint*, int> GetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, ISpDataKey**, int> OpenKey;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, ISpDataKey**, int> CreateKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, int> DeleteKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, ushort*, int> DeleteValue;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, uint, ushort**, int> EnumKeys;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpDataKey*, uint, ushort**, int> EnumValues;
    }
}
