// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='MANIPULATION_VELOCITY.xml' path='doc/member[@name="MANIPULATION_VELOCITY"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct MANIPULATION_VELOCITY
{
    /// <include file='MANIPULATION_VELOCITY.xml' path='doc/member[@name="MANIPULATION_VELOCITY.velocityX"]/*' />
    public float velocityX;

    /// <include file='MANIPULATION_VELOCITY.xml' path='doc/member[@name="MANIPULATION_VELOCITY.velocityY"]/*' />
    public float velocityY;

    /// <include file='MANIPULATION_VELOCITY.xml' path='doc/member[@name="MANIPULATION_VELOCITY.velocityExpansion"]/*' />
    public float velocityExpansion;

    /// <include file='MANIPULATION_VELOCITY.xml' path='doc/member[@name="MANIPULATION_VELOCITY.velocityAngular"]/*' />
    public float velocityAngular;
}
