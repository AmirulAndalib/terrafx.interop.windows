// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510525-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGMarkerElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGMarkerElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, uint>)(lpVtbl[1]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, uint>)(lpVtbl[2]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, uint*, int>)(lpVtbl[3]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int putref_refX(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_refX(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int putref_refY(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_refY(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int putref_markerUnits(ISVGAnimatedEnumeration* v)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[11]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_markerUnits(ISVGAnimatedEnumeration** p)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[12]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int putref_markerWidth(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_markerWidth(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int putref_markerHeight(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedLength*, int>)(lpVtbl[15]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_markerHeight(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedLength**, int>)(lpVtbl[16]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int putref_orientType(ISVGAnimatedEnumeration* v)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedEnumeration*, int>)(lpVtbl[17]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_orientType(ISVGAnimatedEnumeration** p)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedEnumeration**, int>)(lpVtbl[18]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int putref_orientAngle(ISVGAnimatedAngle* v)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedAngle*, int>)(lpVtbl[19]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_orientAngle(ISVGAnimatedAngle** p)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAnimatedAngle**, int>)(lpVtbl[20]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int setOrientToAuto()
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, int>)(lpVtbl[21]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int setOrientToAngle(ISVGAngle* pSVGAngle)
        {
            return ((delegate* unmanaged<ISVGMarkerElement*, ISVGAngle*, int>)(lpVtbl[22]))((ISVGMarkerElement*)Unsafe.AsPointer(ref this), pSVGAngle);
        }
    }
}