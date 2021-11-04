// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B63616C-36B2-46BC-959F-C1593952D19B")]
    [NativeTypeName("struct ISyncMgrControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrControl : ISyncMgrControl.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrControl*, uint>)(lpVtbl[1]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrControl*, uint>)(lpVtbl[2]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT StartHandlerSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, HWND hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, HWND, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int>)(lpVtbl[3]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, hwndOwner, punk, nSyncControlFlags, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT StartItemSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, HWND hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort**, uint, HWND, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int>)(lpVtbl[4]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, ppszItemIDs, cItems, hwndOwner, punk, nSyncControlFlags, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT StartSyncAll(HWND hwndOwner)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, HWND, int>)(lpVtbl[5]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT StopHandlerSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, int>)(lpVtbl[6]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT StopItemSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort**, uint, int>)(lpVtbl[7]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, ppszItemIDs, cItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT StopSyncAll()
        {
            return ((delegate* unmanaged<ISyncMgrControl*, int>)(lpVtbl[8]))((ISyncMgrControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT UpdateHandlerCollection([NativeTypeName("const IID &")] Guid* rclsidCollectionID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, Guid*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[9]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), rclsidCollectionID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT UpdateHandler([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[10]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT UpdateItem([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[11]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT UpdateEvents([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[12]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT UpdateConflict([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, ISyncMgrConflict* pConflict, SYNCMGR_UPDATE_REASON nReason)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, ISyncMgrConflict*, SYNCMGR_UPDATE_REASON, int>)(lpVtbl[13]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, pConflict, nReason);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT UpdateConflicts([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[14]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), pszHandlerID, pszItemID, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT ActivateHandler(BOOL fActivate, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, HWND, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[15]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fActivate, pszHandlerID, hwndOwner, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT EnableHandler(BOOL fEnable, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, HWND, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[16]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fEnable, pszHandlerID, hwndOwner, nControlFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT EnableItem(BOOL fEnable, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags)
        {
            return ((delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, ushort*, HWND, SYNCMGR_CONTROL_FLAGS, int>)(lpVtbl[17]))((ISyncMgrControl*)Unsafe.AsPointer(ref this), fEnable, pszHandlerID, pszItemID, hwndOwner, nControlFlags);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT StartHandlerSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, HWND hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult);

            [VtblIndex(4)]
            HRESULT StartItemSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, HWND hwndOwner, IUnknown* punk, SYNCMGR_SYNC_CONTROL_FLAGS nSyncControlFlags, ISyncMgrSyncResult* pResult);

            [VtblIndex(5)]
            HRESULT StartSyncAll(HWND hwndOwner);

            [VtblIndex(6)]
            HRESULT StopHandlerSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID);

            [VtblIndex(7)]
            HRESULT StopItemSync([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems);

            [VtblIndex(8)]
            HRESULT StopSyncAll();

            [VtblIndex(9)]
            HRESULT UpdateHandlerCollection([NativeTypeName("const IID &")] Guid* rclsidCollectionID, SYNCMGR_CONTROL_FLAGS nControlFlags);

            [VtblIndex(10)]
            HRESULT UpdateHandler([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, SYNCMGR_CONTROL_FLAGS nControlFlags);

            [VtblIndex(11)]
            HRESULT UpdateItem([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);

            [VtblIndex(12)]
            HRESULT UpdateEvents([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);

            [VtblIndex(13)]
            HRESULT UpdateConflict([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, ISyncMgrConflict* pConflict, SYNCMGR_UPDATE_REASON nReason);

            [VtblIndex(14)]
            HRESULT UpdateConflicts([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, SYNCMGR_CONTROL_FLAGS nControlFlags);

            [VtblIndex(15)]
            HRESULT ActivateHandler(BOOL fActivate, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);

            [VtblIndex(16)]
            HRESULT EnableHandler(BOOL fEnable, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);

            [VtblIndex(17)]
            HRESULT EnableItem(BOOL fEnable, [NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR")] ushort* pszItemID, HWND hwndOwner, SYNCMGR_CONTROL_FLAGS nControlFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, HWND, IUnknown *, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, HWND, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int> StartHandlerSync;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR *, ULONG, HWND, IUnknown *, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, ushort**, uint, HWND, IUnknown*, SYNCMGR_SYNC_CONTROL_FLAGS, ISyncMgrSyncResult*, int> StartItemSync;

            [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, HWND, int> StartSyncAll;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, int> StopHandlerSync;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR *, ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, ushort**, uint, int> StopItemSync;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, int> StopSyncAll;

            [NativeTypeName("HRESULT (const IID &, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, Guid*, SYNCMGR_CONTROL_FLAGS, int> UpdateHandlerCollection;

            [NativeTypeName("HRESULT (LPCWSTR, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, SYNCMGR_CONTROL_FLAGS, int> UpdateHandler;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int> UpdateItem;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int> UpdateEvents;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, ISyncMgrConflict *, SYNCMGR_UPDATE_REASON) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, ISyncMgrConflict*, SYNCMGR_UPDATE_REASON, int> UpdateConflict;

            [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, ushort*, ushort*, SYNCMGR_CONTROL_FLAGS, int> UpdateConflicts;

            [NativeTypeName("HRESULT (BOOL, LPCWSTR, HWND, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, HWND, SYNCMGR_CONTROL_FLAGS, int> ActivateHandler;

            [NativeTypeName("HRESULT (BOOL, LPCWSTR, HWND, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, HWND, SYNCMGR_CONTROL_FLAGS, int> EnableHandler;

            [NativeTypeName("HRESULT (BOOL, LPCWSTR, LPCWSTR, HWND, SYNCMGR_CONTROL_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ISyncMgrControl*, BOOL, ushort*, ushort*, HWND, SYNCMGR_CONTROL_FLAGS, int> EnableItem;
        }
    }
}
