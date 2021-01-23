using System;

#nullable disable

namespace WebApiEFCoreRepository.Conditions
{
    public partial class AccountCondition
    {
        public int Idx { get; set; }
        /// <summary>
        /// 帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 電話號碼
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 信箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 新增日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 異動日期
        /// </summary>
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// 異動者
        /// </summary>
        public string ModifyUser { get; set; }
    }
}
