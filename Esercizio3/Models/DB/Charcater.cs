using System;
using System.Collections.Generic;

namespace Esercizio3.Models.DB;

public partial class Charcater
{
    public int IdCharacter { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Artwork> Artworks { get; set; } = new List<Artwork>();
}
