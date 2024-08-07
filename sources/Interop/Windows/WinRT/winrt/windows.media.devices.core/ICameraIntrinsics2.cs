// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICameraIntrinsics2.xml' path='doc/member[@name="ICameraIntrinsics2"]/*' />
[Guid("0CDAA447-0798-4B4D-839F-C5EC414DB27A")]
[NativeTypeName("struct ICameraIntrinsics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraIntrinsics2 : ICameraIntrinsics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraIntrinsics2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, Guid*, void**, int>)(lpVtbl[0]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, uint>)(lpVtbl[1]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, uint>)(lpVtbl[2]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, uint*, Guid**, int>)(lpVtbl[3]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, HSTRING*, int>)(lpVtbl[4]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, TrustLevel*, int>)(lpVtbl[5]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICameraIntrinsics2.xml' path='doc/member[@name="ICameraIntrinsics2.get_UndistortedProjectionTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UndistortedProjectionTransform([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, Matrix4x4*, int>)(lpVtbl[6]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICameraIntrinsics2.xml' path='doc/member[@name="ICameraIntrinsics2.DistortPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DistortPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point input, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, Point, Point*, int>)(lpVtbl[7]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), input, result);
    }

    /// <include file='ICameraIntrinsics2.xml' path='doc/member[@name="ICameraIntrinsics2.DistortPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DistortPoints([NativeTypeName("UINT32")] uint inputsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* inputs, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, uint, Point*, uint, Point*, int>)(lpVtbl[8]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), inputsLength, inputs, resultsLength, results);
    }

    /// <include file='ICameraIntrinsics2.xml' path='doc/member[@name="ICameraIntrinsics2.UndistortPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UndistortPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point input, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, Point, Point*, int>)(lpVtbl[9]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), input, result);
    }

    /// <include file='ICameraIntrinsics2.xml' path='doc/member[@name="ICameraIntrinsics2.UndistortPoints"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UndistortPoints([NativeTypeName("UINT32")] uint inputsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* inputs, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results)
    {
        return ((delegate* unmanaged[MemberFunction]<ICameraIntrinsics2*, uint, Point*, uint, Point*, int>)(lpVtbl[10]))((ICameraIntrinsics2*)Unsafe.AsPointer(ref this), inputsLength, inputs, resultsLength, results);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UndistortedProjectionTransform([NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value);

        [VtblIndex(7)]
        HRESULT DistortPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point input, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result);

        [VtblIndex(8)]
        HRESULT DistortPoints([NativeTypeName("UINT32")] uint inputsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* inputs, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results);

        [VtblIndex(9)]
        HRESULT UndistortPoint([NativeTypeName("ABI::Windows::Foundation::Point")] Point input, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* result);

        [VtblIndex(10)]
        HRESULT UndistortPoints([NativeTypeName("UINT32")] uint inputsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* inputs, [NativeTypeName("UINT32")] uint resultsLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* results);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Numerics::Matrix4x4 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Matrix4x4*, int> get_UndistortedProjectionTransform;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, Point*, int> DistortPoint;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Point *, UINT32, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Point*, uint, Point*, int> DistortPoints;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Point, Point*, int> UndistortPoint;

        [NativeTypeName("HRESULT (UINT32, ABI::Windows::Foundation::Point *, UINT32, ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Point*, uint, Point*, int> UndistortPoints;
    }
}
