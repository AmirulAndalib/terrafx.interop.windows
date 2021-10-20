// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A561E69A-B4B8-4113-91A5-64C6BCCA3430")]
    [NativeTypeName("struct IUserAccountChangeCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUserAccountChangeCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUserAccountChangeCallback*, Guid*, void**, int>)(lpVtbl[0]))((IUserAccountChangeCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserAccountChangeCallback*, uint>)(lpVtbl[1]))((IUserAccountChangeCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserAccountChangeCallback*, uint>)(lpVtbl[2]))((IUserAccountChangeCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int OnPictureChange([NativeTypeName("LPCWSTR")] ushort* pszUserName)
        {
            return ((delegate* unmanaged<IUserAccountChangeCallback*, ushort*, int>)(lpVtbl[3]))((IUserAccountChangeCallback*)Unsafe.AsPointer(ref this), pszUserName);
        }
    }
}