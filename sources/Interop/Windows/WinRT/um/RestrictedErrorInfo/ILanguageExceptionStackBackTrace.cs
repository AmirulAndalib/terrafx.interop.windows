// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

/// <include file='ILanguageExceptionStackBackTrace.xml' path='doc/member[@name="ILanguageExceptionStackBackTrace"]/*' />
[Guid("CBE53FB5-F967-4258-8D34-42F5E25833DE")]
[NativeTypeName("struct ILanguageExceptionStackBackTrace : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ILanguageExceptionStackBackTrace : ILanguageExceptionStackBackTrace.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILanguageExceptionStackBackTrace*, Guid*, void**, int>)(lpVtbl[0]))((ILanguageExceptionStackBackTrace*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILanguageExceptionStackBackTrace*, uint>)(lpVtbl[1]))((ILanguageExceptionStackBackTrace*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILanguageExceptionStackBackTrace*, uint>)(lpVtbl[2]))((ILanguageExceptionStackBackTrace*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILanguageExceptionStackBackTrace.xml' path='doc/member[@name="ILanguageExceptionStackBackTrace.GetStackBackTrace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStackBackTrace([NativeTypeName("ULONG")] uint maxFramesToCapture, [NativeTypeName("UINT_PTR[]")] nuint* stackBackTrace, [NativeTypeName("ULONG *")] uint* framesCaptured)
    {
        return ((delegate* unmanaged<ILanguageExceptionStackBackTrace*, uint, nuint*, uint*, int>)(lpVtbl[3]))((ILanguageExceptionStackBackTrace*)Unsafe.AsPointer(ref this), maxFramesToCapture, stackBackTrace, framesCaptured);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStackBackTrace([NativeTypeName("ULONG")] uint maxFramesToCapture, [NativeTypeName("UINT_PTR[]")] nuint* stackBackTrace, [NativeTypeName("ULONG *")] uint* framesCaptured);
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

        [NativeTypeName("HRESULT (ULONG, UINT_PTR *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nuint*, uint*, int> GetStackBackTrace;
    }
}
