SELECT City
FROM MUSEUM M
LEFT JOIN ARTWORK ART ON ART.ID_Museum = M.Id_Museum
WHERE ART.Name = 'Flora'