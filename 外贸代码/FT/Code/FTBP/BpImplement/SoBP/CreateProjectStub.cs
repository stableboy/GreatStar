﻿







namespace UFIDA.U9.Cust.GS.FT.SoBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBP.ICreateProject")]
    public interface ICreateProject
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
        UFSoft.UBF.Business.BusinessEntity.EntityKey Do(IContext context ,out IList<MessageBase> outMessages ,System.String orderNo, System.String customerNo);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreateProjectStub : OperationStubBase, ICreateProject
    {
        #region ICreateProject Members

        //[OperationBehavior]
        public UFSoft.UBF.Business.BusinessEntity.EntityKey Do(IContext context ,out IList<MessageBase> outMessages, System.String orderNo, System.String customerNo)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, orderNo, customerNo);
        }
        
        //[OperationBehavior]
        public UFSoft.UBF.Business.BusinessEntity.EntityKey DoEx(ICommonDataContract commonData, System.String orderNo, System.String customerNo)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBP.CreateProject");                
                CreateProject objectRef = new CreateProject();
		
				objectRef.OrderNo = orderNo;
				objectRef.CustomerNo = customerNo;

				//处理返回类型.
				UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey result = objectRef.Do();

				if (result == null)
					return null ;
					 
				DoSerializeKey(result, "UFIDA.U9.Cust.GS.FT.SoBP.CreateProject");
				return result;
		
	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBP.CreateProject");
            }
        }
	#endregion
    }
}
