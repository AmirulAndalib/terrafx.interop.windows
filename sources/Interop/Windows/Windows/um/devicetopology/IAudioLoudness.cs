// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("7D8B1437-DD53-4350-9C1B-1EE2890BD938")]
    [NativeTypeName("struct IAudioLoudness : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioLoudness : IAudioLoudness.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioLoudness*, Guid*, void**, int>)(lpVtbl[0]))((IAudioLoudness*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioLoudness*, uint>)(lpVtbl[1]))((IAudioLoudness*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioLoudness*, uint>)(lpVtbl[2]))((IAudioLoudness*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetEnabled(BOOL* pbEnabled)
        {
            return ((delegate* unmanaged<IAudioLoudness*, BOOL*, int>)(lpVtbl[3]))((IAudioLoudness*)Unsafe.AsPointer(ref this), pbEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetEnabled(BOOL bEnable, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioLoudness*, BOOL, Guid*, int>)(lpVtbl[4]))((IAudioLoudness*)Unsafe.AsPointer(ref this), bEnable, pguidEventContext);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetEnabled(BOOL* pbEnabled);

            [VtblIndex(4)]
            HRESULT SetEnabled(BOOL bEnable, [NativeTypeName("LPCGUID")] Guid* pguidEventContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioLoudness*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioLoudness*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioLoudness*, uint> Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioLoudness*, BOOL*, int> GetEnabled;

            [NativeTypeName("HRESULT (BOOL, LPCGUID) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioLoudness*, BOOL, Guid*, int> SetEnabled;
        }
    }
}
