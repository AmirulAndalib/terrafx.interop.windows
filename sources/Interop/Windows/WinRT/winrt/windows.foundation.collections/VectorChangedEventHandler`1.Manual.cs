// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("0C051752-9FBF-4C70-AA0C-0E4C82D9A761")]
public unsafe partial struct VectorChangedEventHandler<T>
    where T : unmanaged
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
    {
        return ((delegate* unmanaged<VectorChangedEventHandler<T>*, Guid*, void**, int>)(lpVtbl[0]))((VectorChangedEventHandler<T>*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<VectorChangedEventHandler<T>*, uint>)(lpVtbl[1]))((VectorChangedEventHandler<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<VectorChangedEventHandler<T>*, uint>)(lpVtbl[2]))((VectorChangedEventHandler<T>*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public HRESULT Invoke([NativeTypeName("IObservableVector<T_logical> *")] IObservableVector<T>* sender, IVectorChangedEventArgs* e)
    {
        return ((delegate* unmanaged<VectorChangedEventHandler<T>*, IObservableVector<T>*, IVectorChangedEventArgs*, int>)(lpVtbl[3]))((VectorChangedEventHandler<T>*)Unsafe.AsPointer(ref this), sender, e);
    }
}
