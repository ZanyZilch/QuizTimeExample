-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 15 dec 2023 om 09:34
-- Serverversie: 10.4.27-MariaDB
-- PHP-versie: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `quiztime`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `answer`
--

CREATE TABLE `answer` (
  `idAnswer` int(11) NOT NULL,
  `answerText` text NOT NULL,
  `image` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Gegevens worden geëxporteerd voor tabel `answer`
--

INSERT INTO `answer` (`idAnswer`, `answerText`, `image`) VALUES
(1, 'Abraham lincoln', ''),
(2, 'George Washingston', ''),
(3, 'Douwe Egbert', ''),
(4, 'Franklin', ''),
(5, '5 september 1915', ''),
(6, '10 juli 1850', ''),
(7, '18 juni 1815', ''),
(8, '18 juli 1820', ''),
(9, 'Zeptic', ''),
(10, 'bla', '...'),
(11, 'bla', '...'),
(12, 'testorino 0', 'C:\\Users\\Surface\\Pictures\\istockphoto-480560906-170667a.jpg'),
(13, 'testorino 0', 'C:\\Users\\Surface\\Pictures\\istockphoto-480560906-170667a.jpg'),
(14, 'Blehh', '...'),
(15, 'Blehh', '...'),
(16, 'Wat nu weer?', '...'),
(17, 'Wat nu weer?', '...'),
(18, 'Wowza!', '...'),
(19, 'Wowza!', '...'),
(20, 'Fotos erbij', 'C:\\Users\\Surface\\Downloads\\ad-image.png'),
(21, 'Fotos erbij', 'C:\\Users\\Surface\\Downloads\\ad-image.png'),
(22, '128x128', 'C:\\Users\\Surface\\Pictures\\Pix2d\\64x64\\gregor_64x64-removebg-preview.png'),
(23, '64x64', 'C:\\Users\\Surface\\Pictures\\Pix2d\\64x64\\gregor_64x64-removebg-preview.png'),
(24, 'la creatura 24', '...'),
(25, 'la creatura 24', '...'),
(26, 'Jowzers!', '...'),
(27, 'Jowzers!', '...'),
(28, 'la creatura 24', '...'),
(29, 'la creatura 24', '...'),
(30, 'meh...', '...'),
(31, 'meh...', '...'),
(32, 'Text', '...'),
(33, 'what...', '...'),
(34, 'what...', '...'),
(35, 'yes way', '...'),
(36, 'no way', '...'),
(37, 'oke', '...'),
(38, 'nee', '...'),
(39, 'true', '...'),
(40, 'false', '...'),
(41, 'oke', '...'),
(42, 'nee', '...'),
(43, '128x128', '...'),
(44, '64x64', '...');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `question`
--

CREATE TABLE `question` (
  `idQuestion` int(11) NOT NULL,
  `questionText` text NOT NULL,
  `image` varchar(255) NOT NULL,
  `idQuiz` int(11) DEFAULT NULL,
  `type` enum('multipleChoice','OneAnswer','','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Gegevens worden geëxporteerd voor tabel `question`
--

INSERT INTO `question` (`idQuestion`, `questionText`, `image`, `idQuiz`, `type`) VALUES
(6, 'Wie was de eerste president van de Verenigde Staten?', '', 1, 'OneAnswer'),
(7, 'Wanneer vond de Slag bij Waterloo plaats?', '', 1, 'OneAnswer'),
(8, 'Wat was de naam van de eerste ruimtevaarder?', '', 1, 'OneAnswer'),
(9, 'Welke dynastie regeerde over het oude Egypte?', '', 1, 'OneAnswer'),
(10, 'zo', 'kaas', 2, 'OneAnswer'),
(11, 'test', '', 2, 'OneAnswer'),
(12, 'Hoeveel teennagels waren er getelt tijdens de Olympische spelen van 1970?', '...', 2, 'OneAnswer'),
(13, 'Text', '...', 3, 'OneAnswer'),
(14, 'bla', '...', 3, 'OneAnswer'),
(15, 'testorino 0', 'C:\\Users\\Surface\\Pictures\\istockphoto-480560906-170667a.jpg', 3, 'OneAnswer'),
(16, 'Blehh', '...', 3, 'OneAnswer'),
(17, 'Wat nu weer?', '...', 1, 'OneAnswer'),
(21, 'ChatGPT', '...', 8, 'OneAnswer'),
(22, 'Wowza!', '...', 9, 'OneAnswer'),
(23, 'Fotos erbij', 'C:\\Users\\Surface\\Downloads\\ad-image.png', 9, 'OneAnswer'),
(24, 'Hoe groot is deze img?', 'C:\\Users\\Surface\\Pictures\\Pix2d\\64x64\\gregor_64x64-removebg-preview.png', 11, 'OneAnswer'),
(25, 'Text', '...', 6, 'OneAnswer'),
(26, 'Text', '...', 6, 'OneAnswer'),
(27, 'Text', '...', 6, 'OneAnswer'),
(28, 'Text', '...', 6, 'OneAnswer'),
(29, 'la creatura 24', '...', 12, 'OneAnswer'),
(30, 'Jowzers!', '...', 12, 'OneAnswer'),
(34, 'la creatura 24', '...', NULL, 'OneAnswer'),
(35, 'spooky', '...', NULL, 'OneAnswer'),
(36, 'huh', '...', 12, 'OneAnswer'),
(37, 'dit is oke', '...', 13, 'OneAnswer'),
(38, 'Waarom dan', '...', 13, 'OneAnswer');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `question_answer`
--

CREATE TABLE `question_answer` (
  `idQuestion` int(11) NOT NULL,
  `idAnswer` int(11) NOT NULL,
  `correct` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Gegevens worden geëxporteerd voor tabel `question_answer`
--

INSERT INTO `question_answer` (`idQuestion`, `idAnswer`, `correct`) VALUES
(6, 1, 1),
(6, 2, 0),
(6, 4, 0),
(6, 3, 0),
(7, 6, 0),
(7, 7, 1),
(7, 5, 0),
(7, 8, 0),
(13, 9, 1),
(15, 13, 0),
(16, 14, 0),
(16, 15, 1),
(17, 16, 0),
(17, 17, 0),
(22, 18, 0),
(22, 19, 0),
(23, 20, 0),
(23, 21, 0),
(24, 22, 0),
(24, 23, 0),
(29, 24, 0),
(29, 25, 0),
(30, 26, 0),
(37, 37, 1),
(37, 38, 0),
(38, 39, 1),
(38, 40, 0),
(36, 41, 1),
(36, 42, 0),
(24, 43, 0),
(24, 44, 1);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `quiz`
--

CREATE TABLE `quiz` (
  `idQuiz` int(11) NOT NULL,
  `Quizname` varchar(255) DEFAULT NULL,
  `Image` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Gegevens worden geëxporteerd voor tabel `quiz`
--

INSERT INTO `quiz` (`idQuiz`, `Quizname`, `Image`) VALUES
(1, 'geschiedenis quiz', NULL),
(2, 'sport quiz', NULL),
(3, 'test', NULL),
(4, 'NewQuiz', NULL),
(5, 'wat quiz', NULL),
(6, 'ladder 64x64', 'file:///C:/Users/Surface/Pictures/Pix2d/64x64/ladder_64x64-removebg-preview.png'),
(7, 'Pan', NULL),
(8, 'Labor comes with a price', NULL),
(9, '54 Process Memory', NULL),
(11, 'cavera', 'file:///C:/Users/Surface/Pictures/CaveraPNG.png'),
(12, 'Delete me for the cause!', 'file:///C:/Users/Surface/Pictures/Pix2d/64x64/monstrr_64x64-removebg-preview.png'),
(13, 'bla', 'file:///C:/Users/Surface/Pictures/Pix2d/64x64/gregor_64x64-removebg-preview.png');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `answer`
--
ALTER TABLE `answer`
  ADD PRIMARY KEY (`idAnswer`);

--
-- Indexen voor tabel `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`idQuestion`),
  ADD KEY `fk_quiz` (`idQuiz`);

--
-- Indexen voor tabel `question_answer`
--
ALTER TABLE `question_answer`
  ADD KEY `fkQAA` (`idAnswer`),
  ADD KEY `fkQAQ` (`idQuestion`);

--
-- Indexen voor tabel `quiz`
--
ALTER TABLE `quiz`
  ADD PRIMARY KEY (`idQuiz`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `answer`
--
ALTER TABLE `answer`
  MODIFY `idAnswer` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT voor een tabel `question`
--
ALTER TABLE `question`
  MODIFY `idQuestion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT voor een tabel `quiz`
--
ALTER TABLE `quiz`
  MODIFY `idQuiz` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `question`
--
ALTER TABLE `question`
  ADD CONSTRAINT `fk_quiz` FOREIGN KEY (`idQuiz`) REFERENCES `quiz` (`idQuiz`);

--
-- Beperkingen voor tabel `question_answer`
--
ALTER TABLE `question_answer`
  ADD CONSTRAINT `fkQAA` FOREIGN KEY (`idAnswer`) REFERENCES `answer` (`idAnswer`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fkQAQ` FOREIGN KEY (`idQuestion`) REFERENCES `question` (`idQuestion`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
