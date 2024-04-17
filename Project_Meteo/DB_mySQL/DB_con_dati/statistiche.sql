-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Mar 22, 2024 alle 10:57
-- Versione del server: 10.4.32-MariaDB
-- Versione PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `meteotempo`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `statistiche`
--

CREATE TABLE `statistiche` (
  `id` int(50) NOT NULL,
  `temperatura` double(10,2) NOT NULL,
  `orario` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dump dei dati per la tabella `statistiche`
--

INSERT INTO `statistiche` (`id`, `temperatura`, `orario`) VALUES
(1, 20.45, '2024-03-01 16:25:03'),
(2, 5.00, '2024-03-02 04:19:43'),
(3, 16.00, '2024-03-03 13:45:36'),
(4, 22.00, '2024-03-04 14:56:21'),
(5, 13.32, '2024-03-05 10:22:56'),
(6, 16.00, '2024-03-06 16:29:57'),
(7, 13.00, '2024-03-07 17:35:34'),
(8, 20.00, '2024-03-08 17:37:19'),
(9, 17.76, '2024-03-09 17:45:27'),
(10, 10.45, '2024-03-10 07:33:31'),
(11, 16.96, '2024-03-11 13:37:29'),
(12, 9.43, '2024-03-12 22:36:30'),
(13, 16.30, '2024-03-13 14:17:44'),
(14, 22.44, '2024-03-14 16:04:51'),
(15, 17.00, '2024-03-15 13:47:31'),
(16, 5.89, '2024-03-16 02:34:29'),
(17, 9.00, '2024-03-17 10:29:07'),
(18, 17.00, '2024-03-18 17:20:44'),
(19, 13.00, '2024-03-19 15:37:26');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `statistiche`
--
ALTER TABLE `statistiche`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `statistiche`
--
ALTER TABLE `statistiche`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
