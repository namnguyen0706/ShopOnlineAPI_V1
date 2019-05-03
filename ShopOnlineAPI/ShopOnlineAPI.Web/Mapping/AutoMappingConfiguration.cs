using AutoMapper;
using ShopOnlineAPI.Model.Models;
using ShopOnlineAPI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnlineAPI.Web.Mapping
{
    public class AutoMappingConfiguration : Profile
    {
        public AutoMappingConfiguration()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Tag, TagViewModel>();
        }
    }
}