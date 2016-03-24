﻿
#region Using directives
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
#endregion


namespace CSUACSelfElevation
{
    internal enum TOKEN_INFORMATION_CLASS
    {
        TokenUser = 1,
        TokenGroups,
        TokenPrivileges,
        TokenOwner,
        TokenPrimaryGroup,
        TokenDefaultDacl,
        TokenSource,
        TokenType,
        TokenImpersonationLevel,
        TokenStatistics,
        TokenRestrictedSids,
        TokenSessionId,
        TokenGroupsAndPrivileges,
        TokenSessionReference,
        TokenSandBoxInert,
        TokenAuditPolicy,
        TokenOrigin,
        TokenElevationType,
        TokenLinkedToken,
        TokenElevation,
        TokenHasRestrictions,
        TokenAccessInformation,
        TokenVirtualizationAllowed,
        TokenVirtualizationEnabled,
        TokenIntegrityLevel,
        TokenUIAccess,
        TokenMandatoryPolicy,
        TokenLogonSid,
        MaxTokenInfoClass
    }


    internal enum WELL_KNOWN_SID_TYPE
    {
        WinNullSid = 0,
        WinWorldSid = 1,
        WinLocalSid = 2,
        WinCreatorOwnerSid = 3,
        WinCreatorGroupSid = 4,
        WinCreatorOwnerServerSid = 5,
        WinCreatorGroupServerSid = 6,
        WinNtAuthoritySid = 7,
        WinDialupSid = 8,
        WinNetworkSid = 9,
        WinBatchSid = 10,
        WinInteractiveSid = 11,
        WinServiceSid = 12,
        WinAnonymousSid = 13,
        WinProxySid = 14,
        WinEnterpriseControllersSid = 15,
        WinSelfSid = 16,
        WinAuthenticatedUserSid = 17,
        WinRestrictedCodeSid = 18,
        WinTerminalServerSid = 19,
        WinRemoteLogonIdSid = 20,
        WinLogonIdsSid = 21,
        WinLocalSystemSid = 22,
        WinLocalServiceSid = 23,
        WinNetworkServiceSid = 24,
        WinBuiltinDomainSid = 25,
        WinBuiltinAdministratorsSid = 26,
        WinBuiltinUsersSid = 27,
        WinBuiltinGuestsSid = 28,
        WinBuiltinPowerUsersSid = 29,
        WinBuiltinAccountOperatorsSid = 30,
        WinBuiltinSystemOperatorsSid = 31,
        WinBuiltinPrintOperatorsSid = 32,
        WinBuiltinBackupOperatorsSid = 33,
        WinBuiltinReplicatorSid = 34,
        WinBuiltinPreWindows2000CompatibleAccessSid = 35,
        WinBuiltinRemoteDesktopUsersSid = 36,
        WinBuiltinNetworkConfigurationOperatorsSid = 37,
        WinAccountAdministratorSid = 38,
        WinAccountGuestSid = 39,
        WinAccountKrbtgtSid = 40,
        WinAccountDomainAdminsSid = 41,
        WinAccountDomainUsersSid = 42,
        WinAccountDomainGuestsSid = 43,
        WinAccountComputersSid = 44,
        WinAccountControllersSid = 45,
        WinAccountCertAdminsSid = 46,
        WinAccountSchemaAdminsSid = 47,
        WinAccountEnterpriseAdminsSid = 48,
        WinAccountPolicyAdminsSid = 49,
        WinAccountRasAndIasServersSid = 50,
        WinNTLMAuthenticationSid = 51,
        WinDigestAuthenticationSid = 52,
        WinSChannelAuthenticationSid = 53,
        WinThisOrganizationSid = 54,
        WinOtherOrganizationSid = 55,
        WinBuiltinIncomingForestTrustBuildersSid = 56,
        WinBuiltinPerfMonitoringUsersSid = 57,
        WinBuiltinPerfLoggingUsersSid = 58,
        WinBuiltinAuthorizationAccessSid = 59,
        WinBuiltinTerminalServerLicenseServersSid = 60,
        WinBuiltinDCOMUsersSid = 61,
        WinBuiltinIUsersSid = 62,
        WinIUserSid = 63,
        WinBuiltinCryptoOperatorsSid = 64,
        WinUntrustedLabelSid = 65,
        WinLowLabelSid = 66,
        WinMediumLabelSid = 67,
        WinHighLabelSid = 68,
        WinSystemLabelSid = 69,
        WinWriteRestrictedCodeSid = 70,
        WinCreatorOwnerRightsSid = 71,
        WinCacheablePrincipalsGroupSid = 72,
        WinNonCacheablePrincipalsGroupSid = 73,
        WinEnterpriseReadonlyControllersSid = 74,
        WinAccountReadonlyControllersSid = 75,
        WinBuiltinEventLogReadersGroup = 76,
        WinNewEnterpriseReadonlyControllersSid = 77,
        WinBuiltinCertSvcDComAccessGroup = 78
    }


