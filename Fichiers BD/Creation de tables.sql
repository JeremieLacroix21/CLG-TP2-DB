--DROP TABLE CATEGORIES CASCADE CONSTRAINTS;
--DROP TABLE joueurs CASCADE CONSTRAINTS;
--DROP TABLE reponses CASCADE CONSTRAINTS;
--DROP TABLE questions CASCADE CONSTRAINTS;
--DROP TABLE scores CASCADE CONSTRAINTS;

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
    score           NUMBER(5),
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
