// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BA468C55-9956-4FB1-A59D-52A7DD7CC6AA")]
    [NativeTypeName("struct ITfLangBarItemMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfLangBarItemMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint>)(lpVtbl[1]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint>)(lpVtbl[2]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT EnumItems(IEnumTfLangBarItems** ppEnum)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, IEnumTfLangBarItems**, int>)(lpVtbl[3]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* rguid, ITfLangBarItem** ppItem)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, Guid*, ITfLangBarItem**, int>)(lpVtbl[4]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), rguid, ppItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddItem(ITfLangBarItem* punk)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItem*, int>)(lpVtbl[5]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RemoveItem(ITfLangBarItem* punk)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItem*, int>)(lpVtbl[6]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AdviseItemSink(ITfLangBarItemSink* punk, [NativeTypeName("DWORD *")] uint* pdwCookie, [NativeTypeName("const GUID &")] Guid* rguidItem)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItemSink*, uint*, Guid*, int>)(lpVtbl[7]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), punk, pdwCookie, rguidItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT UnadviseItemSink([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, int>)(lpVtbl[8]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetItemFloatingRect([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const GUID &")] Guid* rguid, RECT* prc)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, Guid*, RECT*, int>)(lpVtbl[9]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), dwThreadId, rguid, prc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetItemsStatus([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("const GUID *")] Guid* prgguid, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, Guid*, uint*, int>)(lpVtbl[10]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ulCount, prgguid, pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetItemNum([NativeTypeName("ULONG *")] uint* pulCount)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint*, int>)(lpVtbl[11]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), pulCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetItems([NativeTypeName("ULONG")] uint ulCount, ITfLangBarItem** ppItem, TF_LANGBARITEMINFO* pInfo, [NativeTypeName("DWORD *")] uint* pdwStatus, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, ITfLangBarItem**, TF_LANGBARITEMINFO*, uint*, uint*, int>)(lpVtbl[12]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ulCount, ppItem, pInfo, pdwStatus, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT AdviseItemsSink([NativeTypeName("ULONG")] uint ulCount, ITfLangBarItemSink** ppunk, [NativeTypeName("const GUID *")] Guid* pguidItem, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, ITfLangBarItemSink**, Guid*, uint*, int>)(lpVtbl[13]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ulCount, ppunk, pguidItem, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT UnadviseItemsSink([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarItemMgr*, uint, uint*, int>)(lpVtbl[14]))((ITfLangBarItemMgr*)Unsafe.AsPointer(ref this), ulCount, pdwCookie);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint> Release;

            [NativeTypeName("HRESULT (IEnumTfLangBarItems **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, IEnumTfLangBarItems**, int> EnumItems;

            [NativeTypeName("HRESULT (const GUID &, ITfLangBarItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, Guid*, ITfLangBarItem**, int> GetItem;

            [NativeTypeName("HRESULT (ITfLangBarItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItem*, int> AddItem;

            [NativeTypeName("HRESULT (ITfLangBarItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItem*, int> RemoveItem;

            [NativeTypeName("HRESULT (ITfLangBarItemSink *, DWORD *, const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, ITfLangBarItemSink*, uint*, Guid*, int> AdviseItemSink;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint, int> UnadviseItemSink;

            [NativeTypeName("HRESULT (DWORD, const GUID &, RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint, Guid*, RECT*, int> GetItemFloatingRect;

            [NativeTypeName("HRESULT (ULONG, const GUID *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint, Guid*, uint*, int> GetItemsStatus;

            [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint*, int> GetItemNum;

            [NativeTypeName("HRESULT (ULONG, ITfLangBarItem **, TF_LANGBARITEMINFO *, DWORD *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint, ITfLangBarItem**, TF_LANGBARITEMINFO*, uint*, uint*, int> GetItems;

            [NativeTypeName("HRESULT (ULONG, ITfLangBarItemSink **, const GUID *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint, ITfLangBarItemSink**, Guid*, uint*, int> AdviseItemsSink;

            [NativeTypeName("HRESULT (ULONG, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemMgr*, uint, uint*, int> UnadviseItemsSink;
        }
    }
}
