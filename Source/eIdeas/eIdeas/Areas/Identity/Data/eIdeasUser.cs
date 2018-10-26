﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace eIdeas.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the eIdeasUser class
    public class eIdeasUser : IdentityUser
    {
        [PersonalData]
        public string Firstname { get; set; }
        [PersonalData]
        public string Lastname { get; set; }
        [PersonalData]
        public string PictureURL { get; set; }
        [PersonalData]
        public string Team { get; set; }
        [PersonalData]
        public string Role { get; set; }
    }
}