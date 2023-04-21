using System;
using System.Collections.Generic;

namespace Esercizio3.Models.DB;

public partial class Artist
{
    public int IdArtist { get; set; }

    public string? Name { get; set; }

    public string Country { get; set; } = null!;

    public virtual ICollection<Artwork> Artworks { get; set; } = new List<Artwork>();
}
