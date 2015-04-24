﻿#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentUIModel
{	public partial class PrePaymentUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            //this.Views[0].Fields[0].DefaultValue = thsi.co
            this.PrePayment.FieldBusinessDate.DefaultValue = DateTime.Today;
            this.PrePayment.FieldPrePayDate.DefaultValue = DateTime.Today;
            this.PrePayment.FieldSrcDocType.DefaultValue = 1;
        }
        
        //UIModel提交保存之前的校验操作.
        public override void OnValidate()
        {
        		base.OnValidate() ;
            OnValidate_DefualtImpl();
            //your coustom code ...
        }
	}
}