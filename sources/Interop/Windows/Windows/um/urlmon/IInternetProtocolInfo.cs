// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IInternetProtocolInfo.xml' path='doc/member[@name="IInternetProtocolInfo"]/*' />
[Guid("79EAC9EC-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetProtocolInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetProtocolInfo : IInternetProtocolInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolInfo*, Guid*, void**, int>)(lpVtbl[0]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolInfo*, uint>)(lpVtbl[1]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolInfo*, uint>)(lpVtbl[2]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInternetProtocolInfo.xml' path='doc/member[@name="IInternetProtocolInfo.ParseUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ParseUrl([NativeTypeName("LPCWSTR")] char* pwzUrl, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwParseFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolInfo*, char*, PARSEACTION, uint, char*, uint, uint*, uint, int>)(lpVtbl[3]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl, ParseAction, dwParseFlags, pwzResult, cchResult, pcchResult, dwReserved);
    }

    /// <include file='IInternetProtocolInfo.xml' path='doc/member[@name="IInternetProtocolInfo.CombineUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CombineUrl([NativeTypeName("LPCWSTR")] char* pwzBaseUrl, [NativeTypeName("LPCWSTR")] char* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolInfo*, char*, char*, uint, char*, uint, uint*, uint, int>)(lpVtbl[4]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzBaseUrl, pwzRelativeUrl, dwCombineFlags, pwzResult, cchResult, pcchResult, dwReserved);
    }

    /// <include file='IInternetProtocolInfo.xml' path='doc/member[@name="IInternetProtocolInfo.CompareUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CompareUrl([NativeTypeName("LPCWSTR")] char* pwzUrl1, [NativeTypeName("LPCWSTR")] char* pwzUrl2, [NativeTypeName("DWORD")] uint dwCompareFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolInfo*, char*, char*, uint, int>)(lpVtbl[5]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl1, pwzUrl2, dwCompareFlags);
    }

    /// <include file='IInternetProtocolInfo.xml' path='doc/member[@name="IInternetProtocolInfo.QueryInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueryInfo([NativeTypeName("LPCWSTR")] char* pwzUrl, QUERYOPTION OueryOption, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged[MemberFunction]<IInternetProtocolInfo*, char*, QUERYOPTION, uint, void*, uint, uint*, uint, int>)(lpVtbl[6]))((IInternetProtocolInfo*)Unsafe.AsPointer(ref this), pwzUrl, OueryOption, dwQueryFlags, pBuffer, cbBuffer, pcbBuf, dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ParseUrl([NativeTypeName("LPCWSTR")] char* pwzUrl, PARSEACTION ParseAction, [NativeTypeName("DWORD")] uint dwParseFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(4)]
        HRESULT CombineUrl([NativeTypeName("LPCWSTR")] char* pwzBaseUrl, [NativeTypeName("LPCWSTR")] char* pwzRelativeUrl, [NativeTypeName("DWORD")] uint dwCombineFlags, [NativeTypeName("LPWSTR")] char* pwzResult, [NativeTypeName("DWORD")] uint cchResult, [NativeTypeName("DWORD *")] uint* pcchResult, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(5)]
        HRESULT CompareUrl([NativeTypeName("LPCWSTR")] char* pwzUrl1, [NativeTypeName("LPCWSTR")] char* pwzUrl2, [NativeTypeName("DWORD")] uint dwCompareFlags);

        [VtblIndex(6)]
        HRESULT QueryInfo([NativeTypeName("LPCWSTR")] char* pwzUrl, QUERYOPTION OueryOption, [NativeTypeName("DWORD")] uint dwQueryFlags, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint cbBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD")] uint dwReserved);
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

        [NativeTypeName("HRESULT (LPCWSTR, PARSEACTION, DWORD, LPWSTR, DWORD, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PARSEACTION, uint, char*, uint, uint*, uint, int> ParseUrl;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD, LPWSTR, DWORD, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, char*, uint, uint*, uint, int> CombineUrl;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, int> CompareUrl;

        [NativeTypeName("HRESULT (LPCWSTR, QUERYOPTION, DWORD, LPVOID, DWORD, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, QUERYOPTION, uint, void*, uint, uint*, uint, int> QueryInfo;
    }
}
