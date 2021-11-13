// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("6358B7BA-87D2-42D5-BF71-82E919DD5862")]
    [NativeTypeName("struct IUIAnimationVariableChangeHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationVariableChangeHandler : IUIAnimationVariableChangeHandler.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableChangeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler*, uint>)(lpVtbl[1]))((IUIAnimationVariableChangeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler*, uint>)(lpVtbl[2]))((IUIAnimationVariableChangeHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnValueChanged(IUIAnimationStoryboard* storyboard, IUIAnimationVariable* variable, double newValue, double previousValue)
        {
            return ((delegate* unmanaged<IUIAnimationVariableChangeHandler*, IUIAnimationStoryboard*, IUIAnimationVariable*, double, double, int>)(lpVtbl[3]))((IUIAnimationVariableChangeHandler*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnValueChanged(IUIAnimationStoryboard* storyboard, IUIAnimationVariable* variable, double newValue, double previousValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableChangeHandler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableChangeHandler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableChangeHandler*, uint> Release;

            [NativeTypeName("HRESULT (IUIAnimationStoryboard *, IUIAnimationVariable *, DOUBLE, DOUBLE) __attribute__((stdcall))")]
            public delegate* unmanaged<IUIAnimationVariableChangeHandler*, IUIAnimationStoryboard*, IUIAnimationVariable*, double, double, int> OnValueChanged;
        }
    }
}
