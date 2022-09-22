using System;
using System.Collections.Generic;
using System.Drawing;
using LikesCounter;

namespace FacebookCustomAppEngine
{
    public class WhoLikeMeTheMostEngine
    {
        private LikesCalculator m_LikesCalculator;

        public WhoLikeMeTheMostEngine()
        {
        }

        public LikesCalculator LikesCalculator
        {
            get
            {
                return m_LikesCalculator;
            }
        }

        public Image getUserProfilePicture()
        {
            return FacebookAppEngine.Instance.GetUserProfilePicture();
        }

        public void UpdateLikesCalculator(
            IInitializeStrategyMethod i_Method,
            DateTime i_StartDateTime,
            DateTime i_EndDateTime,
            bool i_IncludeAlbums,
            bool i_IncludesPhotos,
            bool i_IncludesPosts,
            int i_AmountsOfUser)
        {
            m_LikesCalculator = new LikesCalculator(
                i_Method,
                i_IncludeAlbums,
                i_IncludesPhotos,
                i_IncludesPosts,
                i_AmountsOfUser);
            m_LikesCalculator.Object1 = i_StartDateTime;
            m_LikesCalculator.Object2 = i_EndDateTime;

        }

        public void UpdateLikesCalculator(
            IInitializeStrategyMethod i_Method,
            int i_NumberToSearch,
            bool i_IncludeAlbums,
            bool i_IncludesPhotos,
            bool i_IncludesPosts,
            int i_AmountsOfUser)
        {
            m_LikesCalculator = new LikesCalculator(
                i_Method,
                i_IncludeAlbums,
                i_IncludesPhotos,
                i_IncludesPosts,
                i_AmountsOfUser);
            m_LikesCalculator.Object1 = i_NumberToSearch;
        }

        public Dictionary<string, Dictionary<string, ImageAndString>> GetTheFriendsWitheTheMostLikes()
        {
            if (m_LikesCalculator == null)
            {
                throw new Exception("Please call the function UpdateLikesCalculator the calculator first");
            }

            if (m_LikesCalculator.IsValidSearch())
            {
                if (m_LikesCalculator.IncludesAlbums || this.m_LikesCalculator.IncludesPhotos)
                {
                    FacebookAppEngine.Instance.updateAlbumsCollections();
                }

                if (m_LikesCalculator.IncludesPosts)
                {
                    FacebookAppEngine.Instance.FetchPostsText();
                }
            }

            return m_LikesCalculator.DoTheSearch(FacebookAppEngine.Instance.GetAlbumsDictionary(), FacebookAppEngine.Instance.GetPostsDictionary());
        }
    }
}
