using System;
using System.Collections.Generic;
using System.Text;
namespace JiaQin.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class Teacher
    {

        public int Id { set; get; }
		/// <summary>
		/// 
		/// </summary>
		public int UserId{set;get;}
		/// <summary>
		/// 
		/// </summary>
		public int SchoolId{set;get;}
		/// <summary>
		/// 
		/// </summary>
		public DateTime AddDate{set;get;}
        public DateTime? DeleteDate { set; get; }
            public virtual SysUser SysUserInfo{set;get;}
            public virtual School SchoolInfo{set;get;}
        /// <summary>
        /// ��ʦ����ı�ǩ
        /// </summary>
            public virtual Tag[] TagList { set; get; }
    }
}