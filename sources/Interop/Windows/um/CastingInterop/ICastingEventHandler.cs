// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C79A6CB7-BEBD-47A6-A2AD-4D45AD79C7BC")]
    [NativeTypeName("struct ICastingEventHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICastingEventHandler : ICastingEventHandler.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICastingEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((ICastingEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICastingEventHandler*, uint>)(lpVtbl[1]))((ICastingEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICastingEventHandler*, uint>)(lpVtbl[2]))((ICastingEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnStateChanged(CASTING_CONNECTION_STATE newState)
        {
            return ((delegate* unmanaged<ICastingEventHandler*, CASTING_CONNECTION_STATE, int>)(lpVtbl[3]))((ICastingEventHandler*)Unsafe.AsPointer(ref this), newState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnError(CASTING_CONNECTION_ERROR_STATUS errorStatus, [NativeTypeName("LPCWSTR")] ushort* errorMessage)
        {
            return ((delegate* unmanaged<ICastingEventHandler*, CASTING_CONNECTION_ERROR_STATUS, ushort*, int>)(lpVtbl[4]))((ICastingEventHandler*)Unsafe.AsPointer(ref this), errorStatus, errorMessage);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnStateChanged(CASTING_CONNECTION_STATE newState);

            [VtblIndex(4)]
            HRESULT OnError(CASTING_CONNECTION_ERROR_STATUS errorStatus, [NativeTypeName("LPCWSTR")] ushort* errorMessage);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICastingEventHandler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICastingEventHandler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICastingEventHandler*, uint> Release;

            [NativeTypeName("HRESULT (CASTING_CONNECTION_STATE) __attribute__((stdcall))")]
            public delegate* unmanaged<ICastingEventHandler*, CASTING_CONNECTION_STATE, int> OnStateChanged;

            [NativeTypeName("HRESULT (CASTING_CONNECTION_ERROR_STATUS, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ICastingEventHandler*, CASTING_CONNECTION_ERROR_STATUS, ushort*, int> OnError;
        }
    }
}
