// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAD9EB88-AE77-4397-B948-5FA2DB0A19EA")]
    [NativeTypeName("struct IVisualTreeServiceCallback2 : IVisualTreeServiceCallback")]
    [NativeInheritance("IVisualTreeServiceCallback")]
    public unsafe partial struct IVisualTreeServiceCallback2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IVisualTreeServiceCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback2*, uint>)(lpVtbl[1]))((IVisualTreeServiceCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback2*, uint>)(lpVtbl[2]))((IVisualTreeServiceCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnVisualTreeChange(ParentChildRelation relation, VisualElement element, VisualMutationType mutationType)
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback2*, ParentChildRelation, VisualElement, VisualMutationType, int>)(lpVtbl[3]))((IVisualTreeServiceCallback2*)Unsafe.AsPointer(ref this), relation, element, mutationType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnElementStateChanged(InstanceHandle element, VisualElementState elementState, [NativeTypeName("LPCWSTR")] ushort* context)
        {
            return ((delegate* unmanaged<IVisualTreeServiceCallback2*, InstanceHandle, VisualElementState, ushort*, int>)(lpVtbl[4]))((IVisualTreeServiceCallback2*)Unsafe.AsPointer(ref this), element, elementState, context);
        }
    }
}
