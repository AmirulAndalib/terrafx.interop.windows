// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_HTTP_MESSAGE_MAPPING
    {
        [NativeTypeName("ULONG")]
        public uint requestMappingOptions;

        [NativeTypeName("ULONG")]
        public uint responseMappingOptions;

        [NativeTypeName("WS_HTTP_HEADER_MAPPING **")]
        public WS_HTTP_HEADER_MAPPING** requestHeaderMappings;

        [NativeTypeName("ULONG")]
        public uint requestHeaderMappingCount;

        [NativeTypeName("WS_HTTP_HEADER_MAPPING **")]
        public WS_HTTP_HEADER_MAPPING** responseHeaderMappings;

        [NativeTypeName("ULONG")]
        public uint responseHeaderMappingCount;
    }
}
