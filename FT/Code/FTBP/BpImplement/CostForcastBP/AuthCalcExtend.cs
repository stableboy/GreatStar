using System;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.BS.Job.RequestClient;

namespace UFIDA.U9.Cust.GS.FT.FTBP.CostForcastBP
{
    /// <summary>
    /// 创建即时调度
    /// </summary>
    public static class AuthCalcExtend
    {
        public static long DoApproveAsynchronous(string ApproveProxyFullName, string BPFullName, List<SM.SO.SO.EntityKey> SO,List<SM.SO.SOLine.EntityKey> SOLine, DateTime ExecuteDate, string RequestCode, string RequestName, string RequestDescription)
        {
            DateTime date = UFIDA.U9.Base.Context.LoginDate;

            if (ExecuteDate > date)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                //date = ExecuteDate.AddMinutes(rnd.Next(0, 59));//随机加分钟
                //date = ExecuteDate.AddMinutes(1);//指定2分钟
                date = date.AddSeconds(rnd.Next(5, 59));
            }

            else

                return 0;

            //else

            //    date = DateTime.Now.AddSeconds(1);//延迟1秒提交请求

            string path = string.Empty;

            if (AppDomain.CurrentDomain.BaseDirectory.Contains("MailService"))
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "Libs\\UFIDA.U9.Cust.GS.FT.FTBP.Agent.dll";

            }
            else
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "ApplicationServer\\Libs\\UFIDA.U9.Cust.GS.FT.FTBP.Agent.dll";

            }

            //throw new Exception(path);
            System.Reflection.Assembly a = System.Reflection.Assembly.LoadFile(path);

            object o = a.CreateInstance(ApproveProxyFullName);

            Type t = o.GetType();

            UFSoft.UBF.Util.TypeLoader typeLoader = new UFSoft.UBF.Util.TypeLoader();

            //Type t = typeLoader.LoadType(ApproveProxyFullName);

            //object o = a.CreateInstance(ApproveProxyFullName);
            List<long> soList = new List<long>();
            List<long> soLineList = new List<long>();
            if (SO != null && SO.Count > 0)
            {
                foreach (SM.SO.SO.EntityKey so in SO)
                {
                    soList.Add(so.ID);
                }
            }
            if (SOLine != null && SOLine.Count > 0)
            {
                foreach (SM.SO.SOLine.EntityKey line in SOLine)
                {
                    soLineList.Add(line.ID);
                }
            }
            if (t.GetProperty("SO") != null)
                t.GetProperty("SO").SetValue(o, soList, null);

            if (t.GetProperty("SOLine") != null)

                t.GetProperty("SOLine").SetValue(o, soLineList, null);

            if (t.GetProperty("IsJobServer") != null)

                t.GetProperty("IsJobServer").SetValue(o, false, null);

            RequestSubmit rsb = new RequestSubmit();

            rsb.Application = 3032;

            rsb.BPFullName = BPFullName;

            rsb.Priority = 1;

            rsb.RequestCode = RequestCode;

            PatternRunOnce once = new PatternRunOnce();

            rsb.SchedulerProject = once.PatternID(date);

            rsb.RequestDescription = RequestDescription;

            rsb.RequestName = RequestName;

            rsb.BPAgentObj = o;

            return rsb.Submit();

        }
    }
}
