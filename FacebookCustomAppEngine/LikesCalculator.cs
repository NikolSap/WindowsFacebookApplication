using System;
using System.Collections.Generic;
using FacebookCustomAppEngine;
using FacebookWrapper.ObjectModel;

namespace LikesCounter
{
    public class LikesCalculator
    {
        public IInitializeStrategyMethod m_ChooseMethod { get; set; }

        private readonly int r_NumberOfWinner;

        private readonly Dictionary<string, UserWithLikes> r_UsersLikesCounterDictionary;
        private object m_Object1 = null;
        private object m_Object2 = null;

        private readonly Dictionary<string, ImageAndString> r_PostsLikerList;
        private readonly Dictionary<string, ImageAndString> r_AlbumsLikerList;
        private readonly Dictionary<string, ImageAndString> r_PhotosLikerList;
        private readonly bool r_IncludesPosts;
        private readonly bool r_IncludesPhotos;
        private readonly bool r_IncludesAlbums;

        public object Object1
        {
            get
            {
                return m_Object1;
            }
            set
            {
                m_Object1 = value;
            }
        }

        public object Object2
        {
            get
            {
                return m_Object2;
            }
            set
            {
                m_Object2 = value;
            }
        }

        public LikesCalculator()
        {
            this.r_UsersLikesCounterDictionary = new Dictionary<string, UserWithLikes>();
            this.r_PostsLikerList = new Dictionary<string, ImageAndString>();
            this.r_AlbumsLikerList = new Dictionary<string, ImageAndString>();
            this.r_PhotosLikerList = new Dictionary<string, ImageAndString>();
        }

        public LikesCalculator(
            IInitializeStrategyMethod i_Method,
            bool i_withAlbums,
            bool i_WithPhotos,
            bool i_WithPosts,
            int i_ListSize)
        {
            this.r_UsersLikesCounterDictionary = new Dictionary<string, UserWithLikes>();
            this.r_PostsLikerList = new Dictionary<string, ImageAndString>();
            this.r_AlbumsLikerList = new Dictionary<string, ImageAndString>();
            this.r_PhotosLikerList = new Dictionary<string, ImageAndString>();
            m_ChooseMethod = i_Method;
            this.r_IncludesAlbums = i_withAlbums;
            this.r_IncludesPosts = i_WithPosts;
            this.r_IncludesPhotos = i_WithPhotos;
            this.r_NumberOfWinner = i_ListSize;

        }



        public bool IncludesPosts
        {
            get
            {
                return this.r_IncludesPosts;
            }
        }

        public bool IncludesPhotos
        {
            get
            {
                return this.r_IncludesPhotos;
            }
        }

        public bool IncludesAlbums
        {
            get
            {
                return this.r_IncludesAlbums;
            }
        }

        public bool IsValidSearch()
        {
            if (!this.IncludesPosts && !this.IncludesAlbums && !this.IncludesPhotos)
            {
                throw new InvalidIncludesException("Please checked at least one option (albums or photos or posts)");
            }

            return true;
        }

        private void addPostsLiker(Dictionary<string, FacebookObject> i_PostDictionary)
        {
            foreach (KeyValuePair<string, FacebookObject> keyValuePair in i_PostDictionary)
            {
                Post post = keyValuePair.Value as Post;
                if (post != null && m_ChooseMethod.Execute(post, m_Object1)
                                && (Object2 != null ? m_ChooseMethod.Execute(post, m_Object2) : true))
                {
                    createPostUsersDictionaryByMethod(post);
                }
            }
        }

        private void createPostUsersDictionaryByMethod(object i_Object)
        {
            FacebookObjectCollection<User> likerUser;
            FacebookObjectCollection<Comment> commentsList;


            if (m_ChooseMethod.GetType() == typeof(InitializeByNumberOfCommentsStrategyMethod))
            {
                createFacebookCollectionByComments(i_Object, out commentsList);

                foreach (Comment comment in commentsList)
                {
                    addUserToDictionary(comment.From);
                }
            }
            else
            {
                createFacebookCollectionByLikes(i_Object, out likerUser);

                foreach (User user in likerUser)
                {
                    addUserToDictionary(user);
                }

            }
        }

        private void createFacebookCollectionByComments(
            object i_Object,
            out FacebookObjectCollection<Comment> io_Comment)
        {
            if (i_Object.GetType() == typeof(Post))
            {
                io_Comment = ((Post)i_Object).Comments;
            }
            else if (i_Object.GetType() == typeof(Photo))
            {
                io_Comment = ((Photo)i_Object).Comments;
            }
            else
            {
                io_Comment = ((Album)i_Object).Comments;
            }
        }

        private void createFacebookCollectionByLikes(object i_Object, out FacebookObjectCollection<User> io_LikerUser)
        {
            if (i_Object.GetType() == typeof(Post))
            {
                io_LikerUser = ((Post)i_Object).LikedBy;
            }
            else if (i_Object.GetType() == typeof(Photo))
            {
                io_LikerUser = ((Photo)i_Object).LikedBy;
            }
            else
            {
                io_LikerUser = ((Album)i_Object).LikedBy;
            }
        }

