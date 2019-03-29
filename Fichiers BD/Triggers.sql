--     Noms : Gabriel Fournier-Cloutier & Jérémie Lacroix
--    Date : 2019-03-29
--  Groupe : 02
-- Fichier : Triggers
--------------------------------------
create or replace TRIGGER SUPPR_CASCADE_JOUEUR 
BEFORE DELETE ON JOUEURS
FOR EACH ROW
BEGIN
    DELETE Scores WHERE aliasJoueur = :OLD.aliasJoueur;
END;


create or replace TRIGGER GARANTIR_NB_REPONSES 
BEFORE INSERT ON REPONSES
FOR EACH ROW
DECLARE
    nbReponses Number;
BEGIN
    SELECT COUNT(numReponse) INTO nbReponses FROM Reponses WHERE numQuestion = :NEW.numQuestion;
    IF nbReponses = 4 THEN
        RAISE_APPLICATION_ERROR(-20001, 'Une question ne peut avoir que 4 choix de reponse au maximum');
    END IF;
END;


create or replace TRIGGER GARANTIR_BONNE_REPONSE 
BEFORE INSERT OR UPDATE OF ESTBONNE ON REPONSES
FOR EACH ROW
DECLARE
    nbBonneReponses Number;
BEGIN
    SELECT COUNT(numReponse) INTO nbBonneReponses FROM Reponses WHERE numQuestion = :NEW.numQuestion AND estbonne = 'Y';
    IF nbBonneReponses > 0 THEN
        RAISE_APPLICATION_ERROR(-20000, 'Une question ne peut pas avoir plusieurs bonnes reponses');
    END IF;
END;