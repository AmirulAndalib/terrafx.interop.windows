// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PROPERTY_METRICS
    {
        [NativeTypeName("LONG")]
        public int nLogicalMin;

        [NativeTypeName("LONG")]
        public int nLogicalMax;

        public PROPERTY_UNITS Units;

        public float fResolution;
    }
}
