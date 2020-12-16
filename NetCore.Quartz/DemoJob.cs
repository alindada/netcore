using Quartz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Quartz
{
    public class DemoJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() =>
            {
                var wtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string path = "/demo.log";
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("执行作业" + wtime);
                }
            });
        }
    }
}
