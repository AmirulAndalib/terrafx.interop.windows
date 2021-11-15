// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("DBF2E947-8E6C-4254-9EEE-7738F71386C9")]
    [NativeTypeName("struct IVirtualSurfaceUpdatesCallbackNative : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVirtualSurfaceUpdatesCallbackNative : IVirtualSurfaceUpdatesCallbackNative.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, Guid*, void**, int>)(lpVtbl[0]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, uint>)(lpVtbl[1]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, uint>)(lpVtbl[2]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT UpdatesNeeded()
        {
            return ((delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, int>)(lpVtbl[3]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT UpdatesNeeded();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, int> UpdatesNeeded;
        }
    }
}