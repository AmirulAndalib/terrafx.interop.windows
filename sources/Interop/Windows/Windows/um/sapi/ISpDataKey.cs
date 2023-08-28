// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey"]/*' />
[Guid("14056581-E16C-11D2-BB90-00C04F8EE6C0")]
[NativeTypeName("struct ISpDataKey : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpDataKey : ISpDataKey.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpDataKey));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, Guid*, void**, int>)(lpVtbl[0]))((ISpDataKey*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, uint>)(lpVtbl[1]))((ISpDataKey*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, uint>)(lpVtbl[2]))((ISpDataKey*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.SetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, uint, byte*, int>)(lpVtbl[3]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, cbData, pData);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.GetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetData([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, uint*, byte*, int>)(lpVtbl[4]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pcbData, pData);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.SetStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStringValue([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPCWSTR")] char* pszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, char*, int>)(lpVtbl[5]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pszValue);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.GetStringValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringValue([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPWSTR *")] char** ppszValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, char**, int>)(lpVtbl[6]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, ppszValue);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.SetDWORD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDWORD([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, uint, int>)(lpVtbl[7]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, dwValue);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.GetDWORD"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDWORD([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, uint*, int>)(lpVtbl[8]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName, pdwValue);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.OpenKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenKey([NativeTypeName("LPCWSTR")] char* pszSubKeyName, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, ISpDataKey**, int>)(lpVtbl[9]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKeyName, ppSubKey);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.CreateKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateKey([NativeTypeName("LPCWSTR")] char* pszSubKey, ISpDataKey** ppSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, ISpDataKey**, int>)(lpVtbl[10]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKey, ppSubKey);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.DeleteKey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteKey([NativeTypeName("LPCWSTR")] char* pszSubKey)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, int>)(lpVtbl[11]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszSubKey);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.DeleteValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteValue([NativeTypeName("LPCWSTR")] char* pszValueName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, char*, int>)(lpVtbl[12]))((ISpDataKey*)Unsafe.AsPointer(ref this), pszValueName);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.EnumKeys"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] char** ppszSubKeyName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, uint, char**, int>)(lpVtbl[13]))((ISpDataKey*)Unsafe.AsPointer(ref this), Index, ppszSubKeyName);
    }

    /// <include file='ISpDataKey.xml' path='doc/member[@name="ISpDataKey.EnumValues"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] char** ppszValueName)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpDataKey*, uint, char**, int>)(lpVtbl[14]))((ISpDataKey*)Unsafe.AsPointer(ref this), Index, ppszValueName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetData([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("ULONG")] uint cbData, [NativeTypeName("const BYTE *")] byte* pData);

        [VtblIndex(4)]
        HRESULT GetData([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("ULONG *")] uint* pcbData, byte* pData);

        [VtblIndex(5)]
        HRESULT SetStringValue([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPCWSTR")] char* pszValue);

        [VtblIndex(6)]
        HRESULT GetStringValue([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("LPWSTR *")] char** ppszValue);

        [VtblIndex(7)]
        HRESULT SetDWORD([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("DWORD")] uint dwValue);

        [VtblIndex(8)]
        HRESULT GetDWORD([NativeTypeName("LPCWSTR")] char* pszValueName, [NativeTypeName("DWORD *")] uint* pdwValue);

        [VtblIndex(9)]
        HRESULT OpenKey([NativeTypeName("LPCWSTR")] char* pszSubKeyName, ISpDataKey** ppSubKey);

        [VtblIndex(10)]
        HRESULT CreateKey([NativeTypeName("LPCWSTR")] char* pszSubKey, ISpDataKey** ppSubKey);

        [VtblIndex(11)]
        HRESULT DeleteKey([NativeTypeName("LPCWSTR")] char* pszSubKey);

        [VtblIndex(12)]
        HRESULT DeleteValue([NativeTypeName("LPCWSTR")] char* pszValueName);

        [VtblIndex(13)]
        HRESULT EnumKeys([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] char** ppszSubKeyName);

        [VtblIndex(14)]
        HRESULT EnumValues([NativeTypeName("ULONG")] uint Index, [NativeTypeName("LPWSTR *")] char** ppszValueName);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, byte*, int> SetData;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, byte*, int> GetData;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, int> SetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char**, int> GetStringValue;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> SetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, int> GetDWORD;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ISpDataKey**, int> OpenKey;

        [NativeTypeName("HRESULT (LPCWSTR, ISpDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, ISpDataKey**, int> CreateKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteKey;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> DeleteValue;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> EnumKeys;

        [NativeTypeName("HRESULT (ULONG, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char**, int> EnumValues;
    }
}
