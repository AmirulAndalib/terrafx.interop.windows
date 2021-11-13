// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("9D264146-A94F-4195-9F9F-3BB12CE0C955")]
    [NativeTypeName("struct IViewStateIdentityItem : IRelatedItem")]
    [NativeInheritance("IRelatedItem")]
    public unsafe partial struct IViewStateIdentityItem : IViewStateIdentityItem.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IViewStateIdentityItem*, Guid*, void**, int>)(lpVtbl[0]))((IViewStateIdentityItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IViewStateIdentityItem*, uint>)(lpVtbl[1]))((IViewStateIdentityItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IViewStateIdentityItem*, uint>)(lpVtbl[2]))((IViewStateIdentityItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetItemIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IViewStateIdentityItem*, ITEMIDLIST**, int>)(lpVtbl[3]))((IViewStateIdentityItem*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItem(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IViewStateIdentityItem*, IShellItem**, int>)(lpVtbl[4]))((IViewStateIdentityItem*)Unsafe.AsPointer(ref this), ppsi);
        }

        public interface Interface : IRelatedItem.Interface
        {
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewStateIdentityItem*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IViewStateIdentityItem*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IViewStateIdentityItem*, uint> Release;

            [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewStateIdentityItem*, ITEMIDLIST**, int> GetItemIDList;

            [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IViewStateIdentityItem*, IShellItem**, int> GetItem;
        }
    }
}
