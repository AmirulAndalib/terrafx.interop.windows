// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_ENCRYPTED_BLOCK_INFO.xml' path='doc/member[@name="D3D11_ENCRYPTED_BLOCK_INFO"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct D3D11_ENCRYPTED_BLOCK_INFO
{
    /// <include file='D3D11_ENCRYPTED_BLOCK_INFO.xml' path='doc/member[@name="D3D11_ENCRYPTED_BLOCK_INFO.NumEncryptedBytesAtBeginning"]/*' />
    public uint NumEncryptedBytesAtBeginning;

    /// <include file='D3D11_ENCRYPTED_BLOCK_INFO.xml' path='doc/member[@name="D3D11_ENCRYPTED_BLOCK_INFO.NumBytesInSkipPattern"]/*' />
    public uint NumBytesInSkipPattern;

    /// <include file='D3D11_ENCRYPTED_BLOCK_INFO.xml' path='doc/member[@name="D3D11_ENCRYPTED_BLOCK_INFO.NumBytesInEncryptPattern"]/*' />
    public uint NumBytesInEncryptPattern;
}
