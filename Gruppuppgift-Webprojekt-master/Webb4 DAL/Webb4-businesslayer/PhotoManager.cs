using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using Webb4_DAL.ModelsV2;

namespace Webb4_businesslayer
{
    class PhotoManager
    {


        internal string SavePhotoToCataloge(HttpPostedFileBase photo, string root, Guid name)
        {
            var url = "~/Photos/" + photo.FileName;
            photo.SaveAs(Path.Combine(root, photo.FileName));

            return url;
        }
    }
}
