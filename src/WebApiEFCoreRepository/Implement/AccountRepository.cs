using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiEFCoreRepository.Conditions;
using WebApiEFCoreRepository.DataModels;
using WebApiEFCoreRepository.DBContext;
using WebApiEFCoreRepository.Interface;

namespace WebApiEFCoreRepository.Implement
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountContext _accountContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountContext"></param>
        public AccountRepository(AccountContext accountContext)
        {
            this._accountContext = accountContext;
        }

        /// <summary>
        /// 新增帳號
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public bool AddAccount(AccountCondition condition)
        {
            this._accountContext.Add(condition);
            var result = this._accountContext.SaveChanges();

            return result > 0;
        }

        /// <summary>
        /// 忘記密碼
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public bool ForgetPassword(AccountCondition condition)
        {
            var data = this._accountContext.Account.Find(condition.Account);
            this._accountContext.Entry(data).CurrentValues.SetValues(condition);
            var result = this._accountContext.SaveChanges();

            return result > 0;
        }

        /// <summary>
        /// 取得單筆帳號
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public AccountDataModel GetAccount(string account)
        {
            var result = this._accountContext.Account.Find(account);

            return result;
        }

        /// <summary>
        /// 取得帳號列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AccountDataModel> GetAccountList()
        {
            var result = this._accountContext.Account.ToList();

            return result;
        }

        /// <summary>
        /// 刪除帳號
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool RemoveAccount(string account)
        {
            var data = this._accountContext.Account.Find(account);
            this._accountContext.Remove(data);
            var result = this._accountContext.SaveChanges();

            return result > 0;
        }

        /// <summary>
        /// 更新帳號
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public bool UpdateAccount(AccountCondition condition)
        {
            this._accountContext.Update(condition);
            var result = this._accountContext.SaveChanges();

            return result > 0;
        }
    }
}
