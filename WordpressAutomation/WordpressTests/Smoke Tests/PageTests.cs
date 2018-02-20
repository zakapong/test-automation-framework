﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class PageTests : WordpressTest
    {
       
        [TestMethod]
        public void Can_Edit_A_Page()
        {
       
            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

           // Assert.IsTrue(NewPostPage.IsInEditMode(), "Wasn't in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did not match");
        }

    }
}
