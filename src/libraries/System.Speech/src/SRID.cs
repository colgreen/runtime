// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Speech
{
    internal enum SRID
    {
        NullParamIllegal,
        ArrayOfNullIllegal,
        ParamsEntryNullIllegal,
        Unavailable,
        UnexpectedError,
        CollectionReadOnly,
        StringCanNotBeEmpty,
        EnumInvalid,
        NotSupportedWithThisVersionOfSAPI,
        NotSupportedWithThisVersionOfSAPI2,
        NotSupportedWithThisVersionOfSAPIBaseUri,
        NotSupportedWithThisVersionOfSAPITagFormat,
        NotSupportedWithThisVersionOfSAPICompareOption,
        MustBeGreaterThanZero,
        InvalidXml,
        OperationAborted,
        InvariantCultureInfo,
        DuplicatedEntry,
        StreamMustBeReadable,
        StreamMustBeWriteable,
        StreamMustBeSeekable,
        StreamEndedUnexpectedly,
        CannotReadFromDirectory,
        UnknownMimeFormat,
        CannotLoadResourceFromManifest,
        TokenInUse,
        TokenDeleted,
        TokenUninitialized,
        InvalidTokenId,
        NotFound,
        NoBackSlash,
        InvalidRegistryEntry,
        TokenCannotCreateInstance,
        InvalidXmlFormat,
        IncorrectAttributeValue,
        MissingRequiredAttribute,
        InvalidRuleRefSelf,
        InvalidDynamicExport,
        InvalidToken,
        MetaNameHTTPEquiv,
        EmptyRule,
        InvalidTokenString,
        InvalidQuotedString,
        ExportDynamicRule,
        EmptyDisplayString,
        EmptyPronunciationString,
        InvalidPhoneme,
        MuliplePronunciationString,
        MultipleDisplayString,
        RuleRedefinition,
        EmptyOneOf,
        InvalidGrammarOrdering,
        MinMaxOutOfRange,
        InvalidExampleOrdering,
        GrammarDefTwice,
        UnsupportedFormat,
        InvalidImport,
        DuplicatedRuleName,
        RootRuleAlreadyDefined,
        RuleNameIdConflict,
        RuleNotDynamic,
        StateWithNoArcs,
        NoTerminatingRulePath,
        RuleRefNoUri,
        UnavailableProperty,
        MinGreaterThanMax,
        ReqConfidenceNotSupported,
        SapiPropertiesAndSemantics,
        InvalidAttributeDefinedTwice,
        GrammarCompilerError,
        RuleScriptNotFound,
        DynamicRuleNotFound,
        RuleScriptInvalidParameters,
        RuleScriptInvalidReturnType,
        NoClassname,
        EmbeddedClassLibraryFailed,
        CannotFindClass,
        StrongTypedGrammarNotAGrammar,
        NoScriptsForRules,
        ClassNotPublic,
        MethodNotPublic,
        IncompatibleLanguageProperties,
        IncompatibleNamespaceProperties,
        IncompatibleDebugProperties,
        CannotLoadDotNetSemanticCode,
        InvalidSemanticProcessingType,
        InvalidScriptDefinition,
        InvalidMethodName,
        ConstructorNotAllowed,
        OverloadNotAllowed,
        OnInitOnPublicRule,
        ArgumentMismatch,
        CantGetPropertyFromSerializedInfo,
        CantFindAConstructor,
        TooManyArcs,
        TooManyRulesWithSemanticsGlobals,
        MaxTransitionsCount,
        UnknownElement,
        CircularRuleRef,
        InvalidFlagsSet,
        RuleDefinedMultipleTimes,
        RuleDefinedMultipleTimes2,
        RuleNotDefined,
        RootNotDefined,
        InvalidLanguage,
        InvalidRuleId,
        InvalidRepeatProbability,
        InvalidConfidence,
        InvalidMinRepeat,
        InvalidMaxRepeat,
        InvalidWeight,
        InvalidName,
        InvalidValueType,
        TagFormatNotSet,
        NoName,
        NoName1,
        InvalidSpecialRuleRef,
        InvalidRuleRef,
        InvalidNotEmptyElement,
        InvalidEmptyElement,
        InvalidEmptyRule,
        UndefRuleRef,
        UnsupportedLanguage,
        UnsupportedPhoneticAlphabet,
        UnsupportedLexicon,
        InvalidScriptAttribute,
        NoLanguageSet,
        MethodAttributeDefinedMultipeTimes,
        RuleAttributeDefinedMultipeTimes,
        InvalidAssemblyReferenceAttribute,
        InvalidImportNamespaceAttribute,
        NoUriForSpecialRuleRef,
        NoAliasForSpecialRuleRef,
        NoSmlData,
        InvalidNameValueProperty,
        InvalidTagInAnEmptyItem,
        InvalidSrgs,
        InvalidSrgsNamespace,
        Line,
        Position,
        InvalidVersion,
        InvalidTagFormat,
        MissingTagFormat,
        InvalidGrammarMode,
        InvalidGrammarAttribute,
        InvalidRuleAttribute,
        InvalidRulerefAttribute,
        InvalidOneOfAttribute,
        InvalidItemAttribute,
        InvalidTokenAttribute,
        InvalidItemRepeatAttribute,
        InvalidReqConfAttribute,
        InvalidTagAttribute,
        InvalidLexiconAttribute,
        InvalidMetaAttribute,
        InvalidItemAttribute2,
        InvalidElement,
        InvalidRuleScope,
        InvalidDynamicSetting,
        InvalidSubsetAttribute,
        InvalidVoiceElementInPromptOutput,
        NoRuleId,
        PromptBuilderInvalideState,
        PromptBuilderStateEnded,
        PromptBuilderStateSentence,
        PromptBuilderStateParagraph,
        PromptBuilderStateVoice,
        PromptBuilderStateStyle,
        PromptBuilderAgeOutOfRange,
        PromptBuilderMismatchStyle,
        PromptBuilderMismatchVoice,
        PromptBuilderMismatchParagraph,
        PromptBuilderMismatchSentence,
        PromptBuilderNestedParagraph,
        PromptBuilderNestedSentence,
        PromptBuilderInvalidAttribute,
        PromptBuilderInvalidElement,
        PromptBuilderInvalidVariant,
        PromptBuilderDatabaseName,
        PromptAsyncOperationCancelled,
        SynthesizerPauseResumeMismatched,
        SynthesizerInvalidMediaType,
        SynthesizerUnknownMediaType,
        SynthesizerSpeakError,
        SynthesizerInvalidWaveFile,
        SynthesizerPromptInUse,
        SynthesizerUnknownPriority,
        SynthesizerUnknownEvent,
        SynthesizerVoiceFailed,
        SynthesizerSetVoiceNoMatch,
        SynthesizerNoCulture,
        SynthesizerSyncSpeakWhilePaused,
        SynthesizerSyncSetOutputWhilePaused,
        SynthesizerNoCulture2,
        SynthesizerNoSpeak,
        SynthesizerSetOutputSpeaking,
        InvalidSpeakAttribute,
        UnsupportedAlphabet,
        GrammarInvalidWeight,
        GrammarInvalidPriority,
        DictationInvalidTopic,
        DictationTopicNotFound,
        RecognizerGrammarNotFound,
        RecognizerRuleNotFound,
        RecognizerInvalidBinaryGrammar,
        RecognizerRuleNotFoundStream,
        RecognizerNoRootRuleToActivate,
        RecognizerNoRootRuleToActivate1,
        RecognizerRuleActivationFailed,
        RecognizerAlreadyRecognizing,
        RecognizerHasNoGrammar,
        NegativeTimesNotSupported,
        AudioDeviceFormatError,
        AudioDeviceError,
        AudioDeviceInternalError,
        RecognizerNotFound,
        RecognizerNotEnabled,
        RecognitionNotSupported,
        RecognitionNotSupportedOn64bit,
        GrammarAlreadyLoaded,
        RecognizerNoInputSource,
        GrammarNotLoaded,
        GrammarLoadingInProgress,
        GrammarLoadFailed,
        GrammarWrongRecognizer,
        NotSupportedOnDictationGrammars,
        LocalFilesOnly,
        NotValidAudioFile,
        NotValidAudioStream,
        FileNotFound,
        CannotSetPriorityOnDictation,
        RecognizerUpdateTableTooLarge,
        MaxAlternatesInvalid,
        RecognizerSettingGetError,
        RecognizerSettingUpdateError,
        RecognizerSettingNotSupported,
        ResourceUsageOutOfRange,
        RateOutOfRange,
        EndSilenceOutOfRange,
        RejectionThresholdOutOfRange,
        ReferencedGrammarNotFound,
        SapiErrorRuleNotFound2,
        NoAudioAvailable,
        ResultNotGrammarAvailable,
        ResultInvalidFormat,
        UnhandledVariant,
        DupSemanticKey,
        DupSemanticValue,
        CannotUseCustomFormat,
        NoPromptEngine,
        NoPromptEngineInterface,
        SeekNotSupported,
        ExtraDataNotPresent,
        BitsPerSampleInvalid,
        DataBlockSizeInvalid,
        NotWholeNumberBlocks,
        BlockSignatureInvalid,
        NumberOfSamplesInvalid,
        // Do not change ordering of codes below here; they correspond to the
        // numerical codes in sperror.h, from SPERR_UNINITIALIZED onwards.
        SapiErrorUninitialized, // 0x80045001 == SPERR_UNINITIALIZED == SPERR_FIRST
        SapiErrorAlreadyInitialized,
        SapiErrorNotSupportedFormat,
        SapiErrorInvalidFlags,
        SapiErrorEndOfStream,
        SapiErrorDeviceBusy,
        SapiErrorDeviceNotSupported,
        SapiErrorDeviceNotEnabled,
        SapiErrorNoDriver,
        SapiErrorFileMustBeUnicode,
        InsufficientData,
        SapiErrorInvalidPhraseID,
        SapiErrorBufferTooSmall,
        SapiErrorFormatNotSpecified,
        SapiErrorAudioStopped0,
        AudioPaused,
        SapiErrorRuleNotFound,
        SapiErrorTTSEngineException,
        SapiErrorTTSNLPException,
        SapiErrorEngineBUSY,
        AudioConversionEnabled,
        NoHypothesisAvailable,
        SapiErrorCantCreate,
        AlreadyInLex,
        SapiErrorNotInLex,
        LexNothingToSync,
        SapiErrorLexVeryOutOfSync,
        SapiErrorUndefinedForwardRuleRef,
        SapiErrorEmptyRule,
        SapiErrorGrammarCompilerInternalError,
        SapiErrorRuleNotDynamic,
        SapiErrorDuplicateRuleName,
        SapiErrorDuplicateResourceName,
        SapiErrorTooManyGrammars,
        SapiErrorCircularReference,
        SapiErrorInvalidImport,
        SapiErrorInvalidWAVFile,
        RequestPending,
        SapiErrorAllWordsOptional,
        SapiErrorInstanceChangeInvalid,
        SapiErrorRuleNameIdConflict,
        SapiErrorNoRules,
        SapiErrorCircularRuleRef,
        NoParseFound,
        SapiErrorInvalidHandle,
        SapiErrorRemoteCallTimedout,
        SapiErrorAudioBufferOverflow,
        SapiErrorNoAudioData,
        SapiErrorDeadAlternate,
        SapiErrorHighLowConfidence,
        SapiErrorInvalidFormatString,
        SPNotSupportedOnStreamInput,
        SapiErrorAppLexReadOnly,
        SapiErrorNoTerminatingRulePath,
        WordExistsWithoutPronunciation,
        SapiErrorStreamClosed,
        SapiErrorNoMoreItems,
        SapiErrorNotFound,
        SapiErrorInvalidAudioState,
        SapiErrorGenericMMSYS,
        SapiErrorMarshalerException,
        SapiErrorNotDynamicGrammar,
        SapiErrorAmbiguousProperty,
        SapiErrorInvalidRegistrykey,
        SapiErrorInvalidTokenId,
        SapiErrorXMLBadSyntax,
        SapiErrorXMLResourceNotFound,
        SapiErrorTokenInUse,
        SapiErrorTokenDeleted,
        SapiErrorMultilingualNotSupported,
        SapiErrorExportDynamicRule,
        SapiErrorSTGF,
        SapiErrorWordFormat,
        SapiErrorStreamNotActive,
        SapiErrorEngineResponseInvalid,
        SapiErrorSREngineException,
        SapiErrorStreamPosInvalid,
        SapiErrorRecognizerInactive,
        SapiErrorRemoteCallOnWrongThread,
        SapiErrorRemoteProcessTerminated,
        SapiErrorRemoteProcessAlreadyRunning,
        SapiErrorLangIdMismatch,
        SapiErrorPartialParseFound,
        SapiErrorNotTopLevelRule,
        SapiErrorNoRuleActive,
        SapiErrorLexRequiresCookie,
        SapiErrorStreamUninitialized, // 0x80045057
        SapiErrorUnused0,             // 0x80045058 is not used by SAPI, but it keeps counting
        SapiErrorNotSupportedLang,    // 0x80045059
        SapiErrorVoicePaused,         // 0x8004505a
        SapiErrorAudioBufferUnderflow,
        SapiErrorAudioStoppedUnexpectedly,
        SapiErrorNoWordPronunciation,
        SapiErrorAlternatesWouldBeInconsistent,
        SapiErrorNotSupportedForSharedRecognizer,
        SapiErrorTimeOut,
        SapiErrorReenterSynchronize,
        SapiErrorStateWithNoArcs,
        SapiErrorNotActiveSession,
        SapiErrorAlreadyDeleted,
        SapiErrorAudioStopped,
        SapiErrorRecoXMLGenerationFail,
        SapiErrorSMLGenerationFail,
        SapiErrorNotPromptVoice,         // 0x80045068
        SapiErrorRootRuleAlreadyDefined, // 0x80045069 == SPERR_ROOTRULE_ALREADY_DEFINED, then it skips 6
        SapiErrorUnused1, // skipped
        SapiErrorUnused2, // skipped
        SapiErrorUnused3, // skipped
        SapiErrorUnused4, // skipped
        SapiErrorUnused5, // skipped
        SapiErrorUnused6, // skipped
        SapiErrorScriptDisallowed,          // 0x80045070 == SPERR_SCRIPT_DISALLOWED
        SapiErrorRemoteCallTimedOutStart,   // 0x80045071
        SapiErrorRemoteCallTimedOutConnect,
        SapiErrorSecMgrChangeNotAllowed,
        SapiErrorCompleteButExtendable,
        SapiErrorFailedToDeleteFile,
        SapiErrorSharedEngineDisabled,
        SapiErrorRecognizerNotFound,
        SapiErrorAudioNotFound,
        SapiErrorNoVowel,
        SapiErrorNotSupportedPhoneme,
        SapiErrorNoRulesToActivate,
        SapiErrorNoWordEntryNotification,
        SapiErrorWordNeedsNormalization,
        SapiErrorCannotNormalize,
        LimitReached,
        NotSupported,
        SapiErrorTopicNotAdaptable,
        SapiErrorPhonemeConversion,
        SapiErrorNotSupportedForInprocRecognizer,
        SapiErrorOverload,
        SapiLexInvalidData,
        SapiConfigInvalidData,
        SapiLexUnexpectedFormat,
        SapiStringTooLong,   // 0x80045088
        SapiStringEmpty,     // 0x80045089 == SPERR_STRING_EMPTY, then it skips 6
        SapiErrorUnused7,    // skipped
        SapiErrorUnused8,    // skipped
        SapiErrorUnused9,    // skipped
        SapiErrorUnused10,   // skipped
        SapiErrorUnused11,   // skipped
        SapiErrorUnused12,   // skipped
        SapiNonWordTransition,        // 0x80045090 == SPERR_NON_WORD_TRANSITION
        SapiSisrAttributesNotAllowed, // 0x80045091
        SapiSisrMixedNotAllowed,      // 0x80045092
        SapiVoiceNotFound             // 0x80045093 == SPERR_VOICE_NOT_FOUND == SPERR_LAST
    }
}
