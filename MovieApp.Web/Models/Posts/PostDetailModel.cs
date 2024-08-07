﻿using System;

namespace MemoMate.Web.Models.Posts
{
    public class PostDetailModel
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public DateTime PostDate { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public float PostRate { get; set; }
        public string Username { get; set; }
        public string UserPhoto { get; set; }
        public string ThemeName { get; set; }
        public string Liked { get; set; }
        public string FriendStatus { get; set; }
        public bool IsOwned { get; set; }
        public bool CanInteract { get; set; }
    }
}
