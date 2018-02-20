using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;
using WordpressAutomation.WorkFlows;
//using WordpressAutomation.Workflows;

namespace WordpressTests.PostsTests
{
    [TestClass]
    public class AllPostsTests : WordpressTest
    {
        // Added posts show up in all posts
        // Can activate excerpt mode
        // Can Add new post

        // Single post selections

        // Can select a post by title
        // Can select a post by Edit
        // Can select a post by QuickEdit
        // Can trash a post
        // Can view a post
        // Can filter by author
        // Can filter by category
        // Can filter by tag
        // Can go to post comments

        // Bulk actions

        // Can edit multiple posts
        // Can trash multiple posts
        // Can select all posts

        // Drop down filters

        // Can filter by month
        // Can filter by category
        // Can view published only
        // Can view drafts only
        // Can view trash only

        // Can search posts


        // Added posts show up in all posts
        // Can trash a post
        // Can search posts

        [TestMethod]
        public void Added_Posts_Show_Up()
        {
            // go to posts, het post count, store
            ListPostsPage.GoTo(PostType.Posts);
            ListPostsPage.StoreCount();

            // add a new post
            PostCreator.CreatePost();

           
            //go to post, get new post count
            ListPostsPage.GoTo(PostType.Posts);
            Assert.AreEqual(ListPostsPage.PreviousPostCount + 1, ListPostsPage.CurrentPostCount, "Count of posts did not increase");


            // check for added post

            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));

            //trash post (clean up)
            ListPostsPage.TrashPost(PostCreator.PreviousTitle);
            Assert.AreEqual(ListPostsPage.PreviousPostCount, ListPostsPage.CurrentPostCount, "Couldn't trash post");

        }

        [TestMethod]
        public void Can_Search_Posts()
        {
            //create a new post
            PostCreator.CreatePost();
           
            //search for post
            ListPostsPage.SearchForPost(PostCreator.PreviousTitle);
            //check the post shows up in the results
            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));
          

         
        }

    
    }
}
