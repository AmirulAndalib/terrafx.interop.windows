// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.effects.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IGraphicsEffectD2D1Interop.xml' path='doc/member[@name="IGraphicsEffectD2D1Interop"]/*' />
[Guid("2FC57384-A068-44D7-A331-30982FCF7177")]
[NativeTypeName("struct IGraphicsEffectD2D1Interop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGraphicsEffectD2D1Interop : IGraphicsEffectD2D1Interop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphicsEffectD2D1Interop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, Guid*, void**, int>)(lpVtbl[0]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, uint>)(lpVtbl[1]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, uint>)(lpVtbl[2]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGraphicsEffectD2D1Interop.xml' path='doc/member[@name="IGraphicsEffectD2D1Interop.GetEffectId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEffectId(Guid* id)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, Guid*, int>)(lpVtbl[3]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), id);
    }

    /// <include file='IGraphicsEffectD2D1Interop.xml' path='doc/member[@name="IGraphicsEffectD2D1Interop.GetNamedPropertyMapping"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetNamedPropertyMapping([NativeTypeName("LPCWSTR")] char* name, uint* index, [NativeTypeName("ABI::Windows::Graphics::Effects::GRAPHICS_EFFECT_PROPERTY_MAPPING *")] GRAPHICS_EFFECT_PROPERTY_MAPPING* mapping)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, char*, uint*, GRAPHICS_EFFECT_PROPERTY_MAPPING*, int>)(lpVtbl[4]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), name, index, mapping);
    }

    /// <include file='IGraphicsEffectD2D1Interop.xml' path='doc/member[@name="IGraphicsEffectD2D1Interop.GetPropertyCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyCount(uint* count)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, uint*, int>)(lpVtbl[5]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), count);
    }

    /// <include file='IGraphicsEffectD2D1Interop.xml' path='doc/member[@name="IGraphicsEffectD2D1Interop.GetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProperty(uint index, [NativeTypeName("Windows::Foundation::IPropertyValue **")] IPropertyValue** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, uint, IPropertyValue**, int>)(lpVtbl[6]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), index, value);
    }

    /// <include file='IGraphicsEffectD2D1Interop.xml' path='doc/member[@name="IGraphicsEffectD2D1Interop.GetSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSource(uint index, IGraphicsEffectSource** source)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, uint, IGraphicsEffectSource**, int>)(lpVtbl[7]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), index, source);
    }

    /// <include file='IGraphicsEffectD2D1Interop.xml' path='doc/member[@name="IGraphicsEffectD2D1Interop.GetSourceCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSourceCount(uint* count)
    {
        return ((delegate* unmanaged[MemberFunction]<IGraphicsEffectD2D1Interop*, uint*, int>)(lpVtbl[8]))((IGraphicsEffectD2D1Interop*)Unsafe.AsPointer(ref this), count);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEffectId(Guid* id);

        [VtblIndex(4)]
        HRESULT GetNamedPropertyMapping([NativeTypeName("LPCWSTR")] char* name, uint* index, [NativeTypeName("ABI::Windows::Graphics::Effects::GRAPHICS_EFFECT_PROPERTY_MAPPING *")] GRAPHICS_EFFECT_PROPERTY_MAPPING* mapping);

        [VtblIndex(5)]
        HRESULT GetPropertyCount(uint* count);

        [VtblIndex(6)]
        HRESULT GetProperty(uint index, [NativeTypeName("Windows::Foundation::IPropertyValue **")] IPropertyValue** value);

        [VtblIndex(7)]
        HRESULT GetSource(uint index, IGraphicsEffectSource** source);

        [VtblIndex(8)]
        HRESULT GetSourceCount(uint* count);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetEffectId;

        [NativeTypeName("HRESULT (LPCWSTR, UINT *, GRAPHICS_EFFECT_PROPERTY_MAPPING *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint*, GRAPHICS_EFFECT_PROPERTY_MAPPING*, int> GetNamedPropertyMapping;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetPropertyCount;

        [NativeTypeName("HRESULT (UINT, Windows::Foundation::IPropertyValue **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IPropertyValue**, int> GetProperty;

        [NativeTypeName("HRESULT (UINT, IGraphicsEffectSource **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IGraphicsEffectSource**, int> GetSource;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSourceCount;
    }
}
