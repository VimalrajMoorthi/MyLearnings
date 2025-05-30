﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    // ImagePost derive from Post and adds a property (ImageURL) and two constructors
    class ImagePost : Post
    {
        public string ImmageURL { get; set; }

        public ImagePost(){ }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = IsPublic;

            // Property ImageURL is a member of ImagePost, but not of Post
            this.ImmageURL = imageURL;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.ID, this.Title, this.ImmageURL, this.SendByUsername);
        }
    }
}
