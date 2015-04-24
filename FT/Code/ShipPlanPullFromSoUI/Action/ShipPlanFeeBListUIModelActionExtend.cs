﻿/**************************************************************
 * Description:
 * ShipPlanFeeBListUIModelAction.cs
 * Product: U9
 * Co.    : UFSoft Group
 * Author : Auto Generated 
 * version: 1.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.UBF.Query.CommonService.QueryStrategy;
using UFIDA.UBF.Query.CaseModel;
using UFIDA.U9.UI.PDHelper;




namespace UFIDA.U9.Cust.GS.FT.ShipPlanFeeBListUIModel
{
	public partial class ShipPlanFeeBListUIModelAction 
	{
		public override void OnInitAction()
		{
			base.OnInitAction();
			//提示:可注册你自己的方法到相应的事件中,如下.
			//this.CommonAction.BeforeLoad += new ActionLoadDelegate(CommonAction_BeforeLoad);
		}
		private void OnLookCase_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnLookCase_DefaultImpl(sender,e);								
        }

        private void OnSaveCase_Extend(object sender, UIActionEventArgs e)
        {
            OnSaveCase_DefaultImpl(sender, e);
        }
		private void OnCaseChanged_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnCaseChanged_DefaultImpl(sender,e);								
        } 
		private void OnOutPut_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnOutPut_DefaultImpl(sender,e);								
        } 
		private void OnGridRowDbClick_Extend(object sender, UIActionEventArgs e)
		{
            string dataId = this.CurrentModel.ShipPlanDetailFeeHead.FocusedRecord["id"].ToString();
            OnNavigatCard("Browse", dataId, "Cust.GS.FT.ShipPlanDetailFeeURI");
            this.OnGridRowDbClick_DefaultImpl(sender, e);
			
			//List Grid RowDbClic Code Demo...
			//string DataID = this.CurrentModel.PositionType.FocusedRecord.ID.ToString();
			//string CardPageID="Test";//在这里CardPageID表示卡片的URI
			//OnNavigatCard("Browse", DataID, CardPageID);
			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnGridRowDbClick_DefaultImpl(sender,e);								
        }

        private void OnNavigatCard(string type, string dataID, string formID)
        {
            string FormID = formID;//AddFormID
            string DataID = dataID;
            if (DataID == String.Empty && type == "Browse")
            {
                return;
            }
            else
            {
                System.Collections.Specialized.NameValueCollection nameValCol = new System.Collections.Specialized.NameValueCollection();
                nameValCol.Add("PDPageStatus", type);
                nameValCol.Add("ID", DataID);
                this.CommonAction.CurrentPart.NavigatePage(FormID, nameValCol);
            }
        } 

		private void OnNew_Extend(object sender, UIActionEventArgs e)
		{

            this.CurrentPart.NavigatePage("Cust.GS.FT.ShipPlanDetailFeeURI", null);

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnNew_DefaultImpl(sender,e);								
        } 
		private void OnPrint_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnPrint_DefaultImpl(sender,e);								
        } 
		private void OnDelete_Extend(object sender, UIActionEventArgs e)
		{
	
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            IList<IUIRecord> selectedSecords = UIRuntimeHelper.Instance.GetSelectRecordFromCache(this.MainView);
           // IList<IUIRecord> selectedSecords = this.MainView.GetSelectedRecordIDs(
            if (selectedSecords.Count == 0)
            {
                return;
            }
            UFIDA.U9.UI.BusinessHelper.ListHelp listhelper = new UFIDA.U9.UI.BusinessHelper.ListHelp();
            listhelper.Delete_Doc(this, e, GetMainID(selectedSecords), "SysVersion", this.CurrentModel.ShipPlanDetailFeeHead.EntityFullName);

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnDelete_DefaultImpl(sender,e);								
        }

        internal static string GetMainID(IList<IUIRecord> selectedSecords)
        {
            if (selectedSecords.Count == 0)
            {
                return "ID";
            }
            IUIRecord record = selectedSecords[0];
            if (record["MainID"] == null || record["MainID"].ToString().Length == 0)
            {
                return "ID";
            }
            return "MainID";
        }

		
		#region UBF 内置两数据处理Action
		//数据加载的扩展
		private void OnLoadData_Extend(object sender, UIActionEventArgs e)
		{
this.OnLoadData_DefaultImpl(sender,e);			
		}

		//数据收集的扩展
		private void OnDataCollect_Extend(object sender, UIActionEventArgs e)
		{
			this.OnDataCollect_DefaultImpl(sender,e);
		}
		#endregion 
		
		  

		    
        #region 列表应用开发人员扩展代码段
        
        private string CustomFilterOpath_Extend(string filterOpath)
        {
            return filterOpath;
        }
        
	private void AfterQryAdjust_Extend(IUFDataGrid UIGrid)
        {

        }

	
        private void BeforeGetQryModel_Extend(BEQueryStrategyImpl beQryStrategyImpl)
        {
        }

        private void AfterGetQueryModel_Extend(CaseModel caseModel)
        {
        }
        
        #endregion
		  

	}
}
