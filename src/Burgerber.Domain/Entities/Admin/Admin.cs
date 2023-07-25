﻿using System.ComponentModel.DataAnnotations;

namespace Burgerber.Domain.Entities.Admin;

public class Admin : Human
{
    [MaxLength(13)]
    public string PhoneNumber { get; set; } = string.Empty;

    public string PhoneNumberConfirmed { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string Salt { get; set; } = string.Empty;
}
