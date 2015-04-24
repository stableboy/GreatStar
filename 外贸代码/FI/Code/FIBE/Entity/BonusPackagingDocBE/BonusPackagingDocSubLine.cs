﻿using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE
{
	
	/// <summary>
	/// 实体: 包装业务员奖金明细行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class BonusPackagingDocSubLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public BonusPackagingDocSubLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static BonusPackagingDocSubLine Create(UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine parentEntity) {
			BonusPackagingDocSubLine entity = (BonusPackagingDocSubLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.BonusPackagingDocLine = parentEntity ;
			parentEntity.BonusPackagingDocSubLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected BonusPackagingDocSubLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return false ;}
		}
		#endregion

		#region Create Default 
	    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
        [Obsolete("仅用于开发的测试用例时期.正式版返回NULL.不可使用.")]
		public  static BonusPackagingDocSubLine CreateDefault(UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine parentEntity) {
		#if Test		
			return CreateDefault_Extend(parentEntity);
		#else 
		    return null;
		#endif
		}
	
		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocSubLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocSubLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class BonusPackagingDocSubLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocSubLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new BonusPackagingDocSubLine GetEntity()
			{
				return (BonusPackagingDocSubLine)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<BonusPackagingDocSubLine> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









						
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<BonusPackagingDocSubLine>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return false ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal: UFSoft.UBF.Business.Entity.EntityOriginal
		{
		    //private BonusPackagingDocSubLine ContainerEntity ;
		    public  new BonusPackagingDocSubLine ContainerEntity 
		    {
				get { return  (BonusPackagingDocSubLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(BonusPackagingDocSubLine container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// 包装业务员奖金明细行.Key.ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建时间 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Sys.创建时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CreatedOn
			{
				get
				{
					object obj = base.GetValue("CreatedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建人 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Sys.创建人
			/// </summary>
			/// <value></value>
			public  System.String CreatedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CreatedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改时间 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Sys.修改时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ModifiedOn
			{
				get
				{
					object obj = base.GetValue("ModifiedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改人 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Sys.修改人
			/// </summary>
			/// <value></value>
			public  System.String ModifiedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ModifiedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 事务版本 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Sys.事务版本
			/// </summary>
			/// <value></value>
			public  System.Int64 SysVersion
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Misc.行号
			/// </summary>
			/// <value></value>
			public  System.Int32 DocLineNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("DocLineNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.业务员
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Operators
			{
				get
				{
					if (OperatorsKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)OperatorsKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_OperatorsKey ;
		/// <summary>
		/// EntityKey 属性
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey OperatorsKey
		{
			get 
			{
				object obj = base.GetValue("Operators") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OperatorsKey==null || m_OperatorsKey.ID != key )
					m_OperatorsKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_OperatorsKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 部门 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.部门
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Department
			{
				get
				{
					if (DepartmentKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Department.Department value =  (UFIDA.U9.CBO.HR.Department.Department)DepartmentKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DepartmentKey ;
		/// <summary>
		/// EntityKey 属性
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DepartmentKey
		{
			get 
			{
				object obj = base.GetValue("Department") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DepartmentKey==null || m_DepartmentKey.ID != key )
					m_DepartmentKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DepartmentKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款单行数 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Misc.付款单行数
			/// </summary>
			/// <value></value>
			public  System.Int32 PaymentRowCount
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("PaymentRowCount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 类别系数 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.类别系数
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient CategoryCoefficient
			{
				get
				{
					if (CategoryCoefficientKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient value =  (UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient)CategoryCoefficientKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient.EntityKey m_CategoryCoefficientKey ;
		/// <summary>
		/// EntityKey 属性
		/// 类别系数 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.类别系数
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient.EntityKey CategoryCoefficientKey
		{
			get 
			{
				object obj = base.GetValue("CategoryCoefficient") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CategoryCoefficientKey==null || m_CategoryCoefficientKey.ID != key )
					m_CategoryCoefficientKey = new UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient.EntityKey(key); 
				return m_CategoryCoefficientKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户难易系数 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Misc.客户难易系数
			/// </summary>
			/// <value></value>
			public  System.Decimal CustomerCoefficient
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("CustomerCoefficient");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款单小类金额 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Misc.付款单小类金额
			/// </summary>
			/// <value></value>
			public  System.Decimal PaymentMey
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PaymentMey");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 小类奖金系数 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Misc.小类奖金系数
			/// </summary>
			/// <value></value>
			public  System.Decimal ItemCoefficient
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ItemCoefficient");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 奖金金额 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Misc.奖金金额
			/// </summary>
			/// <value></value>
			public  System.Decimal Bonus
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Bonus");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款通知单 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.付款通知单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PaymentBE.Payment PaymentDoc
			{
				get
				{
					if (PaymentDocKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.PaymentBE.Payment value =  (UFIDA.U9.Cust.GS.FI.PaymentBE.Payment)PaymentDocKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey m_PaymentDocKey ;
		/// <summary>
		/// EntityKey 属性
		/// 付款通知单 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.付款通知单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey PaymentDocKey
		{
			get 
			{
				object obj = base.GetValue("PaymentDoc") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PaymentDocKey==null || m_PaymentDocKey.ID != key )
					m_PaymentDocKey = new UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey(key); 
				return m_PaymentDocKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款单号 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.付款单号
			/// </summary>
			/// <value></value>
			public  System.String PaymentDocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("PaymentDocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 料品 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.料品
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Item
			{
				get
				{
					if (ItemKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ItemKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemKey ;
		/// <summary>
		/// EntityKey 属性
		/// 料品 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemKey
		{
			get 
			{
				object obj = base.GetValue("Item") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemKey==null || m_ItemKey.ID != key )
					m_ItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源付款行号 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Misc.来源付款行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SrcDocLineNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SrcDocLineNo");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFlexField ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.实体扩展字段
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal DescFlexField
			{
				get
				{
					if (m_DescFlexField == null )
						m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "DescFlexField");
					return m_DescFlexField;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 预期奖金 (该属性可为空,但有默认值)
			/// 包装业务员奖金明细行.Misc.预期奖金
			/// </summary>
			/// <value></value>
			public  System.Decimal ExpectMey
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ExpectMey");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源采购订单 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.来源采购订单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.PM.PO.PurchaseOrder SrcPO
			{
				get
				{
					if (SrcPOKey == null)
						return null ;
					UFIDA.U9.PM.PO.PurchaseOrder value =  (UFIDA.U9.PM.PO.PurchaseOrder)SrcPOKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.PM.PO.PurchaseOrder.EntityKey m_SrcPOKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源采购订单 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.来源采购订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.PM.PO.PurchaseOrder.EntityKey SrcPOKey
		{
			get 
			{
				object obj = base.GetValue("SrcPO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcPOKey==null || m_SrcPOKey.ID != key )
					m_SrcPOKey = new UFIDA.U9.PM.PO.PurchaseOrder.EntityKey(key); 
				return m_SrcPOKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源采购订单号 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.来源采购订单号
			/// </summary>
			/// <value></value>
			public  System.String SrcPODocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SrcPODocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 包装业务员奖金行 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.包装业务员奖金行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine BonusPackagingDocLine
			{
				get
				{
					if (BonusPackagingDocLineKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine value =  (UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine)BonusPackagingDocLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine.EntityKey m_BonusPackagingDocLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 包装业务员奖金行 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.包装业务员奖金行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine.EntityKey BonusPackagingDocLineKey
		{
			get 
			{
				object obj = base.GetValue("BonusPackagingDocLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BonusPackagingDocLineKey==null || m_BonusPackagingDocLineKey.ID != key )
					m_BonusPackagingDocLineKey = new UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine.EntityKey(key); 
				return m_BonusPackagingDocLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 包装业务员奖金明细行.Misc.备注
			/// </summary>
			/// <value></value>
			public  System.String SubLineDemo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SubLineDemo");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 包装业务员奖金明细行.Key.ID
		/// </summary>
		/// <value></value>
	 
		public new System.Int64 ID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ID");
				return value;
				}
				set
			{
				
								base.SetValue("ID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Sys.创建时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CreatedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CreatedOn");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Sys.创建人
		/// </summary>
		/// <value></value>
			public  System.String CreatedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CreatedBy");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Sys.修改时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ModifiedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ModifiedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Sys.修改人
		/// </summary>
		/// <value></value>
			public  System.String ModifiedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ModifiedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Sys.事务版本
		/// </summary>
		/// <value></value>
			public  System.Int64 SysVersion
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
				return value;
				}
				set
			{
				
								base.SetValue("SysVersion", value);
						 
			}
		}
	



		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Misc.行号
		/// </summary>
		/// <value></value>
			public  System.Int32 DocLineNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("DocLineNo");
				return value;
				}
				set
			{
				
								base.SetValue("DocLineNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.业务员
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Operators
		{
			get
			{
				object  obj = this.GetRelation("Operators");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.HR.Operator.Operators value  = (UFIDA.U9.CBO.HR.Operator.Operators)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Operators", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_OperatorsKey ;
		/// <summary>
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey OperatorsKey
		{
			get 
			{
				object obj = base.GetValue("Operators") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OperatorsKey==null || m_OperatorsKey.ID != key )
					m_OperatorsKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_OperatorsKey ;
			}
			set
			{	
				if (OperatorsKey==value)
					return ;
				this.SetRelation("Operators", null);
				m_OperatorsKey = value ;
				if (value != null) 
				{
					base.SetValue("Operators",value.ID);
				}
				else
					base.SetValue("Operators",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 部门 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.部门
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Department
		{
			get
			{
				object  obj = this.GetRelation("Department");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.HR.Department.Department value  = (UFIDA.U9.CBO.HR.Department.Department)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Department", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DepartmentKey ;
		/// <summary>
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DepartmentKey
		{
			get 
			{
				object obj = base.GetValue("Department") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DepartmentKey==null || m_DepartmentKey.ID != key )
					m_DepartmentKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DepartmentKey ;
			}
			set
			{	
				if (DepartmentKey==value)
					return ;
				this.SetRelation("Department", null);
				m_DepartmentKey = value ;
				if (value != null) 
				{
					base.SetValue("Department",value.ID);
				}
				else
					base.SetValue("Department",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 付款单行数 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Misc.付款单行数
		/// </summary>
		/// <value></value>
			public  System.Int32 PaymentRowCount
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("PaymentRowCount");
				return value;
				}
				set
			{
				
								base.SetValue("PaymentRowCount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 类别系数 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.类别系数
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient CategoryCoefficient
		{
			get
			{
				object  obj = this.GetRelation("CategoryCoefficient");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient value  = (UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CategoryCoefficient", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient.EntityKey m_CategoryCoefficientKey ;
		/// <summary>
		/// 类别系数 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.类别系数
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient.EntityKey CategoryCoefficientKey
		{
			get 
			{
				object obj = base.GetValue("CategoryCoefficient") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CategoryCoefficientKey==null || m_CategoryCoefficientKey.ID != key )
					m_CategoryCoefficientKey = new UFIDA.U9.Cust.GS.FI.ProductCoefficientBE.ProductCoefficient.EntityKey(key); 
				return m_CategoryCoefficientKey ;
			}
			set
			{	
				if (CategoryCoefficientKey==value)
					return ;
				this.SetRelation("CategoryCoefficient", null);
				m_CategoryCoefficientKey = value ;
				if (value != null) 
				{
					base.SetValue("CategoryCoefficient",value.ID);
				}
				else
					base.SetValue("CategoryCoefficient",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 客户难易系数 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Misc.客户难易系数
		/// </summary>
		/// <value></value>
			public  System.Decimal CustomerCoefficient
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("CustomerCoefficient");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerCoefficient", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款单小类金额 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Misc.付款单小类金额
		/// </summary>
		/// <value></value>
			public  System.Decimal PaymentMey
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PaymentMey");
				return value;
				}
				set
			{
				
								base.SetValue("PaymentMey", value);
						 
			}
		}
	



		
			/// <summary>
		/// 小类奖金系数 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Misc.小类奖金系数
		/// </summary>
		/// <value></value>
			public  System.Decimal ItemCoefficient
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ItemCoefficient");
				return value;
				}
				set
			{
				
								base.SetValue("ItemCoefficient", value);
						 
			}
		}
	



		
			/// <summary>
		/// 奖金金额 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Misc.奖金金额
		/// </summary>
		/// <value></value>
			public  System.Decimal Bonus
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Bonus");
				return value;
				}
				set
			{
				
								base.SetValue("Bonus", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款通知单 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.付款通知单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PaymentBE.Payment PaymentDoc
		{
			get
			{
				object  obj = this.GetRelation("PaymentDoc");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FI.PaymentBE.Payment value  = (UFIDA.U9.Cust.GS.FI.PaymentBE.Payment)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("PaymentDoc", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey m_PaymentDocKey ;
		/// <summary>
		/// 付款通知单 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.付款通知单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey PaymentDocKey
		{
			get 
			{
				object obj = base.GetValue("PaymentDoc") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PaymentDocKey==null || m_PaymentDocKey.ID != key )
					m_PaymentDocKey = new UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey(key); 
				return m_PaymentDocKey ;
			}
			set
			{	
				if (PaymentDocKey==value)
					return ;
				this.SetRelation("PaymentDoc", null);
				m_PaymentDocKey = value ;
				if (value != null) 
				{
					base.SetValue("PaymentDoc",value.ID);
				}
				else
					base.SetValue("PaymentDoc",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 付款单号 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.付款单号
		/// </summary>
		/// <value></value>
			public  System.String PaymentDocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("PaymentDocNo");
				return value;
				}
				set
			{
				
								base.SetValue("PaymentDocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.料品
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Item
		{
			get
			{
				object  obj = this.GetRelation("Item");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Item.ItemMaster value  = (UFIDA.U9.CBO.SCM.Item.ItemMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Item", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemKey ;
		/// <summary>
		/// 料品 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemKey
		{
			get 
			{
				object obj = base.GetValue("Item") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemKey==null || m_ItemKey.ID != key )
					m_ItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemKey ;
			}
			set
			{	
				if (ItemKey==value)
					return ;
				this.SetRelation("Item", null);
				m_ItemKey = value ;
				if (value != null) 
				{
					base.SetValue("Item",value.ID);
				}
				else
					base.SetValue("Item",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 来源付款行号 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Misc.来源付款行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SrcDocLineNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SrcDocLineNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcDocLineNo", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFlexField ;
			/// <summary>
		/// 实体扩展字段 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.实体扩展字段
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments DescFlexField
		{
			get
			{
				if (m_DescFlexField == null )
					m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "DescFlexField");
				return m_DescFlexField;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_DescFlexField == null)
					this.m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"DescFlexField");
								this.m_DescFlexField.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_DescFlexField.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_DescFlexField.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_DescFlexField.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_DescFlexField.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_DescFlexField.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_DescFlexField.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_DescFlexField.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_DescFlexField.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_DescFlexField.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_DescFlexField.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_DescFlexField.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_DescFlexField.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_DescFlexField.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_DescFlexField.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_DescFlexField.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_DescFlexField.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_DescFlexField.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_DescFlexField.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_DescFlexField.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_DescFlexField.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_DescFlexField.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_DescFlexField.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_DescFlexField.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_DescFlexField.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_DescFlexField.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_DescFlexField.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_DescFlexField.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_DescFlexField.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_DescFlexField.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_DescFlexField.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_DescFlexField.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_DescFlexField.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_DescFlexField.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_DescFlexField.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_DescFlexField.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_DescFlexField.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_DescFlexField.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_DescFlexField.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_DescFlexField.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_DescFlexField.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_DescFlexField.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_DescFlexField.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_DescFlexField.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_DescFlexField.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_DescFlexField.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_DescFlexField.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_DescFlexField.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_DescFlexField.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_DescFlexField.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_DescFlexField.ContextValue = value.ContextValue ;
												this.m_DescFlexField.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_DescFlexField.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_DescFlexField.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_DescFlexField.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_DescFlexField.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_DescFlexField.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_DescFlexField.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_DescFlexField.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_DescFlexField.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_DescFlexField.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_DescFlexField.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_DescFlexField.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_DescFlexField.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_DescFlexField.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_DescFlexField.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_DescFlexField.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_DescFlexField.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_DescFlexField.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_DescFlexField.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_DescFlexField.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_DescFlexField.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_DescFlexField.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_DescFlexField.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_DescFlexField.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_DescFlexField.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_DescFlexField.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_DescFlexField.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_DescFlexField.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_DescFlexField.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_DescFlexField.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_DescFlexField.CombineName = value.CombineName ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 预期奖金 (该属性可为空,但有默认值)
		/// 包装业务员奖金明细行.Misc.预期奖金
		/// </summary>
		/// <value></value>
			public  System.Decimal ExpectMey
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ExpectMey");
				return value;
				}
				set
			{
				
								base.SetValue("ExpectMey", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源采购订单 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.来源采购订单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.PM.PO.PurchaseOrder SrcPO
		{
			get
			{
				object  obj = this.GetRelation("SrcPO");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.PM.PO.PurchaseOrder value  = (UFIDA.U9.PM.PO.PurchaseOrder)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SrcPO", value);
					 
			}
		}
	


   		private UFIDA.U9.PM.PO.PurchaseOrder.EntityKey m_SrcPOKey ;
		/// <summary>
		/// 来源采购订单 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.来源采购订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.PM.PO.PurchaseOrder.EntityKey SrcPOKey
		{
			get 
			{
				object obj = base.GetValue("SrcPO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcPOKey==null || m_SrcPOKey.ID != key )
					m_SrcPOKey = new UFIDA.U9.PM.PO.PurchaseOrder.EntityKey(key); 
				return m_SrcPOKey ;
			}
			set
			{	
				if (SrcPOKey==value)
					return ;
				this.SetRelation("SrcPO", null);
				m_SrcPOKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcPO",value.ID);
				}
				else
					base.SetValue("SrcPO",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 来源采购订单号 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.来源采购订单号
		/// </summary>
		/// <value></value>
			public  System.String SrcPODocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SrcPODocNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcPODocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 包装业务员奖金行 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.包装业务员奖金行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine BonusPackagingDocLine
		{
			get
			{
				object  obj = this.GetRelation("BonusPackagingDocLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine value  = (UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("BonusPackagingDocLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine.EntityKey m_BonusPackagingDocLineKey ;
		/// <summary>
		/// 包装业务员奖金行 的Key (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.包装业务员奖金行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine.EntityKey BonusPackagingDocLineKey
		{
			get 
			{
				object obj = base.GetValue("BonusPackagingDocLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BonusPackagingDocLineKey==null || m_BonusPackagingDocLineKey.ID != key )
					m_BonusPackagingDocLineKey = new UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine.EntityKey(key); 
				return m_BonusPackagingDocLineKey ;
			}
			set
			{	
				if (BonusPackagingDocLineKey==value)
					return ;
				this.SetRelation("BonusPackagingDocLine", null);
				m_BonusPackagingDocLineKey = value ;
				if (value != null) 
				{
					base.SetValue("BonusPackagingDocLine",value.ID);
				}
				else
					base.SetValue("BonusPackagingDocLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 包装业务员奖金明细行.Misc.备注
		/// </summary>
		/// <value></value>
			public  System.String SubLineDemo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SubLineDemo");
				return value;
				}
				set
			{
				
								base.SetValue("SubLineDemo", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocSubLine")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ID　{ get { return EntityRes.GetResource("ID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedOn　{ get { return EntityRes.GetResource("CreatedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedBy　{ get { return EntityRes.GetResource("CreatedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedOn　{ get { return EntityRes.GetResource("ModifiedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedBy　{ get { return EntityRes.GetResource("ModifiedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SysVersion")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SysVersion　{ get { return EntityRes.GetResource("SysVersion");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocLineNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocLineNo　{ get { return EntityRes.GetResource("DocLineNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Operators")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Operators　{ get { return EntityRes.GetResource("Operators");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Department")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Department　{ get { return EntityRes.GetResource("Department");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentRowCount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentRowCount　{ get { return EntityRes.GetResource("PaymentRowCount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CategoryCoefficient")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CategoryCoefficient　{ get { return EntityRes.GetResource("CategoryCoefficient");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerCoefficient")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerCoefficient　{ get { return EntityRes.GetResource("CustomerCoefficient");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentMey")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentMey　{ get { return EntityRes.GetResource("PaymentMey");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ItemCoefficient")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ItemCoefficient　{ get { return EntityRes.GetResource("ItemCoefficient");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Bonus")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Bonus　{ get { return EntityRes.GetResource("Bonus");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentDoc")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentDoc　{ get { return EntityRes.GetResource("PaymentDoc");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentDocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentDocNo　{ get { return EntityRes.GetResource("PaymentDocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Item")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Item　{ get { return EntityRes.GetResource("Item");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocLineNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocLineNo　{ get { return EntityRes.GetResource("SrcDocLineNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFlexField")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFlexField　{ get { return EntityRes.GetResource("DescFlexField");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExpectMey")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExpectMey　{ get { return EntityRes.GetResource("ExpectMey");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPO")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPO　{ get { return EntityRes.GetResource("SrcPO");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPODocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPODocNo　{ get { return EntityRes.GetResource("SrcPODocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BonusPackagingDocLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BonusPackagingDocLine　{ get { return EntityRes.GetResource("BonusPackagingDocLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SubLineDemo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SubLineDemo　{ get { return EntityRes.GetResource("SubLineDemo");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "BonusPackagingDocSubLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocSubLine";　}　}
		
			/// <summary>
			/// 属性: ID 的名称
			/// </summary>
			public static string ID　{ get { return "ID";　}　}
				
			/// <summary>
			/// 属性: 创建时间 的名称
			/// </summary>
			public static string CreatedOn　{ get { return "CreatedOn";　}　}
				
			/// <summary>
			/// 属性: 创建人 的名称
			/// </summary>
			public static string CreatedBy　{ get { return "CreatedBy";　}　}
				
			/// <summary>
			/// 属性: 修改时间 的名称
			/// </summary>
			public static string ModifiedOn　{ get { return "ModifiedOn";　}　}
				
			/// <summary>
			/// 属性: 修改人 的名称
			/// </summary>
			public static string ModifiedBy　{ get { return "ModifiedBy";　}　}
				
			/// <summary>
			/// 属性: 事务版本 的名称
			/// </summary>
			public static string SysVersion　{ get { return "SysVersion";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string DocLineNo　{ get { return "DocLineNo";　}　}
				
			/// <summary>
			/// 属性: 业务员 的名称
			/// </summary>
			public static string Operators　{ get { return "Operators";　}　}
				
			/// <summary>
			/// 属性: 部门 的名称
			/// </summary>
			public static string Department　{ get { return "Department";　}　}
				
			/// <summary>
			/// 属性: 付款单行数 的名称
			/// </summary>
			public static string PaymentRowCount　{ get { return "PaymentRowCount";　}　}
				
			/// <summary>
			/// 属性: 类别系数 的名称
			/// </summary>
			public static string CategoryCoefficient　{ get { return "CategoryCoefficient";　}　}
				
			/// <summary>
			/// 属性: 客户难易系数 的名称
			/// </summary>
			public static string CustomerCoefficient　{ get { return "CustomerCoefficient";　}　}
				
			/// <summary>
			/// 属性: 付款单小类金额 的名称
			/// </summary>
			public static string PaymentMey　{ get { return "PaymentMey";　}　}
				
			/// <summary>
			/// 属性: 小类奖金系数 的名称
			/// </summary>
			public static string ItemCoefficient　{ get { return "ItemCoefficient";　}　}
				
			/// <summary>
			/// 属性: 奖金金额 的名称
			/// </summary>
			public static string Bonus　{ get { return "Bonus";　}　}
				
			/// <summary>
			/// 属性: 付款通知单 的名称
			/// </summary>
			public static string PaymentDoc　{ get { return "PaymentDoc";　}　}
				
			/// <summary>
			/// 属性: 付款单号 的名称
			/// </summary>
			public static string PaymentDocNo　{ get { return "PaymentDocNo";　}　}
				
			/// <summary>
			/// 属性: 料品 的名称
			/// </summary>
			public static string Item　{ get { return "Item";　}　}
				
			/// <summary>
			/// 属性: 来源付款行号 的名称
			/// </summary>
			public static string SrcDocLineNo　{ get { return "SrcDocLineNo";　}　}
				
			/// <summary>
			/// 属性类型属性: DescFlexField 的名称
			/// </summary>
			public static string DescFlexField { get { return "DescFlexField";　}　}
			/// <summary>
			/// 属性类型属性: DescFlexField 的类型全名
			/// </summary>
			public static string DescFlexField_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg1的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg1 { get { return "DescFlexField.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg2的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg2 { get { return "DescFlexField.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg3的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg3 { get { return "DescFlexField.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg4的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg4 { get { return "DescFlexField.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg5的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg5 { get { return "DescFlexField.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg6的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg6 { get { return "DescFlexField.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg7的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg7 { get { return "DescFlexField.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg8的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg8 { get { return "DescFlexField.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg9的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg9 { get { return "DescFlexField.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg10的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg10 { get { return "DescFlexField.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg11的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg11 { get { return "DescFlexField.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg12的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg12 { get { return "DescFlexField.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg13的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg13 { get { return "DescFlexField.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg14的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg14 { get { return "DescFlexField.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg15的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg15 { get { return "DescFlexField.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg16的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg16 { get { return "DescFlexField.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg17的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg17 { get { return "DescFlexField.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg18的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg18 { get { return "DescFlexField.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg19的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg19 { get { return "DescFlexField.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg20的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg20 { get { return "DescFlexField.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg21的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg21 { get { return "DescFlexField.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg22的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg22 { get { return "DescFlexField.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg23的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg23 { get { return "DescFlexField.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg24的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg24 { get { return "DescFlexField.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg25的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg25 { get { return "DescFlexField.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg26的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg26 { get { return "DescFlexField.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg27的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg27 { get { return "DescFlexField.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg28的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg28 { get { return "DescFlexField.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg29的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg29 { get { return "DescFlexField.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg30的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg30 { get { return "DescFlexField.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg31的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg31 { get { return "DescFlexField.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg32的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg32 { get { return "DescFlexField.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg33的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg33 { get { return "DescFlexField.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg34的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg34 { get { return "DescFlexField.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg35的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg35 { get { return "DescFlexField.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg36的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg36 { get { return "DescFlexField.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg37的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg37 { get { return "DescFlexField.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg38的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg38 { get { return "DescFlexField.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg39的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg39 { get { return "DescFlexField.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg40的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg40 { get { return "DescFlexField.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg41的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg41 { get { return "DescFlexField.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg42的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg42 { get { return "DescFlexField.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg43的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg43 { get { return "DescFlexField.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg44的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg44 { get { return "DescFlexField.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg45的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg45 { get { return "DescFlexField.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg46的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg46 { get { return "DescFlexField.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg47的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg47 { get { return "DescFlexField.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg48的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg48 { get { return "DescFlexField.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg49的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg49 { get { return "DescFlexField.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg50的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg50 { get { return "DescFlexField.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.ContextValue的名称
			/// </summary>
			public static string DescFlexField_ContextValue { get { return "DescFlexField.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg1的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg1 { get { return "DescFlexField.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg2的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg2 { get { return "DescFlexField.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg3的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg3 { get { return "DescFlexField.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg4的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg4 { get { return "DescFlexField.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg5的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg5 { get { return "DescFlexField.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg6的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg6 { get { return "DescFlexField.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg7的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg7 { get { return "DescFlexField.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg8的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg8 { get { return "DescFlexField.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg9的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg9 { get { return "DescFlexField.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg10的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg10 { get { return "DescFlexField.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg11的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg11 { get { return "DescFlexField.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg12的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg12 { get { return "DescFlexField.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg13的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg13 { get { return "DescFlexField.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg14的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg14 { get { return "DescFlexField.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg15的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg15 { get { return "DescFlexField.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg16的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg16 { get { return "DescFlexField.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg17的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg17 { get { return "DescFlexField.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg18的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg18 { get { return "DescFlexField.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg19的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg19 { get { return "DescFlexField.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg20的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg20 { get { return "DescFlexField.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg21的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg21 { get { return "DescFlexField.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg22的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg22 { get { return "DescFlexField.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg23的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg23 { get { return "DescFlexField.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg24的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg24 { get { return "DescFlexField.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg25的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg25 { get { return "DescFlexField.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg26的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg26 { get { return "DescFlexField.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg27的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg27 { get { return "DescFlexField.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg28的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg28 { get { return "DescFlexField.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg29的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg29 { get { return "DescFlexField.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg30的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg30 { get { return "DescFlexField.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.CombineName的名称
			/// </summary>
			public static string DescFlexField_CombineName { get { return "DescFlexField.CombineName";　}　}
				
			/// <summary>
			/// 属性: 预期奖金 的名称
			/// </summary>
			public static string ExpectMey　{ get { return "ExpectMey";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单 的名称
			/// </summary>
			public static string SrcPO　{ get { return "SrcPO";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单号 的名称
			/// </summary>
			public static string SrcPODocNo　{ get { return "SrcPODocNo";　}　}
				
			/// <summary>
			/// 属性: 包装业务员奖金行 的名称
			/// </summary>
			public static string BonusPackagingDocLine　{ get { return "BonusPackagingDocLine";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string SubLineDemo　{ get { return "SubLineDemo";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																								
				if (attrName.StartsWith("DescFlexField."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(DescFlexField_TypeFullName, attrName);
												
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }  
        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("DocLineNo","DocLineNo");
			this.exdMultiLangAttrs.Add("Operators","Operators");
			this.exdMultiLangAttrs.Add("Department","Department");
			this.exdMultiLangAttrs.Add("PaymentRowCount","PaymentRowCount");
			this.exdMultiLangAttrs.Add("CategoryCoefficient","CategoryCoefficient");
			this.exdMultiLangAttrs.Add("CustomerCoefficient","CustomerCoefficient");
			this.exdMultiLangAttrs.Add("PaymentMey","PaymentMey");
			this.exdMultiLangAttrs.Add("ItemCoefficient","ItemCoefficient");
			this.exdMultiLangAttrs.Add("Bonus","Bonus");
			this.exdMultiLangAttrs.Add("PaymentDoc","PaymentDoc");
			this.exdMultiLangAttrs.Add("PaymentDocNo","PaymentDocNo");
			this.exdMultiLangAttrs.Add("Item","Item");
			this.exdMultiLangAttrs.Add("SrcDocLineNo","SrcDocLineNo");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg1","DescFlexField_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg2","DescFlexField_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg3","DescFlexField_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg4","DescFlexField_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg5","DescFlexField_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg6","DescFlexField_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg7","DescFlexField_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg8","DescFlexField_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg9","DescFlexField_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg10","DescFlexField_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg11","DescFlexField_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg12","DescFlexField_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg13","DescFlexField_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg14","DescFlexField_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg15","DescFlexField_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg16","DescFlexField_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg17","DescFlexField_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg18","DescFlexField_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg19","DescFlexField_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg20","DescFlexField_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg21","DescFlexField_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg22","DescFlexField_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg23","DescFlexField_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg24","DescFlexField_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg25","DescFlexField_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg26","DescFlexField_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg27","DescFlexField_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg28","DescFlexField_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg29","DescFlexField_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg30","DescFlexField_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg31","DescFlexField_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg32","DescFlexField_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg33","DescFlexField_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg34","DescFlexField_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg35","DescFlexField_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg36","DescFlexField_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg37","DescFlexField_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg38","DescFlexField_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg39","DescFlexField_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg40","DescFlexField_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg41","DescFlexField_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg42","DescFlexField_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg43","DescFlexField_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg44","DescFlexField_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg45","DescFlexField_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg46","DescFlexField_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg47","DescFlexField_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg48","DescFlexField_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg49","DescFlexField_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg50","DescFlexField_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFlexField.ContextValue","DescFlexField_ContextValue");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg1","DescFlexField_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg2","DescFlexField_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg3","DescFlexField_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg4","DescFlexField_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg5","DescFlexField_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg6","DescFlexField_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg7","DescFlexField_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg8","DescFlexField_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg9","DescFlexField_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg10","DescFlexField_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg11","DescFlexField_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg12","DescFlexField_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg13","DescFlexField_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg14","DescFlexField_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg15","DescFlexField_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg16","DescFlexField_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg17","DescFlexField_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg18","DescFlexField_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg19","DescFlexField_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg20","DescFlexField_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg21","DescFlexField_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg22","DescFlexField_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg23","DescFlexField_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg24","DescFlexField_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg25","DescFlexField_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg26","DescFlexField_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg27","DescFlexField_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg28","DescFlexField_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg29","DescFlexField_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg30","DescFlexField_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFlexField.CombineName","DescFlexField_CombineName");
			this.exdMultiLangAttrs.Add("ExpectMey","ExpectMey");
			this.exdMultiLangAttrs.Add("SrcPO","SrcPO");
			this.exdMultiLangAttrs.Add("SrcPODocNo","SrcPODocNo");
			this.exdMultiLangAttrs.Add("BonusPackagingDocLine","BonusPackagingDocLine");
			this.exdMultiLangAttrs.Add("SubLineDemo","SubLineDemo");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																																																																	
																																																																																																																																																																																																																																																						

															

				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(BonusPackagingDocSubLineData data)
		{
		
			

			

			

			

			

			

			

			if (data.Operators == -1 && data.Operators_SKey!=null)
				data.Operators = data.Operators_SKey.GetEntity().ID ;
	

			if (data.Department == -1 && data.Department_SKey!=null)
				data.Department = data.Department_SKey.GetEntity().ID ;
	

			

			if (data.CategoryCoefficient == -1 && data.CategoryCoefficient_SKey!=null)
				data.CategoryCoefficient = data.CategoryCoefficient_SKey.GetEntity().ID ;
	

			

			

			

			

			if (data.PaymentDoc == -1 && data.PaymentDoc_SKey!=null)
				data.PaymentDoc = data.PaymentDoc_SKey.GetEntity().ID ;
	

			

			if (data.Item == -1 && data.Item_SKey!=null)
				data.Item = data.Item_SKey.GetEntity().ID ;
	

			

			

			

			if (data.SrcPO == -1 && data.SrcPO_SKey!=null)
				data.SrcPO = data.SrcPO_SKey.GetEntity().ID ;
	

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			BonusPackagingDocSubLineData data = dto as BonusPackagingDocSubLineData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BonusPackagingDocSubLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BonusPackagingDocSubLineData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
				
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
								this.SetTypeValue("DocLineNo",data.DocLineNo);
		
								this.SetTypeValue("Operators",data.Operators);
		
								this.SetTypeValue("Department",data.Department);
		
								this.SetTypeValue("PaymentRowCount",data.PaymentRowCount);
		
								this.SetTypeValue("CategoryCoefficient",data.CategoryCoefficient);
		
								this.SetTypeValue("CustomerCoefficient",data.CustomerCoefficient);
		
								this.SetTypeValue("PaymentMey",data.PaymentMey);
		
								this.SetTypeValue("ItemCoefficient",data.ItemCoefficient);
		
								this.SetTypeValue("Bonus",data.Bonus);
		
								this.SetTypeValue("PaymentDoc",data.PaymentDoc);
		
								this.SetTypeValue("PaymentDocNo",data.PaymentDocNo);
		
								this.SetTypeValue("Item",data.Item);
		
								this.SetTypeValue("SrcDocLineNo",data.SrcDocLineNo);
		
								this.DescFlexField.FromEntityData(data.DescFlexField);
		
								this.SetTypeValue("ExpectMey",data.ExpectMey);
		
								this.SetTypeValue("SrcPO",data.SrcPO);
		
								this.SetTypeValue("SrcPODocNo",data.SrcPODocNo);
		
								this.SetTypeValue("SubLineDemo",data.SubLineDemo);
		
			#endregion 

			#region 组件内属性
	
					if (data.BonusPackagingDocLine!=null)
			{
				UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine child = dict[data.BonusPackagingDocLine] as UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine ;
				if (child == null)
				{
					if (data.BonusPackagingDocLine.ID>0)
					{
						if (data.BonusPackagingDocLine.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.BonusPackagingDocLine.ID,data.BonusPackagingDocLine.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BonusPackagingDocLine.SysEntityType,null,data.BonusPackagingDocLine.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BonusPackagingDocLine.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.BonusPackagingDocLine,dict);
				}
				this.BonusPackagingDocLine = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BonusPackagingDocSubLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BonusPackagingDocSubLineData ToEntityData(BonusPackagingDocSubLineData data, IDictionary dict){
			if (data == null)
				data = new BonusPackagingDocSubLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocSubLine"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ID");
				if (obj != null)
					data.ID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedOn");
				if (obj != null)
					data.CreatedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedBy");
				if (obj != null)
					data.CreatedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedOn");
				if (obj != null)
					data.ModifiedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedBy");
				if (obj != null)
					data.ModifiedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SysVersion");
				if (obj != null)
					data.SysVersion=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DocLineNo");
				if (obj != null)
					data.DocLineNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Operators");
				if (obj != null)
					data.Operators=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Department");
				if (obj != null)
					data.Department=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PaymentRowCount");
				if (obj != null)
					data.PaymentRowCount=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CategoryCoefficient");
				if (obj != null)
					data.CategoryCoefficient=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerCoefficient");
				if (obj != null)
					data.CustomerCoefficient=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PaymentMey");
				if (obj != null)
					data.PaymentMey=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ItemCoefficient");
				if (obj != null)
					data.ItemCoefficient=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Bonus");
				if (obj != null)
					data.Bonus=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PaymentDoc");
				if (obj != null)
					data.PaymentDoc=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PaymentDocNo");
				if (obj != null)
					data.PaymentDocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Item");
				if (obj != null)
					data.Item=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcDocLineNo");
				if (obj != null)
					data.SrcDocLineNo=(System.Int32)obj;
			}
	     
	    
			if (this.DescFlexField != null)
			{
				data.DescFlexField=this.DescFlexField.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("ExpectMey");
				if (obj != null)
					data.ExpectMey=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPO");
				if (obj != null)
					data.SrcPO=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPODocNo");
				if (obj != null)
					data.SrcPODocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SubLineDemo");
				if (obj != null)
					data.SubLineDemo=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("BonusPackagingDocLine");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLineData _BonusPackagingDocLine = dict["UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLine"+oID.ToString()] as UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE.BonusPackagingDocLineData;			
					data.BonusPackagingDocLine = (_BonusPackagingDocLine != null) ? _BonusPackagingDocLine : (this.BonusPackagingDocLine==null?null:this.BonusPackagingDocLine.ToEntityData(null,dict));
				}
			}
	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
		//L类档案的组织相关检查.
		UFIDA.U9.Base.Util.LTypeOrgAttributeValidator.Validate(this);
        



















			
			//调用UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments属性类型的内置校验方法.
			this.DescFlexField.OnValidate() ;
	





			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}