using Quartz;
using Quartz.Impl;
using System;
using System.Threading;

namespace NetCore.Quartz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IScheduler scheduler;
            ISchedulerFactory factory = new StdSchedulerFactory();
            scheduler = factory.GetScheduler().Result;
            IJobDetail testJobDetail = JobBuilder.Create<DemoJob>().WithIdentity("DemoJob").Build();
            ITrigger testJobTrigger = TriggerBuilder.Create().WithCronSchedule("0/5 * * * * ? *").Build();
            scheduler.ScheduleJob(testJobDetail, testJobTrigger);
            scheduler.Start();
            while (true)
            { 
            }
        }
    }
}
