﻿using System;
using System.Collections.Generic;

namespace Esercizio3.Models.DB;

public partial class Museum
{
    public int IdMuseum { get; set; }

    public string MuseumName { get; set; } = null!;

    public string City { get; set; } = null!;

    public virtual ICollection<Artwork> Artworks { get; set; } = new List<Artwork>();
}
