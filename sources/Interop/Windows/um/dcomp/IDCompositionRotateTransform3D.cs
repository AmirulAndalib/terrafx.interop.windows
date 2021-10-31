// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8F5B23F-D429-4A91-B55A-D2F45FD75B18")]
    [NativeTypeName("struct IDCompositionRotateTransform3D : IDCompositionTransform3D")]
    [NativeInheritance("IDCompositionTransform3D")]
    public unsafe partial struct IDCompositionRotateTransform3D
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, uint>)(lpVtbl[1]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, uint>)(lpVtbl[2]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetAngle(float angle)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[4]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetAngle(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetAxisX(float axisX)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[6]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetAxisX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetAxisY(float axisY)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[8]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetAxisY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetAxisZ(float axisZ)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[10]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetAxisZ(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetCenterX(float centerX)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[12]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetCenterX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetCenterY(float centerY)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[14]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetCenterY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetCenterZ(float centerZ)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[16]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetCenterZ(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[15]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
