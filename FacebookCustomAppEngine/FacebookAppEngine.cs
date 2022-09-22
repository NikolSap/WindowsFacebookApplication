using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace FacebookCustomAppEngine
{
    public sealed class FacebookAppEngine
    {
        private static FacebookAppEngine s_Instance = null;
        private static object s_CreationInstanceObjLock = new Object();
        private static object s_AlbumPropertyAddingLock = new Object();
        private static object s_AlbumsCoversAddingLock = new Object();


        private User m_User;

        private Dictionary<string, object> m_AlbumsCoversDictionary;
        private Dictionary<string, object> m_GroupsCoverDucDictionary;
        private Dictionary<string, object> m_LikePagesCoversDictionary;
        private Dictionary<string, object> m_FavoriteTeamCoverDictionary;
        private Dictionary<string, object> m_EventsCoverDictionary;

        private Dictionary<string, FacebookObject> m_Posts;
        private Dictionary<string, FacebookObject> m_Albums;

        private Dictionary<string, Dictionary<string, FacebookObject>> m_Photos;

        public FacebookAppEngine()
        {
            this.User = null;
        }

        private void updateGroupsCollection(object sender, NotifyCollectionChangedEventArgs e)
        {
            Group group = this.getTheUnknownElement(
                              sender as FacebookObjectCollection<FacebookObject>,
                              this.m_GroupsCoverDucDictionary) as Group;

            if (group != null && this.m_GroupsCoverDucDictionary != null)
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    this.m_FavoriteTeamCoverDictionary.Add(group.Id, new ImageAndString(group.ImageSquare, group.Name));
                }

                if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    this.m_FavoriteTeamCoverDictionary.Remove(group.Id);
                }
            }
        }

        public void SetUser(User i_User)
        {
            if (m_User != i_User)
            {
                this.User = i_User;

                if (m_User != null)
                {
                    this.m_User.Posts.CollectionChanged += updatePostCollection;
                    this.m_User.Events.CollectionChanged += updateEventsCollection;
                    this.m_User.Albums.CollectionChanged += UpdateAlbumsCollection;
                    this.m_User.LikedPages.CollectionChanged += updateLikedPagesCollection;
                    this.m_User.LikedPages.CollectionChanged += updateFavoriteTeamsCollection;
                    this.m_User.Groups.CollectionChanged += updateGroupsCollection;

                }
                this.resetData();
            }
        }

        public FacebookObjectCollection<Album> AlbumsCollection
        {
            get
            {
                return User.Albums;
            }
        }

        public static FacebookAppEngine Instance
        {
            get
            {

                if (s_Instance == null)
                {
                    lock (s_CreationInstanceObjLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookAppEngine();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private User User
        {
            get
            {
                if (m_User == null)
                {
                    throw new UserWasNotSetException("you didn't set the user, please make sure the user was set.");
                }
                return m_User;
            }
            set
            {
                m_User = value;
            }
        }

        public string GetUserName()
        {
            return this.User.Name;
        }

        public Image GetUserProfilePicture()
        {
            return this.User.ImageSquare;
        }

        public Dictionary<string, FacebookObject> GetAlbumsDictionary()
        {
            return this.m_Albums;
        }

        public Dictionary<string, FacebookObject> GetPostsDictionary()
        {
            return this.m_Posts;
        }

        public Dictionary<string, object> FetchAlbumsImageDictionary()
        {
            updateAlbumsCollections();

            return this.m_AlbumsCoversDictionary;
        }

        internal void updateAlbumsCollections()
        {
            if (this.m_Albums == null)
            {
                this.m_Albums = new Dictionary<string, FacebookObject>();
            }

            if (this.m_AlbumsCoversDictionary == null)
            {
                this.m_AlbumsCoversDictionary = new Dictionary<string, object>();
            }


            foreach (Album album in User.Albums)
            {

                Thread thread = new Thread(() => insertAlbumToEngineDataIfNotExists(album));
                thread.Start();
            }
        }

        public Dictionary<string, object> FetchEventsImagesDictionary()
        {
            if (this.m_EventsCoverDictionary == null)
            {
                this.m_EventsCoverDictionary = new Dictionary<string, object>();
                this.getAllEvents();
            }

            return this.m_EventsCoverDictionary;
        }

        private void getAllEvents()
        {

            foreach (Event myEvent in User.Events)
            {
                if (myEvent.ImageSqaure != null)
                {
                    this.m_EventsCoverDictionary.Add(myEvent.Id, new ImageAndString(myEvent.ImageNormal, myEvent.Name));
                }
            }
        }

        private void insertAlbumToEngineDataIfNotExists(Album i_Album)
        {
            if (!this.m_Albums.ContainsKey(i_Album.Id) && i_Album.Photos.Count != 0)
            {
                lock (s_AlbumPropertyAddingLock)
                {
                    if (!this.m_Albums.ContainsKey(i_Album.Id) && i_Album.Photos.Count != 0)
                    {
                        this.m_Albums.Add(i_Album.Id, i_Album);
                    }
                }
            }

            if (!this.m_AlbumsCoversDictionary.ContainsKey(i_Album.Id))
            {
                lock (s_AlbumsCoversAddingLock)
                {
                    if (!this.m_AlbumsCoversDictionary.ContainsKey(i_Album.Id))
                    {
                        this.m_AlbumsCoversDictionary.Add(i_Album.Id, new ImageAndString(i_Album.ImageSmall, i_Album.Name));
                    }
                }
            }
        }
        public Dictionary<string, string> FetchCommentOfPost(string i_PostId)
        {
            Dictionary<string, string> postComments = new Dictionary<string, string>();
            FacebookObjectCollection<Comment> facebookObjectCollection = (this.m_Posts[i_PostId] as Post)?.Comments;

            if (facebookObjectCollection != null)
            {
                foreach (Comment comment in facebookObjectCollection)
                {
                    postComments.Add(comment.Id, comment.Message);
                }
            }

            return postComments;
        }

        public Dictionary<string, object> FetchLikedPagesImagesDictionary()
        {
            if (this.m_LikePagesCoversDictionary == null)
            {
                this.m_LikePagesCoversDictionary = new Dictionary<string, object>();
                this.getAllLikedPages();
            }

            return this.m_LikePagesCoversDictionary;
        }

        private void getAllLikedPages()
        {
            foreach (Page page in User.LikedPages)
            {
                this.m_LikePagesCoversDictionary.Add(page.Id, new ImageAndString(page.ImageSquare, page.Name));
            }
        }

        public Dictionary<string, object> FetchAllFavoritesTeamsImageDictionary()
        {
            if (this.m_FavoriteTeamCoverDictionary == null)
            {
                this.m_FavoriteTeamCoverDictionary = new Dictionary<string, object>();
                this.getAllFavoriteTeams();
            }

            return this.m_FavoriteTeamCoverDictionary;
        }

        private void getAllFavoriteTeams()
        {
            foreach (Page page in this.User.FavofriteTeams)
            {
                this.m_FavoriteTeamCoverDictionary.Add(page.Id, new ImageAndString(page.ImageSquare, page.Name));
            }
        }

        public Dictionary<string, object> FetchGroupsCoverImageDictionary()
        {
            if (this.m_GroupsCoverDucDictionary == null)
            {
                this.m_GroupsCoverDucDictionary = new Dictionary<string, object>();
                this.getAllGroups();
            }

            return this.m_GroupsCoverDucDictionary;
        }

        private void getAllGroups()
        {
            foreach (Group group in this.User.Groups)
            {
                this.m_GroupsCoverDucDictionary.Add(group.Id, new ImageAndString(group.ImageSquare, group.Name));
            }
        }

        private void updateLikedPagesCollection(object sender, NotifyCollectionChangedEventArgs e)
        {
            Page page = this.getTheUnknownElement(
                            sender as FacebookObjectCollection<FacebookObject>,
                            this.m_LikePagesCoversDictionary) as Page;

            if (page != null && this.m_LikePagesCoversDictionary != null)
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    this.m_LikePagesCoversDictionary.Add(page.Id, new ImageAndString(page.ImageSquare, page.Name));
                }

                if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    m_LikePagesCoversDictionary.Remove(page.Id);
                }
            }
        }

        private void updateFavoriteTeamsCollection(object sender, NotifyCollectionChangedEventArgs e)
        {
            Page page = this.getTheUnknownElement(
                            sender as FacebookObjectCollection<FacebookObject>,
                            this.m_FavoriteTeamCoverDictionary) as Page;

            if (page != null && this.m_FavoriteTeamCoverDictionary != null)
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    this.m_FavoriteTeamCoverDictionary.Add(page.Id, new ImageAndString(page.ImageSquare, page.Name));
                }

                if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    this.m_FavoriteTeamCoverDictionary.Remove(page.Id);
                }
            }
        }

        private void updateEventsCollection(object sender, NotifyCollectionChangedEventArgs e)
        {
            Event userEvent = this.getTheUnknownElement(
                                  sender as FacebookObjectCollection<FacebookObject>,
                                  this.m_EventsCoverDictionary) as Event;

            if (userEvent != null && this.m_EventsCoverDictionary != null)
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    this.m_EventsCoverDictionary.Add(userEvent.Id, new ImageAndString(userEvent.ImageSqaure, userEvent.Name));
                }

                if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    this.m_EventsCoverDictionary.Remove(userEvent.Id);
                }
            }
        }

        public void UpdateAlbumsCollection(object sender, NotifyCollectionChangedEventArgs e)
        {
            Album album = this.getTheUnknownElement(sender as FacebookObjectCollection<FacebookObject>, this.m_Albums) as Album;

            if (album != null && this.m_Albums != null)
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    if (this.m_AlbumsCoversDictionary.ContainsKey(album.Id))
                    {
                        this.m_AlbumsCoversDictionary.Add(album.Id, new ImageAndString(album.ImageAlbum, album.Name));
                    }

                    if (this.m_Albums.ContainsKey(album.Id))
                    {
                        this.m_Albums.Add(album.Id, album);
                    }
                }

                syncPhotosDictionaryWithAlbum(album);

                if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    if (this.m_AlbumsCoversDictionary.ContainsKey(album.Id))
                    {
                        this.m_AlbumsCoversDictionary.Remove(album.Id);
                    }

                    if (this.m_Albums.ContainsKey(album.Id))
                    {
                        this.m_Albums.Remove(album.Id);
                    }

                    if (this.m_Photos != null && m_Photos.ContainsKey(album.Id))
                    {
                        this.m_Photos[album.Id].Clear();
                        this.m_Photos.Remove(album.Id);
                    }
                }
            }
        }

        private void syncPhotosDictionaryWithAlbum(Album i_album)
        {
            if (this.m_Photos == null)
            {
                this.m_Photos = new Dictionary<string, Dictionary<string, FacebookObject>>();
            }

            foreach (Photo photo in i_album.Photos)
            {
                if (!this.m_Photos.ContainsKey(i_album.Id))
                {
                    this.m_Photos.Add(i_album.Id, new Dictionary<string, FacebookObject>());
                }

                if (!this.m_Photos[i_album.Id].ContainsKey(photo.Id))
                {
                    this.m_Photos[i_album.Id].Add(photo.Id, photo);
                }
            }
        }

        private void updatePostCollection(object sender, NotifyCollectionChangedEventArgs e)
        {
            Post post = this.getTheUnknownElement(sender as FacebookObjectCollection<FacebookObject>, m_Posts) as Post;

            if (post != null && m_Posts != null)
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    this.m_Posts.Add(post.Id, post);
                }

                if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    this.m_Posts.Remove(post.Id);
                }
            }
        }

        private FacebookObject getTheUnknownElement(
            FacebookObjectCollection<FacebookObject> i_ChangedCollection,
            Dictionary<string, object> i_DictionaryForSearch)
        {
            FacebookObject returnValue = null;

            if (i_DictionaryForSearch != null)
            {
                foreach (FacebookObject facebookObject in i_ChangedCollection)
                {
                    if (!i_DictionaryForSearch.ContainsKey(facebookObject.Id))
                    {
                        returnValue = facebookObject;
                        break;
                    }
                }
            }

            return returnValue;
        }

        private FacebookObject getTheUnknownElement(
            FacebookObjectCollection<FacebookObject> i_ChangedCollection,
            Dictionary<string, FacebookObject> i_DictionaryForSearch)
        {
            FacebookObject returnValue = null;

            if (i_DictionaryForSearch != null)
            {
                foreach (FacebookObject facebookObject in i_ChangedCollection)
                {
                    if (!i_DictionaryForSearch.ContainsKey(facebookObject.Id))
                    {
                        returnValue = facebookObject;
                        break;
                    }
                }
            }

            return returnValue;
        }

        public Dictionary<string, Image> FetchPhotoAlbum(string i_IdOfTheCointainAlbun)
        {
            Dictionary<string, Image> returnValue = new Dictionary<string, Image>();

            if (m_Photos == null)
            {
                this.m_Photos = new Dictionary<string, Dictionary<string, FacebookObject>>();
            }

            if (!this.m_Photos.ContainsKey(i_IdOfTheCointainAlbun))
            { 
                if(!this.m_Albums.ContainsKey(i_IdOfTheCointainAlbun))
                {
                    Album albumToAdd = m_User.Albums.Where(album => album.Id == i_IdOfTheCointainAlbun).First();

                    insertAlbumToEngineDataIfNotExists(albumToAdd);
                }
           
                syncPhotosDictionaryWithAlbum(this.m_Albums[i_IdOfTheCointainAlbun] as Album);
            }

            foreach (KeyValuePair<string, FacebookObject> pair in m_Photos[i_IdOfTheCointainAlbun])
            {
                returnValue.Add(pair.Key, (pair.Value as Photo)?.ImageAlbum);
            }

            return returnValue;
        }

        public Dictionary<string, string> FetchPostsText()
        {
            Dictionary<string, string> postTextDictionary = new Dictionary<string, string>();

            if (this.m_Posts == null)
            {
                updatePostFromUser();
            }

            foreach (KeyValuePair<string, FacebookObject> keyValuePair in m_Posts)
            {
                Post post = keyValuePair.Value as Post;
                if (post != null && post.Message != null)
                {
                    postTextDictionary.Add(keyValuePair.Key, post.Message);
                }
                else if (post != null && post.Caption != null)
                {
                    postTextDictionary.Add(keyValuePair.Key, post.Caption);
                }
            }

            return postTextDictionary;
        }

        private void updatePostFromUser()
        {
            if (this.m_Posts == null)
            {
                this.m_Posts = new Dictionary<string, FacebookObject>();
            }

            foreach (Post userPost in User.Posts)
            {
                if (!this.m_Posts.ContainsKey(userPost.Id))
                {
                    this.m_Posts.Add(userPost.Id, userPost);
                }
            }
        }

        public Dictionary<string, ImageAndString> FetchFriendsDictionary()
        {
            Dictionary<string, ImageAndString> listOfFriends = new Dictionary<string, ImageAndString>();
            foreach (User userFriend in this.User.Friends)
            {
                listOfFriends.Add(userFriend.Id, new ImageAndString(userFriend.ImageSquare, userFriend.Name));
            }

            return listOfFriends;
        }

        private void resetData()
        {
            this.m_AlbumsCoversDictionary = null;
            this.m_GroupsCoverDucDictionary = null;
            this.m_LikePagesCoversDictionary = null;
            this.m_FavoriteTeamCoverDictionary = null;
            this.m_EventsCoverDictionary = null;
            this.m_Posts = null;
            this.m_Albums = null;
            this.m_Photos = null;
        }
    }
}
