// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C02216F6-8C67-4B5B-9D00-D008E73E0064")]
    [NativeTypeName("struct IAudioMeterInformation : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioMeterInformation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioMeterInformation*, Guid*, void**, int>)(lpVtbl[0]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioMeterInformation*, uint>)(lpVtbl[1]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioMeterInformation*, uint>)(lpVtbl[2]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPeakValue(float* pfPeak)
        {
            return ((delegate* unmanaged<IAudioMeterInformation*, float*, int>)(lpVtbl[3]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pfPeak);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMeteringChannelCount(uint* pnChannelCount)
        {
            return ((delegate* unmanaged<IAudioMeterInformation*, uint*, int>)(lpVtbl[4]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pnChannelCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetChannelsPeakValues([NativeTypeName("UINT32")] uint u32ChannelCount, float* afPeakValues)
        {
            return ((delegate* unmanaged<IAudioMeterInformation*, uint, float*, int>)(lpVtbl[5]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), u32ChannelCount, afPeakValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT QueryHardwareSupport([NativeTypeName("DWORD *")] uint* pdwHardwareSupportMask)
        {
            return ((delegate* unmanaged<IAudioMeterInformation*, uint*, int>)(lpVtbl[6]))((IAudioMeterInformation*)Unsafe.AsPointer(ref this), pdwHardwareSupportMask);
        }
    }
}
