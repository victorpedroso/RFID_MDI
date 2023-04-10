-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 10-Abr-2023 às 22:07
-- Versão do servidor: 10.4.27-MariaDB
-- versão do PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sistemacontroleacesso`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `associado`
--

CREATE TABLE `associado` (
  `Id` int(11) NOT NULL,
  `Nome` varchar(255) DEFAULT NULL,
  `Cpf` varchar(100) DEFAULT NULL,
  `Telefone` varchar(100) DEFAULT NULL,
  `Endereco` varchar(255) DEFAULT NULL,
  `DataCadastro` datetime DEFAULT NULL,
  `Tag_id` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `associado`
--

INSERT INTO `associado` (`Id`, `Nome`, `Cpf`, `Telefone`, `Endereco`, `DataCadastro`, `Tag_id`) VALUES
(1, 'teste', '1234567890', '1213434353', 'teste', '2023-04-03 20:20:37', '0000000xf'),
(6, 'victor opedrisi', '42483274823', '47284728', 'heuhuehfue', '2023-04-04 22:04:08', '42483274823'),
(7, 'victor pedroso', '12345789', '12981621831731', 'rua dr milton', '2023-04-04 22:05:34', '12345789');

-- --------------------------------------------------------

--
-- Estrutura da tabela `datasdeacesso`
--

CREATE TABLE `datasdeacesso` (
  `IdData` int(11) NOT NULL,
  `DataHorario` datetime DEFAULT NULL,
  `Nome` varchar(255) NOT NULL,
  `Data` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `datasdeacesso`
--

INSERT INTO `datasdeacesso` (`IdData`, `DataHorario`, `Nome`, `Data`) VALUES
(1, '2022-12-27 08:26:49', 'teste', '27/12/2022'),
(2, '2023-04-04 08:26:49', 'teste2', '04/04/2023');

-- --------------------------------------------------------

--
-- Estrutura da tabela `niveisdeacesso`
--

CREATE TABLE `niveisdeacesso` (
  `IdNivel` int(11) NOT NULL,
  `NomeNivel` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tag`
--

CREATE TABLE `tag` (
  `idTag` int(11) NOT NULL,
  `NumeroTag` varchar(255) NOT NULL,
  `IdAssociado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `idUsuario` int(11) NOT NULL,
  `NomeUsuario` varchar(255) DEFAULT NULL,
  `CpfUsuario` varchar(100) DEFAULT NULL,
  `idNivel` int(11) NOT NULL,
  `DataCadastro` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `associado`
--
ALTER TABLE `associado`
  ADD PRIMARY KEY (`Id`);

--
-- Índices para tabela `datasdeacesso`
--
ALTER TABLE `datasdeacesso`
  ADD PRIMARY KEY (`IdData`);

--
-- Índices para tabela `niveisdeacesso`
--
ALTER TABLE `niveisdeacesso`
  ADD PRIMARY KEY (`IdNivel`);

--
-- Índices para tabela `tag`
--
ALTER TABLE `tag`
  ADD PRIMARY KEY (`idTag`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idUsuario`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `associado`
--
ALTER TABLE `associado`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `datasdeacesso`
--
ALTER TABLE `datasdeacesso`
  MODIFY `IdData` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `niveisdeacesso`
--
ALTER TABLE `niveisdeacesso`
  MODIFY `IdNivel` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tag`
--
ALTER TABLE `tag`
  MODIFY `idTag` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