    internal enum SECURITY_IMPERSONATION_LEVEL
    {
        SecurityAnonymous, 
        SecurityIdentification,
        SecurityImpersonation,
        SecurityDelegation
    }

 
    internal enum TOKEN_ELEVATION_TYPE
    {
        TokenElevationTypeDefault = 1,
        TokenElevationTypeFull,
        TokenElevationTypeLimited
    }

    
    [StructLayout(LayoutKind.Sequential)]
    internal struct SID_AND_ATTRIBUTES
    {
        public IntPtr Sid;
        public UInt32 Attributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct TOKEN_ELEVATION
    {
        public Int32 TokenIsElevated;
    }

    
    [StructLayout(LayoutKind.Sequential)]
    internal struct TOKEN_MANDATORY_LABEL
    {
        public SID_AND_ATTRIBUTES Label;
    }

  
    internal class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private SafeTokenHandle() : base(true)
        {
        }

        internal SafeTokenHandle(IntPtr handle) : base(true)
        {
            base.SetHandle(handle);
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool CloseHandle(IntPtr handle);

        protected override bool ReleaseHandle()
        {
            return CloseHandle(base.handle);
        }
    }

    internal class NativeMethods
    {
 
        public const UInt32 STANDARD_RIGHTS_REQUIRED = 0x000F0000;
        public const UInt32 STANDARD_RIGHTS_READ = 0x00020000;
        public const UInt32 TOKEN_ASSIGN_PRIMARY = 0x0001;
        public const UInt32 TOKEN_DUPLICATE = 0x0002;
        public const UInt32 TOKEN_IMPERSONATE = 0x0004;
        public const UInt32 TOKEN_QUERY = 0x0008;
        public const UInt32 TOKEN_QUERY_SOURCE = 0x0010;
        public const UInt32 TOKEN_ADJUST_PRIVILEGES = 0x0020;
        public const UInt32 TOKEN_ADJUST_GROUPS = 0x0040;
        public const UInt32 TOKEN_ADJUST_DEFAULT = 0x0080;
        public const UInt32 TOKEN_ADJUST_SESSIONID = 0x0100;
        public const UInt32 TOKEN_READ = (STANDARD_RIGHTS_READ | TOKEN_QUERY);
        public const UInt32 TOKEN_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED |
            TOKEN_ASSIGN_PRIMARY | TOKEN_DUPLICATE | TOKEN_IMPERSONATE |
            TOKEN_QUERY | TOKEN_QUERY_SOURCE | TOKEN_ADJUST_PRIVILEGES |
            TOKEN_ADJUST_GROUPS | TOKEN_ADJUST_DEFAULT | TOKEN_ADJUST_SESSIONID);


        public const Int32 ERROR_INSUFFICIENT_BUFFER = 122;




        public const Int32 SECURITY_MANDATORY_UNTRUSTED_RID = 0x00000000;
        public const Int32 SECURITY_MANDATORY_LOW_RID = 0x00001000;
        public const Int32 SECURITY_MANDATORY_MEDIUM_RID = 0x00002000;
        public const Int32 SECURITY_MANDATORY_HIGH_RID = 0x00003000;
        public const Int32 SECURITY_MANDATORY_SYSTEM_RID = 0x00004000;
 

       
        [DllImport("advapi32", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenProcessToken(IntPtr hProcess,
            UInt32 desiredAccess, out SafeTokenHandle hToken);


     
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public extern static bool DuplicateToken(
            SafeTokenHandle ExistingTokenHandle, 
            SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            out SafeTokenHandle DuplicateTokenHandle);


        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetTokenInformation(
            SafeTokenHandle hToken,
            TOKEN_INFORMATION_CLASS tokenInfoClass,
            IntPtr pTokenInfo,
            Int32 tokenInfoLength, 
            out Int32 returnLength);


        public const UInt32 BCM_SETSHIELD = 0x160C;


     
        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, IntPtr lParam);


       
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetSidSubAuthority(IntPtr pSid, UInt32 nSubAuthority);
    }
}