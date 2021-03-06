﻿ 
// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2016-10-29T13:43:21. All Rights Reserved.
//<生成时间>2016-10-29T13:43:21</生成时间>
using AutoMapper;
using EasyFast.Core.Entities.Dtos;

namespace EasyFast.Core.Entities.Mappers
{
	/// <summary>
    /// UserTypeDto映射配置
    /// </summary>
    public class UserTypeMapper : IMapper
    {
        /// <summary>
        /// 初始化映射
        /// </summary>
        public void CreateMappings()
        {
            Mapper.CreateMap<UserType,UserTypeEditDto>();
            Mapper.CreateMap<UserType, UserTypeListDto>();

            Mapper.CreateMap<UserTypeEditDto, UserType>();
            Mapper.CreateMap<UserTypeListDto,UserType>();
        }
    }
}