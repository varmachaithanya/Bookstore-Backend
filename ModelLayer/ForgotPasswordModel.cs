﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class ForgotPasswordModel
    {
        public long UserId { get; set; }

        public string EmailId {  get; set; }

        public string token { get; set; }
    }
}
