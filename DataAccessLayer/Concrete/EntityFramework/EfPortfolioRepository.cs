﻿using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfPortfolioRepository:GenericRepository<Portfolio>,IPortfolioDal
    {
    }
}
