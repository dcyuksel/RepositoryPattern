﻿create database RepositoryPattern;

CREATE TABLE Phones (
    [Id]            BIGINT IDENTITY(1,1) NOT NULL, 
    [Brand]         NVARCHAR(100)        NOT NULL,
    [Model]         NVARCHAR(100)        NOT NULL,
    [Price]         DECIMAL(18,2)        NOT NULL,
);

INSERT INTO Phones([Brand], [Model], [Price]) VALUES ('Apple',   '15',  999.99);
INSERT INTO Phones([Brand], [Model], [Price]) VALUES ('Apple',   '16',  1199.99);
INSERT INTO Phones([Brand], [Model], [Price]) VALUES ('Samsung', 's23', 599.99);
INSERT INTO Phones([Brand], [Model], [Price]) VALUES ('Samsung', 's24', 799.99);

CREATE TABLE Books (
    [Id]     BIGINT IDENTITY(1,1) NOT NULL, 
    [Name]   NVARCHAR(200)        NOT NULL,
    [Author] NVARCHAR(200)        NOT NULL,
    [Price]  DECIMAL(18,2)        NOT NULL,
);

INSERT INTO Books([Name], [Author], [Price]) VALUES ('Sapiens: A Graphic History: The Birth of Humankind', 'Yuval Noah Harari', 20.31);
INSERT INTO Books([Name], [Author], [Price]) VALUES ('On Freedom',                                         'Timothy Snyder',    24.55);
INSERT INTO Books([Name], [Author], [Price]) VALUES ('Book of Why',                                        'Judea Pearl',       13.80);
INSERT INTO Books([Name], [Author], [Price]) VALUES ('Causal Inference',                                   'Paul R. Rosenbaum', 11.99);