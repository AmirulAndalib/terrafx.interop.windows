// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IInputPane2.xml' path='doc/member[@name="IInputPane2"]/*' />
[Guid("8A6B3F26-7090-4793-944C-C3F2CDE26276")]
[NativeTypeName("struct IInputPane2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInputPane2 : IInputPane2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInputPane2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane2*, Guid*, void**, int>)(lpVtbl[0]))((IInputPane2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane2*, uint>)(lpVtbl[1]))((IInputPane2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane2*, uint>)(lpVtbl[2]))((IInputPane2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane2*, uint*, Guid**, int>)(lpVtbl[3]))((IInputPane2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane2*, HSTRING*, int>)(lpVtbl[4]))((IInputPane2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane2*, TrustLevel*, int>)(lpVtbl[5]))((IInputPane2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IInputPane2.xml' path='doc/member[@name="IInputPane2.TryShow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryShow([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane2*, byte*, int>)(lpVtbl[6]))((IInputPane2*)Unsafe.AsPointer(ref this), result);
    }

    /// <include file='IInputPane2.xml' path='doc/member[@name="IInputPane2.TryHide"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryHide([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged[MemberFunction]<IInputPane2*, byte*, int>)(lpVtbl[7]))((IInputPane2*)Unsafe.AsPointer(ref this), result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryShow([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT TryHide([NativeTypeName("boolean *")] byte* result);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> TryShow;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> TryHide;
    }
}
