--     Noms : Gabriel Fournier-Cloutier & Jérémie Lacroix
--    Date : 2019-03-29
--  Groupe : 02
-- Fichier : Creation de tables
--------------------------------------
--------------------- À NE PAS OUBLIER : DROP TABLE = Détruire les triggers aussi
--DROP TABLE CATEGORIES CASCADE CONSTRAINTS;
--DROP TABLE joueurs CASCADE CONSTRAINTS;
--DROP TABLE reponses CASCADE CONSTRAINTS;
--DROP TABLE questions CASCADE CONSTRAINTS;
--DROP TABLE scores CASCADE CONSTRAINTS;

CREATE SEQUENCE SEQ_V_NUMQUESTION MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
CREATE SEQUENCE SEQ_B_NUMQUESTION MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
CREATE SEQUENCE SEQ_O_NUMQUESTION MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
CREATE SEQUENCE SEQ_M_NUMQUESTION MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;

CREATE TABLE categories (
    codecategorie   CHAR(1) NOT NULL,
    nom             VARCHAR2(30),
    couleur         VARCHAR2(20)
);

ALTER TABLE categories ADD CONSTRAINT categories_pk PRIMARY KEY ( codecategorie );

CREATE TABLE joueurs (
    aliasjoueur   VARCHAR2(20) NOT NULL,
    nom           VARCHAR2(40),
    prenom        VARCHAR2(40)
);

ALTER TABLE joueurs ADD CONSTRAINT joueurs_pk PRIMARY KEY ( aliasjoueur );

CREATE TABLE questions (
    numquestion     CHAR(6) NOT NULL,
    enonce          CLOB,
    -- Indique si un joueur à correctement répondu à la question (dans la partie en cours)
    repondu         CHAR(1),
    codecategorie   CHAR(1) NOT NULL
);

ALTER TABLE questions ADD CONSTRAINT questions_pk PRIMARY KEY ( numquestion );
ALTER TABLE Questions ADD CONSTRAINT CK_repondu CHECK(repondu IN('Y', 'N'));

CREATE TABLE reponses (
    numreponse    CHAR(8) NOT NULL,
    description   CLOB,
    estbonne      CHAR(1),
    numquestion   CHAR(6) NOT NULL
);

ALTER TABLE reponses ADD CONSTRAINT reponses_pk PRIMARY KEY ( numreponse );
ALTER TABLE reponses ADD CONSTRAINT CK_estbonne CHECK(estbonne IN('Y', 'N'));

CREATE TABLE scores (
    codecategorie   CHAR(1) NOT NULL,
    aliasjoueur     VARCHAR2(20) NOT NULL,
    -- Indique le nombre de fois que le joueur à gagné dans une certaine catégories (dans toutes les parties)
    score           NUMBER(5),
    -- Indique si le joueur à gagné dans cette catégorie (dans la partie en cours)
    gagnee          CHAR(1)
);

ALTER TABLE scores ADD CONSTRAINT score_pk PRIMARY KEY ( codecategorie, aliasjoueur );
ALTER TABLE scores ADD CONSTRAINT CK_gagnee CHECK(gagnee IN('Y', 'N'));

ALTER TABLE questions
    ADD CONSTRAINT questions_categories_fk FOREIGN KEY ( codecategorie )
        REFERENCES categories ( codecategorie );

ALTER TABLE reponses
    ADD CONSTRAINT reponses_questions_fk FOREIGN KEY ( numquestion )
        REFERENCES questions ( numquestion );

ALTER TABLE scores
    ADD CONSTRAINT score_categories_fk FOREIGN KEY ( codecategorie )
        REFERENCES categories ( codecategorie );

ALTER TABLE scores
    ADD CONSTRAINT scores_joueurs_fk FOREIGN KEY ( aliasjoueur )
        REFERENCES joueurs ( aliasjoueur );
