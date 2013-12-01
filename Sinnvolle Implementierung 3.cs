using System;
using System.Collections.Generic;

enum size { Piccolo, Std, Grande };
enum belag { cheese, salami }; // ... 

public static class Preis {
    public static Dictionary<size, int> sizepay = new Dictionary<size,int>(){ {Piccolo, 1}, {Std, 2}, {Grande, 3} };
    public static Dictionary<belag, int> belagpay = new Dictionary<belag,int>(){ {cheese, 1}, {salami, 2} };

    public static int preis(size g, List<belag> b) {
        var result = sizepay[g];
        foreach (var x in b) result += belagpay[x];
        return result;
    }
}
