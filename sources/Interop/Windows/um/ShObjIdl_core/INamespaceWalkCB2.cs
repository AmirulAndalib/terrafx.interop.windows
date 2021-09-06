// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7AC7492B-C38E-438A-87DB-68737844FF70")]
    [NativeTypeName("struct INamespaceWalkCB2 : INamespaceWalkCB")]
    public unsafe partial struct INamespaceWalkCB2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INamespaceWalkCB2*, Guid*, void**, int>)(lpVtbl[0]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INamespaceWalkCB2*, uint>)(lpVtbl[1]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INamespaceWalkCB2*, uint>)(lpVtbl[2]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FoundItem(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<INamespaceWalkCB2*, IShellFolder*, ITEMIDLIST*, int>)(lpVtbl[3]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), psf, pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnterFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<INamespaceWalkCB2*, IShellFolder*, ITEMIDLIST*, int>)(lpVtbl[4]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), psf, pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LeaveFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<INamespaceWalkCB2*, IShellFolder*, ITEMIDLIST*, int>)(lpVtbl[5]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), psf, pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeProgressDialog([NativeTypeName("LPWSTR *")] ushort** ppszTitle, [NativeTypeName("LPWSTR *")] ushort** ppszCancel)
        {
            return ((delegate* unmanaged<INamespaceWalkCB2*, ushort**, ushort**, int>)(lpVtbl[6]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), ppszTitle, ppszCancel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WalkComplete([NativeTypeName("HRESULT")] int hr)
        {
            return ((delegate* unmanaged<INamespaceWalkCB2*, int, int>)(lpVtbl[7]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), hr);
        }
    }
}
