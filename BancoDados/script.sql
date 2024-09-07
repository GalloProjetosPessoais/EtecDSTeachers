create database DSTeachers;

use DSTeachers;

create table genero
(
    id   int not null auto_increment primary key,
    nome varchar(30),
    cor  varchar(30)
);

INSERT INTO genero VALUES
    (1, 'Rock', 'rgba(139, 0, 0, 1)'),    -- Rock: Deep Red
    (2, 'Pop', 'rgba(255, 20, 147, 1)'),  -- Pop: Deep Pink
    (3, 'Country', 'rgba(210, 105, 30, 1)'), -- Country: Chocolate Brown
    (4, 'Pagode', 'rgba(255, 165, 0, 1)'),   -- Pagode: Orange
    (5, 'Discoteca', 'rgba(75, 0, 130, 1)'); -- Discoteca: Indigo

create table professor
(
    id              int not null auto_increment primary key,
    nome            varchar(50),
    apelido         varchar(20),
    dataNascimento  date,
    foto            varchar(200),
    audio           varchar(200),
    audioGeneroId   int,
    foreign key (audioGeneroId) references genero(id)
);

insert into professor values
    (1, 'José Antonio Gallo Junior', 'Gallo', '1981-08-05', '/img/professores/gallo.png', '/audio/gallo.mp3', 1),
    (2, 'Márcio Jesus de Morais', 'Márcio', '1975-09-20', '/img/professores/marcio.png', '/audio/marcio.mp3', 1),
    (3, 'Edriano Carlos Campana', 'Edriano', '1978-09-30', '/img/professores/edriano.png', '/audio/edriano.mp3', 3),
    (4, 'Rosiene C. Tondelli Casale', 'Rose', '1975-02-05', '/img/professores/rosiene.png', '/audio/rosiene.mp3', 2),
    (5, 'Valdemir de Assis Pedro', 'Val', '1980-02-05', '/img/professores/valdemir.png', '/audio/valdemir.mp3', 2),
    (6, 'Ronan Adriel Zenatti', 'Ronan', '1990-01-01', '/img/professores/ronan.png', '/audio/ronan.mp3', 4)
    (7, 'Marcos Paulo Bressanin', 'Mortadela', '1980-01-01', '/img/professores/marcos.png', '/audio/marcos.mp3', 5),
    (8, 'Everton Steiner Galli', 'Galli', '1981-01-01', '/img/professores/galli.png', '/audio/galli.mp3', 3);
