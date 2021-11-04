// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("332E5848-2E15-458E-85C4-C911C0C3D6F4")]
    [NativeTypeName("struct IRandomAccessStreamFileAccessMode : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRandomAccessStreamFileAccessMode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRandomAccessStreamFileAccessMode*, Guid*, void**, int>)(lpVtbl[0]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint>)(lpVtbl[1]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint>)(lpVtbl[2]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetMode([NativeTypeName("DWORD *")] uint* fileAccessMode)
        {
            return ((delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint*, int>)(lpVtbl[3]))((IRandomAccessStreamFileAccessMode*)Unsafe.AsPointer(ref this), fileAccessMode);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRandomAccessStreamFileAccessMode*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRandomAccessStreamFileAccessMode*, uint*, int> GetMode;
        }
    }
}
