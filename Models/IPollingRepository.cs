﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SportsStore.Models
{
    public interface IPollingRepository
    {
        IEnumerable<Polling> Selection { get; }
        void SaveVote(Polling polling);
    }
}