// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_DECODE_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_DECODE_SWAP_CHAIN_DESC"]/*' />
public partial struct DXGI_DECODE_SWAP_CHAIN_DESC
{
    /// <include file='DXGI_DECODE_SWAP_CHAIN_DESC.xml' path='doc/member[@name="DXGI_DECODE_SWAP_CHAIN_DESC.Flags"]/*' />
    public uint Flags;
}
