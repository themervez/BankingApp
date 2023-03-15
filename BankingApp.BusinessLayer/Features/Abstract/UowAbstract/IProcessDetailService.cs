﻿using BankingApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.BusinessLayer.Features.Abstract.UowAbstract
{
    public interface IProcessDetailService:IUowGenericService<ProcessDetail>
    {
    }
}
