using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PyramidWord.Models
{
    [DataContract]
    public class Pyramid
    {
        [DataMember(Name = "result")]
        public string Result { get; set; }
    }
}