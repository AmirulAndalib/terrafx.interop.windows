// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051045D-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElement5 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLElement5
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElement5*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElement5*, uint>)(lpVtbl[1]))((IHTMLElement5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElement5*, uint>)(lpVtbl[2]))((IHTMLElement5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement5*, uint*, int>)(lpVtbl[3]))((IHTMLElement5*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement5*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement5*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement5*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement5*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement5*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement5*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT getAttributeNode([NativeTypeName("BSTR")] ushort* bstrname, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[7]))((IHTMLElement5*)Unsafe.AsPointer(ref this), bstrname, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT setAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement5*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[8]))((IHTMLElement5*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT removeAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement5*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[9]))((IHTMLElement5*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT hasAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* pfHasAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, short*, int>)(lpVtbl[10]))((IHTMLElement5*)Unsafe.AsPointer(ref this), name, pfHasAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_role([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[11]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_role([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[12]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_ariaBusy([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[13]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_ariaBusy([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[14]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_ariaChecked([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[15]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_ariaChecked([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[16]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_ariaDisabled([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[17]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_ariaDisabled([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[18]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_ariaExpanded([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[19]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_ariaExpanded([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[20]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_ariaHaspopup([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[21]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_ariaHaspopup([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[22]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_ariaHidden([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[23]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_ariaHidden([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[24]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_ariaInvalid([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[25]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_ariaInvalid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[26]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_ariaMultiselectable([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[27]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_ariaMultiselectable([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[28]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_ariaPressed([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[29]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_ariaPressed([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[30]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_ariaReadonly([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[31]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_ariaReadonly([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[32]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_ariaRequired([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[33]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_ariaRequired([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[34]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT put_ariaSecret([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[35]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_ariaSecret([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[36]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT put_ariaSelected([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[37]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_ariaSelected([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[38]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, VARIANT*, int>)(lpVtbl[39]))((IHTMLElement5*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, VARIANT, int>)(lpVtbl[40]))((IHTMLElement5*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, short*, int>)(lpVtbl[41]))((IHTMLElement5*)Unsafe.AsPointer(ref this), strAttributeName, pfSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_attributes(IHTMLAttributeCollection3** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, IHTMLAttributeCollection3**, int>)(lpVtbl[42]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT put_ariaValuenow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[43]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_ariaValuenow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[44]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT put_ariaPosinset(short v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short, int>)(lpVtbl[45]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_ariaPosinset(short* p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short*, int>)(lpVtbl[46]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT put_ariaSetsize(short v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short, int>)(lpVtbl[47]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_ariaSetsize(short* p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short*, int>)(lpVtbl[48]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT put_ariaLevel(short v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short, int>)(lpVtbl[49]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_ariaLevel(short* p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short*, int>)(lpVtbl[50]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT put_ariaValuemin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[51]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_ariaValuemin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[52]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT put_ariaValuemax([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[53]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get_ariaValuemax([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[54]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT put_ariaControls([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[55]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT get_ariaControls([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[56]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT put_ariaDescribedby([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[57]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT get_ariaDescribedby([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[58]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT put_ariaFlowto([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[59]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT get_ariaFlowto([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[60]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT put_ariaLabelledby([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[61]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT get_ariaLabelledby([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[62]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT put_ariaActivedescendant([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[63]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT get_ariaActivedescendant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[64]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT put_ariaOwns([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[65]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT get_ariaOwns([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[66]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short*, int>)(lpVtbl[67]))((IHTMLElement5*)Unsafe.AsPointer(ref this), pfHasAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT put_ariaLive([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[68]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT get_ariaLive([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[69]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT put_ariaRelevant([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[70]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT get_ariaRelevant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[71]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, IHTMLDOMAttribute2**, int> getAttributeNode;

            [NativeTypeName("HRESULT (IHTMLDOMAttribute2 *, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> setAttributeNode;

            [NativeTypeName("HRESULT (IHTMLDOMAttribute2 *, IHTMLDOMAttribute2 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int> removeAttributeNode;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, short*, int> hasAttribute;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_role;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_role;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaBusy;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaBusy;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaChecked;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaChecked;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaDisabled;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaDisabled;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaExpanded;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaExpanded;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaHaspopup;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaHaspopup;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaHidden;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaHidden;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaInvalid;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaInvalid;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaMultiselectable;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaMultiselectable;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaPressed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaPressed;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaReadonly;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaReadonly;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaRequired;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaRequired;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaSecret;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaSecret;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaSelected;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaSelected;

            [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, VARIANT*, int> getAttribute;

            [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, VARIANT, int> setAttribute;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, short*, int> removeAttribute;

            [NativeTypeName("HRESULT (IHTMLAttributeCollection3 **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, IHTMLAttributeCollection3**, int> get_attributes;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaValuenow;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaValuenow;

            [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, short, int> put_ariaPosinset;

            [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, short*, int> get_ariaPosinset;

            [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, short, int> put_ariaSetsize;

            [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, short*, int> get_ariaSetsize;

            [NativeTypeName("HRESULT (short) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, short, int> put_ariaLevel;

            [NativeTypeName("HRESULT (short *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, short*, int> get_ariaLevel;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaValuemin;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaValuemin;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaValuemax;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaValuemax;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaControls;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaControls;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaDescribedby;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaDescribedby;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaFlowto;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaFlowto;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaLabelledby;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaLabelledby;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaActivedescendant;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaActivedescendant;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaOwns;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaOwns;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, short*, int> hasAttributes;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaLive;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaLive;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort*, int> put_ariaRelevant;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLElement5*, ushort**, int> get_ariaRelevant;
        }
    }
}
