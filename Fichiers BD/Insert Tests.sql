SELECT * FROM Questions;

SELECT * FROM Reponses;
SELECT * FROM Categories;
SELECT * FROM Joueurs;
SELECT * FROM Scores;

DROP SEQUENCE SEQ_V_NUMQUESTION;
DROP SEQUENCE SEQ_B_NUMQUESTION;
DROP SEQUENCE SEQ_O_NUMQUESTION;
DROP SEQUENCE SEQ_M_NUMQUESTION;

CREATE SEQUENCE SEQ_V_NUMQUESTION MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
CREATE SEQUENCE SEQ_B_NUMQUESTION MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
CREATE SEQUENCE SEQ_O_NUMQUESTION MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
CREATE SEQUENCE SEQ_M_NUMQUESTION MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;

DELETE Reponses;
DELETE Questions;

VARIABLE OUT num Char(6);

EXECUTE GestionQuestions.InsertQuestion(:num, 'Sport : Repondre A', 'O');
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'A', 'oui', 'Y', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'B', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'C', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'D', 'non', 'N', :num);

EXECUTE GestionQuestions.InsertQuestion(:num, 'Histoire : Repondre B', 'G');
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'A', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'B', 'oui', 'Y', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'C', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'D', 'non', 'N', :num);

EXECUTE GestionQuestions.InsertQuestion(:num, 'Geo : Repondre C', 'B');
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'A', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'B', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'C', 'oui', 'Y', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'D', 'non', 'N', :num);

EXECUTE GestionQuestions.InsertQuestion(:num, 'Art : Repondre D', 'P');
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'A', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'B', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'C', 'non', 'N', :num);
EXECUTE GestionQuestions.InsertReponse(TRIM(:num)||'D', 'oui', 'Y', :num);
