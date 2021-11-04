// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72D6135B-35E9-412C-B926-FD5265F2A885")]
    [NativeTypeName("struct IMFCaptureSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFCaptureSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCaptureSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFCaptureSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCaptureSink*, uint>)(lpVtbl[1]))((IMFCaptureSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCaptureSink*, uint>)(lpVtbl[2]))((IMFCaptureSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetOutputMediaType([NativeTypeName("DWORD")] uint dwSinkStreamIndex, IMFMediaType** ppMediaType)
        {
            return ((delegate* unmanaged<IMFCaptureSink*, uint, IMFMediaType**, int>)(lpVtbl[3]))((IMFCaptureSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetService([NativeTypeName("DWORD")] uint dwSinkStreamIndex, [NativeTypeName("const GUID &")] Guid* rguidService, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppUnknown)
        {
            return ((delegate* unmanaged<IMFCaptureSink*, uint, Guid*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IMFCaptureSink*)Unsafe.AsPointer(ref this), dwSinkStreamIndex, rguidService, riid, ppUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddStream([NativeTypeName("DWORD")] uint dwSourceStreamIndex, IMFMediaType* pMediaType, IMFAttributes* pAttributes, [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex)
        {
            return ((delegate* unmanaged<IMFCaptureSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int>)(lpVtbl[5]))((IMFCaptureSink*)Unsafe.AsPointer(ref this), dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Prepare()
        {
            return ((delegate* unmanaged<IMFCaptureSink*, int>)(lpVtbl[6]))((IMFCaptureSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RemoveAllStreams()
        {
            return ((delegate* unmanaged<IMFCaptureSink*, int>)(lpVtbl[7]))((IMFCaptureSink*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSink*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSink*, uint, IMFMediaType**, int> GetOutputMediaType;

            [NativeTypeName("HRESULT (DWORD, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSink*, uint, Guid*, Guid*, IUnknown**, int> GetService;

            [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFAttributes *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSink*, uint, IMFMediaType*, IMFAttributes*, uint*, int> AddStream;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSink*, int> Prepare;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCaptureSink*, int> RemoveAllStreams;
        }
    }
}
