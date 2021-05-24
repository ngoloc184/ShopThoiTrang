using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Input;
using DevExpress.CodedUIExtension.DXTestControls.v19_2;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using MouseButtons = System.Windows.Forms.MouseButtons;


namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest_Login
    /// </summary>
    [CodedUITest]
    public class CodedUITest_Login
    {
        public CodedUITest_Login()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            this.UIMap.TC_Login_01();
            this.UIMap.TC_Login_02();
            this.UIMap.TC_Login_03();
            //this.UIMap.TC_Login_04();
            this.UIMap.RecordedMethod1();//Trường hợp 4
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            //this.UIMap.RecordedMethod_Login();
            //this.UIMap.RecordedMethod2();
        }
        //public void TC02()
        //{
        //    this.UIMap.TC_Login_02();
        //}
        //public void TC03()
        //{
        //    this.UIMap.TC_Login_03();
        //}
        //public void TC04()
        //{
        //}

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
    public class TaiKhoan
    {
        public TaiKhoan(string tenTaiKhoan,string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }
        public string tenTaiKhoan { get; set; }
        public string matKhau { get; set; }
    }
}
