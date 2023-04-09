﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UserBadges.DTO
{
    public class UserBadgeDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; } // Add user name
        public int BadgeId { get; set; }
        public string BadgeName { get; set; } // Add badge name
        public DateTime AwardDate { get; set; }
    }

}
