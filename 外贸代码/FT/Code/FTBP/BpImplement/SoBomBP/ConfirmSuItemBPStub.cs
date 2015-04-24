﻿







namespace UFIDA.U9.Cust.GS.FT.SoBomBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBomBP.IConfirmSuItemBP")]
    public interface IConfirmSuItemBP
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 sOKey, List<System.Int64> bOMLineKeyList, System.Boolean isConfirm);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ConfirmSuItemBPStub : OperationStubBase, IConfirmSuItemBP
    {
        #region IConfirmSuItemBP Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 sOKey, List<System.Int64> bOMLineKeyList, System.Boolean isConfirm)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, sOKey, bOMLineKeyList, isConfirm);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, System.Int64 sOKey, List<System.Int64> bOMLineKeyList, System.Boolean isConfirm)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBomBP.ConfirmSuItemBP");                
                ConfirmSuItemBP objectRef = new ConfirmSuItemBP();
			
				objectRef.SOKey = sOKey;
				objectRef.BOMLineKeyList = bOMLineKeyList;
				objectRef.IsConfirm = isConfirm;

				//处理返回类型.
				System.Boolean result = objectRef.Do();
				return result ;
						return result;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBomBP.ConfirmSuItemBP");
            }
        }
	#endregion
    }
}
