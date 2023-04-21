SELECT M.MuseumName, ART.Name ArtworkName, C.Name CharacterName
FROM MUSEUM M
LEFT JOIN ARTWORK ART ON M.Id_Museum = ART.ID_Museum
JOIN ARTIST ON ART.ID_Artist = ARTIST.Id_Artist
LEFT JOIN CHARCATER C ON C.ID_Character = ART.ID_Character
WHERE Country = 'Italia'