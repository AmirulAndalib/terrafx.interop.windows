// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F3ED-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ICSSFilterSite : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICSSFilterSite : ICSSFilterSite.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICSSFilterSite*, Guid*, void**, int>)(lpVtbl[0]))((ICSSFilterSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICSSFilterSite*, uint>)(lpVtbl[1]))((ICSSFilterSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICSSFilterSite*, uint>)(lpVtbl[2]))((ICSSFilterSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetElement(IHTMLElement** Element)
        {
            return ((delegate* unmanaged<ICSSFilterSite*, IHTMLElement**, int>)(lpVtbl[3]))((ICSSFilterSite*)Unsafe.AsPointer(ref this), Element);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT FireOnFilterChangeEvent()
        {
            return ((delegate* unmanaged<ICSSFilterSite*, int>)(lpVtbl[4]))((ICSSFilterSite*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetElement(IHTMLElement** Element);

            [VtblIndex(4)]
            HRESULT FireOnFilterChangeEvent();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICSSFilterSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICSSFilterSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICSSFilterSite*, uint> Release;

            [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICSSFilterSite*, IHTMLElement**, int> GetElement;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ICSSFilterSite*, int> FireOnFilterChangeEvent;
        }
    }
}