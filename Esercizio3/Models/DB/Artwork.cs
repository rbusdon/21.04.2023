using System;
using System.Collections.Generic;

namespace Esercizio3.Models.DB;

public partial class Artwork
{
    public int IdArtwork { get; set; }

    public string Name { get; set; } = null!;

    public int IdMuseum { get; set; }

    public int IdArtist { get; set; }

    public int? IdCharacter { get; set; }

    public virtual Artist IdArtistNavigation { get; set; } = null!;

    public virtual Charcater? IdCharacterNavigation { get; set; }

    public virtual Museum IdMuseumNavigation { get; set; } = null!;
}
