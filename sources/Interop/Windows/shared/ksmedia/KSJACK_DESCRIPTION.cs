// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ksmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct KSJACK_DESCRIPTION
    {
        [NativeTypeName("DWORD")]
        public uint ChannelMapping;

        [NativeTypeName("DWORD")]
        public uint Color;

        public EPcxConnectionType ConnectionType;

        public EPcxGeoLocation GeoLocation;

        public EPcxGenLocation GenLocation;

        public EPxcPortConnection PortConnection;

        [NativeTypeName("BOOL")]
        public int IsConnected;
    }
}
