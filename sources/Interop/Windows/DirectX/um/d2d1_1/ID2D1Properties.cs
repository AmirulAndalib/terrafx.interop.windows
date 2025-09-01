// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D2D1_PROPERTY_TYPE;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties"]/*' />
[Guid("483473D7-CD46-4F9D-9D3A-3112AA80159D")]
[NativeTypeName("struct ID2D1Properties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1Properties : ID2D1Properties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID2D1Properties);

    public void** lpVtbl;

    public HRESULT SetValueByName([NativeTypeName("PCWSTR")] char* name, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return SetValueByName(name, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
    }

    public HRESULT SetValue([NativeTypeName("UINT32")] uint index, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return SetValue(index, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
    }

    public readonly HRESULT GetValueByName([NativeTypeName("PCWSTR")] char* name, byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return GetValueByName(name, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
    }

    public readonly HRESULT GetValue([NativeTypeName("UINT32")] uint index, byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return GetValue(index, D2D1_PROPERTY_TYPE_UNKNOWN, data, dataSize);
    }

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Properties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint>)(lpVtbl[1]))((ID2D1Properties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint>)(lpVtbl[2]))((ID2D1Properties*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetPropertyCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public readonly uint GetPropertyCount()
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint>)(lpVtbl[3]))((ID2D1Properties*)Unsafe.AsPointer(in this));
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetPropertyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public readonly HRESULT GetPropertyName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint, char*, uint, int>)(lpVtbl[4]))((ID2D1Properties*)Unsafe.AsPointer(in this), index, name, nameCount);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetPropertyNameLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public readonly uint GetPropertyNameLength([NativeTypeName("UINT32")] uint index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint, uint>)(lpVtbl[5]))((ID2D1Properties*)Unsafe.AsPointer(in this), index);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public readonly D2D1_PROPERTY_TYPE GetType([NativeTypeName("UINT32")] uint index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint, D2D1_PROPERTY_TYPE>)(lpVtbl[6]))((ID2D1Properties*)Unsafe.AsPointer(in this), index);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetPropertyIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT32")]
    public readonly uint GetPropertyIndex([NativeTypeName("PCWSTR")] char* name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, char*, uint>)(lpVtbl[7]))((ID2D1Properties*)Unsafe.AsPointer(in this), name);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.SetValueByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetValueByName([NativeTypeName("PCWSTR")] char* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, char*, D2D1_PROPERTY_TYPE, byte*, uint, int>)(lpVtbl[8]))((ID2D1Properties*)Unsafe.AsPointer(ref this), name, type, data, dataSize);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.SetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint, D2D1_PROPERTY_TYPE, byte*, uint, int>)(lpVtbl[9]))((ID2D1Properties*)Unsafe.AsPointer(ref this), index, type, data, dataSize);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetValueByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public readonly HRESULT GetValueByName([NativeTypeName("PCWSTR")] char* name, D2D1_PROPERTY_TYPE type, byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, char*, D2D1_PROPERTY_TYPE, byte*, uint, int>)(lpVtbl[10]))((ID2D1Properties*)Unsafe.AsPointer(in this), name, type, data, dataSize);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public readonly HRESULT GetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, byte* data, [NativeTypeName("UINT32")] uint dataSize)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint, D2D1_PROPERTY_TYPE, byte*, uint, int>)(lpVtbl[11]))((ID2D1Properties*)Unsafe.AsPointer(in this), index, type, data, dataSize);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetValueSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("UINT32")]
    public readonly uint GetValueSize([NativeTypeName("UINT32")] uint index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint, uint>)(lpVtbl[12]))((ID2D1Properties*)Unsafe.AsPointer(in this), index);
    }

    /// <include file='ID2D1Properties.xml' path='doc/member[@name="ID2D1Properties.GetSubProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public readonly HRESULT GetSubProperties([NativeTypeName("UINT32")] uint index, ID2D1Properties** subProperties)
    {
        return ((delegate* unmanaged[MemberFunction]<ID2D1Properties*, uint, ID2D1Properties**, int>)(lpVtbl[13]))((ID2D1Properties*)Unsafe.AsPointer(in this), index, subProperties);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetPropertyCount();

        [VtblIndex(4)]
        HRESULT GetPropertyName([NativeTypeName("UINT32")] uint index, [NativeTypeName("PWSTR")] char* name, [NativeTypeName("UINT32")] uint nameCount);

        [VtblIndex(5)]
        [return: NativeTypeName("UINT32")]
        uint GetPropertyNameLength([NativeTypeName("UINT32")] uint index);

        [VtblIndex(6)]
        D2D1_PROPERTY_TYPE GetType([NativeTypeName("UINT32")] uint index);

        [VtblIndex(7)]
        [return: NativeTypeName("UINT32")]
        uint GetPropertyIndex([NativeTypeName("PCWSTR")] char* name);

        [VtblIndex(8)]
        HRESULT SetValueByName([NativeTypeName("PCWSTR")] char* name, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        [VtblIndex(9)]
        HRESULT SetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataSize);

        [VtblIndex(10)]
        HRESULT GetValueByName([NativeTypeName("PCWSTR")] char* name, D2D1_PROPERTY_TYPE type, byte* data, [NativeTypeName("UINT32")] uint dataSize);

        [VtblIndex(11)]
        HRESULT GetValue([NativeTypeName("UINT32")] uint index, D2D1_PROPERTY_TYPE type, byte* data, [NativeTypeName("UINT32")] uint dataSize);

        [VtblIndex(12)]
        [return: NativeTypeName("UINT32")]
        uint GetValueSize([NativeTypeName("UINT32")] uint index);

        [VtblIndex(13)]
        HRESULT GetSubProperties([NativeTypeName("UINT32")] uint index, ID2D1Properties** subProperties);
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

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetPropertyCount;

        [NativeTypeName("HRESULT (UINT32, PWSTR, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint, int> GetPropertyName;

        [NativeTypeName("UINT32 (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint> GetPropertyNameLength;

        [NativeTypeName("D2D1_PROPERTY_TYPE (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged[MemberFunction]<TSelf*, uint, D2D1_PROPERTY_TYPE> GetType;

        [NativeTypeName("UINT32 (PCWSTR) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint> GetPropertyIndex;

        [NativeTypeName("HRESULT (PCWSTR, D2D1_PROPERTY_TYPE, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, D2D1_PROPERTY_TYPE, byte*, uint, int> SetValueByName1;

        [NativeTypeName("HRESULT (UINT32, D2D1_PROPERTY_TYPE, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D2D1_PROPERTY_TYPE, byte*, uint, int> SetValue1;

        [NativeTypeName("HRESULT (PCWSTR, D2D1_PROPERTY_TYPE, BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, D2D1_PROPERTY_TYPE, byte*, uint, int> GetValueByName1;

        [NativeTypeName("HRESULT (UINT32, D2D1_PROPERTY_TYPE, BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D2D1_PROPERTY_TYPE, byte*, uint, int> GetValue1;

        [NativeTypeName("UINT32 (UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint> GetValueSize;

        [NativeTypeName("HRESULT (UINT32, ID2D1Properties **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ID2D1Properties**, int> GetSubProperties;
    }
}
