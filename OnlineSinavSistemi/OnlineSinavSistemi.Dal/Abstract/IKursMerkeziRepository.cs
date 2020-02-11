﻿using OnlineSinavSistemi.Core.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavSistemi.Dal.Abstract
{
    public interface IKursMerkeziRepository : IRepository<KursMerkezi>
    {
        ICollection<KursMerkezi> IlSec(string il);
        ICollection<KursMerkezi> IlceSec(string ilce);
    }
}
