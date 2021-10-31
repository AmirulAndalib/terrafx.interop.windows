// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30510529-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISVGLinearGradientElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISVGLinearGradientElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, uint>)(lpVtbl[1]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, uint>)(lpVtbl[2]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, uint*, int>)(lpVtbl[3]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT putref_x1(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_x1(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_y1(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_y1(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT putref_x2(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_x2(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT putref_y2(ISVGAnimatedLength* v)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_y2(ISVGAnimatedLength** p)
        {
            return ((delegate* unmanaged<ISVGLinearGradientElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGLinearGradientElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
