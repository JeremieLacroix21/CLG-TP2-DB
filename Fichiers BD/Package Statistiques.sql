--     Noms : Gabriel Fournier-Cloutier & Jérémie Lacroix
--    Date : 2019-03-29
--  Groupe : 02
-- Fichier : Package Statistiques
--------------------------------------
--------------------
-- PACKAGE
--------------------
create or replace PACKAGE STATISTIQUES AS
    TYPE ENR_SCORE IS REF CURSOR;
    TYPE ENR_CATEGORIE IS REF CURSOR;
    
    -- Incrémente le score d'un joueur pour une catégorie et met le flag gagnee à true
    PROCEDURE IncrScore
    (
        P_codeCategorie Categories.codeCategorie%TYPE,
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    );
    
    -- Remet le flag gagnee pour chaque catégorie pour chaque joueur à false
    PROCEDURE ResetCategoriesGagnee;
    
    -- Retourne les scores d'un joueur pour chaque catégories
    FUNCTION GetScoresJoueur
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    ) RETURN ENR_SCORE;
    
    -- Retourne les données suivantes : nom du joueur, prenom du joueur, les noms des catégories qu'il a gagné
    FUNCTION GetCategoriesGagnees
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    ) RETURN ENR_CATEGORIE;
    
    -- Retourne la catégorie la plus faible d'un joueur
    FUNCTION GetCategorieFaible
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    ) RETURN ENR_CATEGORIE;
    
END STATISTIQUES;

--------------------
-- BODY PACKAGE
--------------------
create or replace PACKAGE BODY STATISTIQUES AS

  PROCEDURE IncrScore
    (
        P_codeCategorie Categories.codeCategorie%TYPE,
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    ) AS
    nbPoints Number;
  BEGIN
    SELECT score INTO nbPoints FROM Scores WHERE codeCategorie = P_codeCategorie AND aliasJoueur = P_aliasJoueur;
    IF nbPoints IS NULL THEN
        INSERT INTO Scores VALUES(P_codeCategorie, P_aliasJoueur, 1, 'Y');
    ELSE
        UPDATE Scores SET score = nbPoints + 1, gagnee = 'Y' WHERE codeCategorie = P_codeCategorie AND aliasJoueur = P_aliasJoueur;
    END IF;
  END IncrScore;
  
  PROCEDURE ResetCategoriesGagnee AS
  BEGIN
    UPDATE Scores SET gagnee = 'N';
  END ResetCategoriesGagnee;

  FUNCTION GetScoresJoueur
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    ) RETURN ENR_SCORE AS
    resultat ENR_SCORE;
  BEGIN
    OPEN resultat FOR SELECT * FROM Scores WHERE P_aliasJoueur = aliasJoueur;
    RETURN resultat;
    CLOSE resultat;
  END GetScoresJoueur;

  FUNCTION GetCategoriesGagnees
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    ) RETURN ENR_CATEGORIE AS
    resultat ENR_CATEGORIE;
  BEGIN
    OPEN resultat FOR SELECT C.nom, J.nom, prenom FROM Scores S
        INNER JOIN Joueurs J ON S.aliasJoueur = J.aliasJoueur
        INNER JOIN Categories C ON S.codeCategorie = C.codeCategorie
        WHERE gagnee = 'Y';
    RETURN resultat;
    CLOSE resultat;
  END GetCategoriesGagnees;

  FUNCTION GetCategorieFaible
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    ) RETURN ENR_CATEGORIE AS
    resultat ENR_CATEGORIE;
    scoreMin Number;
  BEGIN
    SELECT MIN(score) INTO scoreMin FROM Scores WHERE P_aliasJoueur = aliasJoueur;
    OPEN resultat FOR SELECT * FROM Scores WHERE score = scoreMin;
    RETURN resultat;
    CLOSE resultat;
  END GetCategorieFaible;

END STATISTIQUES;