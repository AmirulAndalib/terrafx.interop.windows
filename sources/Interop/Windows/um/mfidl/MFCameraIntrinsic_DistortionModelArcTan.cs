// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MFCameraIntrinsic_DistortionModelArcTan
    {
        public float Radial_k0;

        public float DistortionCenter_x;

        public float DistortionCenter_y;

        public float Tangential_x;

        public float Tangential_y;
    }
}
