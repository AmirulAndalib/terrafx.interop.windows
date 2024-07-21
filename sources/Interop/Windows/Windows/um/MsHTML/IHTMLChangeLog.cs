// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLChangeLog.xml' path='doc/member[@name="IHTMLChangeLog"]/*' />
[Guid("3050F649-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLChangeLog : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLChangeLog : IHTMLChangeLog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLChangeLog));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLChangeLog*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLChangeLog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLChangeLog*, uint>)(lpVtbl[1]))((IHTMLChangeLog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLChangeLog*, uint>)(lpVtbl[2]))((IHTMLChangeLog*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLChangeLog.xml' path='doc/member[@name="IHTMLChangeLog.GetNextChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNextChange(byte* pbBuffer, [NativeTypeName("long")] int nBufferSize, [NativeTypeName("long *")] int* pnRecordLength)
    {
        return ((delegate* unmanaged[MemberFunction]<IHTMLChangeLog*, byte*, int, int*, int>)(lpVtbl[3]))((IHTMLChangeLog*)Unsafe.AsPointer(ref this), pbBuffer, nBufferSize, pnRecordLength);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNextChange(byte* pbBuffer, [NativeTypeName("long")] int nBufferSize, [NativeTypeName("long *")] int* pnRecordLength);
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

        [NativeTypeName("HRESULT (BYTE *, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int, int*, int> GetNextChange;
    }
}
