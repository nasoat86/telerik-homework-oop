﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2Bank
{
    public interface IDeposit
    {
        decimal DepositMoney(decimal amount);
    }
}
