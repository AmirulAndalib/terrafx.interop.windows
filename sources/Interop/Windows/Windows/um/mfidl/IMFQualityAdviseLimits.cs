// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFQualityAdviseLimits.xml' path='doc/member[@name="IMFQualityAdviseLimits"]/*' />
[Guid("DFCD8E4D-30B5-4567-ACAA-8EB5B7853DC9")]
[NativeTypeName("struct IMFQualityAdviseLimits : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFQualityAdviseLimits : IMFQualityAdviseLimits.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IMFQualityAdviseLimits;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFQualityAdviseLimits*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFQualityAdviseLimits*, uint>)(lpVtbl[1]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFQualityAdviseLimits*, uint>)(lpVtbl[2]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFQualityAdviseLimits.xml' path='doc/member[@name="IMFQualityAdviseLimits.GetMaximumDropMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMaximumDropMode(MF_QUALITY_DROP_MODE* peDropMode)
    {
        return ((delegate* unmanaged<IMFQualityAdviseLimits*, MF_QUALITY_DROP_MODE*, int>)(lpVtbl[3]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), peDropMode);
    }

    /// <include file='IMFQualityAdviseLimits.xml' path='doc/member[@name="IMFQualityAdviseLimits.GetMinimumQualityLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMinimumQualityLevel(MF_QUALITY_LEVEL* peQualityLevel)
    {
        return ((delegate* unmanaged<IMFQualityAdviseLimits*, MF_QUALITY_LEVEL*, int>)(lpVtbl[4]))((IMFQualityAdviseLimits*)Unsafe.AsPointer(ref this), peQualityLevel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMaximumDropMode(MF_QUALITY_DROP_MODE* peDropMode);

        [VtblIndex(4)]
        HRESULT GetMinimumQualityLevel(MF_QUALITY_LEVEL* peQualityLevel);
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

        [NativeTypeName("HRESULT (MF_QUALITY_DROP_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_QUALITY_DROP_MODE*, int> GetMaximumDropMode;

        [NativeTypeName("HRESULT (MF_QUALITY_LEVEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_QUALITY_LEVEL*, int> GetMinimumQualityLevel;
    }
}
