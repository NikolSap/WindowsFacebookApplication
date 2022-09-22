using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        private bool m_RememberUser;
        private string m_LastAccessToken;
        private static string s_AppId = "6299416843465609";
        private static string[] s_Permissions;

        public AppSettings()
        {
            m_RememberUser = false;
            m_LastAccessToken = null;
            s_Permissions = new string[]
                              { "email", "public_profile", "user_age_range", "user_birthday", "user_events",
                                  "user_friends", "user_gender", "user_hometown", "user_likes", "user_link",
                                  "user_location",
                                  "user_photos",
                                  "user_posts",
                                  "user_videos"
                              };
        }

        public static string AppId
        {
            get
            {
                return s_AppId;
            }
        }

        public static string[] Permissions
        {
            get
            {
                return s_Permissions;
            }
        }

        public bool RememberUser
        {
            get
            {
                return m_RememberUser;
            }

            set
            {
                m_RememberUser = value;
            }
        }

        public string LastAccessToken
        {
            get
            {
                return m_LastAccessToken;
            }

            set
            {
                m_LastAccessToken = value;
            }
        }

        public void SaveData(string i_FileName)
        {
            if (File.Exists(i_FileName))
            {
                using (Stream stream = new FileStream(i_FileName, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());

                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(i_FileName, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());

                    serializer.Serialize(stream, this);
                }
            }
        }

        public void LoadAppSettingsData(string i_FileName)
        {
            AppSettings obj = new AppSettings();
            if (File.Exists(i_FileName))
            {
                using (Stream stream = new FileStream(i_FileName, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;

                    foreach (PropertyInfo currentProperty in typeof(AppSettings).GetProperties())
                    {
                        if (!currentProperty.GetMethod.IsStatic)
                        {
                            var value = currentProperty.GetValue(obj);

                            currentProperty.SetValue(this, value);
                        }
                    }
                }
            }
        }
    }
}