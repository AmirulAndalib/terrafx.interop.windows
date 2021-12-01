// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='IInkPresenterDesktop.xml' path='doc/member[@name="IInkPresenterDesktop"]/*' />
[Guid("73F3C0D9-2E8B-48F3-895E-20CBD27B723B")]
[NativeTypeName("struct IInkPresenterDesktop : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IInkPresenterDesktop : IInkPresenterDesktop.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInkPresenterDesktop*, Guid*, void**, int>)(lpVtbl[0]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInkPresenterDesktop*, uint>)(lpVtbl[1]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInkPresenterDesktop*, uint>)(lpVtbl[2]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInkPresenterDesktop.xml' path='doc/member[@name="IInkPresenterDesktop.SetRootVisual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetRootVisual(IUnknown* rootVisual, IUnknown* device)
    {
        return ((delegate* unmanaged<IInkPresenterDesktop*, IUnknown*, IUnknown*, int>)(lpVtbl[3]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), rootVisual, device);
    }

    /// <include file='IInkPresenterDesktop.xml' path='doc/member[@name="IInkPresenterDesktop.SetCommitRequestHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCommitRequestHandler(IInkCommitRequestHandler* handler)
    {
        return ((delegate* unmanaged<IInkPresenterDesktop*, IInkCommitRequestHandler*, int>)(lpVtbl[4]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), handler);
    }

    /// <include file='IInkPresenterDesktop.xml' path='doc/member[@name="IInkPresenterDesktop.GetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSize(float* width, float* height)
    {
        return ((delegate* unmanaged<IInkPresenterDesktop*, float*, float*, int>)(lpVtbl[5]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), width, height);
    }

    /// <include file='IInkPresenterDesktop.xml' path='doc/member[@name="IInkPresenterDesktop.SetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(float width, float height)
    {
        return ((delegate* unmanaged<IInkPresenterDesktop*, float, float, int>)(lpVtbl[6]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this), width, height);
    }

    /// <include file='IInkPresenterDesktop.xml' path='doc/member[@name="IInkPresenterDesktop.OnHighContrastChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnHighContrastChanged()
    {
        return ((delegate* unmanaged<IInkPresenterDesktop*, int>)(lpVtbl[7]))((IInkPresenterDesktop*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetRootVisual(IUnknown* rootVisual, IUnknown* device);

        [VtblIndex(4)]
        HRESULT SetCommitRequestHandler(IInkCommitRequestHandler* handler);

        [VtblIndex(5)]
        HRESULT GetSize(float* width, float* height);

        [VtblIndex(6)]
        HRESULT SetSize(float width, float height);

        [VtblIndex(7)]
        HRESULT OnHighContrastChanged();
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

        [NativeTypeName("HRESULT (IUnknown *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IUnknown*, int> SetRootVisual;

        [NativeTypeName("HRESULT (IInkCommitRequestHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInkCommitRequestHandler*, int> SetCommitRequestHandler;

        [NativeTypeName("HRESULT (float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, float*, int> GetSize;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, int> SetSize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnHighContrastChanged;
    }
}
