// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F648-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IMarkupContainer2 : IMarkupContainer")]
    [NativeInheritance("IMarkupContainer")]
    public unsafe partial struct IMarkupContainer2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMarkupContainer2*, Guid*, void**, int>)(lpVtbl[0]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMarkupContainer2*, uint>)(lpVtbl[1]))((IMarkupContainer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMarkupContainer2*, uint>)(lpVtbl[2]))((IMarkupContainer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OwningDoc(IHTMLDocument2** ppDoc)
        {
            return ((delegate* unmanaged<IMarkupContainer2*, IHTMLDocument2**, int>)(lpVtbl[3]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), ppDoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateChangeLog(IHTMLChangeSink* pChangeSink, IHTMLChangeLog** ppChangeLog, [NativeTypeName("BOOL")] int fForward, [NativeTypeName("BOOL")] int fBackward)
        {
            return ((delegate* unmanaged<IMarkupContainer2*, IHTMLChangeSink*, IHTMLChangeLog**, int, int, int>)(lpVtbl[4]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), pChangeSink, ppChangeLog, fForward, fBackward);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterForDirtyRange(IHTMLChangeSink* pChangeSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IMarkupContainer2*, IHTMLChangeSink*, uint*, int>)(lpVtbl[5]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), pChangeSink, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int UnRegisterForDirtyRange([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IMarkupContainer2*, uint, int>)(lpVtbl[6]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetAndClearDirtyRange([NativeTypeName("DWORD")] uint dwCookie, IMarkupPointer* pIPointerBegin, IMarkupPointer* pIPointerEnd)
        {
            return ((delegate* unmanaged<IMarkupContainer2*, uint, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[7]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), dwCookie, pIPointerBegin, pIPointerEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("long")]
        public int GetVersionNumber()
        {
            return ((delegate* unmanaged<IMarkupContainer2*, int>)(lpVtbl[8]))((IMarkupContainer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetMasterElement(IHTMLElement** ppElementMaster)
        {
            return ((delegate* unmanaged<IMarkupContainer2*, IHTMLElement**, int>)(lpVtbl[9]))((IMarkupContainer2*)Unsafe.AsPointer(ref this), ppElementMaster);
        }
    }
}