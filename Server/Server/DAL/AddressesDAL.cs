﻿using Microsoft.Extensions.Options;
using Server.DALInterfaces;
using Server.Domain.Entities;
using Server.Domain.GeneralStructure;
using Server.Infrastructure.Data;

namespace Server.DAL
{
    /// <summary>
    /// The class responsible for Calling the procedures and their data 
    /// According to the Register Addresses area.
    /// </summary>
    public class AddressesDAL : BaseDal<Addresses>, IAddressesDAL
    {
        public AddressesDAL(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
