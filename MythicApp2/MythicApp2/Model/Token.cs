﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MythicApp2.Model
{
    class Token
    {
        public int Id { get; set; }
        public string AccessToken { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime ExpireDate { get; set; }

        public Token() {}
    }

}
