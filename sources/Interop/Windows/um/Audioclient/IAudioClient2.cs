// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("726778CD-F60A-4EDA-82DE-E47610CD78AA")]
    [NativeTypeName("struct IAudioClient2 : IAudioClient")]
    [NativeInheritance("IAudioClient")]
    public unsafe partial struct IAudioClient2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioClient2*, Guid*, void**, int>)(lpVtbl[0]))((IAudioClient2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioClient2*, uint>)(lpVtbl[1]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioClient2*, uint>)(lpVtbl[2]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("REFERENCE_TIME")] long hnsBufferDuration, [NativeTypeName("REFERENCE_TIME")] long hnsPeriodicity, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid)
        {
            return ((delegate* unmanaged<IAudioClient2*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int>)(lpVtbl[3]))((IAudioClient2*)Unsafe.AsPointer(ref this), ShareMode, StreamFlags, hnsBufferDuration, hnsPeriodicity, pFormat, AudioSessionGuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetBufferSize([NativeTypeName("UINT32 *")] uint* pNumBufferFrames)
        {
            return ((delegate* unmanaged<IAudioClient2*, uint*, int>)(lpVtbl[4]))((IAudioClient2*)Unsafe.AsPointer(ref this), pNumBufferFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetStreamLatency([NativeTypeName("REFERENCE_TIME *")] long* phnsLatency)
        {
            return ((delegate* unmanaged<IAudioClient2*, long*, int>)(lpVtbl[5]))((IAudioClient2*)Unsafe.AsPointer(ref this), phnsLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetCurrentPadding([NativeTypeName("UINT32 *")] uint* pNumPaddingFrames)
        {
            return ((delegate* unmanaged<IAudioClient2*, uint*, int>)(lpVtbl[6]))((IAudioClient2*)Unsafe.AsPointer(ref this), pNumPaddingFrames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, WAVEFORMATEX** ppClosestMatch)
        {
            return ((delegate* unmanaged<IAudioClient2*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int>)(lpVtbl[7]))((IAudioClient2*)Unsafe.AsPointer(ref this), ShareMode, pFormat, ppClosestMatch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetMixFormat(WAVEFORMATEX** ppDeviceFormat)
        {
            return ((delegate* unmanaged<IAudioClient2*, WAVEFORMATEX**, int>)(lpVtbl[8]))((IAudioClient2*)Unsafe.AsPointer(ref this), ppDeviceFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDevicePeriod([NativeTypeName("REFERENCE_TIME *")] long* phnsDefaultDevicePeriod, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinimumDevicePeriod)
        {
            return ((delegate* unmanaged<IAudioClient2*, long*, long*, int>)(lpVtbl[9]))((IAudioClient2*)Unsafe.AsPointer(ref this), phnsDefaultDevicePeriod, phnsMinimumDevicePeriod);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Start()
        {
            return ((delegate* unmanaged<IAudioClient2*, int>)(lpVtbl[10]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IAudioClient2*, int>)(lpVtbl[11]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IAudioClient2*, int>)(lpVtbl[12]))((IAudioClient2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetEventHandle(HANDLE eventHandle)
        {
            return ((delegate* unmanaged<IAudioClient2*, HANDLE, int>)(lpVtbl[13]))((IAudioClient2*)Unsafe.AsPointer(ref this), eventHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IAudioClient2*, Guid*, void**, int>)(lpVtbl[14]))((IAudioClient2*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT IsOffloadCapable(AUDIO_STREAM_CATEGORY Category, BOOL* pbOffloadCapable)
        {
            return ((delegate* unmanaged<IAudioClient2*, AUDIO_STREAM_CATEGORY, BOOL*, int>)(lpVtbl[15]))((IAudioClient2*)Unsafe.AsPointer(ref this), Category, pbOffloadCapable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetClientProperties([NativeTypeName("const AudioClientProperties *")] AudioClientProperties* pProperties)
        {
            return ((delegate* unmanaged<IAudioClient2*, AudioClientProperties*, int>)(lpVtbl[16]))((IAudioClient2*)Unsafe.AsPointer(ref this), pProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetBufferSizeLimits([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, BOOL bEventDriven, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinBufferDuration, [NativeTypeName("REFERENCE_TIME *")] long* phnsMaxBufferDuration)
        {
            return ((delegate* unmanaged<IAudioClient2*, WAVEFORMATEX*, BOOL, long*, long*, int>)(lpVtbl[17]))((IAudioClient2*)Unsafe.AsPointer(ref this), pFormat, bEventDriven, phnsMinBufferDuration, phnsMaxBufferDuration);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, uint> Release;

            [NativeTypeName("HRESULT (AUDCLNT_SHAREMODE, DWORD, REFERENCE_TIME, REFERENCE_TIME, const WAVEFORMATEX *, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int> Initialize;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, uint*, int> GetBufferSize;

            [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, long*, int> GetStreamLatency;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, uint*, int> GetCurrentPadding;

            [NativeTypeName("HRESULT (AUDCLNT_SHAREMODE, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int> IsFormatSupported;

            [NativeTypeName("HRESULT (WAVEFORMATEX **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, WAVEFORMATEX**, int> GetMixFormat;

            [NativeTypeName("HRESULT (REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, long*, long*, int> GetDevicePeriod;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, int> Start;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, int> Stop;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, int> Reset;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, HANDLE, int> SetEventHandle;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, Guid*, void**, int> GetService;

            [NativeTypeName("HRESULT (AUDIO_STREAM_CATEGORY, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, AUDIO_STREAM_CATEGORY, BOOL*, int> IsOffloadCapable;

            [NativeTypeName("HRESULT (const AudioClientProperties *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, AudioClientProperties*, int> SetClientProperties;

            [NativeTypeName("HRESULT (const WAVEFORMATEX *, BOOL, REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioClient2*, WAVEFORMATEX*, BOOL, long*, long*, int> GetBufferSizeLimits;
        }
    }
}
