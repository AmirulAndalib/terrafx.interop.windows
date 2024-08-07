// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IScheduledToastNotification2.xml' path='doc/member[@name="IScheduledToastNotification2"]/*' />
[Guid("A66EA09C-31B4-43B0-B5DD-7A40E85363B1")]
[NativeTypeName("struct IScheduledToastNotification2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScheduledToastNotification2 : IScheduledToastNotification2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScheduledToastNotification2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, Guid*, void**, int>)(lpVtbl[0]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, uint>)(lpVtbl[1]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, uint>)(lpVtbl[2]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, uint*, Guid**, int>)(lpVtbl[3]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, HSTRING*, int>)(lpVtbl[4]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, TrustLevel*, int>)(lpVtbl[5]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IScheduledToastNotification2.xml' path='doc/member[@name="IScheduledToastNotification2.put_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Tag(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, HSTRING, int>)(lpVtbl[6]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification2.xml' path='doc/member[@name="IScheduledToastNotification2.get_Tag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Tag(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, HSTRING*, int>)(lpVtbl[7]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification2.xml' path='doc/member[@name="IScheduledToastNotification2.put_Group"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Group(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, HSTRING, int>)(lpVtbl[8]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification2.xml' path='doc/member[@name="IScheduledToastNotification2.get_Group"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Group(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, HSTRING*, int>)(lpVtbl[9]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification2.xml' path='doc/member[@name="IScheduledToastNotification2.put_SuppressPopup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SuppressPopup([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, byte, int>)(lpVtbl[10]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IScheduledToastNotification2.xml' path='doc/member[@name="IScheduledToastNotification2.get_SuppressPopup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SuppressPopup([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IScheduledToastNotification2*, byte*, int>)(lpVtbl[11]))((IScheduledToastNotification2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Tag(HSTRING value);

        [VtblIndex(7)]
        HRESULT get_Tag(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_Group(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_Group(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_SuppressPopup([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_SuppressPopup([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Tag;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Tag;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Group;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Group;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_SuppressPopup;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_SuppressPopup;
    }
}
