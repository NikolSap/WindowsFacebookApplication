using FacebookWrapper.ObjectModel;

namespace LikesCounter
{
    public class UserWithLikes
    {
        private User m_UserData;
        private long m_LikesToAlbums;
        private long m_LikesToPosts;
        private long m_LikesToPhotos;

        public UserWithLikes(User user)
        {
            this.m_UserData = user;
        }

        public User UserData
        {
            get
            {
                return this.m_UserData;
            }
        }

        public long LikesToAlbums
        {
            get
            {
                return this.m_LikesToAlbums;
            }

            set
            {
                this.m_LikesToAlbums = value;
            }
        }

        public long LikesToPosts
        {
            get
            {
                return this.m_LikesToPosts;
            }

            set
            {
                this.m_LikesToPosts = value;
            }
        }

        public long LikesToPhotos
        {
            get
            {
                return this.m_LikesToPhotos;
            }

            set
            {
                this.m_LikesToPhotos = value;
            }
        }
    }
}
