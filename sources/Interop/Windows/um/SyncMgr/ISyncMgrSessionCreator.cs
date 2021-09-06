// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("17F48517-F305-4321-A08D-B25A834918FD")]
    [NativeTypeName("struct ISyncMgrSessionCreator : IUnknown")]
    public unsafe partial struct ISyncMgrSessionCreator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSessionCreator*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSessionCreator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSessionCreator*, uint>)(lpVtbl[1]))((ISyncMgrSessionCreator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSessionCreator*, uint>)(lpVtbl[2]))((ISyncMgrSessionCreator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSession([NativeTypeName("LPCWSTR")] ushort* pszHandlerID, [NativeTypeName("LPCWSTR *")] ushort** ppszItemIDs, [NativeTypeName("ULONG")] uint cItems, ISyncMgrSyncCallback** ppCallback)
        {
            return ((delegate* unmanaged<ISyncMgrSessionCreator*, ushort*, ushort**, uint, ISyncMgrSyncCallback**, int>)(lpVtbl[3]))((ISyncMgrSessionCreator*)Unsafe.AsPointer(ref this), pszHandlerID, ppszItemIDs, cItems, ppCallback);
        }
    }
}
