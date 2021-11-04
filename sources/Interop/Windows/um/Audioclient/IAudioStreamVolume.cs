// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("93014887-242D-4068-8A15-CF5E93B90FE3")]
    [NativeTypeName("struct IAudioStreamVolume : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioStreamVolume
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioStreamVolume*, Guid*, void**, int>)(lpVtbl[0]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioStreamVolume*, uint>)(lpVtbl[1]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioStreamVolume*, uint>)(lpVtbl[2]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<IAudioStreamVolume*, uint*, int>)(lpVtbl[3]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("const float")] float fLevel)
        {
            return ((delegate* unmanaged<IAudioStreamVolume*, uint, float, int>)(lpVtbl[4]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), dwIndex, fLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, float* pfLevel)
        {
            return ((delegate* unmanaged<IAudioStreamVolume*, uint, float*, int>)(lpVtbl[5]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), dwIndex, pfLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("const float *")] float* pfVolumes)
        {
            return ((delegate* unmanaged<IAudioStreamVolume*, uint, float*, int>)(lpVtbl[6]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, float* pfVolumes)
        {
            return ((delegate* unmanaged<IAudioStreamVolume*, uint, float*, int>)(lpVtbl[7]))((IAudioStreamVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioStreamVolume*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioStreamVolume*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioStreamVolume*, uint> Release;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioStreamVolume*, uint*, int> GetChannelCount;

            [NativeTypeName("HRESULT (UINT32, const float) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioStreamVolume*, uint, float, int> SetChannelVolume;

            [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioStreamVolume*, uint, float*, int> GetChannelVolume;

            [NativeTypeName("HRESULT (UINT32, const float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioStreamVolume*, uint, float*, int> SetAllVolumes;

            [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioStreamVolume*, uint, float*, int> GetAllVolumes;
        }
    }
}
