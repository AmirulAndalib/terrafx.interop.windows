// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFExtendedDRMTypeSupport.xml' path='doc/member[@name="IMFExtendedDRMTypeSupport"]/*' />
[Guid("332EC562-3758-468D-A784-E38F23552128")]
[NativeTypeName("struct IMFExtendedDRMTypeSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFExtendedDRMTypeSupport : IMFExtendedDRMTypeSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFExtendedDRMTypeSupport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedDRMTypeSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFExtendedDRMTypeSupport*, uint>)(lpVtbl[1]))((IMFExtendedDRMTypeSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFExtendedDRMTypeSupport*, uint>)(lpVtbl[2]))((IMFExtendedDRMTypeSupport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFExtendedDRMTypeSupport.xml' path='doc/member[@name="IMFExtendedDRMTypeSupport.IsTypeSupportedEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsTypeSupportedEx([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR")] ushort* keySystem, MF_MEDIA_ENGINE_CANPLAY* pAnswer)
    {
        return ((delegate* unmanaged<IMFExtendedDRMTypeSupport*, ushort*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int>)(lpVtbl[3]))((IMFExtendedDRMTypeSupport*)Unsafe.AsPointer(ref this), type, keySystem, pAnswer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsTypeSupportedEx([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR")] ushort* keySystem, MF_MEDIA_ENGINE_CANPLAY* pAnswer);
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

        [NativeTypeName("HRESULT (BSTR, BSTR, MF_MEDIA_ENGINE_CANPLAY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, MF_MEDIA_ENGINE_CANPLAY*, int> IsTypeSupportedEx;
    }
}
