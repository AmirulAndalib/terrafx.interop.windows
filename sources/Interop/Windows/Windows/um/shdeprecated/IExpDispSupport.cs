// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IExpDispSupport.xml' path='doc/member[@name="IExpDispSupport"]/*' />
[Guid("0D7D1D00-6FC0-11D0-A974-00C04FD705A2")]
[NativeTypeName("struct IExpDispSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExpDispSupport : IExpDispSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExpDispSupport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IExpDispSupport*, Guid*, void**, int>)(lpVtbl[0]))((IExpDispSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IExpDispSupport*, uint>)(lpVtbl[1]))((IExpDispSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IExpDispSupport*, uint>)(lpVtbl[2]))((IExpDispSupport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExpDispSupport.xml' path='doc/member[@name="IExpDispSupport.FindConnectionPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FindConnectionPoint([NativeTypeName("const IID &")] Guid* riid, IConnectionPoint** ppccp)
    {
        return ((delegate* unmanaged[MemberFunction]<IExpDispSupport*, Guid*, IConnectionPoint**, int>)(lpVtbl[3]))((IExpDispSupport*)Unsafe.AsPointer(ref this), riid, ppccp);
    }

    /// <include file='IExpDispSupport.xml' path='doc/member[@name="IExpDispSupport.OnTranslateAccelerator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnTranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
    {
        return ((delegate* unmanaged[MemberFunction]<IExpDispSupport*, MSG*, uint, int>)(lpVtbl[4]))((IExpDispSupport*)Unsafe.AsPointer(ref this), pMsg, grfModifiers);
    }

    /// <include file='IExpDispSupport.xml' path='doc/member[@name="IExpDispSupport.OnInvoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnInvoke([NativeTypeName("DISPID")] int dispidMember, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdispparams, VARIANT* pVarResult, EXCEPINFO* pexcepinfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<IExpDispSupport*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[5]))((IExpDispSupport*)Unsafe.AsPointer(ref this), dispidMember, iid, lcid, wFlags, pdispparams, pVarResult, pexcepinfo, puArgErr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FindConnectionPoint([NativeTypeName("const IID &")] Guid* riid, IConnectionPoint** ppccp);

        [VtblIndex(4)]
        HRESULT OnTranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers);

        [VtblIndex(5)]
        HRESULT OnInvoke([NativeTypeName("DISPID")] int dispidMember, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdispparams, VARIANT* pVarResult, EXCEPINFO* pexcepinfo, uint* puArgErr);
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

        [NativeTypeName("HRESULT (const IID &, IConnectionPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IConnectionPoint**, int> FindConnectionPoint;

        [NativeTypeName("HRESULT (MSG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, MSG*, uint, int> OnTranslateAccelerator;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> OnInvoke;
    }
}
