// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F6A0-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLEditHost : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLEditHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLEditHost*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEditHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLEditHost*, uint>)(lpVtbl[1]))((IHTMLEditHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLEditHost*, uint>)(lpVtbl[2]))((IHTMLEditHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SnapRect(IHTMLElement* pIElement, RECT* prcNew, ELEMENT_CORNER eHandle)
        {
            return ((delegate* unmanaged<IHTMLEditHost*, IHTMLElement*, RECT*, ELEMENT_CORNER, int>)(lpVtbl[3]))((IHTMLEditHost*)Unsafe.AsPointer(ref this), pIElement, prcNew, eHandle);
        }
    }
}