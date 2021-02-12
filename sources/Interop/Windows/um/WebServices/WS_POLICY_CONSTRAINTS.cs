// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_POLICY_CONSTRAINTS
    {
        public WS_CHANNEL_BINDING channelBinding;

        [NativeTypeName("WS_CHANNEL_PROPERTY_CONSTRAINT *")]
        public WS_CHANNEL_PROPERTY_CONSTRAINT* channelPropertyConstraints;

        [NativeTypeName("ULONG")]
        public uint channelPropertyConstraintCount;

        [NativeTypeName("WS_SECURITY_CONSTRAINTS *")]
        public WS_SECURITY_CONSTRAINTS* securityConstraints;

        [NativeTypeName("WS_POLICY_EXTENSION **")]
        public WS_POLICY_EXTENSION** policyExtensions;

        [NativeTypeName("ULONG")]
        public uint policyExtensionCount;
    }
}
