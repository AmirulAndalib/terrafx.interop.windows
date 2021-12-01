// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS"]/*' />
[SupportedOSPlatform("windows8.0")]
public enum WINHTTP_WEB_SOCKET_CLOSE_STATUS
{
    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_SUCCESS_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_SUCCESS_CLOSE_STATUS = 1000,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_ENDPOINT_TERMINATED_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_ENDPOINT_TERMINATED_CLOSE_STATUS = 1001,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_PROTOCOL_ERROR_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_PROTOCOL_ERROR_CLOSE_STATUS = 1002,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_INVALID_DATA_TYPE_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_INVALID_DATA_TYPE_CLOSE_STATUS = 1003,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_EMPTY_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_EMPTY_CLOSE_STATUS = 1005,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_ABORTED_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_ABORTED_CLOSE_STATUS = 1006,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_INVALID_PAYLOAD_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_INVALID_PAYLOAD_CLOSE_STATUS = 1007,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_POLICY_VIOLATION_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_POLICY_VIOLATION_CLOSE_STATUS = 1008,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_MESSAGE_TOO_BIG_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_MESSAGE_TOO_BIG_CLOSE_STATUS = 1009,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_UNSUPPORTED_EXTENSIONS_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_UNSUPPORTED_EXTENSIONS_CLOSE_STATUS = 1010,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_SERVER_ERROR_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_SERVER_ERROR_CLOSE_STATUS = 1011,

    /// <include file='WINHTTP_WEB_SOCKET_CLOSE_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_CLOSE_STATUS.WINHTTP_WEB_SOCKET_SECURE_HANDSHAKE_ERROR_CLOSE_STATUS"]/*' />
    WINHTTP_WEB_SOCKET_SECURE_HANDSHAKE_ERROR_CLOSE_STATUS = 1015,
}
