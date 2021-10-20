// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FECEAAA5-8405-11CF-8BA1-00AA00476DA6")]
    [NativeTypeName("struct IOmNavigator : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IOmNavigator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOmNavigator*, Guid*, void**, int>)(lpVtbl[0]))((IOmNavigator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOmNavigator*, uint>)(lpVtbl[1]))((IOmNavigator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOmNavigator*, uint>)(lpVtbl[2]))((IOmNavigator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IOmNavigator*, uint*, int>)(lpVtbl[3]))((IOmNavigator*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IOmNavigator*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IOmNavigator*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IOmNavigator*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IOmNavigator*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IOmNavigator*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IOmNavigator*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_appCodeName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[7]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_appName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[8]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_appVersion([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[9]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_userAgent([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[10]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int javaEnabled([NativeTypeName("VARIANT_BOOL *")] short* enabled)
        {
            return ((delegate* unmanaged<IOmNavigator*, short*, int>)(lpVtbl[11]))((IOmNavigator*)Unsafe.AsPointer(ref this), enabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int taintEnabled([NativeTypeName("VARIANT_BOOL *")] short* enabled)
        {
            return ((delegate* unmanaged<IOmNavigator*, short*, int>)(lpVtbl[12]))((IOmNavigator*)Unsafe.AsPointer(ref this), enabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_mimeTypes(IHTMLMimeTypesCollection** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, IHTMLMimeTypesCollection**, int>)(lpVtbl[13]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_plugins(IHTMLPluginsCollection** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, IHTMLPluginsCollection**, int>)(lpVtbl[14]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_cookieEnabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IOmNavigator*, short*, int>)(lpVtbl[15]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_opsProfile(IHTMLOpsProfile** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, IHTMLOpsProfile**, int>)(lpVtbl[16]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int toString([NativeTypeName("BSTR *")] ushort** @string)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[17]))((IOmNavigator*)Unsafe.AsPointer(ref this), @string);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_cpuClass([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[18]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_systemLanguage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[19]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_browserLanguage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[20]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_userLanguage([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[21]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_platform([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[22]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_appMinorVersion([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, ushort**, int>)(lpVtbl[23]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_connectionSpeed([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IOmNavigator*, int*, int>)(lpVtbl[24]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_onLine([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IOmNavigator*, short*, int>)(lpVtbl[25]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_userProfile(IHTMLOpsProfile** p)
        {
            return ((delegate* unmanaged<IOmNavigator*, IHTMLOpsProfile**, int>)(lpVtbl[26]))((IOmNavigator*)Unsafe.AsPointer(ref this), p);
        }
    }
}