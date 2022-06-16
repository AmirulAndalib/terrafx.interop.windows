// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMLOperatorKernel.xml' path='doc/member[@name="IMLOperatorKernel"]/*' />
[Guid("11C4B4A0-B467-4EAA-A1A6-B961D8D0ED79")]
[NativeTypeName("struct IMLOperatorKernel : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMLOperatorKernel : IMLOperatorKernel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMLOperatorKernel));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMLOperatorKernel*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorKernel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMLOperatorKernel*, uint>)(lpVtbl[1]))((IMLOperatorKernel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMLOperatorKernel*, uint>)(lpVtbl[2]))((IMLOperatorKernel*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMLOperatorKernel.xml' path='doc/member[@name="IMLOperatorKernel.Compute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Compute(IMLOperatorKernelContext* context)
    {
        return ((delegate* unmanaged<IMLOperatorKernel*, IMLOperatorKernelContext*, int>)(lpVtbl[3]))((IMLOperatorKernel*)Unsafe.AsPointer(ref this), context);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Compute(IMLOperatorKernelContext* context);
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

        [NativeTypeName("HRESULT (IMLOperatorKernelContext *) noexcept __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMLOperatorKernelContext*, int> Compute;
    }
}
