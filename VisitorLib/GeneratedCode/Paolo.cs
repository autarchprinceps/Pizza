﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Linq;
using System.Text;

public class Paolo : Koch
{
	public virtual string[] visitRezept(Pizza pizza)
    {
        ArrayList rezept = new ArrayList();
        if (pizza is Margherita)
        {
            rezept.Add(pizza.Pizzeria.teig());
            rezept.Add(pizza.Pizzeria.käse());
            rezept.Add(pizza.Pizzeria.tomatensoße());
            rezept.Add(pizza.Pizzeria.käse());
        }
        else if (pizza is Napoli)
        {
            rezept.Add(pizza.Pizzeria.teig());
            rezept.Add(pizza.Pizzeria.tomatensoße());
            rezept.Add(pizza.Pizzeria.käse());
            rezept.Add(pizza.Pizzeria.sardellen());
        }
        else
            rezept.Add("Es exestiert kein Rezept");

        return (string[])rezept.ToArray();
    }

}

