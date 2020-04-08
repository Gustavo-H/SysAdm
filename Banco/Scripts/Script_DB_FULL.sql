--Drop Das Tabelas-------------------------------------------------------------
-------------------------------------------------------------------------------
Drop Table If Exists TB_Permissao;
Drop Table If Exists TB_Funcionalidade;
Drop Table If Exists TB_Endereco
Drop Table If Exists TB_Bairro
Drop Table If Exists TB_Cidade
Drop Table If Exists TB_UF
Drop Table If Exists TB_Usuario;
Drop Table If Exists TB_Cliente
Go


--Create das Tabelas-----------------------------------------------------------
-------------------------------------------------------------------------------

Create Table TB_Usuario
(
	ID_Usuario Int Primary Key Identity(1,1) Not Null,
	Nm_Usuario Varchar(100) Not Null,
	Ds_Login Varchar(30) Unique Not Null,
	Ds_Senha Varchar(30) Not Null,
	Dt_Cadastro Varchar(22) Not Null,
	Dt_UltimoLogin Varchar(22) Not Null,
	Dt_Desativacao Varchar(22) Default '-',	
);

Create Table TB_Funcionalidade
(
	ID_Funcionalidade Int Primary Key Identity(1,1) Not Null,
	Ds_Funcionalidade varchar(50) Not Null
);

Create Table TB_Permissao
(
	ID_Funcionalidade Int Not Null,
	ID_Usuario Int Not Null,
	Primary Key(ID_Funcionalidade, ID_Usuario),
    Foreign Key (ID_Funcionalidade) References TB_Funcionalidade(ID_Funcionalidade),
	Foreign Key (ID_Usuario) References TB_Usuario(ID_Usuario)
);

Create Table TB_Cliente
(
	ID_Cliente Int Primary Key Identity(1,1) Not Null,
	Nm_Cliente Varchar(200) Not Null,
	CPF_Cliente Varchar(14) Unique,
	RG_Cliente Varchar(12),
	Dt_Nascimento Varchar(10),
	Ds_Telefone1 Varchar(20),
	Ds_Telefone2 Varchar(20),
	Dt_Cadastro Varchar(22) Not Null,
	Dt_Desativacao Varchar(22) Default '-'
);

Create Table TB_UF
(
	ID_UF Int Primary Key Identity(1,1) Not Null,
	Nm_UF Varchar(25) Not Null,
	Ds_AbrevUF Char(2) Not NUll
);

Create Table TB_Cidade
(
	ID_Cidade Int Primary Key Identity(1,1) Not Null,
	Nm_Cidade Varchar(30) Not Null,
	ID_UF Int Not Null,
	Foreign Key (ID_UF) References TB_UF(ID_UF)
);

Create Table TB_Bairro
(
	ID_Bairro Int Primary Key Identity(1,1) Not Null,
	Nm_Bairro Varchar(100) Not Null,
	ID_Cidade Int Not Null,
	Foreign Key (ID_Cidade) References TB_Cidade(ID_Cidade)
);

Create Table TB_Endereco
(
	ID_Endereco Int Primary Key Identity(1,1) Not Null,
	ID_Cliente Int Not Null,
	Nm_Rua Varchar(105),
	Ds_Complemento Varchar(100),
	Ds_CEP Varchar(9),
	ID_Bairro Int,
	Foreign Key (ID_Bairro) References TB_Bairro(ID_Bairro),
	Foreign Key (ID_Cliente) References TB_Cliente(ID_Cliente)
);


--Insert Das Tabelas-----------------------------------------------------------
-------------------------------------------------------------------------------

Insert Into TB_Funcionalidade values('Gerar Relatorios');
Insert Into TB_Funcionalidade values('Gereciar Emprestimos');
Insert Into TB_Funcionalidade values('Criar/Editar Usuarios');
Insert Into TB_Funcionalidade values('Criar/Editar Equipamentos');
Insert Into TB_Funcionalidade values('Excluir Usuarios/Senhas');  
Insert Into TB_Funcionalidade values('Visualizar Registro de Uso'); 

Insert Into TB_Usuario (Nm_Usuario, Ds_Login, Ds_Senha, Dt_Cadastro, Dt_UltimoLogin) 
	Values('Administrador', 'admin', 'admin', FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss'),
	FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss'));

Insert into TB_Permissao Values(1,1);
Insert into TB_Permissao Values(2,1);
Insert into TB_Permissao Values(3,1);
Insert into TB_Permissao Values(4,1);
Insert into TB_Permissao Values(5,1);
Insert into TB_Permissao Values(6,1);


Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Acre','AC'); 
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Alagoas','AL');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Amapá','AP');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Amazonas','AM');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Bahia','BA');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Ceará','CE');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Distrito Federal','DF');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Espírito Santo','ES');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Goiás','GO');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Maranhão','MA');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Mato Grosso','MT');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Mato Grosso do Sul','MS');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Minas Gerais','MG');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Pará','PA');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Paraíba','PB');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Paraná','PR');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Pernambuco','PE');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Piauí','PI');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Rio de Janeiro','RJ');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Rio Grande do Norte','RN');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Rio Grande do Sul','RS');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Rondônia','RO');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Roraima','RR');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Santa Catarina','SC');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('São Paulo','SP');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Sergipe','SE');
Insert Into TB_UF (Nm_UF, Ds_AbrevUF) Values ('Tocantins','TO');




