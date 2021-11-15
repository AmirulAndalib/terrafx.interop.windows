// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct WS_SERVICE_METADATA
    {
        [NativeTypeName("ULONG")]
        public uint documentCount;

        public WS_SERVICE_METADATA_DOCUMENT** documents;

        public WS_XML_STRING* serviceName;

        public WS_XML_STRING* serviceNs;
    }
}