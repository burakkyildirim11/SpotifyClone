
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SpotiftClone
{

using System;
    using System.Collections.Generic;
    
public partial class playedcount_countries
{

    public int ID { get; set; }

    public int countryID { get; set; }

    public int songID { get; set; }

    public int playedCount { get; set; }



    public virtual countries countries { get; set; }

    public virtual songs songs { get; set; }

}

}
