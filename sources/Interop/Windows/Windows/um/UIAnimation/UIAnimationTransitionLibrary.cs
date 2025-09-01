// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='UIAnimationTransitionLibrary.xml' path='doc/member[@name="UIAnimationTransitionLibrary"]/*' />
[Guid("1D6322AD-AA85-4EF5-A828-86D71067D145")]
public unsafe partial struct UIAnimationTransitionLibrary : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in CLSID_UIAnimationTransitionLibrary);
}
