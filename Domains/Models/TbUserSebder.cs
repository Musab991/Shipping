﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

namespace Domains.Models;

public partial class TbUserSender:baseTable
{

    public Guid UserId { get; set; }

    public string SenderName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public Guid CityId { get; set; }

    public string Address { get; set; } = null!;

    public virtual TbCity City { get; set; } = null!;

    public virtual ICollection<TbShippment> TbShippments { get; set; } = new List<TbShippment>();

    
}
