﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        public string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        // Default constructor. if a derived class does not invoke a base-
        // class constructor explicitly, the default constructor is called
        // implicity.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Vimalraj Moorthi";
        }

        // Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = IsPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Virtual method override of the ToString method that is inherited
        // from System.Object

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
