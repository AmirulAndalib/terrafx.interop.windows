// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0C9FB851-E5C9-43EB-A370-F0677B13874C")]
    [NativeTypeName("struct IOperationsProgressDialog : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOperationsProgressDialog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, Guid*, void**, int>)(lpVtbl[0]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, uint>)(lpVtbl[1]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, uint>)(lpVtbl[2]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT StartProgressDialog(HWND hwndOwner, [NativeTypeName("OPPROGDLGF")] uint flags)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, HWND, uint, int>)(lpVtbl[3]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), hwndOwner, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT StopProgressDialog()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, int>)(lpVtbl[4]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetOperation(SPACTION action)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, SPACTION, int>)(lpVtbl[5]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), action);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetMode([NativeTypeName("PDMODE")] uint mode)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, uint, int>)(lpVtbl[6]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT UpdateProgress([NativeTypeName("ULONGLONG")] ulong ullPointsCurrent, [NativeTypeName("ULONGLONG")] ulong ullPointsTotal, [NativeTypeName("ULONGLONG")] ulong ullSizeCurrent, [NativeTypeName("ULONGLONG")] ulong ullSizeTotal, [NativeTypeName("ULONGLONG")] ulong ullItemsCurrent, [NativeTypeName("ULONGLONG")] ulong ullItemsTotal)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, ulong, ulong, ulong, ulong, ulong, ulong, int>)(lpVtbl[7]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), ullPointsCurrent, ullPointsTotal, ullSizeCurrent, ullSizeTotal, ullItemsCurrent, ullItemsTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT UpdateLocations(IShellItem* psiSource, IShellItem* psiTarget, IShellItem* psiItem)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, IShellItem*, IShellItem*, IShellItem*, int>)(lpVtbl[8]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), psiSource, psiTarget, psiItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ResetTimer()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, int>)(lpVtbl[9]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT PauseTimer()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, int>)(lpVtbl[10]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT ResumeTimer()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, int>)(lpVtbl[11]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetMilliseconds([NativeTypeName("ULONGLONG *")] ulong* pullElapsed, [NativeTypeName("ULONGLONG *")] ulong* pullRemaining)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, ulong*, ulong*, int>)(lpVtbl[12]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), pullElapsed, pullRemaining);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetOperationStatus(PDOPSTATUS* popstatus)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, PDOPSTATUS*, int>)(lpVtbl[13]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), popstatus);
        }
    }
}
