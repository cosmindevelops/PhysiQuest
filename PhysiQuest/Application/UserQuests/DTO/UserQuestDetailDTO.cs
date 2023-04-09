﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserQuests.DTO
{
    public class UserQuestDetailDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int RewardPoints { get; set; }
        public int RewardTokens { get; set; }
        public string Status { get; set; }
    }

}
