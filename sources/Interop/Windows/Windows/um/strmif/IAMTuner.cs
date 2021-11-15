// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("211A8761-03AC-11D1-8D13-00AA00BD8339")]
    [NativeTypeName("struct IAMTuner : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMTuner : IAMTuner.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMTuner*, Guid*, void**, int>)(lpVtbl[0]))((IAMTuner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMTuner*, uint>)(lpVtbl[1]))((IAMTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMTuner*, uint>)(lpVtbl[2]))((IAMTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT put_Channel([NativeTypeName("long")] int lChannel, [NativeTypeName("long")] int lVideoSubChannel, [NativeTypeName("long")] int lAudioSubChannel)
        {
            return ((delegate* unmanaged<IAMTuner*, int, int, int, int>)(lpVtbl[3]))((IAMTuner*)Unsafe.AsPointer(ref this), lChannel, lVideoSubChannel, lAudioSubChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_Channel([NativeTypeName("long *")] int* plChannel, [NativeTypeName("long *")] int* plVideoSubChannel, [NativeTypeName("long *")] int* plAudioSubChannel)
        {
            return ((delegate* unmanaged<IAMTuner*, int*, int*, int*, int>)(lpVtbl[4]))((IAMTuner*)Unsafe.AsPointer(ref this), plChannel, plVideoSubChannel, plAudioSubChannel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ChannelMinMax([NativeTypeName("long *")] int* lChannelMin, [NativeTypeName("long *")] int* lChannelMax)
        {
            return ((delegate* unmanaged<IAMTuner*, int*, int*, int>)(lpVtbl[5]))((IAMTuner*)Unsafe.AsPointer(ref this), lChannelMin, lChannelMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT put_CountryCode([NativeTypeName("long")] int lCountryCode)
        {
            return ((delegate* unmanaged<IAMTuner*, int, int>)(lpVtbl[6]))((IAMTuner*)Unsafe.AsPointer(ref this), lCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_CountryCode([NativeTypeName("long *")] int* plCountryCode)
        {
            return ((delegate* unmanaged<IAMTuner*, int*, int>)(lpVtbl[7]))((IAMTuner*)Unsafe.AsPointer(ref this), plCountryCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_TuningSpace([NativeTypeName("long")] int lTuningSpace)
        {
            return ((delegate* unmanaged<IAMTuner*, int, int>)(lpVtbl[8]))((IAMTuner*)Unsafe.AsPointer(ref this), lTuningSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_TuningSpace([NativeTypeName("long *")] int* plTuningSpace)
        {
            return ((delegate* unmanaged<IAMTuner*, int*, int>)(lpVtbl[9]))((IAMTuner*)Unsafe.AsPointer(ref this), plTuningSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Logon(HANDLE hCurrentUser)
        {
            return ((delegate* unmanaged<IAMTuner*, HANDLE, int>)(lpVtbl[10]))((IAMTuner*)Unsafe.AsPointer(ref this), hCurrentUser);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Logout()
        {
            return ((delegate* unmanaged<IAMTuner*, int>)(lpVtbl[11]))((IAMTuner*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SignalPresent([NativeTypeName("long *")] int* plSignalStrength)
        {
            return ((delegate* unmanaged<IAMTuner*, int*, int>)(lpVtbl[12]))((IAMTuner*)Unsafe.AsPointer(ref this), plSignalStrength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_Mode(AMTunerModeType lMode)
        {
            return ((delegate* unmanaged<IAMTuner*, AMTunerModeType, int>)(lpVtbl[13]))((IAMTuner*)Unsafe.AsPointer(ref this), lMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Mode(AMTunerModeType* plMode)
        {
            return ((delegate* unmanaged<IAMTuner*, AMTunerModeType*, int>)(lpVtbl[14]))((IAMTuner*)Unsafe.AsPointer(ref this), plMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetAvailableModes([NativeTypeName("long *")] int* plModes)
        {
            return ((delegate* unmanaged<IAMTuner*, int*, int>)(lpVtbl[15]))((IAMTuner*)Unsafe.AsPointer(ref this), plModes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT RegisterNotificationCallBack(IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents)
        {
            return ((delegate* unmanaged<IAMTuner*, IAMTunerNotification*, int, int>)(lpVtbl[16]))((IAMTuner*)Unsafe.AsPointer(ref this), pNotify, lEvents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT UnRegisterNotificationCallBack(IAMTunerNotification* pNotify)
        {
            return ((delegate* unmanaged<IAMTuner*, IAMTunerNotification*, int>)(lpVtbl[17]))((IAMTuner*)Unsafe.AsPointer(ref this), pNotify);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT put_Channel([NativeTypeName("long")] int lChannel, [NativeTypeName("long")] int lVideoSubChannel, [NativeTypeName("long")] int lAudioSubChannel);

            [VtblIndex(4)]
            HRESULT get_Channel([NativeTypeName("long *")] int* plChannel, [NativeTypeName("long *")] int* plVideoSubChannel, [NativeTypeName("long *")] int* plAudioSubChannel);

            [VtblIndex(5)]
            HRESULT ChannelMinMax([NativeTypeName("long *")] int* lChannelMin, [NativeTypeName("long *")] int* lChannelMax);

            [VtblIndex(6)]
            HRESULT put_CountryCode([NativeTypeName("long")] int lCountryCode);

            [VtblIndex(7)]
            HRESULT get_CountryCode([NativeTypeName("long *")] int* plCountryCode);

            [VtblIndex(8)]
            HRESULT put_TuningSpace([NativeTypeName("long")] int lTuningSpace);

            [VtblIndex(9)]
            HRESULT get_TuningSpace([NativeTypeName("long *")] int* plTuningSpace);

            [VtblIndex(10)]
            HRESULT Logon(HANDLE hCurrentUser);

            [VtblIndex(11)]
            HRESULT Logout();

            [VtblIndex(12)]
            HRESULT SignalPresent([NativeTypeName("long *")] int* plSignalStrength);

            [VtblIndex(13)]
            HRESULT put_Mode(AMTunerModeType lMode);

            [VtblIndex(14)]
            HRESULT get_Mode(AMTunerModeType* plMode);

            [VtblIndex(15)]
            HRESULT GetAvailableModes([NativeTypeName("long *")] int* plModes);

            [VtblIndex(16)]
            HRESULT RegisterNotificationCallBack(IAMTunerNotification* pNotify, [NativeTypeName("long")] int lEvents);

            [VtblIndex(17)]
            HRESULT UnRegisterNotificationCallBack(IAMTunerNotification* pNotify);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, uint> Release;

            [NativeTypeName("HRESULT (long, long, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int, int, int, int> put_Channel;

            [NativeTypeName("HRESULT (long *, long *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int*, int*, int*, int> get_Channel;

            [NativeTypeName("HRESULT (long *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int*, int*, int> ChannelMinMax;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int, int> put_CountryCode;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int*, int> get_CountryCode;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int, int> put_TuningSpace;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int*, int> get_TuningSpace;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, HANDLE, int> Logon;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int> Logout;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int*, int> SignalPresent;

            [NativeTypeName("HRESULT (AMTunerModeType) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, AMTunerModeType, int> put_Mode;

            [NativeTypeName("HRESULT (AMTunerModeType *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, AMTunerModeType*, int> get_Mode;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, int*, int> GetAvailableModes;

            [NativeTypeName("HRESULT (IAMTunerNotification *, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, IAMTunerNotification*, int, int> RegisterNotificationCallBack;

            [NativeTypeName("HRESULT (IAMTunerNotification *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMTuner*, IAMTunerNotification*, int> UnRegisterNotificationCallBack;
        }
    }
}