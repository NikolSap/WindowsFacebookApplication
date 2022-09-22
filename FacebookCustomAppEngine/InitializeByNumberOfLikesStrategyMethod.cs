using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookCustomAppEngine
{
    public class InitializeByNumberOfLikesStrategyMethod : IInitializeStrategyMethod
    {
        public bool Execute(object i_Object1, object i_Object2)
        {
            if(i_Object1.GetType() == typeof(Post))
            {
                return ((Post)i_Object1).LikedBy.Count > (int)i_Object2;
            }
            else if(i_Object1.GetType() == typeof(Photo))
            {
                return ((Photo)i_Object1).LikedBy.Count > (int)i_Object2;
            }
            else
            { 
                return ((Album)i_Object1).LikedBy.Count > (int)i_Object2;
            }
        }
    }
}
