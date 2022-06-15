// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.DirectX;

/// <include file='AudioReverb.xml' path='doc/member[@name="AudioReverb"]/*' />
[Guid("C2633B16-471B-4498-B8C5-4F0959E2EC09")]
public partial struct AudioReverb : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_AudioReverb;
}
