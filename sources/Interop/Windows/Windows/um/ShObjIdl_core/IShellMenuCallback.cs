// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("4CA300A1-9B8D-11D1-8B22-00C04FD918D0")]
    [NativeTypeName("struct IShellMenuCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellMenuCallback : IShellMenuCallback.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellMenuCallback*, Guid*, void**, int>)(lpVtbl[0]))((IShellMenuCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellMenuCallback*, uint>)(lpVtbl[1]))((IShellMenuCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellMenuCallback*, uint>)(lpVtbl[2]))((IShellMenuCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CallbackSM([NativeTypeName("LPSMDATA")] SMDATA* psmd, uint uMsg, WPARAM wParam, LPARAM lParam)
        {
            return ((delegate* unmanaged<IShellMenuCallback*, SMDATA*, uint, WPARAM, LPARAM, int>)(lpVtbl[3]))((IShellMenuCallback*)Unsafe.AsPointer(ref this), psmd, uMsg, wParam, lParam);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CallbackSM([NativeTypeName("LPSMDATA")] SMDATA* psmd, uint uMsg, WPARAM wParam, LPARAM lParam);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellMenuCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellMenuCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IShellMenuCallback*, uint> Release;

            [NativeTypeName("HRESULT (LPSMDATA, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
            public delegate* unmanaged<IShellMenuCallback*, SMDATA*, uint, WPARAM, LPARAM, int> CallbackSM;
        }
    }
}