// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D5C9008-EC7C-4364-9F8A-9AF3C58CBAE6")]
    [NativeTypeName("struct IUIAnimationStoryboardEventHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIAnimationStoryboardEventHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationStoryboardEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler*, uint>)(lpVtbl[1]))((IUIAnimationStoryboardEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler*, uint>)(lpVtbl[2]))((IUIAnimationStoryboardEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnStoryboardStatusChanged(IUIAnimationStoryboard* storyboard, UI_ANIMATION_STORYBOARD_STATUS newStatus, UI_ANIMATION_STORYBOARD_STATUS previousStatus)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler*, IUIAnimationStoryboard*, UI_ANIMATION_STORYBOARD_STATUS, UI_ANIMATION_STORYBOARD_STATUS, int>)(lpVtbl[3]))((IUIAnimationStoryboardEventHandler*)Unsafe.AsPointer(ref this), storyboard, newStatus, previousStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnStoryboardUpdated(IUIAnimationStoryboard* storyboard)
        {
            return ((delegate* unmanaged<IUIAnimationStoryboardEventHandler*, IUIAnimationStoryboard*, int>)(lpVtbl[4]))((IUIAnimationStoryboardEventHandler*)Unsafe.AsPointer(ref this), storyboard);
        }
    }
}
