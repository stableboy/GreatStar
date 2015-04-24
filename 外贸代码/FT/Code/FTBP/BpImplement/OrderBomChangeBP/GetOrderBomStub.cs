﻿







namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using System.IO;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.IGetOrderBom")]
    public interface IGetOrderBom
    {
		[ServiceKnownType(typeof(ApplicationContext))]
		[ServiceKnownType(typeof(PlatformContext))]
		[ServiceKnownType(typeof(ThreadContext))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.BusinessException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.EntityNotExistException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.AttributeInValidException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Business.AttrsContainerException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Exceptions.MessageBase))]
			[FaultContract(typeof(UFSoft.UBF.Service.ServiceLostException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceExceptionDetail))]
		[FaultContract(typeof(ExceptionBase))]
		[FaultContract(typeof(Exception))]
		[OperationContract()]
        List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey soLineID, UFSoft.UBF.Business.BusinessEntity.EntityKey subKeyID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetOrderBomStub : OperationStubBase, IGetOrderBom
    {
        #region IGetOrderBom Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTOData> Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey soLineID, UFSoft.UBF.Business.BusinessEntity.EntityKey subKeyID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, soLineID, subKeyID);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTOData> DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey soLineID, UFSoft.UBF.Business.BusinessEntity.EntityKey subKeyID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetOrderBom");                
                GetOrderBom objectRef = new GetOrderBom();
		
				DeSerializeKey(soLineID);
				if (soLineID == null)
					objectRef.SoLineID = null;
				else
					objectRef.SoLineID = new UFIDA.U9.SM.SO.SOLine.EntityKey(soLineID.ID);
						DeSerializeKey(subKeyID);
				if (subKeyID == null)
					objectRef.SubKeyID = null;
				else
					objectRef.SubKeyID = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(subKeyID.ID);
		
				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTOData> list = new List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTOData>();
				foreach (UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetOrderBom");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetOrderBom");
            }
        }
	#endregion
    }
}
