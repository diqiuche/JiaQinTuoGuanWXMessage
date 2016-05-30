using System;
using System.Collections.Generic;
using System.Text;

namespace JiaQin.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class VipUser
    {

		/// <summary>
		/// 
		/// </summary>
		public int Id{set;get;}

		/// <summary>
		/// 
		/// </summary>
		public string Code{set;get;}

		/// <summary>
		/// 
		/// </summary>
		public string UserName{set;get;}

		/// <summary>
		/// 
		/// </summary>
		public string PassWord{set;get;}

		/// <summary>
		/// 
		/// </summary>
		public string Name{set;get;}

		/// <summary>
		/// 
		/// </summary>
		public string Gender{set;get;}
        public int Age { get {
            if (BirthDate==null)
            {
                return 0;
            }
            DateTime now = DateTime.Now;
            DateTime birthDate = BirthDate.Value;
            int age = now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day)) age--;
            return age;

        } }
        public DateTime? BirthDate { set; get; }
		/// <summary>
		/// 
		/// </summary>
		public string Phone{set;get;}

        private string photo;
		/// <summary>
		/// 
		/// </summary>
        public string Photo { set { this.photo = value; } get {
            if (string.IsNullOrEmpty(photo))
            {
                return Headimgurl;
            }
            return this.photo;
        } }
        /// <summary>
        /// �û��ڵ�ǰ���ںŵ�Ψһ��ʶ
        /// </summary>
        public string OpenId { set; get; }

        /// <summary>
        /// �û���΢��ȫƽ̨Ψһ��ʶ
        /// </summary>
        public string Unionid { set; get; }

        /// <summary>
        /// �û���΢��ͷ���ַ�����ص�ַ��
        /// </summary>
        public string Headimgurl { set; get; }

        /// <summary>
        /// �û���΢���ǳ�
        /// </summary>
        public string Nickname { set; get; }

		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate{set;get;}
        /// <summary>
        /// �ϴθ���ʱ��
        /// </summary>
        public DateTime? BindDate { set; get; }
        /// <summary>
        /// �ϴθ���ʱ��Agent
        /// </summary>
        public string BindAgent { set; get; }


    }
}