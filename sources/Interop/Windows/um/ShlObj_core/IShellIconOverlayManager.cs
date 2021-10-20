// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F10B5E34-DD3B-42A7-AA7D-2F4EC54BB09B")]
    [NativeTypeName("struct IShellIconOverlayManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellIconOverlayManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, Guid*, void**, int>)(lpVtbl[0]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, uint>)(lpVtbl[1]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, uint>)(lpVtbl[2]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileOverlayInfo([NativeTypeName("PCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwAttrib, int* pIndex, [NativeTypeName("DWORD")] uint dwflags)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, ushort*, uint, int*, uint, int>)(lpVtbl[3]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), pwszPath, dwAttrib, pIndex, dwflags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetReservedOverlayInfo([NativeTypeName("PCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwAttrib, int* pIndex, [NativeTypeName("DWORD")] uint dwflags, int iReservedID)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, ushort*, uint, int*, uint, int, int>)(lpVtbl[4]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), pwszPath, dwAttrib, pIndex, dwflags, iReservedID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RefreshOverlayImages([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, uint, int>)(lpVtbl[5]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int LoadNonloadedOverlayIdentifiers()
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, int>)(lpVtbl[6]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int OverlayIndexFromImageIndex(int iImage, int* piIndex, [NativeTypeName("BOOL")] int fAdd)
        {
            return ((delegate* unmanaged<IShellIconOverlayManager*, int, int*, int, int>)(lpVtbl[7]))((IShellIconOverlayManager*)Unsafe.AsPointer(ref this), iImage, piIndex, fAdd);
        }
    }
}