        private void addUserToDictionary(User i_User)
        {
            if (this.r_UsersLikesCounterDictionary.ContainsKey(i_User.Id))
            {
                this.r_UsersLikesCounterDictionary[i_User.Id].LikesToPosts++;
            }
            else
            {
                UserWithLikes userWithLikes = new UserWithLikes(i_User);
                userWithLikes.LikesToPosts++;
                this.r_UsersLikesCounterDictionary.Add(i_User.Id, userWithLikes);
            }
        }

        private void genericInsertToListFunction(string typeOfElement)
        {
            int maxRun = this.r_NumberOfWinner;
            if (r_UsersLikesCounterDictionary != null)
            {
                List<UserWithLikes> listOfUser = new List<UserWithLikes>(this.r_UsersLikesCounterDictionary.Values);

                if (listOfUser.Count > 2)
                {
                    listOfUser.Sort(
                        delegate (UserWithLikes user1, UserWithLikes user2)
                        {
                            switch (typeOfElement)
                            {
                                case "photos":
                                    return user1.LikesToPhotos.CompareTo(user2.LikesToPhotos);
                                case "albums":
                                    return user1.LikesToAlbums.CompareTo(user2.LikesToAlbums);
                                case "posts":
                                    return user1.LikesToPosts.CompareTo(user2.LikesToPosts);
                                default:
                                    throw new BedTypeException("Unknown type of search pls try again");
                            }
                        });
                }

                if (listOfUser.Count < this.r_NumberOfWinner)
                {
                    maxRun = listOfUser.Count;
                }

                for (int i = 0; i < maxRun; i++)
                {
                    User user = listOfUser[i].UserData;

                    switch (typeOfElement)
                    {
                        case "photos":
                            this.r_PhotosLikerList.Add(user.Id, new ImageAndString(user.ImageSquare, user.Name));
                            break;
                        case "albums":
                            this.r_AlbumsLikerList.Add(user.Id, new ImageAndString(user.ImageSquare, user.Name));
                            break;
                        case "posts":
                            this.r_PostsLikerList.Add(user.Id, new ImageAndString(user.ImageSquare, user.Name));
                            break;
                        default:
                            throw new BedTypeException("Unknown type of search pls try again");
                    }
                }
            }
            else
            {
                throw new BedTypeException("There was no data about your selection");
            }
        }

        private void addPhotosLiker(Dictionary<string, FacebookObject> i_Photos)
        {
            foreach (KeyValuePair<string, FacebookObject> keyValuePair in i_Photos)
            {
                Photo photo = keyValuePair.Value as Photo;

                if (photo != null && m_ChooseMethod.Execute(photo, m_Object1) &&
                        (Object2 != null ? !m_ChooseMethod.Execute(photo, m_Object2) : true))
                {
                    createPostUsersDictionaryByMethod(photo);
                }
            }
        }

        private void addAlbumsLikers(Dictionary<string, FacebookObject> i_AlbumsDictionary)
        {
            foreach (KeyValuePair<string, FacebookObject> keyValuePair in i_AlbumsDictionary)
            {
                Album album = keyValuePair.Value as Album;
                if (album != null && album.Photos.Count > 0)
                {
                    if (album.CreatedTime != null && m_ChooseMethod.Execute(album, m_Object1)
                                                 && (Object2 != null
                                                         ? !m_ChooseMethod.Execute(album, m_Object2)
                                                         : true))
                    {
                        createPostUsersDictionaryByMethod(album);
                    }
                }
            }
        }
        public Dictionary<string, Dictionary<string, ImageAndString>> DoTheSearch(Dictionary<string, FacebookObject> i_Albums, Dictionary<string, FacebookObject> i_Posts)
        {
            Dictionary<string, Dictionary<string, ImageAndString>> lastResult = new Dictionary<string, Dictionary<string, ImageAndString>>();
            Dictionary<string, FacebookObject> photos;

            if (this.IncludesAlbums)
            {
                this.addAlbumsLikers(i_Albums);
                this.genericInsertToListFunction("albums");
                lastResult.Add("albums", this.r_AlbumsLikerList);
            }

            if (this.IncludesPhotos)
            {
                photos = new Dictionary<string, FacebookObject>();

                foreach (KeyValuePair<string, FacebookObject> keyValuePair in i_Albums)
                {
                    Album album = keyValuePair.Value as Album;

                    if (album != null)
                    {
                        foreach (Photo photo in album.Photos)
                        {
                            if (m_ChooseMethod.Execute(photo, m_Object1)
                               && (Object2 != null ? !m_ChooseMethod.Execute(photo, m_Object2) : true))
                            {
                                photos.Add(photo.Id, photo);
                            }
                        }
                    }
                }

                this.addPhotosLiker(photos);
                this.genericInsertToListFunction("photos");
                lastResult.Add("photos", this.r_PhotosLikerList);
            }

            if (this.IncludesPosts)
            {
                this.addPostsLiker(i_Posts);
                this.genericInsertToListFunction("posts");
                lastResult.Add("posts", this.r_PostsLikerList);
            }

            return lastResult;
        }
    }
}
