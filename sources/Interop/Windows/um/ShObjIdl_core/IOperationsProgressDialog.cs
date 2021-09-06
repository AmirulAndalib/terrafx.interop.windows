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
    public unsafe partial struct IOperationsProgressDialog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, Guid*, void**, int>)(lpVtbl[0]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, uint>)(lpVtbl[1]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, uint>)(lpVtbl[2]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartProgressDialog([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("OPPROGDLGF")] uint flags)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, IntPtr, uint, int>)(lpVtbl[3]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), hwndOwner, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopProgressDialog()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, int>)(lpVtbl[4]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOperation(SPACTION action)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, SPACTION, int>)(lpVtbl[5]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), action);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMode([NativeTypeName("PDMODE")] uint mode)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, uint, int>)(lpVtbl[6]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateProgress([NativeTypeName("ULONGLONG")] ulong ullPointsCurrent, [NativeTypeName("ULONGLONG")] ulong ullPointsTotal, [NativeTypeName("ULONGLONG")] ulong ullSizeCurrent, [NativeTypeName("ULONGLONG")] ulong ullSizeTotal, [NativeTypeName("ULONGLONG")] ulong ullItemsCurrent, [NativeTypeName("ULONGLONG")] ulong ullItemsTotal)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, ulong, ulong, ulong, ulong, ulong, ulong, int>)(lpVtbl[7]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), ullPointsCurrent, ullPointsTotal, ullSizeCurrent, ullSizeTotal, ullItemsCurrent, ullItemsTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateLocations(IShellItem* psiSource, IShellItem* psiTarget, IShellItem* psiItem)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, IShellItem*, IShellItem*, IShellItem*, int>)(lpVtbl[8]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), psiSource, psiTarget, psiItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResetTimer()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, int>)(lpVtbl[9]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PauseTimer()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, int>)(lpVtbl[10]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ResumeTimer()
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, int>)(lpVtbl[11]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMilliseconds([NativeTypeName("ULONGLONG *")] ulong* pullElapsed, [NativeTypeName("ULONGLONG *")] ulong* pullRemaining)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, ulong*, ulong*, int>)(lpVtbl[12]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), pullElapsed, pullRemaining);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOperationStatus(PDOPSTATUS* popstatus)
        {
            return ((delegate* unmanaged<IOperationsProgressDialog*, PDOPSTATUS*, int>)(lpVtbl[13]))((IOperationsProgressDialog*)Unsafe.AsPointer(ref this), popstatus);
        }
    }
}
