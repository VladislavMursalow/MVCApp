create database TODO_DB
use TODO_DB

create table Users(
	id int primary key identity(1,1) not null,
	LoginU nvarchar(50),
	Email nvarchar(50),
	PhoneNumber nvarchar(12),
	PasswordU nvarchar(50)
)

create table Categories (
	id int primary key identity(1,1) not null,
	NameC nvarchar(50)
)

create table Todos(
	id int primary key identity(1,1) not null,
	UserId int references Users(id),
	CategoryId int references Categories(id),
	Tittle nvarchar(50),
	DescriptionT nvarchar(255),
	isDone bit
)

insert into Categories(NameC) 
values
('Ñleaning'), ('Cooking')

insert into Users(LoginU, Email, PhoneNumber, PasswordU) 
values
('aboba', 'aboba@gmail.com', '0978420083', 'aboba123')

insert into Todos(UserId, CategoryId, Tittle, DescriptionT, isDone) 
values
(1,2,'Ñook a cake', 'For the biscuit:
Eggs - 6 pcs.
Sugar - 150 g
Flour - 200 g
Baking powder - 2 teaspoons
Vegetable oil or butter - for greasing parchment', 0)

select * from Categories
select * from Users
select * from Todos