﻿using System;

public class User
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Email { get; set; }
	public string Password { get; set; }
	public bool Blocked { get; set; }
	public bool Admin { get; set; }
}
