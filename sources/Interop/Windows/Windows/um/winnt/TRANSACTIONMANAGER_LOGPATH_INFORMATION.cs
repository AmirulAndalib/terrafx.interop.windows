// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='TRANSACTIONMANAGER_LOGPATH_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_LOGPATH_INFORMATION"]/*' />
public partial struct TRANSACTIONMANAGER_LOGPATH_INFORMATION
{
    /// <include file='TRANSACTIONMANAGER_LOGPATH_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_LOGPATH_INFORMATION.LogPathLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint LogPathLength;

    /// <include file='TRANSACTIONMANAGER_LOGPATH_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_LOGPATH_INFORMATION.LogPath"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _LogPath_e__FixedBuffer LogPath;

    /// <include file='_LogPath_e__FixedBuffer.xml' path='doc/member[@name="_LogPath_e__FixedBuffer"]/*' />
    public partial struct _LogPath_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
