// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ThumbnailStreamCache.xml' path='doc/member[@name="ThumbnailStreamCache"]/*' />
[Guid("CBE0FED3-4B91-4E90-8354-8A8C84EC6872")]
public unsafe partial struct ThumbnailStreamCache : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ThumbnailStreamCache));
}
