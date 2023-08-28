// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IElementBehaviorSiteLayout.xml' path='doc/member[@name="IElementBehaviorSiteLayout"]/*' />
[Guid("3050F6B7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorSiteLayout : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorSiteLayout : IElementBehaviorSiteLayout.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorSiteLayout));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IElementBehaviorSiteLayout*, Guid*, void**, int>)(lpVtbl[0]))((IElementBehaviorSiteLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IElementBehaviorSiteLayout*, uint>)(lpVtbl[1]))((IElementBehaviorSiteLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IElementBehaviorSiteLayout*, uint>)(lpVtbl[2]))((IElementBehaviorSiteLayout*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSiteLayout.xml' path='doc/member[@name="IElementBehaviorSiteLayout.InvalidateLayoutInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InvalidateLayoutInfo()
    {
        return ((delegate* unmanaged[MemberFunction]<IElementBehaviorSiteLayout*, int>)(lpVtbl[3]))((IElementBehaviorSiteLayout*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSiteLayout.xml' path='doc/member[@name="IElementBehaviorSiteLayout.InvalidateSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InvalidateSize()
    {
        return ((delegate* unmanaged[MemberFunction]<IElementBehaviorSiteLayout*, int>)(lpVtbl[4]))((IElementBehaviorSiteLayout*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSiteLayout.xml' path='doc/member[@name="IElementBehaviorSiteLayout.GetMediaResolution"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMediaResolution(SIZE* psizeResolution)
    {
        return ((delegate* unmanaged[MemberFunction]<IElementBehaviorSiteLayout*, SIZE*, int>)(lpVtbl[5]))((IElementBehaviorSiteLayout*)Unsafe.AsPointer(ref this), psizeResolution);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InvalidateLayoutInfo();

        [VtblIndex(4)]
        HRESULT InvalidateSize();

        [VtblIndex(5)]
        HRESULT GetMediaResolution(SIZE* psizeResolution);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> InvalidateLayoutInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> InvalidateSize;

        [NativeTypeName("HRESULT (SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SIZE*, int> GetMediaResolution;
    }
}
