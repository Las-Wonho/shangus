﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_txt_sever
{
    public enum PROTOCOL : short
    {
        BEGIN = 0,

        CHAT_MSG_REQ = 1,
        CHAT_MSG_ACK = 2,

        END
    }
}
