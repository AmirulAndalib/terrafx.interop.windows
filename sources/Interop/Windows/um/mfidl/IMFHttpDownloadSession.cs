// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71FA9A2C-53CE-4662-A132-1A7E8CBF62DB")]
    [NativeTypeName("struct IMFHttpDownloadSession : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFHttpDownloadSession : IMFHttpDownloadSession.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, uint>)(lpVtbl[1]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, uint>)(lpVtbl[2]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetServer([NativeTypeName("LPCWSTR")] ushort* szServerName, [NativeTypeName("DWORD")] uint nPort)
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, ushort*, uint, int>)(lpVtbl[3]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), szServerName, nPort);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateRequest([NativeTypeName("LPCWSTR")] ushort* szObjectName, BOOL fBypassProxyCache, BOOL fSecure, [NativeTypeName("LPCWSTR")] ushort* szVerb, [NativeTypeName("LPCWSTR")] ushort* szReferrer, IMFHttpDownloadRequest** ppRequest)
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, ushort*, BOOL, BOOL, ushort*, ushort*, IMFHttpDownloadRequest**, int>)(lpVtbl[4]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this), szObjectName, fBypassProxyCache, fSecure, szVerb, szReferrer, ppRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<IMFHttpDownloadSession*, int>)(lpVtbl[5]))((IMFHttpDownloadSession*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetServer([NativeTypeName("LPCWSTR")] ushort* szServerName, [NativeTypeName("DWORD")] uint nPort);

            [VtblIndex(4)]
            HRESULT CreateRequest([NativeTypeName("LPCWSTR")] ushort* szObjectName, BOOL fBypassProxyCache, BOOL fSecure, [NativeTypeName("LPCWSTR")] ushort* szVerb, [NativeTypeName("LPCWSTR")] ushort* szReferrer, IMFHttpDownloadRequest** ppRequest);

            [VtblIndex(5)]
            HRESULT Close();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadSession*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadSession*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadSession*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadSession*, ushort*, uint, int> SetServer;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL, BOOL, LPCWSTR, LPCWSTR, IMFHttpDownloadRequest **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadSession*, ushort*, BOOL, BOOL, ushort*, ushort*, IMFHttpDownloadRequest**, int> CreateRequest;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFHttpDownloadSession*, int> Close;
        }
    }
}
