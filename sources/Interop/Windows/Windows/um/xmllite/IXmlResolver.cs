// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IXmlResolver.xml' path='doc/member[@name="IXmlResolver"]/*' />
[Guid("7279FC82-709D-4095-B63D-69FE4B0D9030")]
[NativeTypeName("struct IXmlResolver : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXmlResolver : IXmlResolver.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlResolver));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlResolver*, Guid*, void**, int>)(lpVtbl[0]))((IXmlResolver*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlResolver*, uint>)(lpVtbl[1]))((IXmlResolver*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlResolver*, uint>)(lpVtbl[2]))((IXmlResolver*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlResolver.xml' path='doc/member[@name="IXmlResolver.ResolveUri"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ResolveUri([NativeTypeName("LPCWSTR")] char* pwszBaseUri, [NativeTypeName("LPCWSTR")] char* pwszPublicIdentifier, [NativeTypeName("LPCWSTR")] char* pwszSystemIdentifier, IUnknown** ppResolvedInput)
    {
        return ((delegate* unmanaged[MemberFunction]<IXmlResolver*, char*, char*, char*, IUnknown**, int>)(lpVtbl[3]))((IXmlResolver*)Unsafe.AsPointer(ref this), pwszBaseUri, pwszPublicIdentifier, pwszSystemIdentifier, ppResolvedInput);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ResolveUri([NativeTypeName("LPCWSTR")] char* pwszBaseUri, [NativeTypeName("LPCWSTR")] char* pwszPublicIdentifier, [NativeTypeName("LPCWSTR")] char* pwszSystemIdentifier, IUnknown** ppResolvedInput);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, IUnknown**, int> ResolveUri;
    }
}