Drop Procedure If Exists sp_Grid_User;
Drop Procedure If Exists sp_ValidarLogin
Drop Procedure If Exists sp_Set_DateLogin;

Go



GO

Create Procedure sp_Set_LoginDate(@pId int) AS 
Begin
Update TB_Usuario
Set Dt_UltimoLogin = FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss')
Where ID_Usuario = @pId;
End;
Go


Go
Create Procedure sp_ValidarLogin (@pLogin Varchar(30), @pSenha varchar(30))
As
Begin 
Select U.Id_Usuario As ID, U.Nm_Usuario As Nome, U.Dt_Cadastro As DataCadastro, U.Dt_UltimoLogin As UltimoLogin  --FORMAT(GETDATE(), 'dd.MM.yyyy hh:mm:ss')
From tb_Usuario as U
Where U.Ds_Prontuario = @pLogin 
And U.Ds_Senha = @pSenha
And U.Dt_Desativacao = '-'
End;

Go




Create Procedure sp_Grid_User (@pNm_Usuer varchar(100), @pDs_Login varchar(30)) AS 
Begin
Select U.ID_Usuario as ID, U.Nm_Usuario as Nome, U.Ds_Login as 'Login'
From TB_Usuario as U
Where (U.Nm_Usuario Like '%' + @pDs_Login + '%') 
And (U.Ds_Login Like '%' + @pDs_Login + '%')
And (U.Dt_Desativacao = '-')
END;
Go

Create Procedure sp_Del_User(@pID int)
AS 
Begin
	Update TB_Usuario
	Set Dt_Desativacao = FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss')
	Where ID_Usuario = @pID
End;
Go

Create Procedure sp_Del_PermissoesUsuario(@pID_Usuario int)
AS 
BEGIN
	Delete From TB_Permissao
	Where ID_Usuario = @pID_Usuario
END;
GO

Create Procedure sp_Upd_Usuario(@pNm_Usuario varchar(100), @pDs_Prontuario varchar(30), @pDs_Senha varchar(30), @pID_Usuario int) AS 
BEGIN
	UPDATE TB_Usuario
	SET Nm_Usuario = @pNm_Usuario, Ds_Prontuario = @pDs_Prontuario, Ds_Senha = @pDs_Senha
	WHERE ID_Usuario = @pID_Usuario
END;
GO

Create Procedure sp_ValidarProntuario(@pDs_Prontuario varchar(30))
AS 
BEGIN
	Select ID_Usuario as ID
	From TB_Usuario
	Where Ds_Login = @pDs_Prontuario
END;
go

Create Procedure sp_Sel_Usuario (@pId_Usuario int) AS 
BEGIN
Select U.Nm_Usuario as Nome, U.Ds_Prontuario as 'Login', U.Ds_Senha as Senha, U.Dt_Cadastro as DataCadastro,
	U.Dt_UltimoLogin as UltimoLogin
From TB_Usuario as U
Where U.ID_Usuario = @pId_Usuario;
END;
GO

Create Procedure sp_Sel_PermissoesUsuario(@pID_Usuario int)
AS 
BEGIN
	Select ID_Funcionalidade as ID
	From TB_Permissao
	Where ID_Usuario = @pID_Usuario
END;
GO

Create Procedure sp_Ins_Usuario(@pNm_Usuario varchar(100), @pDs_Prontuario varchar(30), @pDs_Senha varchar(30)) AS 
BEGIN
Declare @data varchar(20);
Set @data = FORMAT(GETDATE(), 'dd/MM/yyyy HH:mm:ss');
INSERT INTO TB_Usuario(Nm_Usuario, Ds_Prontuario, Ds_Senha, Dt_Cadastro, Dt_UltimoLogin)
VALUES(@pNm_Usuario, @pDs_Prontuario, @pDs_Senha, @data, @data)
Select @@IDENTITY As ID;
END;
GO

Create Procedure sp_Ins_PermissoesUsuario( @pID_Usuario int, @pID_Funcionalidade int) AS 
BEGIN
INSERT INTO TB_Permissao(ID_Funcionalidade , ID_Usuario)
VALUES(@pID_Funcionalidade, @pID_Usuario)
END;

GO




