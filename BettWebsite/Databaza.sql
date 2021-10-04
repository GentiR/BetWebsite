create database BettingWebsite

use BettingWebsite

create table Laliga(
match_id int primary key not null,
teamsName varchar(500) not null,
datat datetime not null,
score_home int not null,
score_away int not null,
moneys money not null
)

create table PremierLeague(
match_id int primary key not null,
teamsName varchar(500) not null,
datat datetime not null,
score_home int not null,
score_away int not null,
moneys money not null
)

create table SeriaA(
match_id int primary key not null,
teamsName varchar(500) not null,
datat datetime not null,
score_home int not null,
score_away int not null,
moneys money not null
)

create table Liga1(
match_id int primary key not null,
teamsName varchar(500) not null,
datat datetime not null,
score_home int not null,
score_away int not null,
moneys money not null
)

create table Bundesliga(
match_id int primary key not null,
teamsName varchar(500) not null,
datat datetime not null,
score_home int not null,
score_away int not null,
moneys money not null
)

drop table Laliga

insert into Laliga values(1, 'Barcelona vs Granada', getdate(), 3, 1, 100.0)
insert into Laliga values(2, 'Real Madrid vs Sevilla', getdate(), 2, 0, 51.50)
insert into Laliga values(3, 'Atletico Madrid vs Rayo Vallecano', getdate(), 1, 1, 10.50)

insert into PremierLeague values(1, 'Arsenal vs Man United', getdate(), 0, 4, 130.25)
insert into PremierLeague values(2, 'Chelsea F.C. vs Aston Villa', getdate(), 2, 2, 51.50)
insert into PremierLeague values(3, 'Leicester City vs Man City', getdate(), 1, 2, 2.50)
insert into PremierLeague values(4, 'Tottenham vs Brentford F.C.', getdate(), 3, 0, 1.20)
insert into PremierLeague values(5, 'West Ham vs Fulham F.C.', getdate(), 3, 4, 15.50)

insert into SeriaA values(1, 'Juventus vs Cagliari Calcio', getdate(), 2, 1, 10)
insert into SeriaA values(2, 'Genoa C.F.C vs ACF Fiorentina', getdate(), 3, 2, 1.50)
insert into SeriaA values(3, 'Torino F.C. vs Bologna FC', getdate(), 8, 1, 1.0)
insert into SeriaA values(4, 'Venezia FC vs A.C. Milan', getdate(), 2, 7, 0.50)
insert into SeriaA values(5, 'Inter Milan vs Atalanta B.C.', getdate(), 2, 4, 13.50)

insert into Liga1 values(1, 'AS Monaco vs FC Nantes', getdate(), 3, 0, 1.20)
insert into Liga1 values(2, 'Angers SCO vs Nîmes Olympique', getdate(), 8, 1, 1.0)
insert into Liga1 values(3, 'Inter Milan vs Atalanta B.C.', getdate(), 2, 4, 13.50)
insert into Liga1 values(4, 'PSG vs RC Lens', getdate(), 1, 1, 10.50)
insert into Liga1 values(5, 'SC Bastia vs SC Fives', getdate(), 2, 0, 51.50)

insert into Bundesliga values(1, 'Leverkusen vs SC Freiburg', getdate(), 3, 1, 200.10)
insert into Bundesliga values(2, 'Bayern Munich vs FC Augsburg', getdate(), 2, 0, 51.50)
insert into Bundesliga values(3, 'Hoffenheim vs Eintracht Frankfurt', getdate(), 1, 1, 34.50)
insert into Bundesliga values(4, '1. FC Köln vs Borussia Dortmund', getdate(), 4, 3, 65.50)
insert into Bundesliga values(5, 'RB Leipzig vs Rayo Vallecano', getdate(), 4, 5, 324.50)

select * from Laliga
select * from PremierLeague
select * from SeriaA
select * from Liga1
select * from Bundesliga
	