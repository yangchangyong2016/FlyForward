
using FlyForward.Core.Model.BaseModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyForward.Core.Model.Models
{
	 ///<summary>
	 ///bi_user
	 ///</summary>
	 [Table("bi_user")]	
	 public class bi_user:IParam
	 {
	 
		 /// <summary>
        /// user_id
        /// </summary>
		[Key]
		[Required]
		public int user_id { get; set; }
	

		 /// <summary>
        /// user_pwd
        /// </summary>
		[Required]
		public string user_pwd { get; set; }
	

		 /// <summary>
        /// user_no
        /// </summary>
		[Required]
		public string user_no { get; set; }
	

		 /// <summary>
        /// user_name
        /// </summary>
		[Required]
		public string user_name { get; set; }
	

		 /// <summary>
        /// user_tel
        /// </summary>
		public string user_tel { get; set; }
	

		 /// <summary>
        /// user_mobile
        /// </summary>
		[Required]
		public string user_mobile { get; set; }
	

		 /// <summary>
        /// user_wechat
        /// </summary>
		public string user_wechat { get; set; }
	

		 /// <summary>
        /// user_cardid
        /// </summary>
		public string user_cardid { get; set; }
	

		 /// <summary>
        /// user_sex
        /// </summary>
		public string user_sex { get; set; }
	

		 /// <summary>
        /// user_weight
        /// </summary>
		[Required]
		public decimal user_weight { get; set; }
	

		 /// <summary>
        /// user_height
        /// </summary>
		[Required]
		public decimal user_height { get; set; }
	

		 /// <summary>
        /// user_age
        /// </summary>
		[Required]
		public int user_age { get; set; }
	

		 /// <summary>
        /// birth_date
        /// </summary>
		[Required]
		public DateTime birth_date { get; set; }
	

		 /// <summary>
        /// user_remarks
        /// </summary>
		public string user_remarks { get; set; }
	

		 /// <summary>
        /// user_status
        /// </summary>
		[Required]
		public string user_status { get; set; }
	

		 /// <summary>
        /// user_type
        /// </summary>
		[Required]
		public string user_type { get; set; }
	

		 /// <summary>
        /// activity_level
        /// </summary>
		[Required]
		public string activity_level { get; set; }
	

		 /// <summary>
        /// stored_amt
        /// </summary>
		[Required]
		public decimal stored_amt { get; set; }
	 
	 }
}	 
