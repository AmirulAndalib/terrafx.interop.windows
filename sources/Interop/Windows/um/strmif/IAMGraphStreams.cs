// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("632105FA-072E-11D3-8AF9-00C04FB6BD3D")]
    [NativeTypeName("struct IAMGraphStreams : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMGraphStreams
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMGraphStreams*, Guid*, void**, int>)(lpVtbl[0]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMGraphStreams*, uint>)(lpVtbl[1]))((IAMGraphStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMGraphStreams*, uint>)(lpVtbl[2]))((IAMGraphStreams*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT FindUpstreamInterface(IPin* pPin, [NativeTypeName("const IID &")] Guid* riid, void** ppvInterface, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IAMGraphStreams*, IPin*, Guid*, void**, uint, int>)(lpVtbl[3]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), pPin, riid, ppvInterface, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SyncUsingStreamOffset(BOOL bUseStreamOffset)
        {
            return ((delegate* unmanaged<IAMGraphStreams*, BOOL, int>)(lpVtbl[4]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), bUseStreamOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetMaxGraphLatency([NativeTypeName("REFERENCE_TIME")] long rtMaxGraphLatency)
        {
            return ((delegate* unmanaged<IAMGraphStreams*, long, int>)(lpVtbl[5]))((IAMGraphStreams*)Unsafe.AsPointer(ref this), rtMaxGraphLatency);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMGraphStreams*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMGraphStreams*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMGraphStreams*, uint> Release;

            [NativeTypeName("HRESULT (IPin *, const IID &, void **, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMGraphStreams*, IPin*, Guid*, void**, uint, int> FindUpstreamInterface;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMGraphStreams*, BOOL, int> SyncUsingStreamOffset;

            [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMGraphStreams*, long, int> SetMaxGraphLatency;
        }
    }
}
