﻿using SqlSugar;

namespace XinjingdailyBot.Models
{
    /// <summary>
    /// 用户权限组信息
    /// </summary>
    [SugarTable("group", TableDescription = "用户组")]
    internal sealed class Groups
    {
        [SugarColumn(IsPrimaryKey = true)]
        public int Id { get; set; }
        /// <summary>
        /// 权限名
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// 默认权限
        /// </summary>
        public UserRights DefaultRight { get; set; } = UserRights.None;
    }
}
