--     Noms : Gabriel Fournier-Cloutier & Jérémie Lacroix
--    Date : 2019-03-29
--  Groupe : 02
-- Fichier : Package GestionQuestions
--------------------------------------
--------------------
-- PACKAGE
--------------------
create or replace PACKAGE GESTIONQUESTIONS AS
    TYPE ENR_QUESTION IS REF CURSOR;
    TYPE ENR_REPONSE IS REF CURSOR;
    
    -- Insertion d'une nouvelle question
    PROCEDURE InsertQuestion
    (
        P_enonce Questions.enonce%TYPE,
        P_repondu Questions.repondu%TYPE,
        P_codeCategorie Categories.codeCategorie%TYPE
    );
    
    -- Insertion d'une nouvelle reponse
    PROCEDURE InsertReponse
    (
        P_numReponse Reponses.numReponse%TYPE,
        P_description Reponses.description%TYPE,
        P_estBonne Reponses.estBonne%TYPE,
        P_numQuestion Questions.numQuestion%TYPE
    );
    
    -- Remet le flag repondu de toute les questions à faux
    PROCEDURE ResetQuestionsRepondues;
    
    -- Set le flag repondu d'une question
    PROCEDURE SetRepondu
    (
        P_numQuestion Questions.numQuestion%TYPE,
        P_nouvRepondu Questions.repondu%TYPE
    );
    
    -- Retourne une question au hasard d'une catégorie dont le flag repondu est faux
    FUNCTION GetQuestionHasard
    (
        P_codeCategorie Categories.codeCategorie%TYPE
    ) RETURN ENR_QUESTION;
    
    -- Retourne toute les réponses associées à une question
    FUNCTION GetReponses
    (
        P_numQuestion Questions.numQuestion%TYPE
    ) RETURN ENR_REPONSE;
    
    -- Retourne 'O' si la reponses est bonne, 'N' si elle ne l'est pas
    FUNCTION ValiderReponse
    (
        P_numReponse Reponses.numReponse%TYPE
    ) RETURN Reponses.estBonne%TYPE;
    
END GESTIONQUESTIONS;

--------------------
-- BODY PACKAGE
--------------------
create or replace PACKAGE BODY GESTIONQUESTIONS AS

  PROCEDURE InsertQuestion
    (
        P_enonce Questions.enonce%TYPE,
        P_repondu Questions.repondu%TYPE,
        P_codeCategorie Categories.codeCategorie%TYPE
    ) AS
    seqNumQuestion Questions.numQuestion%TYPE;
  BEGIN
    IF P_codeCategorie = 'V' THEN -- Histoire
        SELECT SEQ_V_numQuestion.NEXTVAL INTO seqNumQuestion FROM Dual;
    ELSIF P_codeCategorie = 'B' THEN -- Geographie
        SELECT SEQ_B_numQuestion.NEXTVAL INTO seqNumQuestion FROM Dual;
    ELSIF P_codeCategorie = 'O' THEN -- Sport
        SELECT SEQ_O_numQuestion.NEXTVAL INTO seqNumQuestion FROM Dual;
    ELSIF P_codeCategorie = 'M' THEN -- Art - Culture
        SELECT SEQ_M_numQuestion.NEXTVAL INTO seqNumQuestion FROM Dual;
    ELSE
        RAISE_APPLICATION_ERROR(-20002, 'Categorie invalide');
    END IF;
    INSERT INTO Questions VALUES(P_codeCategorie||seqNumQuestion, P_enonce, P_repondu, P_codeCategorie);    
  END InsertQuestion;

  PROCEDURE InsertReponse
    (
        P_numReponse Reponses.numReponse%TYPE,
        P_description Reponses.description%TYPE,
        P_estBonne Reponses.estBonne%TYPE,
        P_numQuestion Questions.numQuestion%TYPE
    ) AS
  BEGIN
    INSERT INTO Reponses VALUES(P_numReponse, P_description, P_estBonne, P_numQuestion);
  END InsertReponse;

  PROCEDURE ResetQuestionsRepondues AS
  BEGIN
    UPDATE Questions SET repondu = 'N';
  END ResetQuestionsRepondues;

  PROCEDURE SetRepondu
    (
        P_numQuestion Questions.numQuestion%TYPE,
        P_nouvRepondu Questions.repondu%TYPE
    ) AS
  BEGIN
    UPDATE Questions SET repondu = P_nouvRepondu WHERE numQuestion = P_numQuestion;
  END SetRepondu;

  FUNCTION GetQuestionHasard
    (
        P_codeCategorie Categories.codeCategorie%TYPE
    ) RETURN ENR_QUESTION AS
    resultat ENR_QUESTION;
    nbQuestionsDispos Number;
    randRowNum Number;
  BEGIN
    SELECT COUNT(numQuestion) INTO nbQuestionsDispos FROM Questions WHERE codeCategorie = P_codeCategorie AND repondu = 'N';
    SELECT DBMS_RANDOM.Value(1, nbQuestionsDispos) INTO randRowNum FROM Dual;
    OPEN resultat FOR SELECT * FROM Questions WHERE codeCategorie = P_codeCategorie AND repondu = 'N' AND ROWNUM = randRowNum;
    RETURN resultat;
    CLOSE resultat;
  END GetQuestionHasard;

  FUNCTION GetReponses
    (
        P_numQuestion Questions.numQuestion%TYPE
    ) RETURN ENR_REPONSE AS
    resultat ENR_REPONSE;
  BEGIN
    OPEN resultat FOR SELECT * FROM Reponses WHERE P_numQuestion = numQuestion;
    RETURN resultat;
    CLOSE resultat;
  END GetReponses;

  FUNCTION ValiderReponse
    (
        P_numReponse Reponses.numReponse%TYPE
    ) RETURN Reponses.estBonne%TYPE AS
    resultat Reponses.estBonne%TYPE;
  BEGIN
    SELECT estBonne INTO resultat FROM Reponses WHERE P_numReponse = numReponse;
    RETURN resultat;
  END ValiderReponse;

END GESTIONQUESTIONS;