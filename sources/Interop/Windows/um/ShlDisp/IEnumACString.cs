// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8E74C210-CF9D-4EAF-A403-7356428F0A5A")]
    [NativeTypeName("struct IEnumACString : IEnumString")]
    [NativeInheritance("IEnumString")]
    public unsafe partial struct IEnumACString
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumACString*, Guid*, void**, int>)(lpVtbl[0]))((IEnumACString*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumACString*, uint>)(lpVtbl[1]))((IEnumACString*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumACString*, uint>)(lpVtbl[2]))((IEnumACString*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLESTR *")] ushort** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumACString*, uint, ushort**, uint*, int>)(lpVtbl[3]))((IEnumACString*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumACString*, uint, int>)(lpVtbl[4]))((IEnumACString*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumACString*, int>)(lpVtbl[5]))((IEnumACString*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumString** ppenum)
        {
            return ((delegate* unmanaged<IEnumACString*, IEnumString**, int>)(lpVtbl[6]))((IEnumACString*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int NextItem([NativeTypeName("LPWSTR")] ushort* pszUrl, [NativeTypeName("ULONG")] uint cchMax, [NativeTypeName("ULONG *")] uint* pulSortIndex)
        {
            return ((delegate* unmanaged<IEnumACString*, ushort*, uint, uint*, int>)(lpVtbl[7]))((IEnumACString*)Unsafe.AsPointer(ref this), pszUrl, cchMax, pulSortIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetEnumOptions([NativeTypeName("DWORD")] uint dwOptions)
        {
            return ((delegate* unmanaged<IEnumACString*, uint, int>)(lpVtbl[8]))((IEnumACString*)Unsafe.AsPointer(ref this), dwOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumOptions([NativeTypeName("DWORD *")] uint* pdwOptions)
        {
            return ((delegate* unmanaged<IEnumACString*, uint*, int>)(lpVtbl[9]))((IEnumACString*)Unsafe.AsPointer(ref this), pdwOptions);
        }
    }
}