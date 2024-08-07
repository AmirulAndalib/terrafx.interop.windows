// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IWalletItemCustomPropertyFactory.xml' path='doc/member[@name="IWalletItemCustomPropertyFactory"]/*' />
[Guid("D0046A44-61A1-41AA-B259-A5610AB5D575")]
[NativeTypeName("struct IWalletItemCustomPropertyFactory : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
public unsafe partial struct IWalletItemCustomPropertyFactory : IWalletItemCustomPropertyFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletItemCustomPropertyFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomPropertyFactory*, Guid*, void**, int>)(lpVtbl[0]))((IWalletItemCustomPropertyFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomPropertyFactory*, uint>)(lpVtbl[1]))((IWalletItemCustomPropertyFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomPropertyFactory*, uint>)(lpVtbl[2]))((IWalletItemCustomPropertyFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomPropertyFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IWalletItemCustomPropertyFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomPropertyFactory*, HSTRING*, int>)(lpVtbl[4]))((IWalletItemCustomPropertyFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomPropertyFactory*, TrustLevel*, int>)(lpVtbl[5]))((IWalletItemCustomPropertyFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWalletItemCustomPropertyFactory.xml' path='doc/member[@name="IWalletItemCustomPropertyFactory.CreateWalletItemCustomProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
    public HRESULT CreateWalletItemCustomProperty(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItemCustomProperty **")] IWalletItemCustomProperty** walletItemCustomProperty)
    {
        return ((delegate* unmanaged[MemberFunction]<IWalletItemCustomPropertyFactory*, HSTRING, HSTRING, IWalletItemCustomProperty**, int>)(lpVtbl[6]))((IWalletItemCustomPropertyFactory*)Unsafe.AsPointer(ref this), name, value, walletItemCustomProperty);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        HRESULT CreateWalletItemCustomProperty(HSTRING name, HSTRING value, [NativeTypeName("ABI::Windows::ApplicationModel::Wallet::IWalletItemCustomProperty **")] IWalletItemCustomProperty** walletItemCustomProperty);
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

        [NativeTypeName("HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Wallet::IWalletItemCustomProperty **) __attribute__((stdcall))")]
        [Obsolete("IWalletItemCustomProperty is deprecated and might not work on all platforms. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, HSTRING, IWalletItemCustomProperty**, int> CreateWalletItemCustomProperty;
    }
}
