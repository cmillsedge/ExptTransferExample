using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioRails.Core.Api;
using BioRails.Core.Model;

namespace ExperimenttTransferExample
{
    public class BioRailsJobHandler
    {
        public static JobReport pollJob(JobReport job, string sessionId, string url)
        {
            JobsApi jobsApi = new JobsApi(url);
            JobReport polledJob;
            do
            {
                Thread.Sleep(1000);
                polledJob = jobsApi.JobGet(sessionId, job.Id);
                Console.WriteLine(polledJob.Status);
            } while (polledJob.Status != "error" && polledJob.Status != "finished");
            return polledJob;
        }
    }
}
