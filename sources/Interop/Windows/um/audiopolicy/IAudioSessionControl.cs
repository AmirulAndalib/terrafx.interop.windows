// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F4B1A599-7266-4319-A8CA-E70ACB11E8CD")]
    [NativeTypeName("struct IAudioSessionControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioSessionControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioSessionControl*, uint>)(lpVtbl[1]))((IAudioSessionControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioSessionControl*, uint>)(lpVtbl[2]))((IAudioSessionControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetState(AudioSessionState* pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, AudioSessionState*, int>)(lpVtbl[3]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, ushort**, int>)(lpVtbl[4]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* Value, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, ushort*, Guid*, int>)(lpVtbl[5]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), Value, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, ushort**, int>)(lpVtbl[6]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* Value, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, ushort*, Guid*, int>)(lpVtbl[7]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), Value, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetGroupingParam(Guid* pRetVal)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, Guid*, int>)(lpVtbl[8]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetGroupingParam([NativeTypeName("LPCGUID")] Guid* Override, [NativeTypeName("LPCGUID")] Guid* EventContext)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, Guid*, Guid*, int>)(lpVtbl[9]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), Override, EventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT RegisterAudioSessionNotification(IAudioSessionEvents* NewNotifications)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, IAudioSessionEvents*, int>)(lpVtbl[10]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), NewNotifications);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT UnregisterAudioSessionNotification(IAudioSessionEvents* NewNotifications)
        {
            return ((delegate* unmanaged<IAudioSessionControl*, IAudioSessionEvents*, int>)(lpVtbl[11]))((IAudioSessionControl*)Unsafe.AsPointer(ref this), NewNotifications);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, uint> Release;

            [NativeTypeName("HRESULT (AudioSessionState *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, AudioSessionState*, int> GetState;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, ushort**, int> GetDisplayName;

            [NativeTypeName("HRESULT (LPCWSTR, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, ushort*, Guid*, int> SetDisplayName;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, ushort**, int> GetIconPath;

            [NativeTypeName("HRESULT (LPCWSTR, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, ushort*, Guid*, int> SetIconPath;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, Guid*, int> GetGroupingParam;

            [NativeTypeName("HRESULT (LPCGUID, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, Guid*, Guid*, int> SetGroupingParam;

            [NativeTypeName("HRESULT (IAudioSessionEvents *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, IAudioSessionEvents*, int> RegisterAudioSessionNotification;

            [NativeTypeName("HRESULT (IAudioSessionEvents *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioSessionControl*, IAudioSessionEvents*, int> UnregisterAudioSessionNotification;
        }
    }
}
