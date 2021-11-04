// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("994E23AF-1CC2-493C-B9FA-46F1CB040FA4")]
    [NativeTypeName("struct IMFPMPServer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFPMPServer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPMPServer*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPServer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPMPServer*, uint>)(lpVtbl[1]))((IMFPMPServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPMPServer*, uint>)(lpVtbl[2]))((IMFPMPServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT LockProcess()
        {
            return ((delegate* unmanaged<IMFPMPServer*, int>)(lpVtbl[3]))((IMFPMPServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnlockProcess()
        {
            return ((delegate* unmanaged<IMFPMPServer*, int>)(lpVtbl[4]))((IMFPMPServer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateObjectByCLSID([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const IID &")] Guid* riid, void** ppObject)
        {
            return ((delegate* unmanaged<IMFPMPServer*, Guid*, Guid*, void**, int>)(lpVtbl[5]))((IMFPMPServer*)Unsafe.AsPointer(ref this), clsid, riid, ppObject);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPServer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPServer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPServer*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPServer*, int> LockProcess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPServer*, int> UnlockProcess;

            [NativeTypeName("HRESULT (const IID &, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFPMPServer*, Guid*, Guid*, void**, int> CreateObjectByCLSID;
        }
    }
}
