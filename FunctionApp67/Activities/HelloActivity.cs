﻿using System.Threading.Tasks;

using Microsoft.Azure.WebJobs;

namespace FunctionApp67.Activities
{
    public class HelloActivity : IHelloActivity
    {
        [FunctionName(nameof(SayHello))]
        public Task<string> SayHello([ActivityTrigger] string name)
        {
            return Task.FromResult($"Hello {name}!");
        }
    }
}