// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFHttpDownloadSession.xml' path='doc/member[@name="IMFHttpDownloadSession"]/*' />
[Guid("71FA9A2C-53CE-4662-A132-1A7E8CBF62DB")]
[NativeTypeName("struct IMFHttpDownloadSession : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFHttpDownloadSession : IMFHttpDownloadSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMFHttpDownloadSession);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFHttpDownloadSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFHttpDownloadSession*, uint>)(lpVtbl[1]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFHttpDownloadSession*, uint>)(lpVtbl[2]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFHttpDownloadSession.xml' path='doc/member[@name="IMFHttpDownloadSession.SetServer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetServer([NativeTypeName("LPCWSTR")] char* szServerName, [NativeTypeName("DWORD")] uint nPort)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFHttpDownloadSession*, char*, uint, int>)(lpVtbl[3]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), szServerName, nPort);
    }

    /// <include file='IMFHttpDownloadSession.xml' path='doc/member[@name="IMFHttpDownloadSession.CreateRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateRequest([NativeTypeName("LPCWSTR")] char* szObjectName, BOOL fBypassProxyCache, BOOL fSecure, [NativeTypeName("LPCWSTR")] char* szVerb, [NativeTypeName("LPCWSTR")] char* szReferrer, IMFHttpDownloadRequest** ppRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFHttpDownloadSession*, char*, BOOL, BOOL, char*, char*, IMFHttpDownloadRequest**, int>)(lpVtbl[4]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), szObjectName, fBypassProxyCache, fSecure, szVerb, szReferrer, ppRequest);
    }

    /// <include file='IMFHttpDownloadSession.xml' path='doc/member[@name="IMFHttpDownloadSession.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFHttpDownloadSession*, int>)(lpVtbl[5]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetServer([NativeTypeName("LPCWSTR")] char* szServerName, [NativeTypeName("DWORD")] uint nPort);

        [VtblIndex(4)]
        HRESULT CreateRequest([NativeTypeName("LPCWSTR")] char* szObjectName, BOOL fBypassProxyCache, BOOL fSecure, [NativeTypeName("LPCWSTR")] char* szVerb, [NativeTypeName("LPCWSTR")] char* szReferrer, IMFHttpDownloadRequest** ppRequest);

        [VtblIndex(5)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> SetServer;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL, BOOL, LPCWSTR, LPCWSTR, IMFHttpDownloadRequest **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL, BOOL, char*, char*, IMFHttpDownloadRequest**, int> CreateRequest;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Close;
    }
}
