// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F2D1-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLSelectElementEx : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLSelectElementEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLSelectElementEx*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLSelectElementEx*, uint>)(lpVtbl[1]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLSelectElementEx*, uint>)(lpVtbl[2]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ShowDropdown([NativeTypeName("BOOL")] int fShow)
        {
            return ((delegate* unmanaged<IHTMLSelectElementEx*, int, int>)(lpVtbl[3]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelectExFlags([NativeTypeName("DWORD")] uint lFlags)
        {
            return ((delegate* unmanaged<IHTMLSelectElementEx*, uint, int>)(lpVtbl[4]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectExFlags([NativeTypeName("DWORD *")] uint* pFlags)
        {
            return ((delegate* unmanaged<IHTMLSelectElementEx*, uint*, int>)(lpVtbl[5]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), pFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDropdownOpen([NativeTypeName("BOOL *")] int* pfOpen)
        {
            return ((delegate* unmanaged<IHTMLSelectElementEx*, int*, int>)(lpVtbl[6]))((IHTMLSelectElementEx*)Unsafe.AsPointer(ref this), pfOpen);
        }
    }
}