SELECT ARTIST.Name ArtistsWithArtworksInParis
FROM ARTIST
LEFT JOIN ARTWORK ART ON ART.ID_Artist = ARTIST.Id_Artist
JOIN MUSEUM M ON M.Id_Museum = ART.ID_Museum
WHERE M.City = 'Parigi'