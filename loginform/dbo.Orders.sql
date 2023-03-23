CREATE TABLE [dbo].[Orders] (
    [billID]      INT          NOT NULL,
    [employeeID]  VARCHAR (50) NOT NULL,
    [billDate]    VARCHAR (50) NOT NULL,
    [totalAmount] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([billID] ASC),
);

