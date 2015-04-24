﻿







namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.OperatorBonusBP.IApproveOperatorBonus")]
    public interface IApproveOperatorBonus
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
        UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 docID, System.Int32 docStatus, System.Int64 vIVersion, System.Int32 docType);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ApproveOperatorBonusStub : OperationStubBase, IApproveOperatorBonus
    {
        #region IApproveOperatorBonus Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 docID, System.Int32 docStatus, System.Int64 vIVersion, System.Int32 docType)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, docID, docStatus, vIVersion, docType);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData DoEx(ICommonDataContract commonData, System.Int64 docID, System.Int32 docStatus, System.Int64 vIVersion, System.Int32 docType)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.OperatorBonusBP.ApproveOperatorBonus");                
                ApproveOperatorBonus objectRef = new ApproveOperatorBonus();
				
				objectRef.DocID = docID;
				objectRef.DocStatus = docStatus;
				objectRef.VIVersion = vIVersion;
				objectRef.DocType = docType;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FI.OperatorBonusBP.ApproveOperatorBonus");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.OperatorBonusBP.ApproveOperatorBonus");
            }
        }
	#endregion
    }
}
