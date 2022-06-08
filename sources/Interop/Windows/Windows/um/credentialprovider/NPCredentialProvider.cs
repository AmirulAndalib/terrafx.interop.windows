// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='NPCredentialProvider.xml' path='doc/member[@name="NPCredentialProvider"]/*' />
[Guid("3DD6BEC0-8193-4FFE-AE25-E08E39EA4063")]
public partial struct NPCredentialProvider : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_NPCredentialProvider;
}
