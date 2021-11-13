// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("49FF1172-EADC-446D-9285-156453A6431C")]
    [NativeTypeName("struct IActionProgressDialog : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IActionProgressDialog : IActionProgressDialog.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActionProgressDialog*, Guid*, void**, int>)(lpVtbl[0]))((IActionProgressDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActionProgressDialog*, uint>)(lpVtbl[1]))((IActionProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActionProgressDialog*, uint>)(lpVtbl[2]))((IActionProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize([NativeTypeName("SPINITF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszCancel)
        {
            return ((delegate* unmanaged<IActionProgressDialog*, uint, ushort*, ushort*, int>)(lpVtbl[3]))((IActionProgressDialog*)Unsafe.AsPointer(ref this), flags, pszTitle, pszCancel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Stop()
        {
            return ((delegate* unmanaged<IActionProgressDialog*, int>)(lpVtbl[4]))((IActionProgressDialog*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Initialize([NativeTypeName("SPINITF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszCancel);

            [VtblIndex(4)]
            HRESULT Stop();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IActionProgressDialog*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IActionProgressDialog*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IActionProgressDialog*, uint> Release;

            [NativeTypeName("HRESULT (SPINITF, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IActionProgressDialog*, uint, ushort*, ushort*, int> Initialize;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IActionProgressDialog*, int> Stop;
        }
    }
}
