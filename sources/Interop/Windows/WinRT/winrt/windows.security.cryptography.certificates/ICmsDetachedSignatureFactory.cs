// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICmsDetachedSignatureFactory.xml' path='doc/member[@name="ICmsDetachedSignatureFactory"]/*' />
[Guid("C4AB3503-AE7F-4387-AD19-00F150E48EBB")]
[NativeTypeName("struct ICmsDetachedSignatureFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICmsDetachedSignatureFactory : ICmsDetachedSignatureFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICmsDetachedSignatureFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICmsDetachedSignatureFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureFactory*, uint>)(lpVtbl[1]))((ICmsDetachedSignatureFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureFactory*, uint>)(lpVtbl[2]))((ICmsDetachedSignatureFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureFactory*, uint*, Guid**, int>)(lpVtbl[3]))((ICmsDetachedSignatureFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureFactory*, HSTRING*, int>)(lpVtbl[4]))((ICmsDetachedSignatureFactory*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureFactory*, TrustLevel*, int>)(lpVtbl[5]))((ICmsDetachedSignatureFactory*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICmsDetachedSignatureFactory.xml' path='doc/member[@name="ICmsDetachedSignatureFactory.CreateCmsDetachedSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCmsDetachedSignature([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* inputBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICmsDetachedSignature **")] ICmsDetachedSignature** cmsSignedData)
    {
        return ((delegate* unmanaged[MemberFunction]<ICmsDetachedSignatureFactory*, IBuffer*, ICmsDetachedSignature**, int>)(lpVtbl[6]))((ICmsDetachedSignatureFactory*)Unsafe.AsPointer(ref this), inputBlob, cmsSignedData);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCmsDetachedSignature([NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer* inputBlob, [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICmsDetachedSignature **")] ICmsDetachedSignature** cmsSignedData);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Security::Cryptography::Certificates::ICmsDetachedSignature **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IBuffer*, ICmsDetachedSignature**, int> CreateCmsDetachedSignature;
    }
}
