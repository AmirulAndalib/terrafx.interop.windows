// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("8FEED468-6F7E-440D-869A-49BDD283AD0D")]
    [NativeTypeName("struct IMFSampleOutputStream : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSampleOutputStream : IMFSampleOutputStream.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSampleOutputStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSampleOutputStream*, uint>)(lpVtbl[1]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSampleOutputStream*, uint>)(lpVtbl[2]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT BeginWriteSample(IMFSample* pSample, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFSampleOutputStream*, IMFSample*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), pSample, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EndWriteSample(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFSampleOutputStream*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<IMFSampleOutputStream*, int>)(lpVtbl[5]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT BeginWriteSample(IMFSample* pSample, IMFAsyncCallback* pCallback, IUnknown* punkState);

            [VtblIndex(4)]
            HRESULT EndWriteSample(IMFAsyncResult* pResult);

            [VtblIndex(5)]
            HRESULT Close();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleOutputStream*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleOutputStream*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleOutputStream*, uint> Release;

            [NativeTypeName("HRESULT (IMFSample *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleOutputStream*, IMFSample*, IMFAsyncCallback*, IUnknown*, int> BeginWriteSample;

            [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleOutputStream*, IMFAsyncResult*, int> EndWriteSample;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSampleOutputStream*, int> Close;
        }
    }
}
