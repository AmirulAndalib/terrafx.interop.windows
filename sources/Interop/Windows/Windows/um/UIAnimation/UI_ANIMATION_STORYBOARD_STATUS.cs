// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS"]/*' />
public enum UI_ANIMATION_STORYBOARD_STATUS
{
    /// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS.UI_ANIMATION_STORYBOARD_BUILDING"]/*' />
    UI_ANIMATION_STORYBOARD_BUILDING = 0,

    /// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS.UI_ANIMATION_STORYBOARD_SCHEDULED"]/*' />
    UI_ANIMATION_STORYBOARD_SCHEDULED = 1,

    /// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS.UI_ANIMATION_STORYBOARD_CANCELLED"]/*' />
    UI_ANIMATION_STORYBOARD_CANCELLED = 2,

    /// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS.UI_ANIMATION_STORYBOARD_PLAYING"]/*' />
    UI_ANIMATION_STORYBOARD_PLAYING = 3,

    /// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS.UI_ANIMATION_STORYBOARD_TRUNCATED"]/*' />
    UI_ANIMATION_STORYBOARD_TRUNCATED = 4,

    /// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS.UI_ANIMATION_STORYBOARD_FINISHED"]/*' />
    UI_ANIMATION_STORYBOARD_FINISHED = 5,

    /// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS.UI_ANIMATION_STORYBOARD_READY"]/*' />
    UI_ANIMATION_STORYBOARD_READY = 6,

    /// <include file='UI_ANIMATION_STORYBOARD_STATUS.xml' path='doc/member[@name="UI_ANIMATION_STORYBOARD_STATUS.UI_ANIMATION_STORYBOARD_INSUFFICIENT_PRIORITY"]/*' />
    UI_ANIMATION_STORYBOARD_INSUFFICIENT_PRIORITY = 7,
}
