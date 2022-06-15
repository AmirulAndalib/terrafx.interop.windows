// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IElementBehavior.xml' path='doc/member[@name="IElementBehavior"]/*' />
[Guid("3050F425-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehavior : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehavior : IElementBehavior.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IElementBehavior;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehavior*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehavior*, uint>)(lpVtbl[1]))((IElementBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehavior*, uint>)(lpVtbl[2]))((IElementBehavior*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehavior.xml' path='doc/member[@name="IElementBehavior.Init"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Init(IElementBehaviorSite* pBehaviorSite)
    {
        return ((delegate* unmanaged<IElementBehavior*, IElementBehaviorSite*, int>)(lpVtbl[3]))((IElementBehavior*)Unsafe.AsPointer(ref this), pBehaviorSite);
    }

    /// <include file='IElementBehavior.xml' path='doc/member[@name="IElementBehavior.Notify"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Notify([NativeTypeName("LONG")] int lEvent, VARIANT* pVar)
    {
        return ((delegate* unmanaged<IElementBehavior*, int, VARIANT*, int>)(lpVtbl[4]))((IElementBehavior*)Unsafe.AsPointer(ref this), lEvent, pVar);
    }

    /// <include file='IElementBehavior.xml' path='doc/member[@name="IElementBehavior.Detach"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Detach()
    {
        return ((delegate* unmanaged<IElementBehavior*, int>)(lpVtbl[5]))((IElementBehavior*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Init(IElementBehaviorSite* pBehaviorSite);

        [VtblIndex(4)]
        HRESULT Notify([NativeTypeName("LONG")] int lEvent, VARIANT* pVar);

        [VtblIndex(5)]
        HRESULT Detach();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IElementBehaviorSite *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IElementBehaviorSite*, int> Init;

        [NativeTypeName("HRESULT (LONG, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, VARIANT*, int> Notify;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Detach;
    }
}
