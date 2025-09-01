// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IShellImageDataFactory.xml' path='doc/member[@name="IShellImageDataFactory"]/*' />
[Guid("9BE8ED5C-EDAB-4D75-90F3-BD5BDBB21C82")]
[NativeTypeName("struct IShellImageDataFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellImageDataFactory : IShellImageDataFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IShellImageDataFactory);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellImageDataFactory*, Guid*, void**, int>)(lpVtbl[0]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellImageDataFactory*, uint>)(lpVtbl[1]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellImageDataFactory*, uint>)(lpVtbl[2]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellImageDataFactory.xml' path='doc/member[@name="IShellImageDataFactory.CreateIShellImageData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateIShellImageData(IShellImageData** ppshimg)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellImageDataFactory*, IShellImageData**, int>)(lpVtbl[3]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), ppshimg);
    }

    /// <include file='IShellImageDataFactory.xml' path='doc/member[@name="IShellImageDataFactory.CreateImageFromFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateImageFromFile([NativeTypeName("LPCWSTR")] char* pszPath, IShellImageData** ppshimg)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellImageDataFactory*, char*, IShellImageData**, int>)(lpVtbl[4]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), pszPath, ppshimg);
    }

    /// <include file='IShellImageDataFactory.xml' path='doc/member[@name="IShellImageDataFactory.CreateImageFromStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateImageFromStream(IStream* pStream, IShellImageData** ppshimg)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellImageDataFactory*, IStream*, IShellImageData**, int>)(lpVtbl[5]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), pStream, ppshimg);
    }

    /// <include file='IShellImageDataFactory.xml' path='doc/member[@name="IShellImageDataFactory.GetDataFormatFromPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDataFormatFromPath([NativeTypeName("LPCWSTR")] char* pszPath, Guid* pDataFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellImageDataFactory*, char*, Guid*, int>)(lpVtbl[6]))((IShellImageDataFactory*)Unsafe.AsPointer(ref this), pszPath, pDataFormat);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateIShellImageData(IShellImageData** ppshimg);

        [VtblIndex(4)]
        HRESULT CreateImageFromFile([NativeTypeName("LPCWSTR")] char* pszPath, IShellImageData** ppshimg);

        [VtblIndex(5)]
        HRESULT CreateImageFromStream(IStream* pStream, IShellImageData** ppshimg);

        [VtblIndex(6)]
        HRESULT GetDataFormatFromPath([NativeTypeName("LPCWSTR")] char* pszPath, Guid* pDataFormat);
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

        [NativeTypeName("HRESULT (IShellImageData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellImageData**, int> CreateIShellImageData;

        [NativeTypeName("HRESULT (LPCWSTR, IShellImageData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, IShellImageData**, int> CreateImageFromFile;

        [NativeTypeName("HRESULT (IStream *, IShellImageData **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, IShellImageData**, int> CreateImageFromStream;

        [NativeTypeName("HRESULT (LPCWSTR, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, Guid*, int> GetDataFormatFromPath;
    }
}
