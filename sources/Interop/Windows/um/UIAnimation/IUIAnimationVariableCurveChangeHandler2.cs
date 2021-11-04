// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72895E91-0145-4C21-9192-5AAB40EDDF80")]
    [NativeTypeName("struct IUIAnimationVariableCurveChangeHandler2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationVariableCurveChangeHandler2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationVariableCurveChangeHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableCurveChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationVariableCurveChangeHandler2*, uint>)(lpVtbl[1]))((IUIAnimationVariableCurveChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationVariableCurveChangeHandler2*, uint>)(lpVtbl[2]))((IUIAnimationVariableCurveChangeHandler2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnCurveChanged(IUIAnimationVariable2* variable)
        {
            return ((delegate* unmanaged<IUIAnimationVariableCurveChangeHandler2*, IUIAnimationVariable2*, int>)(lpVtbl[3]))((IUIAnimationVariableCurveChangeHandler2*)Unsafe.AsPointer(ref this), variable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableCurveChangeHandler2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableCurveChangeHandler2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableCurveChangeHandler2*, uint> Release;

            [NativeTypeName("HRESULT (IUIAnimationVariable2 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableCurveChangeHandler2*, IUIAnimationVariable2*, int> OnCurveChanged;
        }
    }
}
