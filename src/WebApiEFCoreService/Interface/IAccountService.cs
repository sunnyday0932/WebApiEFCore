﻿using System.Collections.Generic;
using WebApiEFCoreService.Dtos;
using WebApiEFCoreService.InfoModels;

namespace WebApiEFCoreService.Interface
{
    public interface IAccountService
    {
        /// <summary>
        /// 取得單筆帳號資訊
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public AccountDto GetAccount(string account);

        /// <summary>
        /// 取得帳號列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountDto> GetAccountList();

        /// <summary>
        /// 新增帳號
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public ResultDto AddAccount(AccountInfoModel info);

        /// <summary>
        /// 刪除帳號
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public ResultDto RemoveAccount(AccountInfoModel info);

        /// <summary>
        /// 更新帳號資訊
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public ResultDto UpdateAccount(AccountInfoModel info);

        /// <summary>
        /// 忘記密碼
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public ResultDto ForgetPassword(AccountInfoModel info);
    }
}