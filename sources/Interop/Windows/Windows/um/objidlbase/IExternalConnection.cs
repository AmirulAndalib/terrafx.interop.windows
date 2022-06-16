// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IExternalConnection.xml' path='doc/member[@name="IExternalConnection"]/*' />
[Guid("00000019-0000-0000-C000-000000000046")]
[NativeTypeName("struct IExternalConnection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExternalConnection : IExternalConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExternalConnection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExternalConnection*, Guid*, void**, int>)(lpVtbl[0]))((IExternalConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IExternalConnection*, uint>)(lpVtbl[1]))((IExternalConnection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExternalConnection*, uint>)(lpVtbl[2]))((IExternalConnection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExternalConnection.xml' path='doc/member[@name="IExternalConnection.AddConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint AddConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved)
    {
        return ((delegate* unmanaged<IExternalConnection*, uint, uint, uint>)(lpVtbl[3]))((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved);
    }

    /// <include file='IExternalConnection.xml' path='doc/member[@name="IExternalConnection.ReleaseConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("DWORD")]
    public uint ReleaseConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved, BOOL fLastReleaseCloses)
    {
        return ((delegate* unmanaged<IExternalConnection*, uint, uint, BOOL, uint>)(lpVtbl[4]))((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved, fLastReleaseCloses);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint AddConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved);

        [VtblIndex(4)]
        [return: NativeTypeName("DWORD")]
        uint ReleaseConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved, BOOL fLastReleaseCloses);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("DWORD (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint> AddConnection;

        [NativeTypeName("DWORD (DWORD, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, BOOL, uint> ReleaseConnection;
    }
}
