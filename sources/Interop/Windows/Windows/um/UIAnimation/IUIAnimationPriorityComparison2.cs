// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("5B6D7A37-4621-467C-8B05-70131DE62DDB")]
[NativeTypeName("struct IUIAnimationPriorityComparison2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationPriorityComparison2 : IUIAnimationPriorityComparison2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationPriorityComparison2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationPriorityComparison2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationPriorityComparison2*, uint>)(lpVtbl[1]))((IUIAnimationPriorityComparison2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationPriorityComparison2*, uint>)(lpVtbl[2]))((IUIAnimationPriorityComparison2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT HasPriority(IUIAnimationStoryboard2* scheduledStoryboard, IUIAnimationStoryboard2* newStoryboard, UI_ANIMATION_PRIORITY_EFFECT priorityEffect)
    {
        return ((delegate* unmanaged<IUIAnimationPriorityComparison2*, IUIAnimationStoryboard2*, IUIAnimationStoryboard2*, UI_ANIMATION_PRIORITY_EFFECT, int>)(lpVtbl[3]))((IUIAnimationPriorityComparison2*)Unsafe.AsPointer(ref this), scheduledStoryboard, newStoryboard, priorityEffect);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT HasPriority(IUIAnimationStoryboard2* scheduledStoryboard, IUIAnimationStoryboard2* newStoryboard, UI_ANIMATION_PRIORITY_EFFECT priorityEffect);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IUIAnimationPriorityComparison2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IUIAnimationPriorityComparison2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IUIAnimationPriorityComparison2*, uint> Release;

        [NativeTypeName("HRESULT (IUIAnimationStoryboard2 *, IUIAnimationStoryboard2 *, UI_ANIMATION_PRIORITY_EFFECT) __attribute__((stdcall))")]
        public delegate* unmanaged<IUIAnimationPriorityComparison2*, IUIAnimationStoryboard2*, IUIAnimationStoryboard2*, UI_ANIMATION_PRIORITY_EFFECT, int> HasPriority;
    }
}
