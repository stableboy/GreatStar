﻿using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 扣款状态枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class DRStatusEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum");
        #region ctor & cctor 
        static DRStatusEnum()
        {
            InitData();
        }
        private DRStatusEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private DRStatusEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,DRStatusEnum>();
            none = new DRStatusEnum(0,"None") ;
            innerEnums.Add(0,none) ;
            part = new DRStatusEnum(1,"Part") ;
            innerEnums.Add(1,part) ;
            closed = new DRStatusEnum(2,"Closed") ;
            innerEnums.Add(2,closed) ;
            empty = new DRStatusEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static DRStatusEnum empty;
        public static DRStatusEnum Empty
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
        			case "None":
        				return this.Res_None; 
        			case "Part":
        				return this.Res_Part; 
        			case "Closed":
        				return this.Res_Closed; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static DRStatusEnum none ;
        /// <summary>
        /// 枚举值: 未扣款  Value:0  
        /// 扣款状态枚举.Misc.未扣款
        /// </summary>
        public static DRStatusEnum None
        {
            get
            {
                return  none ;
            }
        }
        private static DRStatusEnum part ;
        /// <summary>
        /// 枚举值: 部分扣款  Value:1  
        /// 扣款状态枚举.Misc.部分扣款
        /// </summary>
        public static DRStatusEnum Part
        {
            get
            {
                return  part ;
            }
        }
        private static DRStatusEnum closed ;
        /// <summary>
        /// 枚举值: 扣款关闭  Value:2  
        /// 扣款状态枚举.Misc.扣款关闭
        /// </summary>
        public static DRStatusEnum Closed
        {
            get
            {
                return  closed ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, DRStatusEnum> innerEnums;
        /// <summary>
        /// Get DRStatusEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<DRStatusEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get DRStatusEnum By Value 
        /// </summary>
        public static DRStatusEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						DRStatusEnum newValue = new DRStatusEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get DRStatusEnum By Value 
        /// </summary>
        public static DRStatusEnum GetFromValue(object value)
        {
			if (value == null)
				return DRStatusEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get DRStatusEnum By Name 
        /// </summary>
        public static DRStatusEnum GetFromName(string name)
        {
            foreach (DRStatusEnum obj in innerEnums.Values)
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
		/// 扣款状态枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 扣款状态枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_None　{ get {return EnumRes.GetResource("None");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Part　{ get {return EnumRes.GetResource("Part");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Closed　{ get {return EnumRes.GetResource("Closed");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum";　}　}

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