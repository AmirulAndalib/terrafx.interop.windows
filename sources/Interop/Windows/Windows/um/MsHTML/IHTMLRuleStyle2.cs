// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F4AC-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLRuleStyle2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLRuleStyle2 : IHTMLRuleStyle2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, uint>)(lpVtbl[1]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, uint>)(lpVtbl[2]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, uint*, int>)(lpVtbl[3]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_tableLayout([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[7]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_tableLayout([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[8]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_borderCollapse([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[9]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_borderCollapse([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[10]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_direction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[11]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[12]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[13]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[14]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_position([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[15]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_position([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[16]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_unicodeBidi([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[17]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[18]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_bottom(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int>)(lpVtbl[19]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_bottom(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int>)(lpVtbl[20]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_right(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int>)(lpVtbl[21]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_right(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int>)(lpVtbl[22]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_pixelBottom([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, int, int>)(lpVtbl[23]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_pixelBottom([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, int*, int>)(lpVtbl[24]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_pixelRight([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, int, int>)(lpVtbl[25]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_pixelRight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, int*, int>)(lpVtbl[26]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_posBottom(float v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, float, int>)(lpVtbl[27]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_posBottom(float* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, float*, int>)(lpVtbl[28]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_posRight(float v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, float, int>)(lpVtbl[29]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_posRight(float* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, float*, int>)(lpVtbl[30]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_imeMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[31]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_imeMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[32]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_rubyAlign([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[33]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_rubyAlign([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[34]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT put_rubyPosition([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[35]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_rubyPosition([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[36]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT put_rubyOverhang([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[37]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[38]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT put_layoutGridChar(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int>)(lpVtbl[39]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_layoutGridChar(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int>)(lpVtbl[40]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT put_layoutGridLine(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int>)(lpVtbl[41]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_layoutGridLine(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int>)(lpVtbl[42]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT put_layoutGridMode([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[43]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[44]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT put_layoutGridType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[45]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_layoutGridType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[46]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT put_layoutGrid([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[47]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_layoutGrid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[48]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT put_textAutospace([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[49]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_textAutospace([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[50]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT put_wordBreak([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[51]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_wordBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[52]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT put_lineBreak([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[53]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get_lineBreak([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[54]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT put_textJustify([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[55]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT get_textJustify([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[56]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[57]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[58]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT put_textKashida(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int>)(lpVtbl[59]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT get_textKashida(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int>)(lpVtbl[60]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT put_overflowX([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[61]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT get_overflowX([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[62]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT put_overflowY([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[63]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT get_overflowY([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[64]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT put_accelerator([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int>)(lpVtbl[65]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT get_accelerator([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int>)(lpVtbl[66]))((IHTMLRuleStyle2*)Unsafe.AsPointer(ref this), p);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT put_tableLayout([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(8)]
            HRESULT get_tableLayout([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(9)]
            HRESULT put_borderCollapse([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(10)]
            HRESULT get_borderCollapse([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(11)]
            HRESULT put_direction([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(12)]
            HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(13)]
            HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(14)]
            HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(15)]
            HRESULT put_position([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(16)]
            HRESULT get_position([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(17)]
            HRESULT put_unicodeBidi([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(18)]
            HRESULT get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(19)]
            HRESULT put_bottom(VARIANT v);

            [VtblIndex(20)]
            HRESULT get_bottom(VARIANT* p);

            [VtblIndex(21)]
            HRESULT put_right(VARIANT v);

            [VtblIndex(22)]
            HRESULT get_right(VARIANT* p);

            [VtblIndex(23)]
            HRESULT put_pixelBottom([NativeTypeName("long")] int v);

            [VtblIndex(24)]
            HRESULT get_pixelBottom([NativeTypeName("long *")] int* p);

            [VtblIndex(25)]
            HRESULT put_pixelRight([NativeTypeName("long")] int v);

            [VtblIndex(26)]
            HRESULT get_pixelRight([NativeTypeName("long *")] int* p);

            [VtblIndex(27)]
            HRESULT put_posBottom(float v);

            [VtblIndex(28)]
            HRESULT get_posBottom(float* p);

            [VtblIndex(29)]
            HRESULT put_posRight(float v);

            [VtblIndex(30)]
            HRESULT get_posRight(float* p);

            [VtblIndex(31)]
            HRESULT put_imeMode([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(32)]
            HRESULT get_imeMode([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(33)]
            HRESULT put_rubyAlign([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(34)]
            HRESULT get_rubyAlign([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(35)]
            HRESULT put_rubyPosition([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(36)]
            HRESULT get_rubyPosition([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(37)]
            HRESULT put_rubyOverhang([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(38)]
            HRESULT get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(39)]
            HRESULT put_layoutGridChar(VARIANT v);

            [VtblIndex(40)]
            HRESULT get_layoutGridChar(VARIANT* p);

            [VtblIndex(41)]
            HRESULT put_layoutGridLine(VARIANT v);

            [VtblIndex(42)]
            HRESULT get_layoutGridLine(VARIANT* p);

            [VtblIndex(43)]
            HRESULT put_layoutGridMode([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(44)]
            HRESULT get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(45)]
            HRESULT put_layoutGridType([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(46)]
            HRESULT get_layoutGridType([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(47)]
            HRESULT put_layoutGrid([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(48)]
            HRESULT get_layoutGrid([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(49)]
            HRESULT put_textAutospace([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(50)]
            HRESULT get_textAutospace([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(51)]
            HRESULT put_wordBreak([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(52)]
            HRESULT get_wordBreak([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(53)]
            HRESULT put_lineBreak([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(54)]
            HRESULT get_lineBreak([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(55)]
            HRESULT put_textJustify([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(56)]
            HRESULT get_textJustify([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(57)]
            HRESULT put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(58)]
            HRESULT get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(59)]
            HRESULT put_textKashida(VARIANT v);

            [VtblIndex(60)]
            HRESULT get_textKashida(VARIANT* p);

            [VtblIndex(61)]
            HRESULT put_overflowX([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(62)]
            HRESULT get_overflowX([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(63)]
            HRESULT put_overflowY([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(64)]
            HRESULT get_overflowY([NativeTypeName("BSTR *")] ushort** p);

            [VtblIndex(65)]
            HRESULT put_accelerator([NativeTypeName("BSTR")] ushort* v);

            [VtblIndex(66)]
            HRESULT get_accelerator([NativeTypeName("BSTR *")] ushort** p);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_tableLayout;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_tableLayout;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_borderCollapse;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_borderCollapse;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_direction;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_direction;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_behavior;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_behavior;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_position;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_position;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_unicodeBidi;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_unicodeBidi;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int> put_bottom;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int> get_bottom;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int> put_right;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int> get_right;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, int, int> put_pixelBottom;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, int*, int> get_pixelBottom;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, int, int> put_pixelRight;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, int*, int> get_pixelRight;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, float, int> put_posBottom;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, float*, int> get_posBottom;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, float, int> put_posRight;

            [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, float*, int> get_posRight;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_imeMode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_imeMode;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_rubyAlign;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_rubyAlign;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_rubyPosition;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_rubyPosition;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_rubyOverhang;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_rubyOverhang;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int> put_layoutGridChar;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int> get_layoutGridChar;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int> put_layoutGridLine;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int> get_layoutGridLine;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_layoutGridMode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_layoutGridMode;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_layoutGridType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_layoutGridType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_layoutGrid;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_layoutGrid;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_textAutospace;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_textAutospace;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_wordBreak;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_wordBreak;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_lineBreak;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_lineBreak;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_textJustify;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_textJustify;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_textJustifyTrim;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_textJustifyTrim;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT, int> put_textKashida;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, VARIANT*, int> get_textKashida;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_overflowX;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_overflowX;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_overflowY;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_overflowY;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort*, int> put_accelerator;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLRuleStyle2*, ushort**, int> get_accelerator;
        }
    }
}
