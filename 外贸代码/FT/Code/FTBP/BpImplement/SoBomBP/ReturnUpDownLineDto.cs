﻿


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	/// <summary>
	/// 上下一行返回DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ReturnUpDownLineDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ReturnUpDownLineDto(){
			initData();
		}
		private void initData()
		{
					RowNo = 0; 
		
		
		
		
					Qty = 0m; 
		
					Precision_Qty = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 RowNo
		{
			get	
			{	
				return (System.Int32)base.GetValue("RowNo",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("RowNo",value);
			}
		}
				/// <summary>
		/// 销售订单ID (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.销售订单ID
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SO</value>
		public UFIDA.U9.SM.SO.SO.EntityKey SoID
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SO.EntityKey)base.GetValue("SoID",typeof(UFIDA.U9.SM.SO.SO.EntityKey));
			}

			 set	
			{
				base.SetValue("SoID",value);
			}
		}
				/// <summary>
		/// 销售订单行ID (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.销售订单行ID
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SOLine</value>
		public UFIDA.U9.SM.SO.SOLine.EntityKey SoLineID
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SOLine.EntityKey)base.GetValue("SoLineID",typeof(UFIDA.U9.SM.SO.SOLine.EntityKey));
			}

			 set	
			{
				base.SetValue("SoLineID",value);
			}
		}
				/// <summary>
		/// 料号 (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemInfo_ItemID
		{
			get	
			{	
				return (System.String)base.GetValue("ItemInfo_ItemID",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemInfo_ItemID",value);
			}
		}
				/// <summary>
		/// 品名 (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.品名
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemInfo_ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("ItemInfo_ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemInfo_ItemName",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Qty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Qty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Qty",value);
			}
		}
				/// <summary>
		/// 单位 (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.单位
		/// </summary>
		/// <value>System.String</value>
		public System.String Uom
		{
			get	
			{	
				return (System.String)base.GetValue("Uom",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Uom",value);
			}
		}
				/// <summary>
		/// 精度 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Precision_Qty
		{
			get	
			{	
				return (System.Int32)base.GetValue("Precision_Qty",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Precision_Qty",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 

		#region ModelResource
		/// <summary>
		/// 上下一行返回DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RowNo　{ get { return "";　}　}
		/// <summary>
		/// 销售订单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoID　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineID　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemInfo_ItemID　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemInfo_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		/// <summary>
		/// 单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom　{ get { return "";　}　}
		/// <summary>
		/// 精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Precision_Qty　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ReturnUpDownLineDtoData data)
		{
		

			if (data.SoID == -1 && data.SoID_SKey!=null)
				data.SoID = data.SoID_SKey.GetEntity().ID ;

			if (data.SoLineID == -1 && data.SoLineID_SKey!=null)
				data.SoLineID = data.SoLineID_SKey.GetEntity().ID ;






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ReturnUpDownLineDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ReturnUpDownLineDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.RowNo = data.RowNo;

			{
				if (data.SoID <= 0)
					this.SoID = null ;
				else
					this.SoID = new UFIDA.U9.SM.SO.SO.EntityKey(data.SoID);
			}

			{
				if (data.SoLineID <= 0)
					this.SoLineID = null ;
				else
					this.SoLineID = new UFIDA.U9.SM.SO.SOLine.EntityKey(data.SoLineID);
			}

			this.ItemInfo_ItemID = data.ItemInfo_ItemID;

			this.ItemInfo_ItemName = data.ItemInfo_ItemName;

			this.Qty = data.Qty;

			this.Uom = data.Uom;

			this.Precision_Qty = data.Precision_Qty;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ReturnUpDownLineDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ReturnUpDownLineDtoData ToEntityData(ReturnUpDownLineDtoData data, IDictionary dict){
			if (data == null)
				data = new ReturnUpDownLineDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ReturnUpDownLineDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.RowNo = this.RowNo;

			if (this.SoID!=null)
			{
				data.SoID = this.SoID.ID;

			}

			if (this.SoLineID!=null)
			{
				data.SoLineID = this.SoLineID.ID;

			}

			data.ItemInfo_ItemID = this.ItemInfo_ItemID;

			data.ItemInfo_ItemName = this.ItemInfo_ItemName;

			data.Qty = this.Qty;

			data.Uom = this.Uom;

			data.Precision_Qty = this.Precision_Qty;

			return data ;
		}

		#endregion	
	}	
	
}