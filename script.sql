CREATE TABLE PRODUTO(
 ID                UNIQUEIDENTIFIER   NOT NULL,
 NOME              NVARCHAR(100)      NOT NULL,
 PRECO             Decimal(18,2)       NOT NULL,
 QUANTIDADE        INTEGER          NOT NULL,
 DATADEVALIDADE      DATE             NOT NULL,
 
    PRIMARY KEY(ID))
    GO