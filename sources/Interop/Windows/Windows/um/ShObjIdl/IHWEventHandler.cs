// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHWEventHandler.xml' path='doc/member[@name="IHWEventHandler"]/*' />
[Guid("C1FB73D0-EC3A-4BA2-B512-8CDB9187B6D1")]
[NativeTypeName("struct IHWEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHWEventHandler : IHWEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHWEventHandler);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHWEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IHWEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IHWEventHandler*, uint>)(lpVtbl[1]))((IHWEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IHWEventHandler*, uint>)(lpVtbl[2]))((IHWEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHWEventHandler.xml' path='doc/member[@name="IHWEventHandler.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize([NativeTypeName("LPCWSTR")] char* pszParams)
    {
        return ((delegate* unmanaged[MemberFunction]<IHWEventHandler*, char*, int>)(lpVtbl[3]))((IHWEventHandler*)Unsafe.AsPointer(ref this), pszParams);
    }

    /// <include file='IHWEventHandler.xml' path='doc/member[@name="IHWEventHandler.HandleEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT HandleEvent([NativeTypeName("LPCWSTR")] char* pszDeviceID, [NativeTypeName("LPCWSTR")] char* pszAltDeviceID, [NativeTypeName("LPCWSTR")] char* pszEventType)
    {
        return ((delegate* unmanaged[MemberFunction]<IHWEventHandler*, char*, char*, char*, int>)(lpVtbl[4]))((IHWEventHandler*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType);
    }

    /// <include file='IHWEventHandler.xml' path='doc/member[@name="IHWEventHandler.HandleEventWithContent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT HandleEventWithContent([NativeTypeName("LPCWSTR")] char* pszDeviceID, [NativeTypeName("LPCWSTR")] char* pszAltDeviceID, [NativeTypeName("LPCWSTR")] char* pszEventType, [NativeTypeName("LPCWSTR")] char* pszContentTypeHandler, IDataObject* pdataobject)
    {
        return ((delegate* unmanaged[MemberFunction]<IHWEventHandler*, char*, char*, char*, char*, IDataObject*, int>)(lpVtbl[5]))((IHWEventHandler*)Unsafe.AsPointer(ref this), pszDeviceID, pszAltDeviceID, pszEventType, pszContentTypeHandler, pdataobject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize([NativeTypeName("LPCWSTR")] char* pszParams);

        [VtblIndex(4)]
        HRESULT HandleEvent([NativeTypeName("LPCWSTR")] char* pszDeviceID, [NativeTypeName("LPCWSTR")] char* pszAltDeviceID, [NativeTypeName("LPCWSTR")] char* pszEventType);

        [VtblIndex(5)]
        HRESULT HandleEventWithContent([NativeTypeName("LPCWSTR")] char* pszDeviceID, [NativeTypeName("LPCWSTR")] char* pszAltDeviceID, [NativeTypeName("LPCWSTR")] char* pszEventType, [NativeTypeName("LPCWSTR")] char* pszContentTypeHandler, IDataObject* pdataobject);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> Initialize;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, int> HandleEvent;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, char*, IDataObject*, int> HandleEventWithContent;
    }
}
