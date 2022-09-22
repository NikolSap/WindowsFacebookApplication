using FacebookCustomAppEngine;
using FourInRowForms;
using LikesCounter;

namespace BasicFacebookFeatures
{
    public static class FormFeaturesFactory
    {
        public static BaseClassOfAllFeaturesForm Create(eFeatureType i_FeatureType)
        {
            BaseClassOfAllFeaturesForm resultFeature = null;
            switch(i_FeatureType)
            {
                case eFeatureType.AlbumsForm:
                    resultFeature = new AlbumsForm();
                    break;
                case eFeatureType.EventsForm:
                    resultFeature = new EventsForm();
                    break;
                case eFeatureType.FavoriteTeamsForm:
                    resultFeature = new FavoriteTeamsFrom();
                    break;
                case eFeatureType.GroupsForm:
                    resultFeature = new GroupsForm();
                    break;
                case eFeatureType.LikedPagesForm:
                    resultFeature = new LikedPagesForm();
                    break;
                case eFeatureType.PostsForm:
                    resultFeature = new PostsForm();
                    break;
                case eFeatureType.RandomAlbumDataForm:
                    resultFeature = new RandomAlbumDataForm();
                    break;
                case eFeatureType.StartingGameForm:
                    resultFeature = new StartingGameForm();
                    break;
                case eFeatureType.WhoLikesMeTheMostForm:
                    resultFeature = new LikesCounterConfigurationForm();
                    break;
            }

            return resultFeature;
        }

        public static BaseClassOfAllFeaturesForm Create(
            eFeatureType i_FeatureType,
            string i_IdOfSelectedItem)
        {
            BaseClassOfAllFeaturesForm resultFeature = null;
            switch(i_FeatureType)
            {
                case eFeatureType.PhotosForm:
                    resultFeature = new PhotosForm(i_IdOfSelectedItem);
                    break;
                case eFeatureType.CommentsForm:
                    resultFeature = new CommentsForm(i_IdOfSelectedItem);
                    break;
            }

            return resultFeature;
        }
    }
}
