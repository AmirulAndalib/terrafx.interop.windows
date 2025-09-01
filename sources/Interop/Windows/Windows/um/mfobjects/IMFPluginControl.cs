// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFPluginControl.xml' path='doc/member[@name="IMFPluginControl"]/*' />
[Guid("5C6C44BF-1DB6-435B-9249-E8CD10FDEC96")]
[NativeTypeName("struct IMFPluginControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPluginControl : IMFPluginControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IMFPluginControl);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFPluginControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, uint>)(lpVtbl[1]))((IMFPluginControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, uint>)(lpVtbl[2]))((IMFPluginControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPluginControl.xml' path='doc/member[@name="IMFPluginControl.GetPreferredClsid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] char* selector, [NativeTypeName("CLSID *")] Guid* clsid)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, uint, char*, Guid*, int>)(lpVtbl[3]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, selector, clsid);
    }

    /// <include file='IMFPluginControl.xml' path='doc/member[@name="IMFPluginControl.GetPreferredClsidByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("LPWSTR *")] char** selector, [NativeTypeName("CLSID *")] Guid* clsid)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, uint, uint, char**, Guid*, int>)(lpVtbl[4]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, index, selector, clsid);
    }

    /// <include file='IMFPluginControl.xml' path='doc/member[@name="IMFPluginControl.SetPreferredClsid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] char* selector, [NativeTypeName("const CLSID *")] Guid* clsid)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, uint, char*, Guid*, int>)(lpVtbl[5]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, selector, clsid);
    }

    /// <include file='IMFPluginControl.xml' path='doc/member[@name="IMFPluginControl.IsDisabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, uint, Guid*, int>)(lpVtbl[6]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, clsid);
    }

    /// <include file='IMFPluginControl.xml' path='doc/member[@name="IMFPluginControl.GetDisabledByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisabledByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, uint, uint, Guid*, int>)(lpVtbl[7]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, index, clsid);
    }

    /// <include file='IMFPluginControl.xml' path='doc/member[@name="IMFPluginControl.SetDisabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid, BOOL disabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFPluginControl*, uint, Guid*, BOOL, int>)(lpVtbl[8]))((IMFPluginControl*)Unsafe.AsPointer(ref this), pluginType, clsid, disabled);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] char* selector, [NativeTypeName("CLSID *")] Guid* clsid);

        [VtblIndex(4)]
        HRESULT GetPreferredClsidByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("LPWSTR *")] char** selector, [NativeTypeName("CLSID *")] Guid* clsid);

        [VtblIndex(5)]
        HRESULT SetPreferredClsid([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("LPCWSTR")] char* selector, [NativeTypeName("const CLSID *")] Guid* clsid);

        [VtblIndex(6)]
        HRESULT IsDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid);

        [VtblIndex(7)]
        HRESULT GetDisabledByIndex([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("DWORD")] uint index, [NativeTypeName("CLSID *")] Guid* clsid);

        [VtblIndex(8)]
        HRESULT SetDisabled([NativeTypeName("DWORD")] uint pluginType, [NativeTypeName("const IID &")] Guid* clsid, BOOL disabled);
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

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, Guid*, int> GetPreferredClsid;

        [NativeTypeName("HRESULT (DWORD, DWORD, LPWSTR *, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, char**, Guid*, int> GetPreferredClsidByIndex;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, const CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, Guid*, int> SetPreferredClsid;

        [NativeTypeName("HRESULT (DWORD, const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, int> IsDisabled;

        [NativeTypeName("HRESULT (DWORD, DWORD, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, Guid*, int> GetDisabledByIndex;

        [NativeTypeName("HRESULT (DWORD, const IID &, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, BOOL, int> SetDisabled;
    }
}
