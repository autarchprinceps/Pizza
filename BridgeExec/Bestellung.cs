using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeExec
{
    public partial class Bestellung : Form
    {
        public Bestellung()
        {
            InitializeComponent();
        }

        private void doit_Click(object sender, EventArgs e)
        {
            var m = numMar.Value;
            var n = numNap.Value;
            var quit = "Quittung:\n";
            Pizzeria laden = raAm.Checked ? (Pizzeria)new AmericanPizzas() : (Pizzeria)new Tonis();
            List<Pizza> bestellung = new List<Pizza>();
            for (var i = 1; i <= m; i++) bestellung.Add(new Margherita(laden));
            for (var j = 1; j <= n; j++) bestellung.Add(new Napoli(laden));
            foreach (var x in bestellung) quit += ((x is Margherita) ? "Margherita: " : "Napoli: ") + x.kosten();
            Quittung.Text = quit;
        }

        private void doRezept_Click(object sender, EventArgs e)
        {
            var m = numMar.Value;
            var n = numNap.Value;
            var r = "Rezept:\n";
            Pizzeria laden = raAm.Checked ? (Pizzeria)new AmericanPizzas() : (Pizzeria)new Tonis();
            if (m > 0) r += (new Margherita(laden)).rezept() + '\n';
            if (n > 0) r += (new Napoli(laden)).rezept() + '\n';
            Rezept.Text = r;
        }
    }
}
