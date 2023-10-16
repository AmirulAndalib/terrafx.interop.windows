// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="STORAGE_DEVICE_ATTRIBUTES_DESCRIPTOR" /> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class STORAGE_DEVICE_ATTRIBUTES_DESCRIPTORTests
{
}
