﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Pizza
{
	public virtual Pizzeria Pizzeria
	{
		get;
		set;
	}

	public abstract string[] rezept();

	public abstract int kosten();

	public virtual Pizza (Pizzeria laden)
	{
        this.Pizzeria = laden;
    }

	public virtual string[] accept(KochRezeptVisitor visitor)
	{
		throw new System.NotImplementedException();
	}

	public abstract int durchmesser();

}

