// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("3050F69E-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IDisplayPointer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDisplayPointer : IDisplayPointer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDisplayPointer*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayPointer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDisplayPointer*, uint>)(lpVtbl[1]))((IDisplayPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDisplayPointer*, uint>)(lpVtbl[2]))((IDisplayPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT MoveToPoint(POINT ptPoint, COORD_SYSTEM eCoordSystem, IHTMLElement* pElementContext, [NativeTypeName("DWORD")] uint dwHitTestOptions, [NativeTypeName("DWORD *")] uint* pdwHitTestResults)
        {
            return ((delegate* unmanaged<IDisplayPointer*, POINT, COORD_SYSTEM, IHTMLElement*, uint, uint*, int>)(lpVtbl[3]))((IDisplayPointer*)Unsafe.AsPointer(ref this), ptPoint, eCoordSystem, pElementContext, dwHitTestOptions, pdwHitTestResults);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT MoveUnit(DISPLAY_MOVEUNIT eMoveUnit, [NativeTypeName("LONG")] int lXPos)
        {
            return ((delegate* unmanaged<IDisplayPointer*, DISPLAY_MOVEUNIT, int, int>)(lpVtbl[4]))((IDisplayPointer*)Unsafe.AsPointer(ref this), eMoveUnit, lXPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT PositionMarkupPointer(IMarkupPointer* pMarkupPointer)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IMarkupPointer*, int>)(lpVtbl[5]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pMarkupPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT MoveToPointer(IDisplayPointer* pDispPointer)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, int>)(lpVtbl[6]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pDispPointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetPointerGravity(POINTER_GRAVITY eGravity)
        {
            return ((delegate* unmanaged<IDisplayPointer*, POINTER_GRAVITY, int>)(lpVtbl[7]))((IDisplayPointer*)Unsafe.AsPointer(ref this), eGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetPointerGravity(POINTER_GRAVITY* peGravity)
        {
            return ((delegate* unmanaged<IDisplayPointer*, POINTER_GRAVITY*, int>)(lpVtbl[8]))((IDisplayPointer*)Unsafe.AsPointer(ref this), peGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetDisplayGravity(DISPLAY_GRAVITY eGravity)
        {
            return ((delegate* unmanaged<IDisplayPointer*, DISPLAY_GRAVITY, int>)(lpVtbl[9]))((IDisplayPointer*)Unsafe.AsPointer(ref this), eGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetDisplayGravity(DISPLAY_GRAVITY* peGravity)
        {
            return ((delegate* unmanaged<IDisplayPointer*, DISPLAY_GRAVITY*, int>)(lpVtbl[10]))((IDisplayPointer*)Unsafe.AsPointer(ref this), peGravity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT IsPositioned(BOOL* pfPositioned)
        {
            return ((delegate* unmanaged<IDisplayPointer*, BOOL*, int>)(lpVtbl[11]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pfPositioned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Unposition()
        {
            return ((delegate* unmanaged<IDisplayPointer*, int>)(lpVtbl[12]))((IDisplayPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT IsEqualTo(IDisplayPointer* pDispPointer, BOOL* pfIsEqual)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int>)(lpVtbl[13]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pDispPointer, pfIsEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT IsLeftOf(IDisplayPointer* pDispPointer, BOOL* pfIsLeftOf)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int>)(lpVtbl[14]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pDispPointer, pfIsLeftOf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT IsRightOf(IDisplayPointer* pDispPointer, BOOL* pfIsRightOf)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int>)(lpVtbl[15]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pDispPointer, pfIsRightOf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT IsAtBOL(BOOL* pfBOL)
        {
            return ((delegate* unmanaged<IDisplayPointer*, BOOL*, int>)(lpVtbl[16]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pfBOL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT MoveToMarkupPointer(IMarkupPointer* pPointer, IDisplayPointer* pDispLineContext)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IMarkupPointer*, IDisplayPointer*, int>)(lpVtbl[17]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pPointer, pDispLineContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT ScrollIntoView()
        {
            return ((delegate* unmanaged<IDisplayPointer*, int>)(lpVtbl[18]))((IDisplayPointer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetLineInfo(ILineInfo** ppLineInfo)
        {
            return ((delegate* unmanaged<IDisplayPointer*, ILineInfo**, int>)(lpVtbl[19]))((IDisplayPointer*)Unsafe.AsPointer(ref this), ppLineInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetFlowElement(IHTMLElement** ppLayoutElement)
        {
            return ((delegate* unmanaged<IDisplayPointer*, IHTMLElement**, int>)(lpVtbl[20]))((IDisplayPointer*)Unsafe.AsPointer(ref this), ppLayoutElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT QueryBreaks([NativeTypeName("DWORD *")] uint* pdwBreaks)
        {
            return ((delegate* unmanaged<IDisplayPointer*, uint*, int>)(lpVtbl[21]))((IDisplayPointer*)Unsafe.AsPointer(ref this), pdwBreaks);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT MoveToPoint(POINT ptPoint, COORD_SYSTEM eCoordSystem, IHTMLElement* pElementContext, [NativeTypeName("DWORD")] uint dwHitTestOptions, [NativeTypeName("DWORD *")] uint* pdwHitTestResults);

            [VtblIndex(4)]
            HRESULT MoveUnit(DISPLAY_MOVEUNIT eMoveUnit, [NativeTypeName("LONG")] int lXPos);

            [VtblIndex(5)]
            HRESULT PositionMarkupPointer(IMarkupPointer* pMarkupPointer);

            [VtblIndex(6)]
            HRESULT MoveToPointer(IDisplayPointer* pDispPointer);

            [VtblIndex(7)]
            HRESULT SetPointerGravity(POINTER_GRAVITY eGravity);

            [VtblIndex(8)]
            HRESULT GetPointerGravity(POINTER_GRAVITY* peGravity);

            [VtblIndex(9)]
            HRESULT SetDisplayGravity(DISPLAY_GRAVITY eGravity);

            [VtblIndex(10)]
            HRESULT GetDisplayGravity(DISPLAY_GRAVITY* peGravity);

            [VtblIndex(11)]
            HRESULT IsPositioned(BOOL* pfPositioned);

            [VtblIndex(12)]
            HRESULT Unposition();

            [VtblIndex(13)]
            HRESULT IsEqualTo(IDisplayPointer* pDispPointer, BOOL* pfIsEqual);

            [VtblIndex(14)]
            HRESULT IsLeftOf(IDisplayPointer* pDispPointer, BOOL* pfIsLeftOf);

            [VtblIndex(15)]
            HRESULT IsRightOf(IDisplayPointer* pDispPointer, BOOL* pfIsRightOf);

            [VtblIndex(16)]
            HRESULT IsAtBOL(BOOL* pfBOL);

            [VtblIndex(17)]
            HRESULT MoveToMarkupPointer(IMarkupPointer* pPointer, IDisplayPointer* pDispLineContext);

            [VtblIndex(18)]
            HRESULT ScrollIntoView();

            [VtblIndex(19)]
            HRESULT GetLineInfo(ILineInfo** ppLineInfo);

            [VtblIndex(20)]
            HRESULT GetFlowElement(IHTMLElement** ppLayoutElement);

            [VtblIndex(21)]
            HRESULT QueryBreaks([NativeTypeName("DWORD *")] uint* pdwBreaks);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, uint> Release;

            [NativeTypeName("HRESULT (POINT, COORD_SYSTEM, IHTMLElement *, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, POINT, COORD_SYSTEM, IHTMLElement*, uint, uint*, int> MoveToPoint;

            [NativeTypeName("HRESULT (DISPLAY_MOVEUNIT, LONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, DISPLAY_MOVEUNIT, int, int> MoveUnit;

            [NativeTypeName("HRESULT (IMarkupPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, IMarkupPointer*, int> PositionMarkupPointer;

            [NativeTypeName("HRESULT (IDisplayPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, int> MoveToPointer;

            [NativeTypeName("HRESULT (POINTER_GRAVITY) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, POINTER_GRAVITY, int> SetPointerGravity;

            [NativeTypeName("HRESULT (POINTER_GRAVITY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, POINTER_GRAVITY*, int> GetPointerGravity;

            [NativeTypeName("HRESULT (DISPLAY_GRAVITY) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, DISPLAY_GRAVITY, int> SetDisplayGravity;

            [NativeTypeName("HRESULT (DISPLAY_GRAVITY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, DISPLAY_GRAVITY*, int> GetDisplayGravity;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, BOOL*, int> IsPositioned;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, int> Unposition;

            [NativeTypeName("HRESULT (IDisplayPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int> IsEqualTo;

            [NativeTypeName("HRESULT (IDisplayPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int> IsLeftOf;

            [NativeTypeName("HRESULT (IDisplayPointer *, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, IDisplayPointer*, BOOL*, int> IsRightOf;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, BOOL*, int> IsAtBOL;

            [NativeTypeName("HRESULT (IMarkupPointer *, IDisplayPointer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, IMarkupPointer*, IDisplayPointer*, int> MoveToMarkupPointer;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, int> ScrollIntoView;

            [NativeTypeName("HRESULT (ILineInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, ILineInfo**, int> GetLineInfo;

            [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, IHTMLElement**, int> GetFlowElement;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDisplayPointer*, uint*, int> QueryBreaks;
        }
    }
}