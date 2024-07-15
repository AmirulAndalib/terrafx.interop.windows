// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiscFormat2TrackAtOnceEventArgs.xml' path='doc/member[@name="IDiscFormat2TrackAtOnceEventArgs"]/*' />
[Guid("27354140-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IDiscFormat2TrackAtOnceEventArgs : IWriteEngine2EventArgs")]
[NativeInheritance("IWriteEngine2EventArgs")]
public unsafe partial struct IDiscFormat2TrackAtOnceEventArgs : IDiscFormat2TrackAtOnceEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscFormat2TrackAtOnceEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, uint>)(lpVtbl[1]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, uint>)(lpVtbl[2]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, uint*, int>)(lpVtbl[3]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] char** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, Guid*, char**, uint, uint, int*, int>)(lpVtbl[5]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="IWriteEngine2EventArgs.get_StartLba" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StartLba([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[7]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IWriteEngine2EventArgs.get_SectorCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SectorCount([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[8]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IWriteEngine2EventArgs.get_LastReadLba" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LastReadLba([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[9]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IWriteEngine2EventArgs.get_LastWrittenLba" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_LastWrittenLba([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[10]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IWriteEngine2EventArgs.get_TotalSystemBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_TotalSystemBuffer([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[11]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IWriteEngine2EventArgs.get_UsedSystemBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UsedSystemBuffer([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[12]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IWriteEngine2EventArgs.get_FreeSystemBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FreeSystemBuffer([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[13]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2TrackAtOnceEventArgs.xml' path='doc/member[@name="IDiscFormat2TrackAtOnceEventArgs.get_CurrentTrackNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CurrentTrackNumber([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[14]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2TrackAtOnceEventArgs.xml' path='doc/member[@name="IDiscFormat2TrackAtOnceEventArgs.get_CurrentAction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CurrentAction(IMAPI_FORMAT2_TAO_WRITE_ACTION* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, IMAPI_FORMAT2_TAO_WRITE_ACTION*, int>)(lpVtbl[15]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2TrackAtOnceEventArgs.xml' path='doc/member[@name="IDiscFormat2TrackAtOnceEventArgs.get_ElapsedTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_ElapsedTime([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[16]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IDiscFormat2TrackAtOnceEventArgs.xml' path='doc/member[@name="IDiscFormat2TrackAtOnceEventArgs.get_RemainingTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RemainingTime([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDiscFormat2TrackAtOnceEventArgs*, int*, int>)(lpVtbl[17]))((IDiscFormat2TrackAtOnceEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IWriteEngine2EventArgs.Interface
    {
        [VtblIndex(14)]
        HRESULT get_CurrentTrackNumber([NativeTypeName("LONG *")] int* value);

        [VtblIndex(15)]
        HRESULT get_CurrentAction(IMAPI_FORMAT2_TAO_WRITE_ACTION* value);

        [VtblIndex(16)]
        HRESULT get_ElapsedTime([NativeTypeName("LONG *")] int* value);

        [VtblIndex(17)]
        HRESULT get_RemainingTime([NativeTypeName("LONG *")] int* value);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, char**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_StartLba;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_SectorCount;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_LastReadLba;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_LastWrittenLba;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_TotalSystemBuffer;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_UsedSystemBuffer;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_FreeSystemBuffer;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_CurrentTrackNumber;

        [NativeTypeName("HRESULT (IMAPI_FORMAT2_TAO_WRITE_ACTION *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMAPI_FORMAT2_TAO_WRITE_ACTION*, int> get_CurrentAction;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_ElapsedTime;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_RemainingTime;
    }
}
