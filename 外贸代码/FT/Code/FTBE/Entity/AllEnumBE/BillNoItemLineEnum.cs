﻿using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 发票号组状态 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class BillNoItemLineEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum");
        #region ctor & cctor 
        static BillNoItemLineEnum()
        {
            InitData();
        }
        private BillNoItemLineEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private BillNoItemLineEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,BillNoItemLineEnum>();
            isUnUsed = new BillNoItemLineEnum(0,"IsUnUsed") ;
            innerEnums.Add(0,isUnUsed) ;
            isUsed = new BillNoItemLineEnum(1,"IsUsed") ;
            innerEnums.Add(1,isUsed) ;
            empty = new BillNoItemLineEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static BillNoItemLineEnum empty;
        public static BillNoItemLineEnum Empty
        {
            get
            {
                return empty;
            }
        }
        #endregion 

        #region Intstance Propertites 
        private int currentValue;
        public System.Int32 Value
        {
            get
            {
				return currentValue ;         
            }
        }
        private string  name ;
        public string  Name 
        {
            get
            {
                return name;
            }
        }
        [System.Obsolete("已经废弃,请用EnumRes.GetResource(name)方式来获取显示名称. ")]
        public string Res_Name
        {
        	get 
        	{
        		switch ( this.Name )
        		{
        			case "IsUnUsed":
        				return this.Res_IsUnUsed; 
        			case "IsUsed":
        				return this.Res_IsUsed; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static BillNoItemLineEnum isUnUsed ;
        /// <summary>
        /// 枚举值: 未使用  Value:0  
        /// 发票号组状态.Misc.未使用
        /// </summary>
        public static BillNoItemLineEnum IsUnUsed
        {
            get
            {
                return  isUnUsed ;
            }
        }
        private static BillNoItemLineEnum isUsed ;
        /// <summary>
        /// 枚举值: 已使用  Value:1  
        /// 发票号组状态.Misc.已使用
        /// </summary>
        public static BillNoItemLineEnum IsUsed
        {
            get
            {
                return  isUsed ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, BillNoItemLineEnum> innerEnums;
        /// <summary>
        /// Get BillNoItemLineEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<BillNoItemLineEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get BillNoItemLineEnum By Value 
        /// </summary>
        public static BillNoItemLineEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						BillNoItemLineEnum newValue = new BillNoItemLineEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get BillNoItemLineEnum By Value 
        /// </summary>
        public static BillNoItemLineEnum GetFromValue(object value)
        {
			if (value == null)
				return BillNoItemLineEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get BillNoItemLineEnum By Name 
        /// </summary>
        public static BillNoItemLineEnum GetFromName(string name)
        {
            foreach (BillNoItemLineEnum obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 


		#region ModelResource
		/// <summary>
		/// 发票号组状态的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 发票号组状态的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_IsUnUsed　{ get {return EnumRes.GetResource("IsUnUsed");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_IsUsed　{ get {return EnumRes.GetResource("IsUsed");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum";　}　}

			/// <summary>
			///  获取资源接口,直接传了枚举对象.Name 就可.
			/// </summary>
			public static string GetResource(String attrName)
			{
				if (attrName== Enum_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName);
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName, attrName);
			}
			/// <summary>
			///  获取资源接口,直接传了枚举对象.Value 或Int32值 就可.
			/// </summary>
			public static string GetResourceByValue(Int32 value)
			{
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetNameForEnumValue(Enum_FullName, value);
			}
		}
		#endregion 
    }
}