// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDebugCallbackNotificationHandler.xml' path='doc/member[@name="IDebugCallbackNotificationHandler"]/*' />
[Guid("30510842-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDebugCallbackNotificationHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDebugCallbackNotificationHandler : IDebugCallbackNotificationHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDebugCallbackNotificationHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, uint>)(lpVtbl[1]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, uint>)(lpVtbl[2]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDebugCallbackNotificationHandler.xml' path='doc/member[@name="IDebugCallbackNotificationHandler.RequestedCallbackTypes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RequestedCallbackTypes([NativeTypeName("DWORD *")] uint* pCallbackMask)
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, uint*, int>)(lpVtbl[3]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pCallbackMask);
    }

    /// <include file='IDebugCallbackNotificationHandler.xml' path='doc/member[@name="IDebugCallbackNotificationHandler.BeforeDispatchEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeforeDispatchEvent(IUnknown* pEvent)
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, IUnknown*, int>)(lpVtbl[4]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pEvent);
    }

    /// <include file='IDebugCallbackNotificationHandler.xml' path='doc/member[@name="IDebugCallbackNotificationHandler.DispatchEventComplete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DispatchEventComplete(IUnknown* pEvent, [NativeTypeName("DWORD")] uint propagationStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, IUnknown*, uint, int>)(lpVtbl[5]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pEvent, propagationStatus);
    }

    /// <include file='IDebugCallbackNotificationHandler.xml' path='doc/member[@name="IDebugCallbackNotificationHandler.BeforeInvokeDomCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BeforeInvokeDomCallback(IUnknown* pEvent, IScriptEventHandler* pCallback, DOM_EVENT_PHASE eStage, [NativeTypeName("DWORD")] uint propagationStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, IUnknown*, IScriptEventHandler*, DOM_EVENT_PHASE, uint, int>)(lpVtbl[6]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pEvent, pCallback, eStage, propagationStatus);
    }

    /// <include file='IDebugCallbackNotificationHandler.xml' path='doc/member[@name="IDebugCallbackNotificationHandler.InvokeDomCallbackComplete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InvokeDomCallbackComplete(IUnknown* pEvent, IScriptEventHandler* pCallback, DOM_EVENT_PHASE eStage, [NativeTypeName("DWORD")] uint propagationStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, IUnknown*, IScriptEventHandler*, DOM_EVENT_PHASE, uint, int>)(lpVtbl[7]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), pEvent, pCallback, eStage, propagationStatus);
    }

    /// <include file='IDebugCallbackNotificationHandler.xml' path='doc/member[@name="IDebugCallbackNotificationHandler.BeforeInvokeCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BeforeInvokeCallback(SCRIPT_TIMER_TYPE eCallbackType, [NativeTypeName("DWORD")] uint callbackCookie, IDispatch* pDispHandler, [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie, [NativeTypeName("BSTR")] char* functionName, [NativeTypeName("UINT32")] uint line, [NativeTypeName("UINT32")] uint column, [NativeTypeName("UINT32")] uint cchLength, IUnknown* pDebugDocumentContext)
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, SCRIPT_TIMER_TYPE, uint, IDispatch*, ulong, char*, uint, uint, uint, IUnknown*, int>)(lpVtbl[8]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), eCallbackType, callbackCookie, pDispHandler, ullHandlerCookie, functionName, line, column, cchLength, pDebugDocumentContext);
    }

    /// <include file='IDebugCallbackNotificationHandler.xml' path='doc/member[@name="IDebugCallbackNotificationHandler.InvokeCallbackComplete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvokeCallbackComplete(SCRIPT_TIMER_TYPE eCallbackType, [NativeTypeName("DWORD")] uint callbackCookie, IDispatch* pDispHandler, [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie, [NativeTypeName("BSTR")] char* functionName, [NativeTypeName("UINT32")] uint line, [NativeTypeName("UINT32")] uint column, [NativeTypeName("UINT32")] uint cchLength, IUnknown* pDebugDocumentContext)
    {
        return ((delegate* unmanaged[MemberFunction]<IDebugCallbackNotificationHandler*, SCRIPT_TIMER_TYPE, uint, IDispatch*, ulong, char*, uint, uint, uint, IUnknown*, int>)(lpVtbl[9]))((IDebugCallbackNotificationHandler*)Unsafe.AsPointer(ref this), eCallbackType, callbackCookie, pDispHandler, ullHandlerCookie, functionName, line, column, cchLength, pDebugDocumentContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RequestedCallbackTypes([NativeTypeName("DWORD *")] uint* pCallbackMask);

        [VtblIndex(4)]
        HRESULT BeforeDispatchEvent(IUnknown* pEvent);

        [VtblIndex(5)]
        HRESULT DispatchEventComplete(IUnknown* pEvent, [NativeTypeName("DWORD")] uint propagationStatus);

        [VtblIndex(6)]
        HRESULT BeforeInvokeDomCallback(IUnknown* pEvent, IScriptEventHandler* pCallback, DOM_EVENT_PHASE eStage, [NativeTypeName("DWORD")] uint propagationStatus);

        [VtblIndex(7)]
        HRESULT InvokeDomCallbackComplete(IUnknown* pEvent, IScriptEventHandler* pCallback, DOM_EVENT_PHASE eStage, [NativeTypeName("DWORD")] uint propagationStatus);

        [VtblIndex(8)]
        HRESULT BeforeInvokeCallback(SCRIPT_TIMER_TYPE eCallbackType, [NativeTypeName("DWORD")] uint callbackCookie, IDispatch* pDispHandler, [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie, [NativeTypeName("BSTR")] char* functionName, [NativeTypeName("UINT32")] uint line, [NativeTypeName("UINT32")] uint column, [NativeTypeName("UINT32")] uint cchLength, IUnknown* pDebugDocumentContext);

        [VtblIndex(9)]
        HRESULT InvokeCallbackComplete(SCRIPT_TIMER_TYPE eCallbackType, [NativeTypeName("DWORD")] uint callbackCookie, IDispatch* pDispHandler, [NativeTypeName("ULONGLONG")] ulong ullHandlerCookie, [NativeTypeName("BSTR")] char* functionName, [NativeTypeName("UINT32")] uint line, [NativeTypeName("UINT32")] uint column, [NativeTypeName("UINT32")] uint cchLength, IUnknown* pDebugDocumentContext);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> RequestedCallbackTypes;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, int> BeforeDispatchEvent;

        [NativeTypeName("HRESULT (IUnknown *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, uint, int> DispatchEventComplete;

        [NativeTypeName("HRESULT (IUnknown *, IScriptEventHandler *, DOM_EVENT_PHASE, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, IScriptEventHandler*, DOM_EVENT_PHASE, uint, int> BeforeInvokeDomCallback;

        [NativeTypeName("HRESULT (IUnknown *, IScriptEventHandler *, DOM_EVENT_PHASE, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUnknown*, IScriptEventHandler*, DOM_EVENT_PHASE, uint, int> InvokeDomCallbackComplete;

        [NativeTypeName("HRESULT (SCRIPT_TIMER_TYPE, DWORD, IDispatch *, ULONGLONG, BSTR, UINT32, UINT32, UINT32, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SCRIPT_TIMER_TYPE, uint, IDispatch*, ulong, char*, uint, uint, uint, IUnknown*, int> BeforeInvokeCallback;

        [NativeTypeName("HRESULT (SCRIPT_TIMER_TYPE, DWORD, IDispatch *, ULONGLONG, BSTR, UINT32, UINT32, UINT32, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SCRIPT_TIMER_TYPE, uint, IDispatch*, ulong, char*, uint, uint, uint, IUnknown*, int> InvokeCallbackComplete;
    }
}
