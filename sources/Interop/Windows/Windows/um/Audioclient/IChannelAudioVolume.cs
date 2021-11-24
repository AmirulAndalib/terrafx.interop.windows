// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("1C158861-B533-4B30-B1CF-E853E51C59B8")]
[NativeTypeName("struct IChannelAudioVolume : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IChannelAudioVolume : IChannelAudioVolume.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IChannelAudioVolume*, Guid*, void**, int>)(lpVtbl[0]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IChannelAudioVolume*, uint>)(lpVtbl[1]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IChannelAudioVolume*, uint>)(lpVtbl[2]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IChannelAudioVolume*, uint*, int>)(lpVtbl[3]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), pdwCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("const float")] float fLevel, [NativeTypeName("LPCGUID")] Guid* EventContext)
    {
        return ((delegate* unmanaged<IChannelAudioVolume*, uint, float, Guid*, int>)(lpVtbl[4]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), dwIndex, fLevel, EventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, float* pfLevel)
    {
        return ((delegate* unmanaged<IChannelAudioVolume*, uint, float*, int>)(lpVtbl[5]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), dwIndex, pfLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("const float *")] float* pfVolumes, [NativeTypeName("LPCGUID")] Guid* EventContext)
    {
        return ((delegate* unmanaged<IChannelAudioVolume*, uint, float*, Guid*, int>)(lpVtbl[6]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes, EventContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, float* pfVolumes)
    {
        return ((delegate* unmanaged<IChannelAudioVolume*, uint, float*, int>)(lpVtbl[7]))((IChannelAudioVolume*)Unsafe.AsPointer(ref this), dwCount, pfVolumes);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount);

        [VtblIndex(4)]
        HRESULT SetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, [NativeTypeName("const float")] float fLevel, [NativeTypeName("LPCGUID")] Guid* EventContext);

        [VtblIndex(5)]
        HRESULT GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, float* pfLevel);

        [VtblIndex(6)]
        HRESULT SetAllVolumes([NativeTypeName("UINT32")] uint dwCount, [NativeTypeName("const float *")] float* pfVolumes, [NativeTypeName("LPCGUID")] Guid* EventContext);

        [VtblIndex(7)]
        HRESULT GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, float* pfVolumes);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IChannelAudioVolume*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IChannelAudioVolume*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IChannelAudioVolume*, uint> Release;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<IChannelAudioVolume*, uint*, int> GetChannelCount;

        [NativeTypeName("HRESULT (UINT32, const float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IChannelAudioVolume*, uint, float, Guid*, int> SetChannelVolume;

        [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IChannelAudioVolume*, uint, float*, int> GetChannelVolume;

        [NativeTypeName("HRESULT (UINT32, const float *, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<IChannelAudioVolume*, uint, float*, Guid*, int> SetAllVolumes;

        [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IChannelAudioVolume*, uint, float*, int> GetAllVolumes;
    }
}
