﻿using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.InstalledArkBE
{
	
	/// <summary>
	/// 实体: 预装柜单明细行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class InstalledArkDetailLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public InstalledArkDetailLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static InstalledArkDetailLine Create(UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine parentEntity) {
			InstalledArkDetailLine entity = (InstalledArkDetailLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.InstalledArkLine = parentEntity ;
			parentEntity.InstalledArkDetailLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected InstalledArkDetailLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static InstalledArkDetailLine CreateDefault(UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkDetailLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkDetailLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class InstalledArkDetailLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkDetailLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new InstalledArkDetailLine GetEntity()
			{
				return (InstalledArkDetailLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<InstalledArkDetailLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<InstalledArkDetailLine>{
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
		    //private InstalledArkDetailLine ContainerEntity ;
		    public  new InstalledArkDetailLine ContainerEntity 
		    {
				get { return  (InstalledArkDetailLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(InstalledArkDetailLine container)
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
			/// 预装柜单明细行.Key.ID
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
			/// 预装柜单明细行.Sys.创建时间
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
			/// 预装柜单明细行.Sys.创建人
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
			/// 预装柜单明细行.Sys.修改时间
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
			/// 预装柜单明细行.Sys.修改人
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
			/// 预装柜单明细行.Sys.事务版本
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
			/// 预装柜单行 (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.预装柜单行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine InstalledArkLine
			{
				get
				{
					if (InstalledArkLineKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine value =  (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine)InstalledArkLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityKey m_InstalledArkLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 预装柜单行 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.预装柜单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityKey InstalledArkLineKey
		{
			get 
			{
				object obj = base.GetValue("InstalledArkLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InstalledArkLineKey==null || m_InstalledArkLineKey.ID != key )
					m_InstalledArkLineKey = new UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityKey(key); 
				return m_InstalledArkLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.行号
			/// </summary>
			/// <value></value>
			public  System.Int32 RowNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("RowNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源销售订单号 (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.来源销售订单号
			/// </summary>
			/// <value></value>
			public  System.String SrcSONo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SrcSONo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源销售订单ID (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.来源销售订单ID
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SO SrcSO
			{
				get
				{
					if (SrcSOKey == null)
						return null ;
					UFIDA.U9.SM.SO.SO value =  (UFIDA.U9.SM.SO.SO)SrcSOKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SrcSOKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源销售订单ID 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.来源销售订单ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SrcSOKey
		{
			get 
			{
				object obj = base.GetValue("SrcSO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcSOKey==null || m_SrcSOKey.ID != key )
					m_SrcSOKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SrcSOKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源销售订单行号 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.来源销售订单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SrcSOLineNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SrcSOLineNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源销售订单行ID (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.来源销售订单行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcSOLine
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcSOLine");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源行号 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.来源行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SrcShipLineNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SrcShipLineNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据行ID (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.来源单据行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcShipLine
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcShipLine");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据号 (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.来源单据号
			/// </summary>
			/// <value></value>
			public  System.String SrcShipNO
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SrcShipNO");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据ID (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.来源单据ID
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead SrcShip
			{
				get
				{
					if (SrcShipKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead value =  (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)SrcShipKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey m_SrcShipKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源单据ID 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.来源单据ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey SrcShipKey
		{
			get 
			{
				object obj = base.GetValue("SrcShip") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcShipKey==null || m_SrcShipKey.ID != key )
					m_SrcShipKey = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey(key); 
				return m_SrcShipKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 产品 (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.产品
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster ItemMaster
			{
				get
				{
					if (ItemMasterKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ItemMasterKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemMasterKey ;
		/// <summary>
		/// EntityKey 属性
		/// 产品 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.产品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMasterKey
		{
			get 
			{
				object obj = base.GetValue("ItemMaster") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemMasterKey==null || m_ItemMasterKey.ID != key )
					m_ItemMasterKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemMasterKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 规格 (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.规格
			/// </summary>
			/// <value></value>
			public  System.String Standard
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Standard");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.数量
			/// </summary>
			/// <value></value>
			public  System.Decimal Qty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Qty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计量单位 (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.计量单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM Uom
			{
				get
				{
					if (UomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)UomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_UomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey UomKey
		{
			get 
			{
				object obj = base.GetValue("Uom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UomKey==null || m_UomKey.ID != key )
					m_UomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_UomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 本次装柜数量 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.本次装柜数量
			/// </summary>
			/// <value></value>
			public  System.Decimal InstalledArkNumber
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("InstalledArkNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 外箱数 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.外箱数
			/// </summary>
			/// <value></value>
			public  System.Decimal OutBoxNumner
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("OutBoxNumner");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 内箱数 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.内箱数
			/// </summary>
			/// <value></value>
			public  System.Decimal InBoxNumber
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("InBoxNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.体积
			/// </summary>
			/// <value></value>
			public  System.Decimal Bulks
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Bulks");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 长 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.长
			/// </summary>
			/// <value></value>
			public  System.Decimal Length
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Length");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 宽 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.宽
			/// </summary>
			/// <value></value>
			public  System.Decimal Width
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Width");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 高 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.高
			/// </summary>
			/// <value></value>
			public  System.Decimal Higth
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Higth");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 毛重 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.毛重
			/// </summary>
			/// <value></value>
			public  System.Decimal GrossWeight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("GrossWeight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 净重 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.净重
			/// </summary>
			/// <value></value>
			public  System.Decimal NetWeight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NetWeight");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_Descflexfield ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段集合 (该属性可为空,且无默认值)
			/// 预装柜单明细行.Misc.实体扩展字段集合
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal Descflexfield
			{
				get
				{
					if (m_Descflexfield == null )
						m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "Descflexfield");
					return m_Descflexfield;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 柜数 (该属性可为空,但有默认值)
			/// 预装柜单明细行.Misc.柜数
			/// </summary>
			/// <value></value>
			public  System.Decimal BoxNumber
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BoxNumber");
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
		/// 预装柜单明细行.Key.ID
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
		/// 预装柜单明细行.Sys.创建时间
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
		/// 预装柜单明细行.Sys.创建人
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
		/// 预装柜单明细行.Sys.修改时间
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
		/// 预装柜单明细行.Sys.修改人
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
		/// 预装柜单明细行.Sys.事务版本
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
		/// 预装柜单行 (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.预装柜单行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine InstalledArkLine
		{
			get
			{
				object  obj = this.GetRelation("InstalledArkLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine value  = (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("InstalledArkLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityKey m_InstalledArkLineKey ;
		/// <summary>
		/// 预装柜单行 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.预装柜单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityKey InstalledArkLineKey
		{
			get 
			{
				object obj = base.GetValue("InstalledArkLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InstalledArkLineKey==null || m_InstalledArkLineKey.ID != key )
					m_InstalledArkLineKey = new UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityKey(key); 
				return m_InstalledArkLineKey ;
			}
			set
			{	
				if (InstalledArkLineKey==value)
					return ;
				this.SetRelation("InstalledArkLine", null);
				m_InstalledArkLineKey = value ;
				if (value != null) 
				{
					base.SetValue("InstalledArkLine",value.ID);
				}
				else
					base.SetValue("InstalledArkLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.行号
		/// </summary>
		/// <value></value>
			public  System.Int32 RowNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("RowNo");
				return value;
				}
				set
			{
				
								base.SetValue("RowNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源销售订单号 (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.来源销售订单号
		/// </summary>
		/// <value></value>
			public  System.String SrcSONo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SrcSONo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcSONo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源销售订单ID (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.来源销售订单ID
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SO SrcSO
		{
			get
			{
				object  obj = this.GetRelation("SrcSO");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.SM.SO.SO value  = (UFIDA.U9.SM.SO.SO)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SrcSO", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SrcSOKey ;
		/// <summary>
		/// 来源销售订单ID 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.来源销售订单ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SrcSOKey
		{
			get 
			{
				object obj = base.GetValue("SrcSO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcSOKey==null || m_SrcSOKey.ID != key )
					m_SrcSOKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SrcSOKey ;
			}
			set
			{	
				if (SrcSOKey==value)
					return ;
				this.SetRelation("SrcSO", null);
				m_SrcSOKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcSO",value.ID);
				}
				else
					base.SetValue("SrcSO",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 来源销售订单行号 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.来源销售订单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SrcSOLineNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SrcSOLineNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcSOLineNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源销售订单行ID (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.来源销售订单行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcSOLine
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcSOLine");
				return value;
				}
				set
			{
				
								base.SetValue("SrcSOLine", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源行号 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.来源行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SrcShipLineNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SrcShipLineNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcShipLineNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据行ID (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.来源单据行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcShipLine
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcShipLine");
				return value;
				}
				set
			{
				
								base.SetValue("SrcShipLine", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据号 (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.来源单据号
		/// </summary>
		/// <value></value>
			public  System.String SrcShipNO
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SrcShipNO");
				return value;
				}
				set
			{
				
								base.SetValue("SrcShipNO", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据ID (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.来源单据ID
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead SrcShip
		{
			get
			{
				object  obj = this.GetRelation("SrcShip");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead value  = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SrcShip", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey m_SrcShipKey ;
		/// <summary>
		/// 来源单据ID 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.来源单据ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey SrcShipKey
		{
			get 
			{
				object obj = base.GetValue("SrcShip") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcShipKey==null || m_SrcShipKey.ID != key )
					m_SrcShipKey = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey(key); 
				return m_SrcShipKey ;
			}
			set
			{	
				if (SrcShipKey==value)
					return ;
				this.SetRelation("SrcShip", null);
				m_SrcShipKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcShip",value.ID);
				}
				else
					base.SetValue("SrcShip",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 产品 (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.产品
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster ItemMaster
		{
			get
			{
				object  obj = this.GetRelation("ItemMaster");
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
				
				this.SetRelation("ItemMaster", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemMasterKey ;
		/// <summary>
		/// 产品 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.产品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMasterKey
		{
			get 
			{
				object obj = base.GetValue("ItemMaster") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemMasterKey==null || m_ItemMasterKey.ID != key )
					m_ItemMasterKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemMasterKey ;
			}
			set
			{	
				if (ItemMasterKey==value)
					return ;
				this.SetRelation("ItemMaster", null);
				m_ItemMasterKey = value ;
				if (value != null) 
				{
					base.SetValue("ItemMaster",value.ID);
				}
				else
					base.SetValue("ItemMaster",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 规格 (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.规格
		/// </summary>
		/// <value></value>
			public  System.String Standard
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Standard");
				return value;
				}
				set
			{
				
								base.SetValue("Standard", value);
						 
			}
		}
	



		
			/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.数量
		/// </summary>
		/// <value></value>
			public  System.Decimal Qty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Qty");
				return value;
				}
				set
			{
				
								base.SetValue("Qty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 计量单位 (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.计量单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM Uom
		{
			get
			{
				object  obj = this.GetRelation("Uom");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.UOM.UOM value  = (UFIDA.U9.Base.UOM.UOM)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Uom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_UomKey ;
		/// <summary>
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey UomKey
		{
			get 
			{
				object obj = base.GetValue("Uom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UomKey==null || m_UomKey.ID != key )
					m_UomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_UomKey ;
			}
			set
			{	
				if (UomKey==value)
					return ;
				this.SetRelation("Uom", null);
				m_UomKey = value ;
				if (value != null) 
				{
					base.SetValue("Uom",value.ID);
				}
				else
					base.SetValue("Uom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 本次装柜数量 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.本次装柜数量
		/// </summary>
		/// <value></value>
			public  System.Decimal InstalledArkNumber
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("InstalledArkNumber");
				return value;
				}
				set
			{
				
								base.SetValue("InstalledArkNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 外箱数 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.外箱数
		/// </summary>
		/// <value></value>
			public  System.Decimal OutBoxNumner
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("OutBoxNumner");
				return value;
				}
				set
			{
				
								base.SetValue("OutBoxNumner", value);
						 
			}
		}
	



		
			/// <summary>
		/// 内箱数 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.内箱数
		/// </summary>
		/// <value></value>
			public  System.Decimal InBoxNumber
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("InBoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("InBoxNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 体积 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.体积
		/// </summary>
		/// <value></value>
			public  System.Decimal Bulks
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Bulks");
				return value;
				}
				set
			{
				
								base.SetValue("Bulks", value);
						 
			}
		}
	



		
			/// <summary>
		/// 长 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.长
		/// </summary>
		/// <value></value>
			public  System.Decimal Length
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Length");
				return value;
				}
				set
			{
				
								base.SetValue("Length", value);
						 
			}
		}
	



		
			/// <summary>
		/// 宽 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.宽
		/// </summary>
		/// <value></value>
			public  System.Decimal Width
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Width");
				return value;
				}
				set
			{
				
								base.SetValue("Width", value);
						 
			}
		}
	



		
			/// <summary>
		/// 高 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.高
		/// </summary>
		/// <value></value>
			public  System.Decimal Higth
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Higth");
				return value;
				}
				set
			{
				
								base.SetValue("Higth", value);
						 
			}
		}
	



		
			/// <summary>
		/// 毛重 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.毛重
		/// </summary>
		/// <value></value>
			public  System.Decimal GrossWeight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("GrossWeight");
				return value;
				}
				set
			{
				
								base.SetValue("GrossWeight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 净重 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.净重
		/// </summary>
		/// <value></value>
			public  System.Decimal NetWeight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NetWeight");
				return value;
				}
				set
			{
				
								base.SetValue("NetWeight", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_Descflexfield ;
			/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 预装柜单明细行.Misc.实体扩展字段集合
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments Descflexfield
		{
			get
			{
				if (m_Descflexfield == null )
					m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "Descflexfield");
				return m_Descflexfield;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_Descflexfield == null)
					this.m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"Descflexfield");
								this.m_Descflexfield.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_Descflexfield.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_Descflexfield.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_Descflexfield.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_Descflexfield.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_Descflexfield.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_Descflexfield.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_Descflexfield.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_Descflexfield.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_Descflexfield.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_Descflexfield.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_Descflexfield.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_Descflexfield.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_Descflexfield.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_Descflexfield.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_Descflexfield.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_Descflexfield.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_Descflexfield.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_Descflexfield.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_Descflexfield.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_Descflexfield.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_Descflexfield.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_Descflexfield.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_Descflexfield.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_Descflexfield.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_Descflexfield.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_Descflexfield.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_Descflexfield.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_Descflexfield.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_Descflexfield.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_Descflexfield.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_Descflexfield.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_Descflexfield.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_Descflexfield.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_Descflexfield.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_Descflexfield.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_Descflexfield.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_Descflexfield.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_Descflexfield.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_Descflexfield.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_Descflexfield.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_Descflexfield.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_Descflexfield.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_Descflexfield.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_Descflexfield.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_Descflexfield.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_Descflexfield.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_Descflexfield.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_Descflexfield.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_Descflexfield.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_Descflexfield.ContextValue = value.ContextValue ;
												this.m_Descflexfield.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_Descflexfield.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_Descflexfield.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_Descflexfield.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_Descflexfield.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_Descflexfield.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_Descflexfield.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_Descflexfield.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_Descflexfield.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_Descflexfield.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_Descflexfield.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_Descflexfield.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_Descflexfield.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_Descflexfield.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_Descflexfield.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_Descflexfield.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_Descflexfield.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_Descflexfield.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_Descflexfield.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_Descflexfield.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_Descflexfield.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_Descflexfield.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_Descflexfield.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_Descflexfield.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_Descflexfield.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_Descflexfield.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_Descflexfield.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_Descflexfield.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_Descflexfield.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_Descflexfield.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_Descflexfield.CombineName = value.CombineName ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 柜数 (该属性可为空,但有默认值)
		/// 预装柜单明细行.Misc.柜数
		/// </summary>
		/// <value></value>
			public  System.Decimal BoxNumber
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("BoxNumber", value);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkDetailLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InstalledArkLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InstalledArkLine　{ get { return EntityRes.GetResource("InstalledArkLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RowNo　{ get { return EntityRes.GetResource("RowNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcSONo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcSONo　{ get { return EntityRes.GetResource("SrcSONo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcSO")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcSO　{ get { return EntityRes.GetResource("SrcSO");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcSOLineNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcSOLineNo　{ get { return EntityRes.GetResource("SrcSOLineNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcSOLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcSOLine　{ get { return EntityRes.GetResource("SrcSOLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcShipLineNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcShipLineNo　{ get { return EntityRes.GetResource("SrcShipLineNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcShipLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcShipLine　{ get { return EntityRes.GetResource("SrcShipLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcShipNO")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcShipNO　{ get { return EntityRes.GetResource("SrcShipNO");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcShip")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcShip　{ get { return EntityRes.GetResource("SrcShip");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ItemMaster")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ItemMaster　{ get { return EntityRes.GetResource("ItemMaster");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Standard")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Standard　{ get { return EntityRes.GetResource("Standard");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Qty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Qty　{ get { return EntityRes.GetResource("Qty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Uom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Uom　{ get { return EntityRes.GetResource("Uom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InstalledArkNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InstalledArkNumber　{ get { return EntityRes.GetResource("InstalledArkNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OutBoxNumner")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OutBoxNumner　{ get { return EntityRes.GetResource("OutBoxNumner");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InBoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InBoxNumber　{ get { return EntityRes.GetResource("InBoxNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Bulks")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Bulks　{ get { return EntityRes.GetResource("Bulks");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Length")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Length　{ get { return EntityRes.GetResource("Length");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Width")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Width　{ get { return EntityRes.GetResource("Width");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Higth")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Higth　{ get { return EntityRes.GetResource("Higth");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("GrossWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_GrossWeight　{ get { return EntityRes.GetResource("GrossWeight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NetWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NetWeight　{ get { return EntityRes.GetResource("NetWeight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Descflexfield")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Descflexfield　{ get { return EntityRes.GetResource("Descflexfield");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BoxNumber　{ get { return EntityRes.GetResource("BoxNumber");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "InstalledArkDetailLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkDetailLine";　}　}
		
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
			/// 属性: 预装柜单行 的名称
			/// </summary>
			public static string InstalledArkLine　{ get { return "InstalledArkLine";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string RowNo　{ get { return "RowNo";　}　}
				
			/// <summary>
			/// 属性: 来源销售订单号 的名称
			/// </summary>
			public static string SrcSONo　{ get { return "SrcSONo";　}　}
				
			/// <summary>
			/// 属性: 来源销售订单ID 的名称
			/// </summary>
			public static string SrcSO　{ get { return "SrcSO";　}　}
				
			/// <summary>
			/// 属性: 来源销售订单行号 的名称
			/// </summary>
			public static string SrcSOLineNo　{ get { return "SrcSOLineNo";　}　}
				
			/// <summary>
			/// 属性: 来源销售订单行ID 的名称
			/// </summary>
			public static string SrcSOLine　{ get { return "SrcSOLine";　}　}
				
			/// <summary>
			/// 属性: 来源行号 的名称
			/// </summary>
			public static string SrcShipLineNo　{ get { return "SrcShipLineNo";　}　}
				
			/// <summary>
			/// 属性: 来源单据行ID 的名称
			/// </summary>
			public static string SrcShipLine　{ get { return "SrcShipLine";　}　}
				
			/// <summary>
			/// 属性: 来源单据号 的名称
			/// </summary>
			public static string SrcShipNO　{ get { return "SrcShipNO";　}　}
				
			/// <summary>
			/// 属性: 来源单据ID 的名称
			/// </summary>
			public static string SrcShip　{ get { return "SrcShip";　}　}
				
			/// <summary>
			/// 属性: 产品 的名称
			/// </summary>
			public static string ItemMaster　{ get { return "ItemMaster";　}　}
				
			/// <summary>
			/// 属性: 规格 的名称
			/// </summary>
			public static string Standard　{ get { return "Standard";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string Qty　{ get { return "Qty";　}　}
				
			/// <summary>
			/// 属性: 计量单位 的名称
			/// </summary>
			public static string Uom　{ get { return "Uom";　}　}
				
			/// <summary>
			/// 属性: 本次装柜数量 的名称
			/// </summary>
			public static string InstalledArkNumber　{ get { return "InstalledArkNumber";　}　}
				
			/// <summary>
			/// 属性: 外箱数 的名称
			/// </summary>
			public static string OutBoxNumner　{ get { return "OutBoxNumner";　}　}
				
			/// <summary>
			/// 属性: 内箱数 的名称
			/// </summary>
			public static string InBoxNumber　{ get { return "InBoxNumber";　}　}
				
			/// <summary>
			/// 属性: 体积 的名称
			/// </summary>
			public static string Bulks　{ get { return "Bulks";　}　}
				
			/// <summary>
			/// 属性: 长 的名称
			/// </summary>
			public static string Length　{ get { return "Length";　}　}
				
			/// <summary>
			/// 属性: 宽 的名称
			/// </summary>
			public static string Width　{ get { return "Width";　}　}
				
			/// <summary>
			/// 属性: 高 的名称
			/// </summary>
			public static string Higth　{ get { return "Higth";　}　}
				
			/// <summary>
			/// 属性: 毛重 的名称
			/// </summary>
			public static string GrossWeight　{ get { return "GrossWeight";　}　}
				
			/// <summary>
			/// 属性: 净重 的名称
			/// </summary>
			public static string NetWeight　{ get { return "NetWeight";　}　}
				
			/// <summary>
			/// 属性类型属性: Descflexfield 的名称
			/// </summary>
			public static string Descflexfield { get { return "Descflexfield";　}　}
			/// <summary>
			/// 属性类型属性: Descflexfield 的类型全名
			/// </summary>
			public static string Descflexfield_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg1的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg1 { get { return "Descflexfield.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg2的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg2 { get { return "Descflexfield.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg3的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg3 { get { return "Descflexfield.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg4的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg4 { get { return "Descflexfield.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg5的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg5 { get { return "Descflexfield.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg6的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg6 { get { return "Descflexfield.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg7的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg7 { get { return "Descflexfield.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg8的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg8 { get { return "Descflexfield.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg9的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg9 { get { return "Descflexfield.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg10的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg10 { get { return "Descflexfield.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg11的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg11 { get { return "Descflexfield.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg12的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg12 { get { return "Descflexfield.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg13的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg13 { get { return "Descflexfield.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg14的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg14 { get { return "Descflexfield.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg15的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg15 { get { return "Descflexfield.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg16的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg16 { get { return "Descflexfield.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg17的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg17 { get { return "Descflexfield.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg18的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg18 { get { return "Descflexfield.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg19的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg19 { get { return "Descflexfield.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg20的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg20 { get { return "Descflexfield.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg21的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg21 { get { return "Descflexfield.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg22的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg22 { get { return "Descflexfield.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg23的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg23 { get { return "Descflexfield.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg24的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg24 { get { return "Descflexfield.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg25的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg25 { get { return "Descflexfield.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg26的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg26 { get { return "Descflexfield.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg27的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg27 { get { return "Descflexfield.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg28的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg28 { get { return "Descflexfield.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg29的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg29 { get { return "Descflexfield.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg30的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg30 { get { return "Descflexfield.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg31的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg31 { get { return "Descflexfield.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg32的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg32 { get { return "Descflexfield.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg33的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg33 { get { return "Descflexfield.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg34的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg34 { get { return "Descflexfield.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg35的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg35 { get { return "Descflexfield.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg36的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg36 { get { return "Descflexfield.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg37的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg37 { get { return "Descflexfield.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg38的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg38 { get { return "Descflexfield.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg39的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg39 { get { return "Descflexfield.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg40的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg40 { get { return "Descflexfield.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg41的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg41 { get { return "Descflexfield.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg42的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg42 { get { return "Descflexfield.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg43的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg43 { get { return "Descflexfield.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg44的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg44 { get { return "Descflexfield.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg45的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg45 { get { return "Descflexfield.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg46的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg46 { get { return "Descflexfield.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg47的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg47 { get { return "Descflexfield.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg48的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg48 { get { return "Descflexfield.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg49的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg49 { get { return "Descflexfield.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg50的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg50 { get { return "Descflexfield.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.ContextValue的名称
			/// </summary>
			public static string Descflexfield_ContextValue { get { return "Descflexfield.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg1的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg1 { get { return "Descflexfield.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg2的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg2 { get { return "Descflexfield.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg3的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg3 { get { return "Descflexfield.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg4的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg4 { get { return "Descflexfield.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg5的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg5 { get { return "Descflexfield.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg6的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg6 { get { return "Descflexfield.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg7的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg7 { get { return "Descflexfield.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg8的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg8 { get { return "Descflexfield.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg9的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg9 { get { return "Descflexfield.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg10的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg10 { get { return "Descflexfield.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg11的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg11 { get { return "Descflexfield.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg12的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg12 { get { return "Descflexfield.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg13的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg13 { get { return "Descflexfield.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg14的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg14 { get { return "Descflexfield.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg15的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg15 { get { return "Descflexfield.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg16的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg16 { get { return "Descflexfield.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg17的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg17 { get { return "Descflexfield.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg18的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg18 { get { return "Descflexfield.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg19的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg19 { get { return "Descflexfield.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg20的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg20 { get { return "Descflexfield.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg21的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg21 { get { return "Descflexfield.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg22的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg22 { get { return "Descflexfield.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg23的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg23 { get { return "Descflexfield.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg24的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg24 { get { return "Descflexfield.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg25的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg25 { get { return "Descflexfield.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg26的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg26 { get { return "Descflexfield.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg27的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg27 { get { return "Descflexfield.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg28的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg28 { get { return "Descflexfield.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg29的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg29 { get { return "Descflexfield.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg30的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg30 { get { return "Descflexfield.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.CombineName的名称
			/// </summary>
			public static string Descflexfield_CombineName { get { return "Descflexfield.CombineName";　}　}
				
			/// <summary>
			/// 属性: 柜数 的名称
			/// </summary>
			public static string BoxNumber　{ get { return "BoxNumber";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																																												
				if (attrName.StartsWith("Descflexfield."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(Descflexfield_TypeFullName, attrName);
				
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
			this.exdMultiLangAttrs.Add("InstalledArkLine","InstalledArkLine");
			this.exdMultiLangAttrs.Add("RowNo","RowNo");
			this.exdMultiLangAttrs.Add("SrcSONo","SrcSONo");
			this.exdMultiLangAttrs.Add("SrcSO","SrcSO");
			this.exdMultiLangAttrs.Add("SrcSOLineNo","SrcSOLineNo");
			this.exdMultiLangAttrs.Add("SrcSOLine","SrcSOLine");
			this.exdMultiLangAttrs.Add("SrcShipLineNo","SrcShipLineNo");
			this.exdMultiLangAttrs.Add("SrcShipLine","SrcShipLine");
			this.exdMultiLangAttrs.Add("SrcShipNO","SrcShipNO");
			this.exdMultiLangAttrs.Add("SrcShip","SrcShip");
			this.exdMultiLangAttrs.Add("ItemMaster","ItemMaster");
			this.exdMultiLangAttrs.Add("Standard","Standard");
			this.exdMultiLangAttrs.Add("Qty","Qty");
			this.exdMultiLangAttrs.Add("Uom","Uom");
			this.exdMultiLangAttrs.Add("InstalledArkNumber","InstalledArkNumber");
			this.exdMultiLangAttrs.Add("OutBoxNumner","OutBoxNumner");
			this.exdMultiLangAttrs.Add("InBoxNumber","InBoxNumber");
			this.exdMultiLangAttrs.Add("Bulks","Bulks");
			this.exdMultiLangAttrs.Add("Length","Length");
			this.exdMultiLangAttrs.Add("Width","Width");
			this.exdMultiLangAttrs.Add("Higth","Higth");
			this.exdMultiLangAttrs.Add("GrossWeight","GrossWeight");
			this.exdMultiLangAttrs.Add("NetWeight","NetWeight");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg1","Descflexfield_PubDescSeg1");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg2","Descflexfield_PubDescSeg2");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg3","Descflexfield_PubDescSeg3");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg4","Descflexfield_PubDescSeg4");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg5","Descflexfield_PubDescSeg5");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg6","Descflexfield_PubDescSeg6");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg7","Descflexfield_PubDescSeg7");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg8","Descflexfield_PubDescSeg8");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg9","Descflexfield_PubDescSeg9");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg10","Descflexfield_PubDescSeg10");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg11","Descflexfield_PubDescSeg11");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg12","Descflexfield_PubDescSeg12");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg13","Descflexfield_PubDescSeg13");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg14","Descflexfield_PubDescSeg14");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg15","Descflexfield_PubDescSeg15");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg16","Descflexfield_PubDescSeg16");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg17","Descflexfield_PubDescSeg17");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg18","Descflexfield_PubDescSeg18");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg19","Descflexfield_PubDescSeg19");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg20","Descflexfield_PubDescSeg20");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg21","Descflexfield_PubDescSeg21");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg22","Descflexfield_PubDescSeg22");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg23","Descflexfield_PubDescSeg23");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg24","Descflexfield_PubDescSeg24");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg25","Descflexfield_PubDescSeg25");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg26","Descflexfield_PubDescSeg26");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg27","Descflexfield_PubDescSeg27");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg28","Descflexfield_PubDescSeg28");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg29","Descflexfield_PubDescSeg29");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg30","Descflexfield_PubDescSeg30");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg31","Descflexfield_PubDescSeg31");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg32","Descflexfield_PubDescSeg32");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg33","Descflexfield_PubDescSeg33");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg34","Descflexfield_PubDescSeg34");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg35","Descflexfield_PubDescSeg35");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg36","Descflexfield_PubDescSeg36");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg37","Descflexfield_PubDescSeg37");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg38","Descflexfield_PubDescSeg38");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg39","Descflexfield_PubDescSeg39");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg40","Descflexfield_PubDescSeg40");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg41","Descflexfield_PubDescSeg41");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg42","Descflexfield_PubDescSeg42");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg43","Descflexfield_PubDescSeg43");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg44","Descflexfield_PubDescSeg44");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg45","Descflexfield_PubDescSeg45");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg46","Descflexfield_PubDescSeg46");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg47","Descflexfield_PubDescSeg47");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg48","Descflexfield_PubDescSeg48");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg49","Descflexfield_PubDescSeg49");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg50","Descflexfield_PubDescSeg50");
			this.exdMultiLangAttrs.Add("Descflexfield.ContextValue","Descflexfield_ContextValue");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg1","Descflexfield_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg2","Descflexfield_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg3","Descflexfield_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg4","Descflexfield_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg5","Descflexfield_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg6","Descflexfield_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg7","Descflexfield_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg8","Descflexfield_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg9","Descflexfield_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg10","Descflexfield_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg11","Descflexfield_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg12","Descflexfield_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg13","Descflexfield_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg14","Descflexfield_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg15","Descflexfield_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg16","Descflexfield_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg17","Descflexfield_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg18","Descflexfield_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg19","Descflexfield_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg20","Descflexfield_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg21","Descflexfield_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg22","Descflexfield_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg23","Descflexfield_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg24","Descflexfield_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg25","Descflexfield_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg26","Descflexfield_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg27","Descflexfield_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg28","Descflexfield_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg29","Descflexfield_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg30","Descflexfield_PrivateDescSeg30");
			this.multiLangAttrs.Add("Descflexfield.CombineName","Descflexfield_CombineName");
			this.exdMultiLangAttrs.Add("BoxNumber","BoxNumber");
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
		private void DeSerializeKey(InstalledArkDetailLineData data)
		{
		
			

			

			

			

			

			

			

			

			if (data.SrcSO == -1 && data.SrcSO_SKey!=null)
				data.SrcSO = data.SrcSO_SKey.GetEntity().ID ;
	

			

			

			

			

			

			if (data.SrcShip == -1 && data.SrcShip_SKey!=null)
				data.SrcShip = data.SrcShip_SKey.GetEntity().ID ;
	

			if (data.ItemMaster == -1 && data.ItemMaster_SKey!=null)
				data.ItemMaster = data.ItemMaster_SKey.GetEntity().ID ;
	

			

			

			if (data.Uom == -1 && data.Uom_SKey!=null)
				data.Uom = data.Uom_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			InstalledArkDetailLineData data = dto as InstalledArkDetailLineData ;
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
		public void FromEntityData(InstalledArkDetailLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(InstalledArkDetailLineData data,IDictionary dict)
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
		
								this.SetTypeValue("RowNo",data.RowNo);
		
								this.SetTypeValue("SrcSONo",data.SrcSONo);
		
								this.SetTypeValue("SrcSO",data.SrcSO);
		
								this.SetTypeValue("SrcSOLineNo",data.SrcSOLineNo);
		
								this.SetTypeValue("SrcSOLine",data.SrcSOLine);
		
								this.SetTypeValue("SrcShipLineNo",data.SrcShipLineNo);
		
								this.SetTypeValue("SrcShipLine",data.SrcShipLine);
		
								this.SetTypeValue("SrcShipNO",data.SrcShipNO);
		
								this.SetTypeValue("SrcShip",data.SrcShip);
		
								this.SetTypeValue("ItemMaster",data.ItemMaster);
		
								this.SetTypeValue("Standard",data.Standard);
		
								this.SetTypeValue("Qty",data.Qty);
		
								this.SetTypeValue("Uom",data.Uom);
		
								this.SetTypeValue("InstalledArkNumber",data.InstalledArkNumber);
		
								this.SetTypeValue("OutBoxNumner",data.OutBoxNumner);
		
								this.SetTypeValue("InBoxNumber",data.InBoxNumber);
		
								this.SetTypeValue("Bulks",data.Bulks);
		
								this.SetTypeValue("Length",data.Length);
		
								this.SetTypeValue("Width",data.Width);
		
								this.SetTypeValue("Higth",data.Higth);
		
								this.SetTypeValue("GrossWeight",data.GrossWeight);
		
								this.SetTypeValue("NetWeight",data.NetWeight);
		
								this.Descflexfield.FromEntityData(data.Descflexfield);
		
								this.SetTypeValue("BoxNumber",data.BoxNumber);
		
			#endregion 

			#region 组件内属性
	
					if (data.InstalledArkLine!=null)
			{
				UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine child = dict[data.InstalledArkLine] as UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine ;
				if (child == null)
				{
					if (data.InstalledArkLine.ID>0)
					{
						if (data.InstalledArkLine.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.InstalledArkLine.ID,data.InstalledArkLine.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.InstalledArkLine.SysEntityType,null,data.InstalledArkLine.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.InstalledArkLine.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.InstalledArkLine,dict);
				}
				this.InstalledArkLine = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public InstalledArkDetailLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public InstalledArkDetailLineData ToEntityData(InstalledArkDetailLineData data, IDictionary dict){
			if (data == null)
				data = new InstalledArkDetailLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkDetailLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("RowNo");
				if (obj != null)
					data.RowNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcSONo");
				if (obj != null)
					data.SrcSONo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcSO");
				if (obj != null)
					data.SrcSO=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcSOLineNo");
				if (obj != null)
					data.SrcSOLineNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcSOLine");
				if (obj != null)
					data.SrcSOLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcShipLineNo");
				if (obj != null)
					data.SrcShipLineNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcShipLine");
				if (obj != null)
					data.SrcShipLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcShipNO");
				if (obj != null)
					data.SrcShipNO=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcShip");
				if (obj != null)
					data.SrcShip=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ItemMaster");
				if (obj != null)
					data.ItemMaster=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Standard");
				if (obj != null)
					data.Standard=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Qty");
				if (obj != null)
					data.Qty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Uom");
				if (obj != null)
					data.Uom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InstalledArkNumber");
				if (obj != null)
					data.InstalledArkNumber=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OutBoxNumner");
				if (obj != null)
					data.OutBoxNumner=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InBoxNumber");
				if (obj != null)
					data.InBoxNumber=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Bulks");
				if (obj != null)
					data.Bulks=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Length");
				if (obj != null)
					data.Length=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Width");
				if (obj != null)
					data.Width=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Higth");
				if (obj != null)
					data.Higth=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("GrossWeight");
				if (obj != null)
					data.GrossWeight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NetWeight");
				if (obj != null)
					data.NetWeight=(System.Decimal)obj;
			}
	     
	    
			if (this.Descflexfield != null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("BoxNumber");
				if (obj != null)
					data.BoxNumber=(System.Decimal)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("InstalledArkLine");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLineData _InstalledArkLine = dict["UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine"+oID.ToString()] as UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLineData;			
					data.InstalledArkLine = (_InstalledArkLine != null) ? _InstalledArkLine : (this.InstalledArkLine==null?null:this.InstalledArkLine.ToEntityData(null,dict));
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
			this.Descflexfield.OnValidate() ;
	

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