// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("BB420AA4-765B-4A1F-91FE-D6A8A143924C")]
    [NativeTypeName("struct IMFByteStreamHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFByteStreamHandler : IMFByteStreamHandler.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFByteStreamHandler*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFByteStreamHandler*, uint>)(lpVtbl[1]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFByteStreamHandler*, uint>)(lpVtbl[2]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT BeginCreateObject(IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFByteStreamHandler*, IMFByteStream*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), pByteStream, pwszURL, dwFlags, pProps, ppIUnknownCancelCookie, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EndCreateObject(IMFAsyncResult* pResult, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFByteStreamHandler*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int>)(lpVtbl[4]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), pResult, pObjectType, ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CancelObjectCreation(IUnknown* pIUnknownCancelCookie)
        {
            return ((delegate* unmanaged<IMFByteStreamHandler*, IUnknown*, int>)(lpVtbl[5]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), pIUnknownCancelCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetMaxNumberOfBytesRequiredForResolution([NativeTypeName("QWORD *")] ulong* pqwBytes)
        {
            return ((delegate* unmanaged<IMFByteStreamHandler*, ulong*, int>)(lpVtbl[6]))((IMFByteStreamHandler*)Unsafe.AsPointer(ref this), pqwBytes);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT BeginCreateObject(IMFByteStream* pByteStream, [NativeTypeName("LPCWSTR")] ushort* pwszURL, [NativeTypeName("DWORD")] uint dwFlags, IPropertyStore* pProps, IUnknown** ppIUnknownCancelCookie, IMFAsyncCallback* pCallback, IUnknown* punkState);

            [VtblIndex(4)]
            HRESULT EndCreateObject(IMFAsyncResult* pResult, MF_OBJECT_TYPE* pObjectType, IUnknown** ppObject);

            [VtblIndex(5)]
            HRESULT CancelObjectCreation(IUnknown* pIUnknownCancelCookie);

            [VtblIndex(6)]
            HRESULT GetMaxNumberOfBytesRequiredForResolution([NativeTypeName("QWORD *")] ulong* pqwBytes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamHandler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamHandler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamHandler*, uint> Release;

            [NativeTypeName("HRESULT (IMFByteStream *, LPCWSTR, DWORD, IPropertyStore *, IUnknown **, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamHandler*, IMFByteStream*, ushort*, uint, IPropertyStore*, IUnknown**, IMFAsyncCallback*, IUnknown*, int> BeginCreateObject;

            [NativeTypeName("HRESULT (IMFAsyncResult *, MF_OBJECT_TYPE *, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamHandler*, IMFAsyncResult*, MF_OBJECT_TYPE*, IUnknown**, int> EndCreateObject;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamHandler*, IUnknown*, int> CancelObjectCreation;

            [NativeTypeName("HRESULT (QWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamHandler*, ulong*, int> GetMaxNumberOfBytesRequiredForResolution;
        }
    }
}
