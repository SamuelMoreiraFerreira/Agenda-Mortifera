CREATE DATABASE IF NOT EXISTS db_agenda;

USE db_agenda;

-- TABELA DE USUÁRIOS

CREATE TABLE IF NOT EXISTS tb_usuarios (
	pecado VARCHAR(20) NOT NULL,
	nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(20) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);