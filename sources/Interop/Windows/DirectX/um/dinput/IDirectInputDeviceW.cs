// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW"]/*' />
[Guid("5944E681-C92E-11CF-BFC7-444553540000")]
[NativeTypeName("struct IDirectInputDeviceW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectInputDeviceW : IDirectInputDeviceW.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDirectInputDeviceW);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, Guid*, void**, int>)(lpVtbl[0]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, uint>)(lpVtbl[1]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, uint>)(lpVtbl[2]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.GetCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapabilities([NativeTypeName("LPDIDEVCAPS")] DIDEVCAPS* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, DIDEVCAPS*, int>)(lpVtbl[3]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.EnumObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects([NativeTypeName("LPDIENUMDEVICEOBJECTSCALLBACKW")] delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, void*, BOOL> param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, void*, BOOL>, void*, uint, int>)(lpVtbl[4]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.GetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIPROPHEADER")] DIPROPHEADER* param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, Guid*, DIPROPHEADER*, int>)(lpVtbl[5]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.SetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIPROPHEADER")] DIPROPHEADER* param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, Guid*, DIPROPHEADER*, int>)(lpVtbl[6]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.Acquire"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Acquire()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, int>)(lpVtbl[7]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.Unacquire"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unacquire()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, int>)(lpVtbl[8]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.GetDeviceState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceState([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, uint, void*, int>)(lpVtbl[9]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.GetDeviceData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceData([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1, [NativeTypeName("LPDWORD")] uint* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int>)(lpVtbl[10]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.SetDataFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDataFormat([NativeTypeName("LPCDIDATAFORMAT")] DIDATAFORMAT* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, DIDATAFORMAT*, int>)(lpVtbl[11]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.SetEventNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetEventNotification(HANDLE param0)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, HANDLE, int>)(lpVtbl[12]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.SetCooperativeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, HWND, uint, int>)(lpVtbl[13]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.GetObjectInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetObjectInfo([NativeTypeName("LPDIDEVICEOBJECTINSTANCEW")] DIDEVICEOBJECTINSTANCE* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, DIDEVICEOBJECTINSTANCE*, uint, uint, int>)(lpVtbl[14]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.GetDeviceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceInfo([NativeTypeName("LPDIDEVICEINSTANCEW")] DIDEVICEINSTANCE* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, DIDEVICEINSTANCE*, int>)(lpVtbl[15]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.RunControlPanel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, HWND, uint, int>)(lpVtbl[16]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDeviceW.xml' path='doc/member[@name="IDirectInputDeviceW.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("const GUID &")] Guid* param2)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInputDeviceW*, HINSTANCE, uint, Guid*, int>)(lpVtbl[17]))((IDirectInputDeviceW*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCapabilities([NativeTypeName("LPDIDEVCAPS")] DIDEVCAPS* param0);

        [VtblIndex(5)]
        HRESULT GetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIPROPHEADER")] DIPROPHEADER* param1);

        [VtblIndex(6)]
        HRESULT SetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIPROPHEADER")] DIPROPHEADER* param1);

        [VtblIndex(7)]
        HRESULT Acquire();

        [VtblIndex(8)]
        HRESULT Unacquire();

        [VtblIndex(9)]
        HRESULT GetDeviceState([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1);

        [VtblIndex(10)]
        HRESULT GetDeviceData([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1, [NativeTypeName("LPDWORD")] uint* param2, [NativeTypeName("DWORD")] uint param3);

        [VtblIndex(11)]
        HRESULT SetDataFormat([NativeTypeName("LPCDIDATAFORMAT")] DIDATAFORMAT* param0);

        [VtblIndex(12)]
        HRESULT SetEventNotification(HANDLE param0);

        [VtblIndex(13)]
        HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(14)]
        HRESULT GetObjectInfo([NativeTypeName("LPDIDEVICEOBJECTINSTANCEW")] DIDEVICEOBJECTINSTANCE* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

        [VtblIndex(15)]
        HRESULT GetDeviceInfo([NativeTypeName("LPDIDEVICEINSTANCEW")] DIDEVICEINSTANCE* param0);

        [VtblIndex(16)]
        HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(17)]
        HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("const GUID &")] Guid* param2);
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

        [NativeTypeName("HRESULT (LPDIDEVCAPS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DIDEVCAPS*, int> GetCapabilities;

        [NativeTypeName("HRESULT (LPDIENUMDEVICEOBJECTSCALLBACKW, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, void*, BOOL>, void*, uint, int> EnumObjects;

        [NativeTypeName("HRESULT (const GUID &, LPDIPROPHEADER) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, DIPROPHEADER*, int> GetProperty;

        [NativeTypeName("HRESULT (const GUID &, LPCDIPROPHEADER) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, DIPROPHEADER*, int> SetProperty;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Acquire;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Unacquire;

        [NativeTypeName("HRESULT (DWORD, LPVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*, int> GetDeviceState;

        [NativeTypeName("HRESULT (DWORD, LPDIDEVICEOBJECTDATA, LPDWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int> GetDeviceData;

        [NativeTypeName("HRESULT (LPCDIDATAFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DIDATAFORMAT*, int> SetDataFormat;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HANDLE, int> SetEventNotification;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, uint, int> SetCooperativeLevel;

        [NativeTypeName("HRESULT (LPDIDEVICEOBJECTINSTANCEW, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DIDEVICEOBJECTINSTANCE*, uint, uint, int> GetObjectInfo;

        [NativeTypeName("HRESULT (LPDIDEVICEINSTANCEW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, DIDEVICEINSTANCE*, int> GetDeviceInfo;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, uint, int> RunControlPanel;

        [NativeTypeName("HRESULT (HINSTANCE, DWORD, const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HINSTANCE, uint, Guid*, int> Initialize;
    }
}
