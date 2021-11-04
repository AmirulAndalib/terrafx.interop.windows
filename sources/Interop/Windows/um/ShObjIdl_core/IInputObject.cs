// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("68284FAA-6A48-11D0-8C78-00C04FD918B4")]
    [NativeTypeName("struct IInputObject : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInputObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInputObject*, Guid*, void**, int>)(lpVtbl[0]))((IInputObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInputObject*, uint>)(lpVtbl[1]))((IInputObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInputObject*, uint>)(lpVtbl[2]))((IInputObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT UIActivateIO(BOOL fActivate, MSG* pMsg)
        {
            return ((delegate* unmanaged<IInputObject*, BOOL, MSG*, int>)(lpVtbl[3]))((IInputObject*)Unsafe.AsPointer(ref this), fActivate, pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT HasFocusIO()
        {
            return ((delegate* unmanaged<IInputObject*, int>)(lpVtbl[4]))((IInputObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT TranslateAcceleratorIO(MSG* pMsg)
        {
            return ((delegate* unmanaged<IInputObject*, MSG*, int>)(lpVtbl[5]))((IInputObject*)Unsafe.AsPointer(ref this), pMsg);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInputObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInputObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInputObject*, uint> Release;

            [NativeTypeName("HRESULT (BOOL, MSG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInputObject*, BOOL, MSG*, int> UIActivateIO;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IInputObject*, int> HasFocusIO;

            [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IInputObject*, MSG*, int> TranslateAcceleratorIO;
        }
    }
}
