﻿namespace XinjingdailyBot.Enums
{
    /// <summary>
    /// 用户权限
    /// </summary>
    [Flags]
    internal enum UserRights : byte
    {
        /// <summary>
        /// 无权限
        /// </summary>
        None = 0x00,

        /// <summary>
        /// 投稿
        /// </summary>
        SendPost = 0x01,
        /// <summary>
        /// 审核
        /// </summary>
        ReviewPost = 0x02,
        /// <summary>
        /// 直接投稿
        /// </summary>
        DirectPost = 0x04,

        /// <summary>
        /// 普通命令
        /// </summary>
        NormalCmd = 0x10,
        /// <summary>
        /// 管理命令
        /// </summary>
        AdminCmd = 0x20,
        /// <summary>
        /// 超管命令
        /// </summary>
        SuperCmd = 0x40,

        /// <summary>
        /// 全部权限
        /// </summary>
        ALL = 0xFF,
    }
}
