--     Noms : Gabriel Fournier-Cloutier & Jérémie Lacroix
--    Date : 2019-03-30
--  Groupe : 02
-- Fichier : Package GestionCategories
--------------------------------------
--------------------
-- PACKAGE
--------------------
CREATE OR REPLACE 
PACKAGE GESTIONCATEGORIES AS 
  TYPE ENR_CATEGORIE IS REF CURSOR;
    
  -- Retourne tous les enregistrements de la table Categories
  FUNCTION GetToutesCategories RETURN ENR_CATEGORIE;

END GESTIONCATEGORIES;

--------------------
-- BODY PACKAGE
--------------------
CREATE OR REPLACE
PACKAGE BODY GESTIONCATEGORIES AS

  FUNCTION GetToutesCategories RETURN ENR_CATEGORIE AS
    resultat ENR_CATEGORIE;
  BEGIN
    OPEN resultat FOR SELECT * FROM Categories;
    RETURN resultat;
    CLOSE resultat;
  END GetToutesCategories;

END GESTIONCATEGORIES;