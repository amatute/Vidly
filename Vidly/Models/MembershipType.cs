﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
  public class MembershipType
  {
    public byte Id { get; set; }
    public short SignUpFee { get; set; }
    [StringLength(100)]
    public string Name { get; set; }
    public byte DurationInMonths { get; set; }
    public byte DiscountRate { get; set; }

    public static readonly byte Unknown = 0;    
    public static readonly byte PayAsYouGo = 1;    
  } 
}   