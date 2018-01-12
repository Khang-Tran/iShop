﻿using iShop.Web.Server.Commons.BaseClasses;
using iShop.Web.Server.Core.Models;
using iShop.Web.Server.Core.Resources;

namespace iShop.Web.Server.Mapping
{
    public class ImageProfile:BaseProfile
    {
        public ImageProfile(string profileName) : base(profileName)
        {
        }

        protected override void CreateMap()
        {
            CreateMap<Image, ImageResource>();
            CreateMap<ImageResource, Image>();
        }
    }
}
