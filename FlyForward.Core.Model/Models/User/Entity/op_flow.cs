
using FlyForward.Core.Model.BaseModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FlyForward.Core.Model.Models
{
	 ///<summary>
	 ///op_flow
	 ///</summary>
	 [Table("op_flow")]	
	 public class op_flow:IParam
	 {
	 

		 /// <summary>
        /// flow_no
        /// </summary>
		[Key]
		[Required]
		public string flow_no { get; set; }
	

		 /// <summary>
        /// user_id
        /// </summary>
		[Key]
		[Required]
		public int user_id { get; set; }
	

		 /// <summary>
        /// oper_type
        /// </summary>
		[Required]
		public string oper_type { get; set; }
	

		 /// <summary>
        /// oper_date
        /// </summary>
		[Required]
		public DateTime oper_date { get; set; }
	

		 /// <summary>
        /// oper_amt
        /// </summary>
		[Required]
		public decimal oper_amt { get; set; }
	

		 /// <summary>
        /// oper_txt
        /// </summary>
		public string oper_txt { get; set; }
	

		 /// <summary>
        /// pay_way
        /// </summary>
		[Required]
		public string pay_way { get; set; }
	

		 /// <summary>
        /// sheet_no
        /// </summary>
		public string sheet_no { get; set; }
	

		 /// <summary>
        /// refsheet_no
        /// </summary>
		public string refsheet_no { get; set; }
	 
	 }
}	 
