// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

public partial struct SID
{
    [NativeTypeName("#define SID_SHlinkFrame IID_IHlinkFrame")]
    public static ref readonly Guid SID_SHlinkFrame => ref IID_IHlinkFrame;
}
