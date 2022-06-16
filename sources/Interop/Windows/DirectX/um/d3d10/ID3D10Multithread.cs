// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread"]/*' />
[Guid("9B7E4E00-342C-4106-A19F-4F2704F689F0")]
[NativeTypeName("struct ID3D10Multithread : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10Multithread : ID3D10Multithread.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Multithread));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10Multithread*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10Multithread*, uint>)(lpVtbl[1]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10Multithread*, uint>)(lpVtbl[2]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread.Enter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Enter()
    {
        ((delegate* unmanaged<ID3D10Multithread*, void>)(lpVtbl[3]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread.Leave"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Leave()
    {
        ((delegate* unmanaged<ID3D10Multithread*, void>)(lpVtbl[4]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread.SetMultithreadProtected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public BOOL SetMultithreadProtected(BOOL bMTProtect)
    {
        return ((delegate* unmanaged<ID3D10Multithread*, BOOL, int>)(lpVtbl[5]))((ID3D10Multithread*)Unsafe.AsPointer(ref this), bMTProtect);
    }

    /// <include file='ID3D10Multithread.xml' path='doc/member[@name="ID3D10Multithread.GetMultithreadProtected"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL GetMultithreadProtected()
    {
        return ((delegate* unmanaged<ID3D10Multithread*, int>)(lpVtbl[6]))((ID3D10Multithread*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void Enter();

        [VtblIndex(4)]
        void Leave();

        [VtblIndex(5)]
        BOOL SetMultithreadProtected(BOOL bMTProtect);

        [VtblIndex(6)]
        BOOL GetMultithreadProtected();
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

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Enter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Leave;

        [NativeTypeName("BOOL (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetMultithreadProtected;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetMultithreadProtected;
    }
}
