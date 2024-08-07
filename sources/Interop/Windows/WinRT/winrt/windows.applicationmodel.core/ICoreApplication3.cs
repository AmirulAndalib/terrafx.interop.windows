// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreApplication3.xml' path='doc/member[@name="ICoreApplication3"]/*' />
[Guid("FEEC0D39-598B-4507-8A67-772632580A57")]
[NativeTypeName("struct ICoreApplication3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreApplication3 : ICoreApplication3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreApplication3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication3*, Guid*, void**, int>)(lpVtbl[0]))((ICoreApplication3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication3*, uint>)(lpVtbl[1]))((ICoreApplication3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication3*, uint>)(lpVtbl[2]))((ICoreApplication3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication3*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreApplication3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication3*, HSTRING*, int>)(lpVtbl[4]))((ICoreApplication3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication3*, TrustLevel*, int>)(lpVtbl[5]))((ICoreApplication3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreApplication3.xml' path='doc/member[@name="ICoreApplication3.RequestRestartAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestRestartAsync(HSTRING launchArguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCore__CAppRestartFailureReason_t **")] IAsyncOperation<AppRestartFailureReason>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication3*, HSTRING, IAsyncOperation<AppRestartFailureReason>**, int>)(lpVtbl[6]))((ICoreApplication3*)Unsafe.AsPointer(ref this), launchArguments, operation);
    }

    /// <include file='ICoreApplication3.xml' path='doc/member[@name="ICoreApplication3.RequestRestartForUserAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestRestartForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING launchArguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCore__CAppRestartFailureReason_t **")] IAsyncOperation<AppRestartFailureReason>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreApplication3*, IUser*, HSTRING, IAsyncOperation<AppRestartFailureReason>**, int>)(lpVtbl[7]))((ICoreApplication3*)Unsafe.AsPointer(ref this), user, launchArguments, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestRestartAsync(HSTRING launchArguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCore__CAppRestartFailureReason_t **")] IAsyncOperation<AppRestartFailureReason>** operation);

        [VtblIndex(7)]
        HRESULT RequestRestartForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, HSTRING launchArguments, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCore__CAppRestartFailureReason_t **")] IAsyncOperation<AppRestartFailureReason>** operation);
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCore__CAppRestartFailureReason_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, IAsyncOperation<AppRestartFailureReason>**, int> RequestRestartAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCore__CAppRestartFailureReason_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUser*, HSTRING, IAsyncOperation<AppRestartFailureReason>**, int> RequestRestartForUserAsync;
    }
}
