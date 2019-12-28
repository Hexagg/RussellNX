using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussellNX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public static class TemplateVar
    {
        public static string GlobalTemplateJSONString = @"";
        public static string GlobalTemplateXMLString = @"<?xml version=""1.0"" encoding=""utf-8""?>
<Application>
    <Title>
        <Language>AmericanEnglish</Language>
        <Name>INSERT_TITLE_OF_APP_HERE</Name>
        <Publisher>INSERT_DEVELOPER_OF_THE_APP_HERE</Publisher>
    </Title>
    <Isbn/>
    <StartupUserAccount>Required</StartupUserAccount>
    <UserAccountSwitchLock>Disable</UserAccountSwitchLock>
    <ParentalControl>None</ParentalControl>
    <SupportedLanguage>AmericanEnglish</SupportedLanguage>
    <Screenshot>Allow</Screenshot>
    <VideoCapture>Enable</VideoCapture>
    <PresenceGroupId>INSERT_TITLEID_OF_THE_APP_HERE</PresenceGroupId>
    <DisplayVersion>INSERT_VERSION_STRING_HERE</DisplayVersion>
    <Rating>
        <Organization>CERO</Organization>
        <Age>12</Age>
    </Rating>
    <Rating>
        <Organization>ESRB</Organization>
        <Age>10</Age>
    </Rating>
    <Rating>
        <Organization>USK</Organization>
        <Age>12</Age>
    </Rating>
    <Rating>
        <Organization>PEGI</Organization>
        <Age>12</Age>
    </Rating>
    <Rating>
        <Organization>PEGIPortugal</Organization>
        <Age>12</Age>
    </Rating>
    <Rating>
        <Organization>PEGIBBFC</Organization>
        <Age>12</Age>
    </Rating>
    <Rating>
        <Organization>Russian</Organization>
        <Age>12</Age>
    </Rating>
    <Rating>
        <Organization>ACB</Organization>
        <Age>13</Age>
    </Rating>
    <Rating>
        <Organization>OFLC</Organization>
        <Age>13</Age>
    </Rating>
    <DataLossConfirmation>Required</DataLossConfirmation>
    <PlayLogPolicy>All</PlayLogPolicy>
    <SaveDataOwnerId>INSERT_TITLEID_OF_THE_APP_HERE</SaveDataOwnerId>
    <UserAccountSaveDataSize>0x0000000003e00000</UserAccountSaveDataSize>
    <UserAccountSaveDataJournalSize>0x0000000000180000</UserAccountSaveDataJournalSize>
    <DeviceSaveDataSize>0x0000000000000000</DeviceSaveDataSize>
    <DeviceSaveDataJournalSize>0x0000000000000000</DeviceSaveDataJournalSize>
    <BcatDeliveryCacheStorageSize>0x0000000000000000</BcatDeliveryCacheStorageSize>
    <ApplicationErrorCodeCategory/>
    <AddOnContentBaseId>0x0104444444442001</AddOnContentBaseId>
    <LogoType>Nintendo</LogoType>
    <LocalCommunicationId>INSERT_TITLEID_OF_THE_APP_HERE</LocalCommunicationId>
    <LogoHandling>Auto</LogoHandling>
    <SeedForPseudoDeviceId>0x0000000000000000</SeedForPseudoDeviceId>
    <BcatPassphrase/>
    <AddOnContentRegistrationType>AllOnLaunch</AddOnContentRegistrationType>
    <UserAccountSaveDataSizeMax>0x0000000000000000</UserAccountSaveDataSizeMax>
    <UserAccountSaveDataJournalSizeMax>0x0000000000000000</UserAccountSaveDataJournalSizeMax>
    <DeviceSaveDataSizeMax>0x0000000000000000</DeviceSaveDataSizeMax>
    <DeviceSaveDataJournalSizeMax>0x0000000000000000</DeviceSaveDataJournalSizeMax>
    <TemporaryStorageSize>0x0000000000000000</TemporaryStorageSize>
    <CacheStorageSize>0x0000000000000000</CacheStorageSize>
    <CacheStorageJournalSize>0x0000000000000000</CacheStorageJournalSize>
    <CacheStorageDataAndJournalSizeMax>0x0000000000000000</CacheStorageDataAndJournalSizeMax>
    <CacheStorageIndexMax>0x0000000000000000</CacheStorageIndexMax>
    <Hdcp>None</Hdcp>
    <CrashReport>Deny</CrashReport>
    <RuntimeAddOnContentInstall>Deny</RuntimeAddOnContentInstall>
    <PlayLogQueryableApplicationId>0x0000000000000000</PlayLogQueryableApplicationId>
    <PlayLogQueryCapability>None</PlayLogQueryCapability>
    <Repair>None</Repair>
    <Attribute>None</Attribute>
    <ProgramIndex>0</ProgramIndex>
    <RequiredNetworkServiceLicenseOnLaunch>None</RequiredNetworkServiceLicenseOnLaunch>
</Application>
";
    }
}
