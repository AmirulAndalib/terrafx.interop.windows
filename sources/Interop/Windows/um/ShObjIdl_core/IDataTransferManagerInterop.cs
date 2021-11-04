// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3A3DCD6C-3EAB-43DC-BCDE-45671CE800C8")]
    [NativeTypeName("struct IDataTransferManagerInterop : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDataTransferManagerInterop
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDataTransferManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataTransferManagerInterop*, uint>)(lpVtbl[1]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataTransferManagerInterop*, uint>)(lpVtbl[2]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** dataTransferManager)
        {
            return ((delegate* unmanaged<IDataTransferManagerInterop*, HWND, Guid*, void**, int>)(lpVtbl[3]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, dataTransferManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ShowShareUIForWindow(HWND appWindow)
        {
            return ((delegate* unmanaged<IDataTransferManagerInterop*, HWND, int>)(lpVtbl[4]))((IDataTransferManagerInterop*)Unsafe.AsPointer(ref this), appWindow);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataTransferManagerInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDataTransferManagerInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDataTransferManagerInterop*, uint> Release;

            [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataTransferManagerInterop*, HWND, Guid*, void**, int> GetForWindow;

            [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataTransferManagerInterop*, HWND, int> ShowShareUIForWindow;
        }
    }
}
