// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirectInput7A.xml' path='doc/member[@name="IDirectInput7A"]/*' />
[Guid("9A4CB684-236D-11D3-8E9D-00C04F6844AE")]
[NativeTypeName("struct IDirectInput7A : IDirectInput2A")]
[NativeInheritance("IDirectInput2A")]
public unsafe partial struct IDirectInput7A : IDirectInput7A.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInput7A));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, Guid*, void**, int>)(lpVtbl[0]))((IDirectInput7A*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, uint>)(lpVtbl[1]))((IDirectInput7A*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, uint>)(lpVtbl[2]))((IDirectInput7A*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirectInputA.CreateDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIRECTINPUTDEVICEA *")] IDirectInputDeviceA** param1, [NativeTypeName("LPUNKNOWN")] IUnknown* param2)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, Guid*, IDirectInputDeviceA**, IUnknown*, int>)(lpVtbl[3]))((IDirectInput7A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <inheritdoc cref="IDirectInputA.EnumDevices" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumDevices([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIENUMDEVICESCALLBACKA")] delegate* unmanaged<DIDEVICEINSTANCEA*, void*, BOOL> param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, uint, delegate* unmanaged<DIDEVICEINSTANCEA*, void*, BOOL>, void*, uint, int>)(lpVtbl[4]))((IDirectInput7A*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <inheritdoc cref="IDirectInputA.GetDeviceStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDeviceStatus([NativeTypeName("const GUID &")] Guid* param0)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, Guid*, int>)(lpVtbl[5]))((IDirectInput7A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <inheritdoc cref="IDirectInputA.RunControlPanel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, HWND, uint, int>)(lpVtbl[6]))((IDirectInput7A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref="IDirectInputA.Initialize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, HINSTANCE, uint, int>)(lpVtbl[7]))((IDirectInput7A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref="IDirectInput2A.FindDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPGUID")] Guid* param2)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, Guid*, sbyte*, Guid*, int>)(lpVtbl[8]))((IDirectInput7A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInput7A.xml' path='doc/member[@name="IDirectInput7A.CreateDeviceEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDeviceEx([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("const IID &")] Guid* param1, [NativeTypeName("LPVOID *")] void** param2, [NativeTypeName("LPUNKNOWN")] IUnknown* param3)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirectInput7A*, Guid*, Guid*, void**, IUnknown*, int>)(lpVtbl[9]))((IDirectInput7A*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    public interface Interface : IDirectInput2A.Interface
    {
        [VtblIndex(9)]
        HRESULT CreateDeviceEx([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("const IID &")] Guid* param1, [NativeTypeName("LPVOID *")] void** param2, [NativeTypeName("LPUNKNOWN")] IUnknown* param3);
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

        [NativeTypeName("HRESULT (const GUID &, LPDIRECTINPUTDEVICEA *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, IDirectInputDeviceA**, IUnknown*, int> CreateDevice;

        [NativeTypeName("HRESULT (DWORD, LPDIENUMDEVICESCALLBACKA, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, delegate* unmanaged<DIDEVICEINSTANCEA*, void*, BOOL>, void*, uint, int> EnumDevices;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetDeviceStatus;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, uint, int> RunControlPanel;

        [NativeTypeName("HRESULT (HINSTANCE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HINSTANCE, uint, int> Initialize;

        [NativeTypeName("HRESULT (const GUID &, LPCSTR, LPGUID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, sbyte*, Guid*, int> FindDevice;

        [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, Guid*, void**, IUnknown*, int> CreateDeviceEx;
    }
}
