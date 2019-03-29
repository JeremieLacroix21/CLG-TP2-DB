--     Noms : Gabriel Fournier-Cloutier & Jérémie Lacroix
--    Date : 2019-03-29
--  Groupe : 02
-- Fichier : Package GestionJoueurs
--------------------------------------
--------------------
-- PACKAGE
--------------------
create or replace PACKAGE GESTIONJOUEURS AS
    TYPE ENR_JOUEUR IS REF CURSOR;
    
    -- Insertion d'un nouveau joueur
    PROCEDURE InsertJoueur
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE,
        P_nom Joueurs.nom%TYPE,
        P_prenom Joueurs.prenom%TYPE
    );
    
    -- Suppression d'un joueur
    PROCEDURE SupprJoueur
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    );
    
END GESTIONJOUEURS;

--------------------
-- BODY PACKAGE
--------------------
create or replace PACKAGE BODY GESTIONJOUEURS AS

  PROCEDURE InsertJoueur
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE,
        P_nom Joueurs.nom%TYPE,
        P_prenom Joueurs.prenom%TYPE
    ) AS
  BEGIN
    INSERT INTO Joueurs VALUES(P_aliasJoueur, P_nom, P_prenom);
  END InsertJoueur;

  PROCEDURE SupprJoueur
    (
        P_aliasJoueur Joueurs.aliasJoueur%TYPE
    ) AS
  BEGIN
    DELETE Joueurs WHERE aliasJoueur = P_aliasJoueur;
  END SupprJoueur;

END GESTIONJOUEURS;