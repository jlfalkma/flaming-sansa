using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.TestAttributes;
using ArtOfTest.WebAii.TestTemplates;
using ArtOfTest.WebAii.Win32.Dialogs;

using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

using NUnit.Framework;
using Core = NUnit.Core;
//using Telerik.TestingFramework.Controls.KendoUI;  //test change
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;

namespace testsignup
{
    /// <summary>
    /// Summary description for add_edit_event_error_reminder_MBUnitTest
    /// </summary>
    [TestFixture]
    [Category("round one")]
    public class add_edit_event_error_reminder_MBUnitTest : BaseTest
    {

        #region [Setup / TearDown]

        /// <summary>
        /// Initialization for each test.
        /// </summary>
        [SetUp]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            // Initializes WebAii manager to be used by the test case.
            // If a WebAii configuration section exists, settings will be
            // loaded from it. Otherwise, will create a default settings
            // object with system defaults.
            //
            // Note: We are passing in a delegate to the NUnit's TestContext.Out.
            // WriteLine() method. This way any logging
            // done from WebAii (i.e. Manager.Log.WriteLine()) is
            // automatically logged to same output as NUnit.
            //
            // If you do not care about unifying the log, then you can simply
            // initialize the test by calling Initialize() with no parameters;
            // that will cause the log location to be picked up from the config
            // file if it exists or will use the default system settings.
            // You can also use Initialize(LogLocation) to set a specific log
            // location for this test.

            // Pass in 'true' to recycle the browser between test methods
            Initialize(false, new TestContextWriteLine(Console.Out.WriteLine));
            _pages = new Pages(Manager.Current);

            // If you need to override any other settings coming from the
            // config section or you don't have a config section, you can
            // comment the 'Initialize' line above and instead use the
            // following:

            /*

            // This will get a new Settings object. If a configuration
            // section exists, then settings from that section will be
            // loaded

            Settings settings = GetSettings();

            // Override the settings you want. For example:
            settings.DefaultBrowser = BrowserType.FireFox;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(Core.TestContext.Out.WriteLine));

            */

            #endregion

            //
            // Place any additional initialization here
            //
        }

        /// <summary>
        /// Clean up after each test.
        /// </summary>
        [TearDown]
        public void MyTestCleanUp()
        {
            //
            // Place any additional cleanup here
            //

            #region WebAii CleanUp

            // Shuts down WebAii manager and closes all browsers currently running
            this.CleanUp();

            #endregion
        }

        /// <summary>
        /// Called after all tests in this class are executed.
        /// </summary>
        [TestFixtureTearDown]
        public void FixtureCleanup()
        {
            // This will shut down all browsers if
            // recycleBrowser is turned on. Else
            // will do nothing.
            ShutDown();
        }

        #endregion

        private testsignup.Pages _pages;

        public testsignup.Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        [Test()]
        [TestCase(BrowserType.InternetExplorer)]
        [TestCase(BrowserType.FireFox)]
        [TestCase(BrowserType.Chrome)]
        //[TestCase(BrowserType.Safari)]
        public void add_edit_event_error_reminder_MB(BrowserType browser)
        {
            // Launch an instance of the browser
            Manager.LaunchNewBrowser(browser);
            //System.Diagnostics.Debugger.Break();

            #region Execute test 'Clear Browser Cache.tstest'

            // Coded Step From Test
            if (ActiveBrowser.BrowserType != BrowserType.Safari && ActiveBrowser.BrowserType != BrowserType.FireFox)
            {
                ActiveBrowser.ClearCache(BrowserCacheType.Cookies);
                if (ActiveBrowser.BrowserType != BrowserType.InternetExplorer)
                    ActiveBrowser.ClearCache(BrowserCacheType.History);
                if (ActiveBrowser.BrowserType != BrowserType.Chrome)
                    ActiveBrowser.ClearCache(BrowserCacheType.TempFilesCache);
            }


            #endregion


            #region Execute test 'testing login evanced MB.tstest'

            // Navigate to : 'http://testing.evanced.info/testing/evanced'
            ActiveBrowser.NavigateTo("http://testing.evanced.info/testing/evanced", false);


            // Enter text 'evanced' in 'TbxUsernameText'
            Actions.SetText(Pages.Admin2EvancedSolutions0.TbxUsernameText, "evanced");


            // Enter text 'pledok@' in 'TbxPasswordPassword'
            Actions.SetText(Pages.Admin2EvancedSolutions0.TbxPasswordPassword, "pledok@");


            // Click 'BtnSubmitSubmit'
            Pages.Admin2EvancedSolutions0.BtnSubmitSubmit.Click(false);


            // Click 'SULogoPngImage'
            Pages.SignupEvancedSolutions0.SULogoPngImage.Click(false);


            #endregion


            // Click 'AddEventDiv'
            Pages.SignupEvancedSolutions0.AddEventDiv.Click(false);


            // Click 'BtnPreviewButton'
            Pages.SignupEvancedSolutions0.BtnPreviewButton.Click(false);


            // Verify 'InnerText' 'Exact' 'Event Preview' on 'UiDialogTitleDivEventPreviewDialogSpan'
            Pages.SignupEvancedSolutions0.UiDialogTitleDivEventPreviewDialogSpan.AssertContent().InnerText(ArtOfTest.Common.StringCompareType.Exact, "Event Preview");


            // Click 'CloseSpan'
            Pages.SignupEvancedSolutions0.CloseSpan.Click(false);


            // Click 'Tab2Link'
            Pages.SignupEvancedSolutions0.Tab2Link.Click(false);


            // Wait for 'ColorAndBackground:Color' style 'Exact' '#CE0B09' on 'Tab1Link'
            Wait.For<HtmlAnchor>(c => c.AssertStyle(false).ColorAndBackground(ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleColorAndBackground.Color, "#CE0B09", ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleType.Computed, ArtOfTest.Common.StringCompareType.Exact), Pages.SignupEvancedSolutions0.Tab1Link, 10000);


            // Select 'ByValue' option '1' on 'DdlRepeatSelect'
            Pages.SignupEvancedSolutions0.DdlRepeatSelect.SelectByValue("1", true);


            // Click 'Tab4Link'
            Pages.SignupEvancedSolutions0.Tab4Link.Click(false);


            // Wait for 'ColorAndBackground:Color' style 'Exact' '#CE0B09' on 'Tab2Link'
            Wait.For<HtmlAnchor>(c => c.AssertStyle(false).ColorAndBackground(ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleColorAndBackground.Color, "#CE0B09", ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleType.Computed, ArtOfTest.Common.StringCompareType.Exact), Pages.SignupEvancedSolutions0.Tab2Link, 10000);


            // Select 'ByValue' option '1' on 'DdlRegistrationSelect'
            Pages.SignupEvancedSolutions0.DdlRegistrationSelect.SelectByValue("1", true);


            // Click 'Tab6Link'
            Pages.SignupEvancedSolutions0.Tab6Link.Click(false);


            // Wait for 'ColorAndBackground:Color' style 'Exact' '#CE0B09' on 'Tab4Link'
            Wait.For<HtmlAnchor>(c => c.AssertStyle(false).ColorAndBackground(ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleColorAndBackground.Color, "#CE0B09", ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleType.Computed, ArtOfTest.Common.StringCompareType.Exact), Pages.SignupEvancedSolutions0.Tab4Link, 10000);


            // Click 'LogoutLink'
            Pages.SignupEvancedSolutions0.LogoutLink.Click(false);



        }


    }
}
