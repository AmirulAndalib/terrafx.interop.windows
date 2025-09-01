// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback"]/*' />
[Guid("884CCD87-B139-4937-A4BA-4F8E19513FBE")]
[NativeTypeName("struct ISyncMgrSyncCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSyncCallback : ISyncMgrSyncCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISyncMgrSyncCallback);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, uint>)(lpVtbl[1]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, uint>)(lpVtbl[2]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.ReportProgress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportProgress([NativeTypeName("LPCWSTR")] char* pszItemID, [NativeTypeName("LPCWSTR")] char* pszProgressText, SYNCMGR_PROGRESS_STATUS nStatus, [NativeTypeName("ULONG")] uint uCurrentStep, [NativeTypeName("ULONG")] uint uMaxStep, SYNCMGR_CANCEL_REQUEST* pnCancelRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, char*, char*, SYNCMGR_PROGRESS_STATUS, uint, uint, SYNCMGR_CANCEL_REQUEST*, int>)(lpVtbl[3]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID, pszProgressText, nStatus, uCurrentStep, uMaxStep, pnCancelRequest);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.SetHandlerProgressText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetHandlerProgressText([NativeTypeName("LPCWSTR")] char* pszProgressText, SYNCMGR_CANCEL_REQUEST* pnCancelRequest)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, char*, SYNCMGR_CANCEL_REQUEST*, int>)(lpVtbl[4]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszProgressText, pnCancelRequest);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.ReportEventW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReportEventW([NativeTypeName("LPCWSTR")] char* pszItemID, SYNCMGR_EVENT_LEVEL nLevel, SYNCMGR_EVENT_FLAGS nFlags, [NativeTypeName("LPCWSTR")] char* pszName, [NativeTypeName("LPCWSTR")] char* pszDescription, [NativeTypeName("LPCWSTR")] char* pszLinkText, [NativeTypeName("LPCWSTR")] char* pszLinkReference, [NativeTypeName("LPCWSTR")] char* pszContext, Guid* pguidEventID)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, char*, SYNCMGR_EVENT_LEVEL, SYNCMGR_EVENT_FLAGS, char*, char*, char*, char*, char*, Guid*, int>)(lpVtbl[5]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID, nLevel, nFlags, pszName, pszDescription, pszLinkText, pszLinkReference, pszContext, pguidEventID);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.CanContinue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CanContinue([NativeTypeName("LPCWSTR")] char* pszItemID)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, char*, int>)(lpVtbl[6]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.QueryForAdditionalItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT QueryForAdditionalItems(IEnumString** ppenumItemIDs, IEnumUnknown** ppenumPunks)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, IEnumString**, IEnumUnknown**, int>)(lpVtbl[7]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), ppenumItemIDs, ppenumPunks);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.AddItemToSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddItemToSession([NativeTypeName("LPCWSTR")] char* pszItemID)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, char*, int>)(lpVtbl[8]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.AddIUnknownToSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddIUnknownToSession(IUnknown* punk)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, IUnknown*, int>)(lpVtbl[9]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.ProposeItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ProposeItem(ISyncMgrSyncItem* pNewItem)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, ISyncMgrSyncItem*, int>)(lpVtbl[10]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pNewItem);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.CommitItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CommitItem([NativeTypeName("LPCWSTR")] char* pszItemID)
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, char*, int>)(lpVtbl[11]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this), pszItemID);
    }

    /// <include file='ISyncMgrSyncCallback.xml' path='doc/member[@name="ISyncMgrSyncCallback.ReportManualSync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReportManualSync()
    {
        return ((delegate* unmanaged[MemberFunction]<ISyncMgrSyncCallback*, int>)(lpVtbl[12]))((ISyncMgrSyncCallback*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReportProgress([NativeTypeName("LPCWSTR")] char* pszItemID, [NativeTypeName("LPCWSTR")] char* pszProgressText, SYNCMGR_PROGRESS_STATUS nStatus, [NativeTypeName("ULONG")] uint uCurrentStep, [NativeTypeName("ULONG")] uint uMaxStep, SYNCMGR_CANCEL_REQUEST* pnCancelRequest);

        [VtblIndex(4)]
        HRESULT SetHandlerProgressText([NativeTypeName("LPCWSTR")] char* pszProgressText, SYNCMGR_CANCEL_REQUEST* pnCancelRequest);

        [VtblIndex(5)]
        HRESULT ReportEventW([NativeTypeName("LPCWSTR")] char* pszItemID, SYNCMGR_EVENT_LEVEL nLevel, SYNCMGR_EVENT_FLAGS nFlags, [NativeTypeName("LPCWSTR")] char* pszName, [NativeTypeName("LPCWSTR")] char* pszDescription, [NativeTypeName("LPCWSTR")] char* pszLinkText, [NativeTypeName("LPCWSTR")] char* pszLinkReference, [NativeTypeName("LPCWSTR")] char* pszContext, Guid* pguidEventID);

        [VtblIndex(6)]
        HRESULT CanContinue([NativeTypeName("LPCWSTR")] char* pszItemID);

        [VtblIndex(7)]
        HRESULT QueryForAdditionalItems(IEnumString** ppenumItemIDs, IEnumUnknown** ppenumPunks);

        [VtblIndex(8)]
        HRESULT AddItemToSession([NativeTypeName("LPCWSTR")] char* pszItemID);

        [VtblIndex(9)]
        HRESULT AddIUnknownToSession(IUnknown* punk);

        [VtblIndex(10)]
        HRESULT ProposeItem(ISyncMgrSyncItem* pNewItem);

        [VtblIndex(11)]
        HRESULT CommitItem([NativeTypeName("LPCWSTR")] char* pszItemID);

        [VtblIndex(12)]
        HRESULT ReportManualSync();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, SYNCMGR_PROGRESS_STATUS, ULONG, ULONG, SYNCMGR_CANCEL_REQUEST *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, SYNCMGR_PROGRESS_STATUS, uint, uint, SYNCMGR_CANCEL_REQUEST*, int> ReportProgress;

        [NativeTypeName("HRESULT (LPCWSTR, SYNCMGR_CANCEL_REQUEST *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, SYNCMGR_CANCEL_REQUEST*, int> SetHandlerProgressText;

        [NativeTypeName("HRESULT (LPCWSTR, SYNCMGR_EVENT_LEVEL, SYNCMGR_EVENT_FLAGS, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, SYNCMGR_EVENT_LEVEL, SYNCMGR_EVENT_FLAGS, char*, char*, char*, char*, char*, Guid*, int> ReportEventW;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> CanContinue;

        [NativeTypeName("HRESULT (IEnumString **, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumString**, IEnumUnknown**, int> QueryForAdditionalItems;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> AddItemToSession;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, int> AddIUnknownToSession;

        [NativeTypeName("HRESULT (ISyncMgrSyncItem *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISyncMgrSyncItem*, int> ProposeItem;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> CommitItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReportManualSync;
    }
}
