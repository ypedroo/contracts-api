﻿using Contracts.Domain.Core.Models;
using System;

namespace Contracts.Domain.Models
{
    public class PartModel : Entity
    {
        public PartModel(PartInformation partInformation)
        {
            Id = Guid.NewGuid();
            Information.FistName = partInformation.FistName;
            Information.LastName = partInformation.LastName;
            Information.Cpf = partInformation.Cpf;
            Information.Email = partInformation.Email;
            Information.Phone = partInformation.Phone;
        }

        public PartInformation Information { get; set; }
    }
}
