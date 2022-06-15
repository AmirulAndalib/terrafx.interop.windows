// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='AppxFactory.xml' path='doc/member[@name="AppxFactory"]/*' />
[Guid("5842A140-FF9F-4166-8F5C-62F5B7B0C781")]
public partial struct AppxFactory : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_AppxFactory;
}
