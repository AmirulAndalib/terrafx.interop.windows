// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IStreamAsync.xml' path='doc/member[@name="IStreamAsync"]/*' />
[Guid("FE0B6665-E0CA-49B9-A178-2B5CB48D92A5")]
[NativeTypeName("struct IStreamAsync : IStream")]
[NativeInheritance("IStream")]
public unsafe partial struct IStreamAsync : IStreamAsync.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamAsync));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, Guid*, void**, int>)(lpVtbl[0]))((IStreamAsync*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, uint>)(lpVtbl[1]))((IStreamAsync*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, uint>)(lpVtbl[2]))((IStreamAsync*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISequentialStream.Read" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, void*, uint, uint*, int>)(lpVtbl[3]))((IStreamAsync*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref="ISequentialStream.Write" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, void*, uint, uint*, int>)(lpVtbl[4]))((IStreamAsync*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    /// <inheritdoc cref="IStream.Seek" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IStreamAsync*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <inheritdoc cref="IStream.SetSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IStreamAsync*)Unsafe.AsPointer(ref this), libNewSize);
    }

    /// <inheritdoc cref="IStream.CopyTo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IStreamAsync*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    /// <inheritdoc cref="IStream.Commit" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, uint, int>)(lpVtbl[8]))((IStreamAsync*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <inheritdoc cref="IStream.Revert" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, int>)(lpVtbl[9]))((IStreamAsync*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IStream.LockRegion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IStreamAsync*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref="IStream.UnlockRegion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IStreamAsync*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref="IStream.Stat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, STATSTG*, uint, int>)(lpVtbl[12]))((IStreamAsync*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    }

    /// <inheritdoc cref="IStream.Clone" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, IStream**, int>)(lpVtbl[13]))((IStreamAsync*)Unsafe.AsPointer(ref this), ppstm);
    }

    /// <include file='IStreamAsync.xml' path='doc/member[@name="IStreamAsync.ReadAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReadAsync(void* pv, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* pcbRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, void*, uint, uint*, OVERLAPPED*, int>)(lpVtbl[14]))((IStreamAsync*)Unsafe.AsPointer(ref this), pv, cb, pcbRead, lpOverlapped);
    }

    /// <include file='IStreamAsync.xml' path='doc/member[@name="IStreamAsync.WriteAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteAsync([NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* pcbWritten, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, void*, uint, uint*, OVERLAPPED*, int>)(lpVtbl[15]))((IStreamAsync*)Unsafe.AsPointer(ref this), lpBuffer, cb, pcbWritten, lpOverlapped);
    }

    /// <include file='IStreamAsync.xml' path='doc/member[@name="IStreamAsync.OverlappedResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT OverlappedResult([NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, BOOL bWait)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, OVERLAPPED*, uint*, BOOL, int>)(lpVtbl[16]))((IStreamAsync*)Unsafe.AsPointer(ref this), lpOverlapped, lpNumberOfBytesTransferred, bWait);
    }

    /// <include file='IStreamAsync.xml' path='doc/member[@name="IStreamAsync.CancelIo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CancelIo()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamAsync*, int>)(lpVtbl[17]))((IStreamAsync*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IStream.Interface
    {
        [VtblIndex(14)]
        HRESULT ReadAsync(void* pv, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* pcbRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [VtblIndex(15)]
        HRESULT WriteAsync([NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* pcbWritten, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [VtblIndex(16)]
        HRESULT OverlappedResult([NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, BOOL bWait);

        [VtblIndex(17)]
        HRESULT CancelIo();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> Read;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> Write;

        [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

        [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ULARGE_INTEGER, int> SetSize;

        [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> CopyTo;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Revert;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> LockRegion;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> UnlockRegion;

        [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STATSTG*, uint, int> Stat;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream**, int> Clone;

        [NativeTypeName("HRESULT (void *, DWORD, LPDWORD, LPOVERLAPPED) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, OVERLAPPED*, int> ReadAsync;

        [NativeTypeName("HRESULT (const void *, DWORD, LPDWORD, LPOVERLAPPED) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, OVERLAPPED*, int> WriteAsync;

        [NativeTypeName("HRESULT (LPOVERLAPPED, LPDWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, OVERLAPPED*, uint*, BOOL, int> OverlappedResult;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CancelIo;
    }
}
