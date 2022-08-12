﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SL_WCF
{
    [DataContract]
    public class Result
    {

        [DataMember]
        public Exception Ex { get; set; }


        [DataMember]
        public bool Correct { get; set; }


        [DataMember]
        public List<Object>Objects { get; set; }


        [DataMember]
        public object Object { get; set; }


        [DataMember] 
        public string ErrorMessage { get; set; }


    }
}