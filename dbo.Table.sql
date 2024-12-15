CREATE TABLE [dbo].[logintable]
(
    [Username] VARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [User Type] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_logintable] PRIMARY KEY ([Username])
)
