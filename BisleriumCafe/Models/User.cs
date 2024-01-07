﻿using BisleriumCafe.Models.Base;
using BisleriumCafe.Models.Enums;

namespace BisleriumCafe.Models;

public class User : BaseEntity
{
    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public Role Role { get; set; }
}
