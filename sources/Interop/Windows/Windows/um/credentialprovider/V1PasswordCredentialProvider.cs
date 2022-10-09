// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='V1PasswordCredentialProvider.xml' path='doc/member[@name="V1PasswordCredentialProvider"]/*' />
[Guid("6F45DC1E-5384-457A-BC13-2CD81B0D28ED")]
public unsafe partial struct V1PasswordCredentialProvider : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_V1PasswordCredentialProvider));
}
