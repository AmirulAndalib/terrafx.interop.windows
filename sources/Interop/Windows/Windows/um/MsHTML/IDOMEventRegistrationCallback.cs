// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDOMEventRegistrationCallback.xml' path='doc/member[@name="IDOMEventRegistrationCallback"]/*' />
[Guid("3051083B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMEventRegistrationCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDOMEventRegistrationCallback : IDOMEventRegistrationCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMEventRegistrationCallback));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDOMEventRegistrationCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDOMEventRegistrationCallback*, uint>)(lpVtbl[1]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDOMEventRegistrationCallback*, uint>)(lpVtbl[2]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDOMEventRegistrationCallback.xml' path='doc/member[@name="IDOMEventRegistrationCallback.OnDOMEventListenerAdded"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDOMEventListenerAdded([NativeTypeName("LPCWSTR")] char* pszEventType, IScriptEventHandler* pHandler)
    {
        return ((delegate* unmanaged[MemberFunction]<IDOMEventRegistrationCallback*, char*, IScriptEventHandler*, int>)(lpVtbl[3]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), pszEventType, pHandler);
    }

    /// <include file='IDOMEventRegistrationCallback.xml' path='doc/member[@name="IDOMEventRegistrationCallback.OnDOMEventListenerRemoved"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnDOMEventListenerRemoved([NativeTypeName("ULONGLONG")] ulong ullCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IDOMEventRegistrationCallback*, ulong, int>)(lpVtbl[4]))((IDOMEventRegistrationCallback*)Unsafe.AsPointer(ref this), ullCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnDOMEventListenerAdded([NativeTypeName("LPCWSTR")] char* pszEventType, IScriptEventHandler* pHandler);

        [VtblIndex(4)]
        HRESULT OnDOMEventListenerRemoved([NativeTypeName("ULONGLONG")] ulong ullCookie);
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

        [NativeTypeName("HRESULT (LPCWSTR, IScriptEventHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IScriptEventHandler*, int> OnDOMEventListenerAdded;

        [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ulong, int> OnDOMEventListenerRemoved;
    }
}
