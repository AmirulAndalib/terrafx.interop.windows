// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.SPEVENTENUM;
using static TerraFX.Interop.SPPHRASERNG;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const float")]
        public const float Speech_Default_Weight = (1);

        [NativeTypeName("const LONG")]
        public const int Speech_Max_Word_Length = (128);

        [NativeTypeName("const LONG")]
        public const int Speech_Max_Pron_Length = (384);

        [NativeTypeName("const LONG")]
        public const int Speech_StreamPos_Asap = (0);

        [NativeTypeName("const LONG")]
        public const int Speech_StreamPos_RealTime = (-1);

        [NativeTypeName("const LONG")]
        public const int SpeechAllElements = (int)(SPPR_ALL_ELEMENTS);

        [NativeTypeName("#define _SAPI_VER 0x054")]
        public const int _SAPI_VER = 0x054;

        [NativeTypeName("#define SPDUI_EngineProperties L\"EngineProperties\"")]
        public const string SPDUI_EngineProperties = "EngineProperties";

        [NativeTypeName("#define SPDUI_AddRemoveWord L\"AddRemoveWord\"")]
        public const string SPDUI_AddRemoveWord = "AddRemoveWord";

        [NativeTypeName("#define SPDUI_UserTraining L\"UserTraining\"")]
        public const string SPDUI_UserTraining = "UserTraining";

        [NativeTypeName("#define SPDUI_MicTraining L\"MicTraining\"")]
        public const string SPDUI_MicTraining = "MicTraining";

        [NativeTypeName("#define SPDUI_RecoProfileProperties L\"RecoProfileProperties\"")]
        public const string SPDUI_RecoProfileProperties = "RecoProfileProperties";

        [NativeTypeName("#define SPDUI_AudioProperties L\"AudioProperties\"")]
        public const string SPDUI_AudioProperties = "AudioProperties";

        [NativeTypeName("#define SPDUI_AudioVolume L\"AudioVolume\"")]
        public const string SPDUI_AudioVolume = "AudioVolume";

        [NativeTypeName("#define SPDUI_UserEnrollment L\"UserEnrollment\"")]
        public const string SPDUI_UserEnrollment = "UserEnrollment";

        [NativeTypeName("#define SPDUI_ShareData L\"ShareData\"")]
        public const string SPDUI_ShareData = "ShareData";

        [NativeTypeName("#define SPDUI_Tutorial L\"Tutorial\"")]
        public const string SPDUI_Tutorial = "Tutorial";

        [NativeTypeName("#define SPREG_USER_ROOT L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\"")]
        public const string SPREG_USER_ROOT = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech";

        [NativeTypeName("#define SPREG_LOCAL_MACHINE_ROOT L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\"")]
        public const string SPREG_LOCAL_MACHINE_ROOT = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech";

        [NativeTypeName("#define SPCAT_AUDIOOUT L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioOutput\"")]
        public const string SPCAT_AUDIOOUT = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput";

        [NativeTypeName("#define SPCAT_AUDIOIN L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioInput\"")]
        public const string SPCAT_AUDIOIN = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput";

        [NativeTypeName("#define SPCAT_VOICES L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\Voices\"")]
        public const string SPCAT_VOICES = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Voices";

        [NativeTypeName("#define SPCAT_RECOGNIZERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\Recognizers\"")]
        public const string SPCAT_RECOGNIZERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\Recognizers";

        [NativeTypeName("#define SPCAT_APPLEXICONS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AppLexicons\"")]
        public const string SPCAT_APPLEXICONS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AppLexicons";

        [NativeTypeName("#define SPCAT_PHONECONVERTERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\PhoneConverters\"")]
        public const string SPCAT_PHONECONVERTERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\PhoneConverters";

        [NativeTypeName("#define SPCAT_TEXTNORMALIZERS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\TextNormalizers\"")]
        public const string SPCAT_TEXTNORMALIZERS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\TextNormalizers";

        [NativeTypeName("#define SPCAT_RECOPROFILES L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\RecoProfiles\"")]
        public const string SPCAT_RECOPROFILES = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\RecoProfiles";

        [NativeTypeName("#define SPMMSYS_AUDIO_IN_TOKEN_ID L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioInput\\\\TokenEnums\\\\MMAudioIn\\\\\"")]
        public const string SPMMSYS_AUDIO_IN_TOKEN_ID = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioInput\\TokenEnums\\MMAudioIn\\";

        [NativeTypeName("#define SPMMSYS_AUDIO_OUT_TOKEN_ID L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\AudioOutput\\\\TokenEnums\\\\MMAudioOut\\\\\"")]
        public const string SPMMSYS_AUDIO_OUT_TOKEN_ID = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\AudioOutput\\TokenEnums\\MMAudioOut\\";

        [NativeTypeName("#define SPCURRENT_USER_LEXICON_TOKEN_ID L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\CurrentUserLexicon\"")]
        public const string SPCURRENT_USER_LEXICON_TOKEN_ID = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserLexicon";

        [NativeTypeName("#define SPCURRENT_USER_SHORTCUT_TOKEN_ID L\"HKEY_CURRENT_USER\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\CurrentUserShortcut\"")]
        public const string SPCURRENT_USER_SHORTCUT_TOKEN_ID = "HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Speech\\CurrentUserShortcut";

        [NativeTypeName("#define SPTOKENVALUE_CLSID L\"CLSID\"")]
        public const string SPTOKENVALUE_CLSID = "CLSID";

        [NativeTypeName("#define SPTOKENKEY_FILES L\"Files\"")]
        public const string SPTOKENKEY_FILES = "Files";

        [NativeTypeName("#define SPTOKENKEY_UI L\"UI\"")]
        public const string SPTOKENKEY_UI = "UI";

        [NativeTypeName("#define SPTOKENKEY_ATTRIBUTES L\"Attributes\"")]
        public const string SPTOKENKEY_ATTRIBUTES = "Attributes";

        [NativeTypeName("#define SPTOKENKEY_RETAINEDAUDIO L\"SecondsPerRetainedAudioEvent\"")]
        public const string SPTOKENKEY_RETAINEDAUDIO = "SecondsPerRetainedAudioEvent";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_WARNING L\"LatencyWarningThreshold\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_WARNING = "LatencyWarningThreshold";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_TRUNCATE L\"LatencyTruncateThreshold\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_TRUNCATE = "LatencyTruncateThreshold";

        [NativeTypeName("#define SPTOKENKEY_AUDIO_LATENCY_UPDATE_INTERVAL L\"LatencyUpdateInterval\"")]
        public const string SPTOKENKEY_AUDIO_LATENCY_UPDATE_INTERVAL = "LatencyUpdateInterval";

        [NativeTypeName("#define SPVOICECATEGORY_TTSRATE L\"DefaultTTSRate\"")]
        public const string SPVOICECATEGORY_TTSRATE = "DefaultTTSRate";

        [NativeTypeName("#define SPPROP_RESOURCE_USAGE L\"ResourceUsage\"")]
        public const string SPPROP_RESOURCE_USAGE = "ResourceUsage";

        [NativeTypeName("#define SPPROP_HIGH_CONFIDENCE_THRESHOLD L\"HighConfidenceThreshold\"")]
        public const string SPPROP_HIGH_CONFIDENCE_THRESHOLD = "HighConfidenceThreshold";

        [NativeTypeName("#define SPPROP_NORMAL_CONFIDENCE_THRESHOLD L\"NormalConfidenceThreshold\"")]
        public const string SPPROP_NORMAL_CONFIDENCE_THRESHOLD = "NormalConfidenceThreshold";

        [NativeTypeName("#define SPPROP_LOW_CONFIDENCE_THRESHOLD L\"LowConfidenceThreshold\"")]
        public const string SPPROP_LOW_CONFIDENCE_THRESHOLD = "LowConfidenceThreshold";

        [NativeTypeName("#define SPPROP_RESPONSE_SPEED L\"ResponseSpeed\"")]
        public const string SPPROP_RESPONSE_SPEED = "ResponseSpeed";

        [NativeTypeName("#define SPPROP_COMPLEX_RESPONSE_SPEED L\"ComplexResponseSpeed\"")]
        public const string SPPROP_COMPLEX_RESPONSE_SPEED = "ComplexResponseSpeed";

        [NativeTypeName("#define SPPROP_ADAPTATION_ON L\"AdaptationOn\"")]
        public const string SPPROP_ADAPTATION_ON = "AdaptationOn";

        [NativeTypeName("#define SPPROP_PERSISTED_BACKGROUND_ADAPTATION L\"PersistedBackgroundAdaptation\"")]
        public const string SPPROP_PERSISTED_BACKGROUND_ADAPTATION = "PersistedBackgroundAdaptation";

        [NativeTypeName("#define SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION L\"PersistedLanguageModelAdaptation\"")]
        public const string SPPROP_PERSISTED_LANGUAGE_MODEL_ADAPTATION = "PersistedLanguageModelAdaptation";

        [NativeTypeName("#define SPPROP_UX_IS_LISTENING L\"UXIsListening\"")]
        public const string SPPROP_UX_IS_LISTENING = "UXIsListening";

        [NativeTypeName("#define SPTOPIC_SPELLING L\"Spelling\"")]
        public const string SPTOPIC_SPELLING = "Spelling";

        [NativeTypeName("#define SPWILDCARD L\"...\"")]
        public const string SPWILDCARD = "...";

        [NativeTypeName("#define SPDICTATION L\"*\"")]
        public const string SPDICTATION = "*";

        [NativeTypeName("#define SPINFDICTATION L\"*+\"")]
        public const string SPINFDICTATION = "*+";

        [NativeTypeName("#define SPREG_SAFE_USER_TOKENS L\"HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\Microsoft\\\\Speech\\\\UserTokens\"")]
        public const string SPREG_SAFE_USER_TOKENS = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Speech\\UserTokens";

        [NativeTypeName("#define SP_LOW_CONFIDENCE ( -1 )")]
        public const int SP_LOW_CONFIDENCE = (-1);

        [NativeTypeName("#define SP_NORMAL_CONFIDENCE ( 0 )")]
        public const int SP_NORMAL_CONFIDENCE = (0);

        [NativeTypeName("#define SP_HIGH_CONFIDENCE ( +1 )")]
        public const int SP_HIGH_CONFIDENCE = (+1);

        [NativeTypeName("#define DEFAULT_WEIGHT ( 1 )")]
        public const int DEFAULT_WEIGHT = (1);

        [NativeTypeName("#define SP_MAX_WORD_LENGTH ( 128 )")]
        public const int SP_MAX_WORD_LENGTH = (128);

        [NativeTypeName("#define SP_MAX_PRON_LENGTH ( 384 )")]
        public const int SP_MAX_PRON_LENGTH = (384);

        [NativeTypeName("#define SP_EMULATE_RESULT ( 0x40000000 )")]
        public const int SP_EMULATE_RESULT = (0x40000000);

        [NativeTypeName("#define SPFEI_FLAGCHECK ( (1ui64 << SPEI_RESERVED1) | (1ui64 << SPEI_RESERVED2) )")]
        public const ulong SPFEI_FLAGCHECK = ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2)));

        [NativeTypeName("#define SPFEI_ALL_TTS_EVENTS (0x000000000000FFFEui64 | SPFEI_FLAGCHECK)")]
        public const ulong SPFEI_ALL_TTS_EVENTS = (0x000000000000FFFEUL | ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2))));

        [NativeTypeName("#define SPFEI_ALL_SR_EVENTS (0x003FFFFC00000000ui64 | SPFEI_FLAGCHECK)")]
        public const ulong SPFEI_ALL_SR_EVENTS = (0x003FFFFC00000000UL | ((1UL << (int)(SPEI_RESERVED1)) | (1UL << (int)(SPEI_RESERVED2))));

        [NativeTypeName("#define SPFEI_ALL_EVENTS 0xEFFFFFFFFFFFFFFFui64")]
        public const ulong SPFEI_ALL_EVENTS = 0xEFFFFFFFFFFFFFFFUL;

        [NativeTypeName("#define SP_SPPHRASESIZE_500 sizeof(SPPHRASE_50)")]
        public static readonly uint SP_SPPHRASESIZE_500 = unchecked((uint)(sizeof(SPPHRASE_50)));

        [NativeTypeName("#define SP_SPPHRASESIZE_530 sizeof(SPPHRASE_53)")]
        public static readonly uint SP_SPPHRASESIZE_530 = unchecked((uint)(sizeof(SPPHRASE_53)));

        [NativeTypeName("#define SP_GETWHOLEPHRASE SPPR_ALL_ELEMENTS")]
        public const SPPHRASERNG SP_GETWHOLEPHRASE = SPPR_ALL_ELEMENTS;

        [NativeTypeName("#define SPRR_ALL_ELEMENTS SPPR_ALL_ELEMENTS")]
        public const SPPHRASERNG SPRR_ALL_ELEMENTS = SPPR_ALL_ELEMENTS;

        [NativeTypeName("#define SP_STREAMPOS_ASAP ( 0 )")]
        public const int SP_STREAMPOS_ASAP = (0);

        [NativeTypeName("#define SP_STREAMPOS_REALTIME ( -1 )")]
        public const int SP_STREAMPOS_REALTIME = (-1);

        [NativeTypeName("#define SPRULETRANS_TEXTBUFFER (SPSTATEHANDLE)(-1)")]
        public static readonly IntPtr SPRULETRANS_TEXTBUFFER = (IntPtr)(-1);

        [NativeTypeName("#define SPRULETRANS_WILDCARD (SPSTATEHANDLE)(-2)")]
        public static readonly IntPtr SPRULETRANS_WILDCARD = (IntPtr)(-2);

        [NativeTypeName("#define SPRULETRANS_DICTATION (SPSTATEHANDLE)(-3)")]
        public static readonly IntPtr SPRULETRANS_DICTATION = (IntPtr)(-3);

        [NativeTypeName("#define SPRP_NORMAL 0")]
        public const int SPRP_NORMAL = 0;

        [NativeTypeName("#define SP_MAX_LANGIDS ( 20 )")]
        public const int SP_MAX_LANGIDS = (20);

        public static readonly Guid IID_ISpNotifySource = new Guid(0x5EFF4AEF, 0x8487, 0x11D2, 0x96, 0x1C, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid IID_ISpNotifySink = new Guid(0x259684DC, 0x37C3, 0x11D2, 0x96, 0x03, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid IID_ISpNotifyTranslator = new Guid(0xACA16614, 0x5D3D, 0x11D2, 0x96, 0x0E, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid IID_ISpDataKey = new Guid(0x14056581, 0xE16C, 0x11D2, 0xBB, 0x90, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0xC0);

        public static readonly Guid IID_ISpRegDataKey = new Guid(0x92A66E2B, 0xC830, 0x4149, 0x83, 0xDF, 0x6F, 0xC2, 0xBA, 0x1E, 0x7A, 0x5B);

        public static readonly Guid IID_ISpObjectTokenCategory = new Guid(0x2D3D3845, 0x39AF, 0x4850, 0xBB, 0xF9, 0x40, 0xB4, 0x97, 0x80, 0x01, 0x1D);

        public static readonly Guid IID_ISpObjectToken = new Guid(0x14056589, 0xE16C, 0x11D2, 0xBB, 0x90, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0xC0);

        public static readonly Guid IID_ISpObjectTokenInit = new Guid(0xB8AAB0CF, 0x346F, 0x49D8, 0x94, 0x99, 0xC8, 0xB0, 0x3F, 0x16, 0x1D, 0x51);

        public static readonly Guid IID_IEnumSpObjectTokens = new Guid(0x06B64F9E, 0x7FDA, 0x11D2, 0xB4, 0xF2, 0x00, 0xC0, 0x4F, 0x79, 0x73, 0x96);

        public static readonly Guid IID_ISpObjectWithToken = new Guid(0x5B559F40, 0xE952, 0x11D2, 0xBB, 0x91, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0xC0);

        public static readonly Guid IID_ISpResourceManager = new Guid(0x93384E18, 0x5014, 0x43D5, 0xAD, 0xBB, 0xA7, 0x8E, 0x05, 0x59, 0x26, 0xBD);

        public static readonly Guid IID_ISpEventSource = new Guid(0xBE7A9CCE, 0x5F9E, 0x11D2, 0x96, 0x0F, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid IID_ISpEventSource2 = new Guid(0x2373A435, 0x6A4B, 0x429E, 0xA6, 0xAC, 0xD4, 0x23, 0x1A, 0x61, 0x97, 0x5B);

        public static readonly Guid IID_ISpEventSink = new Guid(0xBE7A9CC9, 0x5F9E, 0x11D2, 0x96, 0x0F, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid IID_ISpStreamFormat = new Guid(0xBED530BE, 0x2606, 0x4F4D, 0xA1, 0xC0, 0x54, 0xC5, 0xCD, 0xA5, 0x56, 0x6F);

        public static readonly Guid IID_ISpStream = new Guid(0x12E3CCA9, 0x7518, 0x44C5, 0xA5, 0xE7, 0xBA, 0x5A, 0x79, 0xCB, 0x92, 0x9E);

        public static readonly Guid IID_ISpStreamFormatConverter = new Guid(0x678A932C, 0xEA71, 0x4446, 0x9B, 0x41, 0x78, 0xFD, 0xA6, 0x28, 0x0A, 0x29);

        public static readonly Guid IID_ISpAudio = new Guid(0xC05C768F, 0xFAE8, 0x4EC2, 0x8E, 0x07, 0x33, 0x83, 0x21, 0xC1, 0x24, 0x52);

        public static readonly Guid IID_ISpMMSysAudio = new Guid(0x15806F6E, 0x1D70, 0x4B48, 0x98, 0xE6, 0x3B, 0x1A, 0x00, 0x75, 0x09, 0xAB);

        public static readonly Guid IID_ISpTranscript = new Guid(0x10F63BCE, 0x201A, 0x11D3, 0xAC, 0x70, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0xC0);

        public static readonly Guid IID_ISpLexicon = new Guid(0xDA41A7C2, 0x5383, 0x4DB2, 0x91, 0x6B, 0x6C, 0x17, 0x19, 0xE3, 0xDB, 0x58);

        public static readonly Guid IID_ISpContainerLexicon = new Guid(0x8565572F, 0xC094, 0x41CC, 0xB5, 0x6E, 0x10, 0xBD, 0x9C, 0x3F, 0xF0, 0x44);

        public static readonly Guid IID_ISpShortcut = new Guid(0x3DF681E2, 0xEA56, 0x11D9, 0x8B, 0xDE, 0xF6, 0x6B, 0xAD, 0x1E, 0x3F, 0x3A);

        public static readonly Guid IID_ISpPhoneConverter = new Guid(0x8445C581, 0x0CAC, 0x4A38, 0xAB, 0xFE, 0x9B, 0x2C, 0xE2, 0x82, 0x64, 0x55);

        public static readonly Guid IID_ISpPhoneticAlphabetConverter = new Guid(0x133ADCD4, 0x19B4, 0x4020, 0x9F, 0xDC, 0x84, 0x2E, 0x78, 0x25, 0x3B, 0x17);

        public static readonly Guid IID_ISpPhoneticAlphabetSelection = new Guid(0xB2745EFD, 0x42CE, 0x48CA, 0x81, 0xF1, 0xA9, 0x6E, 0x02, 0x53, 0x8A, 0x90);

        public static readonly Guid IID_ISpVoice = new Guid(0x6C44DF74, 0x72B9, 0x4992, 0xA1, 0xEC, 0xEF, 0x99, 0x6E, 0x04, 0x22, 0xD4);

        public static readonly Guid IID_ISpPhrase = new Guid(0x1A5C0354, 0xB621, 0x4B5A, 0x87, 0x91, 0xD3, 0x06, 0xED, 0x37, 0x9E, 0x53);

        public static readonly Guid IID_ISpPhraseAlt = new Guid(0x8FCEBC98, 0x4E49, 0x4067, 0x9C, 0x6C, 0xD8, 0x6A, 0x0E, 0x09, 0x2E, 0x3D);

        public static readonly Guid IID_ISpPhrase2 = new Guid(0xF264DA52, 0xE457, 0x4696, 0xB8, 0x56, 0xA7, 0x37, 0xB7, 0x17, 0xAF, 0x79);

        public static readonly Guid IID_ISpRecoResult = new Guid(0x20B053BE, 0xE235, 0x43CD, 0x9A, 0x2A, 0x8D, 0x17, 0xA4, 0x8B, 0x78, 0x42);

        public static readonly Guid IID_ISpRecoResult2 = new Guid(0x27CAC6C4, 0x88F2, 0x41F2, 0x88, 0x17, 0x0C, 0x95, 0xE5, 0x9F, 0x1E, 0x6E);

        public static readonly Guid IID_ISpXMLRecoResult = new Guid(0xAE39362B, 0x45A8, 0x4074, 0x9B, 0x9E, 0xCC, 0xF4, 0x9A, 0xA2, 0xD0, 0xB6);

        public static readonly Guid IID_ISpGrammarBuilder = new Guid(0x8137828F, 0x591A, 0x4A42, 0xBE, 0x58, 0x49, 0xEA, 0x7E, 0xBA, 0xAC, 0x68);

        public static readonly Guid IID_ISpRecoGrammar = new Guid(0x2177DB29, 0x7F45, 0x47D0, 0x85, 0x54, 0x06, 0x7E, 0x91, 0xC8, 0x05, 0x02);

        public static readonly Guid IID_ISpGrammarBuilder2 = new Guid(0x8AB10026, 0x20CC, 0x4B20, 0x8C, 0x22, 0xA4, 0x9C, 0x9B, 0xA7, 0x8F, 0x60);

        public static readonly Guid IID_ISpRecoGrammar2 = new Guid(0x4B37BC9E, 0x9ED6, 0x44A3, 0x93, 0xD3, 0x18, 0xF0, 0x22, 0xB7, 0x9E, 0xC3);

        public static readonly Guid IID_ISpeechResourceLoader = new Guid(0xB9AC5783, 0xFCD0, 0x4B21, 0xB1, 0x19, 0xB4, 0xF8, 0xDA, 0x8F, 0xD2, 0xC3);

        public static readonly Guid IID_ISpRecoContext = new Guid(0xF740A62F, 0x7C15, 0x489E, 0x82, 0x34, 0x94, 0x0A, 0x33, 0xD9, 0x27, 0x2D);

        public static readonly Guid IID_ISpRecoContext2 = new Guid(0xBEAD311C, 0x52FF, 0x437F, 0x94, 0x64, 0x6B, 0x21, 0x05, 0x4C, 0xA7, 0x3D);

        public static readonly Guid IID_ISpProperties = new Guid(0x5B4FB971, 0xB115, 0x4DE1, 0xAD, 0x97, 0xE4, 0x82, 0xE3, 0xBF, 0x6E, 0xE4);

        public static readonly Guid IID_ISpRecognizer = new Guid(0xC2B5F241, 0xDAA0, 0x4507, 0x9E, 0x16, 0x5A, 0x1E, 0xAA, 0x2B, 0x7A, 0x5C);

        public static readonly Guid IID_ISpSerializeState = new Guid(0x21B501A0, 0x0EC7, 0x46C9, 0x92, 0xC3, 0xA2, 0xBC, 0x78, 0x4C, 0x54, 0xB9);

        public static readonly Guid IID_ISpRecognizer2 = new Guid(0x8FC6D974, 0xC81E, 0x4098, 0x93, 0xC5, 0x01, 0x47, 0xF6, 0x1E, 0xD4, 0xD3);

        public static readonly Guid IID_ISpRecoCategory = new Guid(0xDA0CD0F9, 0x14A2, 0x4F09, 0x8C, 0x2A, 0x85, 0xCC, 0x48, 0x97, 0x93, 0x45);

        public static readonly Guid IID_ISpRecognizer3 = new Guid(0xDF1B943C, 0x5838, 0x4AA2, 0x87, 0x06, 0xD7, 0xCD, 0x5B, 0x33, 0x34, 0x99);

        public static readonly Guid IID_ISpEnginePronunciation = new Guid(0xC360CE4B, 0x76D1, 0x4214, 0xAD, 0x68, 0x52, 0x65, 0x7D, 0x50, 0x83, 0xDA);

        public static readonly Guid IID_ISpDisplayAlternates = new Guid(0xC8D7C7E2, 0x0DDE, 0x44B7, 0xAF, 0xE3, 0xB0, 0xC9, 0x91, 0xFB, 0xEB, 0x5E);

        public static readonly Guid IID_ISpeechDataKey = new Guid(0xCE17C09B, 0x4EFA, 0x44D5, 0xA4, 0xC9, 0x59, 0xD9, 0x58, 0x5A, 0xB0, 0xCD);

        public static readonly Guid IID_ISpeechObjectToken = new Guid(0xC74A3ADC, 0xB727, 0x4500, 0xA8, 0x4A, 0xB5, 0x26, 0x72, 0x1C, 0x8B, 0x8C);

        public static readonly Guid IID_ISpeechObjectTokens = new Guid(0x9285B776, 0x2E7B, 0x4BC0, 0xB5, 0x3E, 0x58, 0x0E, 0xB6, 0xFA, 0x96, 0x7F);

        public static readonly Guid IID_ISpeechObjectTokenCategory = new Guid(0xCA7EAC50, 0x2D01, 0x4145, 0x86, 0xD4, 0x5A, 0xE7, 0xD7, 0x0F, 0x44, 0x69);

        public static readonly Guid IID_ISpeechAudioBufferInfo = new Guid(0x11B103D8, 0x1142, 0x4EDF, 0xA0, 0x93, 0x82, 0xFB, 0x39, 0x15, 0xF8, 0xCC);

        public static readonly Guid IID_ISpeechAudioStatus = new Guid(0xC62D9C91, 0x7458, 0x47F6, 0x86, 0x2D, 0x1E, 0xF8, 0x6F, 0xB0, 0xB2, 0x78);

        public static readonly Guid IID_ISpeechAudioFormat = new Guid(0xE6E9C590, 0x3E18, 0x40E3, 0x82, 0x99, 0x06, 0x1F, 0x98, 0xBD, 0xE7, 0xC7);

        public static readonly Guid IID_ISpeechWaveFormatEx = new Guid(0x7A1EF0D5, 0x1581, 0x4741, 0x88, 0xE4, 0x20, 0x9A, 0x49, 0xF1, 0x1A, 0x10);

        public static readonly Guid IID_ISpeechBaseStream = new Guid(0x6450336F, 0x7D49, 0x4CED, 0x80, 0x97, 0x49, 0xD6, 0xDE, 0xE3, 0x72, 0x94);

        public static readonly Guid IID_ISpeechFileStream = new Guid(0xAF67F125, 0xAB39, 0x4E93, 0xB4, 0xA2, 0xCC, 0x2E, 0x66, 0xE1, 0x82, 0xA7);

        public static readonly Guid IID_ISpeechMemoryStream = new Guid(0xEEB14B68, 0x808B, 0x4ABE, 0xA5, 0xEA, 0xB5, 0x1D, 0xA7, 0x58, 0x80, 0x08);

        public static readonly Guid IID_ISpeechCustomStream = new Guid(0x1A9E9F4F, 0x104F, 0x4DB8, 0xA1, 0x15, 0xEF, 0xD7, 0xFD, 0x0C, 0x97, 0xAE);

        public static readonly Guid IID_ISpeechAudio = new Guid(0xCFF8E175, 0x019E, 0x11D3, 0xA0, 0x8E, 0x00, 0xC0, 0x4F, 0x8E, 0xF9, 0xB5);

        public static readonly Guid IID_ISpeechMMSysAudio = new Guid(0x3C76AF6D, 0x1FD7, 0x4831, 0x81, 0xD1, 0x3B, 0x71, 0xD5, 0xA1, 0x3C, 0x44);

        public static readonly Guid IID_ISpeechVoice = new Guid(0x269316D8, 0x57BD, 0x11D2, 0x9E, 0xEE, 0x00, 0xC0, 0x4F, 0x79, 0x73, 0x96);

        public static readonly Guid IID_ISpeechVoiceStatus = new Guid(0x8BE47B07, 0x57F6, 0x11D2, 0x9E, 0xEE, 0x00, 0xC0, 0x4F, 0x79, 0x73, 0x96);

        public static readonly Guid DIID__ISpeechVoiceEvents = new Guid(0xA372ACD1, 0x3BEF, 0x4BBD, 0x8F, 0xFB, 0xCB, 0x3E, 0x2B, 0x41, 0x6A, 0xF8);

        public static readonly Guid IID_ISpeechRecognizer = new Guid(0x2D5F1C0C, 0xBD75, 0x4B08, 0x94, 0x78, 0x3B, 0x11, 0xFE, 0xA2, 0x58, 0x6C);

        public static readonly Guid IID_ISpeechRecognizerStatus = new Guid(0xBFF9E781, 0x53EC, 0x484E, 0xBB, 0x8A, 0x0E, 0x1B, 0x55, 0x51, 0xE3, 0x5C);

        public static readonly Guid IID_ISpeechRecoContext = new Guid(0x580AA49D, 0x7E1E, 0x4809, 0xB8, 0xE2, 0x57, 0xDA, 0x80, 0x61, 0x04, 0xB8);

        public static readonly Guid IID_ISpeechRecoGrammar = new Guid(0xB6D6F79F, 0x2158, 0x4E50, 0xB5, 0xBC, 0x9A, 0x9C, 0xCD, 0x85, 0x2A, 0x09);

        public static readonly Guid DIID__ISpeechRecoContextEvents = new Guid(0x7B8FCB42, 0x0E9D, 0x4F00, 0xA0, 0x48, 0x7B, 0x04, 0xD6, 0x17, 0x9D, 0x3D);

        public static readonly Guid IID_ISpeechGrammarRule = new Guid(0xAFE719CF, 0x5DD1, 0x44F2, 0x99, 0x9C, 0x7A, 0x39, 0x9F, 0x1C, 0xFC, 0xCC);

        public static readonly Guid IID_ISpeechGrammarRules = new Guid(0x6FFA3B44, 0xFC2D, 0x40D1, 0x8A, 0xFC, 0x32, 0x91, 0x1C, 0x7F, 0x1A, 0xD1);

        public static readonly Guid IID_ISpeechGrammarRuleState = new Guid(0xD4286F2C, 0xEE67, 0x45AE, 0xB9, 0x28, 0x28, 0xD6, 0x95, 0x36, 0x2E, 0xDA);

        public static readonly Guid IID_ISpeechGrammarRuleStateTransition = new Guid(0xCAFD1DB1, 0x41D1, 0x4A06, 0x98, 0x63, 0xE2, 0xE8, 0x1D, 0xA1, 0x7A, 0x9A);

        public static readonly Guid IID_ISpeechGrammarRuleStateTransitions = new Guid(0xEABCE657, 0x75BC, 0x44A2, 0xAA, 0x7F, 0xC5, 0x64, 0x76, 0x74, 0x29, 0x63);

        public static readonly Guid IID_ISpeechTextSelectionInformation = new Guid(0x3B9C7E7A, 0x6EEE, 0x4DED, 0x90, 0x92, 0x11, 0x65, 0x72, 0x79, 0xAD, 0xBE);

        public static readonly Guid IID_ISpeechRecoResult = new Guid(0xED2879CF, 0xCED9, 0x4EE6, 0xA5, 0x34, 0xDE, 0x01, 0x91, 0xD5, 0x46, 0x8D);

        public static readonly Guid IID_ISpeechRecoResult2 = new Guid(0x8E0A246D, 0xD3C8, 0x45DE, 0x86, 0x57, 0x04, 0x29, 0x0C, 0x45, 0x8C, 0x3C);

        public static readonly Guid IID_ISpeechRecoResultTimes = new Guid(0x62B3B8FB, 0xF6E7, 0x41BE, 0xBD, 0xCB, 0x05, 0x6B, 0x1C, 0x29, 0xEF, 0xC0);

        public static readonly Guid IID_ISpeechPhraseAlternate = new Guid(0x27864A2A, 0x2B9F, 0x4CB8, 0x92, 0xD3, 0x0D, 0x27, 0x22, 0xFD, 0x1E, 0x73);

        public static readonly Guid IID_ISpeechPhraseAlternates = new Guid(0xB238B6D5, 0xF276, 0x4C3D, 0xA6, 0xC1, 0x29, 0x74, 0x80, 0x1C, 0x3C, 0xC2);

        public static readonly Guid IID_ISpeechPhraseInfo = new Guid(0x961559CF, 0x4E67, 0x4662, 0x8B, 0xF0, 0xD9, 0x3F, 0x1F, 0xCD, 0x61, 0xB3);

        public static readonly Guid IID_ISpeechPhraseElement = new Guid(0xE6176F96, 0xE373, 0x4801, 0xB2, 0x23, 0x3B, 0x62, 0xC0, 0x68, 0xC0, 0xB4);

        public static readonly Guid IID_ISpeechPhraseElements = new Guid(0x0626B328, 0x3478, 0x467D, 0xA0, 0xB3, 0xD0, 0x85, 0x3B, 0x93, 0xDD, 0xA3);

        public static readonly Guid IID_ISpeechPhraseReplacement = new Guid(0x2890A410, 0x53A7, 0x4FB5, 0x94, 0xEC, 0x06, 0xD4, 0x99, 0x8E, 0x3D, 0x02);

        public static readonly Guid IID_ISpeechPhraseReplacements = new Guid(0x38BC662F, 0x2257, 0x4525, 0x95, 0x9E, 0x20, 0x69, 0xD2, 0x59, 0x6C, 0x05);

        public static readonly Guid IID_ISpeechPhraseProperty = new Guid(0xCE563D48, 0x961E, 0x4732, 0xA2, 0xE1, 0x37, 0x8A, 0x42, 0xB4, 0x30, 0xBE);

        public static readonly Guid IID_ISpeechPhraseProperties = new Guid(0x08166B47, 0x102E, 0x4B23, 0xA5, 0x99, 0xBD, 0xB9, 0x8D, 0xBF, 0xD1, 0xF4);

        public static readonly Guid IID_ISpeechPhraseRule = new Guid(0xA7BFE112, 0xA4A0, 0x48D9, 0xB6, 0x02, 0xC3, 0x13, 0x84, 0x3F, 0x69, 0x64);

        public static readonly Guid IID_ISpeechPhraseRules = new Guid(0x9047D593, 0x01DD, 0x4B72, 0x81, 0xA3, 0xE4, 0xA0, 0xCA, 0x69, 0xF4, 0x07);

        public static readonly Guid IID_ISpeechLexicon = new Guid(0x3DA7627A, 0xC7AE, 0x4B23, 0x87, 0x08, 0x63, 0x8C, 0x50, 0x36, 0x2C, 0x25);

        public static readonly Guid IID_ISpeechLexiconWords = new Guid(0x8D199862, 0x415E, 0x47D5, 0xAC, 0x4F, 0xFA, 0xA6, 0x08, 0xB4, 0x24, 0xE6);

        public static readonly Guid IID_ISpeechLexiconWord = new Guid(0x4E5B933C, 0xC9BE, 0x48ED, 0x88, 0x42, 0x1E, 0xE5, 0x1B, 0xB1, 0xD4, 0xFF);

        public static readonly Guid IID_ISpeechLexiconPronunciations = new Guid(0x72829128, 0x5682, 0x4704, 0xA0, 0xD4, 0x3E, 0x2B, 0xB6, 0xF2, 0xEA, 0xD3);

        public static readonly Guid IID_ISpeechLexiconPronunciation = new Guid(0x95252C5D, 0x9E43, 0x4F4A, 0x98, 0x99, 0x48, 0xEE, 0x73, 0x35, 0x2F, 0x9F);

        public static readonly Guid IID_ISpeechXMLRecoResult = new Guid(0xAAEC54AF, 0x8F85, 0x4924, 0x94, 0x4D, 0xB7, 0x9D, 0x39, 0xD7, 0x2E, 0x19);

        public static readonly Guid IID_ISpeechRecoResultDispatch = new Guid(0x6D60EB64, 0xACED, 0x40A6, 0xBB, 0xF3, 0x4E, 0x55, 0x7F, 0x71, 0xDE, 0xE2);

        public static readonly Guid IID_ISpeechPhraseInfoBuilder = new Guid(0x3B151836, 0xDF3A, 0x4E0A, 0x84, 0x6C, 0xD2, 0xAD, 0xC9, 0x33, 0x43, 0x33);

        public static readonly Guid IID_ISpeechPhoneConverter = new Guid(0xC3E4F353, 0x433F, 0x43D6, 0x89, 0xA1, 0x6A, 0x62, 0xA7, 0x05, 0x4C, 0x3D);

        public static readonly Guid CLSID_SpNotifyTranslator = new Guid(0xE2AE5372, 0x5D40, 0x11D2, 0x96, 0x0E, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid CLSID_SpObjectTokenCategory = new Guid(0xA910187F, 0x0C7A, 0x45AC, 0x92, 0xCC, 0x59, 0xED, 0xAF, 0xB7, 0x7B, 0x53);

        public static readonly Guid CLSID_SpObjectToken = new Guid(0xEF411752, 0x3736, 0x4CB4, 0x9C, 0x8C, 0x8E, 0xF4, 0xCC, 0xB5, 0x8E, 0xFE);

        public static readonly Guid CLSID_SpResourceManager = new Guid(0x96749373, 0x3391, 0x11D2, 0x9E, 0xE3, 0x00, 0xC0, 0x4F, 0x79, 0x73, 0x96);

        public static readonly Guid CLSID_SpStreamFormatConverter = new Guid(0x7013943A, 0xE2EC, 0x11D2, 0xA0, 0x86, 0x00, 0xC0, 0x4F, 0x8E, 0xF9, 0xB5);

        public static readonly Guid CLSID_SpMMAudioEnum = new Guid(0xAB1890A0, 0xE91F, 0x11D2, 0xBB, 0x91, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0xC0);

        public static readonly Guid CLSID_SpMMAudioIn = new Guid(0xCF3D2E50, 0x53F2, 0x11D2, 0x96, 0x0C, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid CLSID_SpMMAudioOut = new Guid(0xA8C680EB, 0x3D32, 0x11D2, 0x9E, 0xE7, 0x00, 0xC0, 0x4F, 0x79, 0x73, 0x96);

        public static readonly Guid CLSID_SpStream = new Guid(0x715D9C59, 0x4442, 0x11D2, 0x96, 0x05, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid CLSID_SpVoice = new Guid(0x96749377, 0x3391, 0x11D2, 0x9E, 0xE3, 0x00, 0xC0, 0x4F, 0x79, 0x73, 0x96);

        public static readonly Guid CLSID_SpSharedRecoContext = new Guid(0x47206204, 0x5ECA, 0x11D2, 0x96, 0x0F, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid CLSID_SpInprocRecognizer = new Guid(0x41B89B6B, 0x9399, 0x11D2, 0x96, 0x23, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);

        public static readonly Guid CLSID_SpSharedRecognizer = new Guid(0x3BEE4890, 0x4FE9, 0x4A37, 0x8C, 0x1E, 0x5E, 0x7E, 0x12, 0x79, 0x1C, 0x1F);

        public static readonly Guid CLSID_SpLexicon = new Guid(0x0655E396, 0x25D0, 0x11D3, 0x9C, 0x26, 0x00, 0xC0, 0x4F, 0x8E, 0xF8, 0x7C);

        public static readonly Guid CLSID_SpUnCompressedLexicon = new Guid(0xC9E37C15, 0xDF92, 0x4727, 0x85, 0xD6, 0x72, 0xE5, 0xEE, 0xB6, 0x99, 0x5A);

        public static readonly Guid CLSID_SpCompressedLexicon = new Guid(0x90903716, 0x2F42, 0x11D3, 0x9C, 0x26, 0x00, 0xC0, 0x4F, 0x8E, 0xF8, 0x7C);

        public static readonly Guid CLSID_SpShortcut = new Guid(0x0D722F1A, 0x9FCF, 0x4E62, 0x96, 0xD8, 0x6D, 0xF8, 0xF0, 0x1A, 0x26, 0xAA);

        public static readonly Guid CLSID_SpPhoneConverter = new Guid(0x9185F743, 0x1143, 0x4C28, 0x86, 0xB5, 0xBF, 0xF1, 0x4F, 0x20, 0xE5, 0xC8);

        public static readonly Guid IID_SpPhoneticAlphabetConverter = new Guid(0x4F414126, 0xDFE3, 0x4629, 0x99, 0xEE, 0x79, 0x79, 0x78, 0x31, 0x7E, 0xAD);

        public static readonly Guid CLSID_SpNullPhoneConverter = new Guid(0x455F24E9, 0x7396, 0x4A16, 0x97, 0x15, 0x7C, 0x0F, 0xDB, 0xE3, 0xEF, 0xE3);

        public static readonly Guid IID_SpTextSelectionInformation = new Guid(0x0F92030A, 0xCBFD, 0x4AB8, 0xA1, 0x64, 0xFF, 0x59, 0x85, 0x54, 0x7F, 0xF6);

        public static readonly Guid CLSID_SpPhraseInfoBuilder = new Guid(0xC23FC28D, 0xC55F, 0x4720, 0x8B, 0x32, 0x91, 0xF7, 0x3C, 0x2B, 0xD5, 0xD1);

        public static readonly Guid CLSID_SpAudioFormat = new Guid(0x9EF96870, 0xE160, 0x4792, 0x82, 0x0D, 0x48, 0xCF, 0x06, 0x49, 0xE4, 0xEC);

        public static readonly Guid CLSID_SpWaveFormatEx = new Guid(0xC79A574C, 0x63BE, 0x44B9, 0x80, 0x1F, 0x28, 0x3F, 0x87, 0xF8, 0x98, 0xBE);

        public static readonly Guid CLSID_SpInProcRecoContext = new Guid(0x73AD6842, 0xACE0, 0x45E8, 0xA4, 0xDD, 0x87, 0x95, 0x88, 0x1A, 0x2C, 0x2A);

        public static readonly Guid CLSID_SpCustomStream = new Guid(0x8DBEF13F, 0x1948, 0x4AA8, 0x8C, 0xF0, 0x04, 0x8E, 0xEB, 0xED, 0x95, 0xD8);

        public static readonly Guid CLSID_SpFileStream = new Guid(0x947812B3, 0x2AE1, 0x4644, 0xBA, 0x86, 0x9E, 0x90, 0xDE, 0xD7, 0xEC, 0x91);

        public static readonly Guid CLSID_SpMemoryStream = new Guid(0x5FB7EF7D, 0xDFF4, 0x468A, 0xB6, 0xB7, 0x2F, 0xCB, 0xD1, 0x88, 0xF9, 0x94);
    }
}
