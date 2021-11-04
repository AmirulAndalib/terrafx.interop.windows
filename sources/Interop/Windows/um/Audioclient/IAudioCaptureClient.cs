// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C8ADBD64-E71E-48A0-A4DE-185C395CD317")]
    [NativeTypeName("struct IAudioCaptureClient : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioCaptureClient : IAudioCaptureClient.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioCaptureClient*, Guid*, void**, int>)(lpVtbl[0]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioCaptureClient*, uint>)(lpVtbl[1]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioCaptureClient*, uint>)(lpVtbl[2]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBuffer(byte** ppData, [NativeTypeName("UINT32 *")] uint* pNumFramesToRead, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("UINT64 *")] ulong* pu64DevicePosition, [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition)
        {
            return ((delegate* unmanaged<IAudioCaptureClient*, byte**, uint*, uint*, ulong*, ulong*, int>)(lpVtbl[3]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), ppData, pNumFramesToRead, pdwFlags, pu64DevicePosition, pu64QPCPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ReleaseBuffer([NativeTypeName("UINT32")] uint NumFramesRead)
        {
            return ((delegate* unmanaged<IAudioCaptureClient*, uint, int>)(lpVtbl[4]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), NumFramesRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetNextPacketSize([NativeTypeName("UINT32 *")] uint* pNumFramesInNextPacket)
        {
            return ((delegate* unmanaged<IAudioCaptureClient*, uint*, int>)(lpVtbl[5]))((IAudioCaptureClient*)Unsafe.AsPointer(ref this), pNumFramesInNextPacket);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetBuffer(byte** ppData, [NativeTypeName("UINT32 *")] uint* pNumFramesToRead, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("UINT64 *")] ulong* pu64DevicePosition, [NativeTypeName("UINT64 *")] ulong* pu64QPCPosition);

            [VtblIndex(4)]
            HRESULT ReleaseBuffer([NativeTypeName("UINT32")] uint NumFramesRead);

            [VtblIndex(5)]
            HRESULT GetNextPacketSize([NativeTypeName("UINT32 *")] uint* pNumFramesInNextPacket);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioCaptureClient*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioCaptureClient*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioCaptureClient*, uint> Release;

            [NativeTypeName("HRESULT (BYTE **, UINT32 *, DWORD *, UINT64 *, UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioCaptureClient*, byte**, uint*, uint*, ulong*, ulong*, int> GetBuffer;

            [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioCaptureClient*, uint, int> ReleaseBuffer;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioCaptureClient*, uint*, int> GetNextPacketSize;
        }
    }
}
