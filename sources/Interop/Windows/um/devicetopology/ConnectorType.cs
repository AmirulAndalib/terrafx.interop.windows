// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum ConnectorType
    {
        Unknown_Connector = 0,
        Physical_Internal = (Unknown_Connector + 1),
        Physical_External = (Physical_Internal + 1),
        Software_IO = (Physical_External + 1),
        Software_Fixed = (Software_IO + 1),
        Network = (Software_Fixed + 1),
    }
}
