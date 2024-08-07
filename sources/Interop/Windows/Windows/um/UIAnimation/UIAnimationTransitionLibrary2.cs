// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='UIAnimationTransitionLibrary2.xml' path='doc/member[@name="UIAnimationTransitionLibrary2"]/*' />
[Guid("812F944A-C5C8-4CD9-B0A6-B3DA802F228D")]
public unsafe partial struct UIAnimationTransitionLibrary2 : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in CLSID_UIAnimationTransitionLibrary2));
}
