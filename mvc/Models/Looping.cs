using System;
using System.Collections.Generic;

namespace Models
{

public class Looping
{
    public DateTime BaslangicTarihi { get; set; }
    public DateTime BitisTarihi { get; set; }
    
    public List<DateTime> onbesligunler { get; set; }
    public List<int> Brak { get; set; }
    
    
    
    
    public int günFark { get; set; }
    public int ustLoop { get; set; }
    public List<DateTime> günce { get; set; }
    
    
    
}    
}