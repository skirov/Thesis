﻿using Colab.API.DataTransferObjects.Users;
using Colab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Web;

namespace Colab.API.DataTransferObjects.Posts
{
    [DataContract]
    public class PostDto
    {

        public static new Expression<Func<Post, PostDto>> ToDto
        {
            get
            {
                return post => new PostDto
                {
                    Id = post.Id,
                    Body  = post.Body,
                    Creator = new UserDto
                    {
                        Id = post.Creator.Id,
                        UserName = post.Creator.UserName
                    },
                };
            }
        }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }
        
        [DataMember(Name = "creator")]
        public UserDto Creator { get; set; }
    }
}