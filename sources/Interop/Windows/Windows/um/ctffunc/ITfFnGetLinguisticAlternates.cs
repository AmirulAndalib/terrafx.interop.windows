// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITfFnGetLinguisticAlternates.xml' path='doc/member[@name="ITfFnGetLinguisticAlternates"]/*' />
[Guid("EA163CE2-7A65-4506-82A3-C528215DA64E")]
[NativeTypeName("struct ITfFnGetLinguisticAlternates : ITfFunction")]
[NativeInheritance("ITfFunction")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ITfFnGetLinguisticAlternates : ITfFnGetLinguisticAlternates.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnGetLinguisticAlternates));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfFnGetLinguisticAlternates*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITfFnGetLinguisticAlternates*, uint>)(lpVtbl[1]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITfFnGetLinguisticAlternates*, uint>)(lpVtbl[2]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfFunction.GetDisplayName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] char** pbstrName)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfFnGetLinguisticAlternates*, char**, int>)(lpVtbl[3]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnGetLinguisticAlternates.xml' path='doc/member[@name="ITfFnGetLinguisticAlternates.GetAlternates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAlternates(ITfRange* pRange, ITfCandidateList** ppCandidateList)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfFnGetLinguisticAlternates*, ITfRange*, ITfCandidateList**, int>)(lpVtbl[4]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this), pRange, ppCandidateList);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT GetAlternates(ITfRange* pRange, ITfCandidateList** ppCandidateList);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetDisplayName;

        [NativeTypeName("HRESULT (ITfRange *, ITfCandidateList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITfRange*, ITfCandidateList**, int> GetAlternates;
    }
}
