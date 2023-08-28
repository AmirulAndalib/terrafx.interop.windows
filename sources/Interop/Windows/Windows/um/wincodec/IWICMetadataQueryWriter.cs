// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICMetadataQueryWriter.xml' path='doc/member[@name="IWICMetadataQueryWriter"]/*' />
[Guid("A721791A-0DEF-4D06-BD91-2118BF1DB10B")]
[NativeTypeName("struct IWICMetadataQueryWriter : IWICMetadataQueryReader")]
[NativeInheritance("IWICMetadataQueryReader")]
public unsafe partial struct IWICMetadataQueryWriter : IWICMetadataQueryWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataQueryWriter));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, uint>)(lpVtbl[1]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, uint>)(lpVtbl[2]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWICMetadataQueryReader.GetContainerFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
    }

    /// <inheritdoc cref="IWICMetadataQueryReader.GetLocation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLocation(uint cchMaxLength, [NativeTypeName("WCHAR *")] char* wzNamespace, uint* pcchActualLength)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, uint, char*, uint*, int>)(lpVtbl[4]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
    }

    /// <inheritdoc cref="IWICMetadataQueryReader.GetMetadataByName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMetadataByName([NativeTypeName("LPCWSTR")] char* wzName, PROPVARIANT* pvarValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, char*, PROPVARIANT*, int>)(lpVtbl[5]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
    }

    /// <inheritdoc cref="IWICMetadataQueryReader.GetEnumerator" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEnumerator(IEnumString** ppIEnumString)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, IEnumString**, int>)(lpVtbl[6]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), ppIEnumString);
    }

    /// <include file='IWICMetadataQueryWriter.xml' path='doc/member[@name="IWICMetadataQueryWriter.SetMetadataByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMetadataByName([NativeTypeName("LPCWSTR")] char* wzName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, char*, PROPVARIANT*, int>)(lpVtbl[7]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
    }

    /// <include file='IWICMetadataQueryWriter.xml' path='doc/member[@name="IWICMetadataQueryWriter.RemoveMetadataByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveMetadataByName([NativeTypeName("LPCWSTR")] char* wzName)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICMetadataQueryWriter*, char*, int>)(lpVtbl[8]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName);
    }

    public interface Interface : IWICMetadataQueryReader.Interface
    {
        [VtblIndex(7)]
        HRESULT SetMetadataByName([NativeTypeName("LPCWSTR")] char* wzName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue);

        [VtblIndex(8)]
        HRESULT RemoveMetadataByName([NativeTypeName("LPCWSTR")] char* wzName);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetLocation;

        [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> GetMetadataByName;

        [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEnumString**, int> GetEnumerator;

        [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, PROPVARIANT*, int> SetMetadataByName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> RemoveMetadataByName;
    }
}
