﻿using Application.Features.ProgrammingLanguageTechnologies.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgrammingLanguageTechnologies.Models
{
    public class LanguageTechnologyListModel: BasePageableModel
    {
        public List<LanguageTechnologyListDto>  Items { get; set; }
    }
}
