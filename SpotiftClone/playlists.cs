
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
    
public partial class playlists
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public playlists()
    {

        this.user_playlist_songs = new HashSet<user_playlist_songs>();

    }


    public int ID { get; set; }

    public int userID { get; set; }

    public int songTypeID { get; set; }



    public virtual song_type song_type { get; set; }

    public virtual users users { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<user_playlist_songs> user_playlist_songs { get; set; }

}

}
