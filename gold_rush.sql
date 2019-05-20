-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 20, 2019 at 06:58 PM
-- Server version: 5.6.38
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gold_rush`
--
CREATE DATABASE IF NOT EXISTS `gold_rush` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `gold_rush`;

-- --------------------------------------------------------

--
-- Table structure for table `boards`
--

CREATE TABLE `boards` (
  `id` int(11) NOT NULL,
  `x_axis` int(11) DEFAULT NULL,
  `y_axis` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `boards_golds`
--

CREATE TABLE `boards_golds` (
  `id` int(11) NOT NULL,
  `board_id` int(11) NOT NULL,
  `gold_tnt_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `golds_tnts`
--

CREATE TABLE `golds_tnts` (
  `id` int(11) NOT NULL,
  `unmined_gold` tinyint(1) DEFAULT NULL,
  `tnt` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `players`
--

CREATE TABLE `players` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `player_gold` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `players_golds`
--

CREATE TABLE `players_golds` (
  `id` int(11) NOT NULL,
  `player_id` int(11) DEFAULT NULL,
  `gold_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `prospectors`
--

CREATE TABLE `prospectors` (
  `id` int(11) NOT NULL,
  `phrases` varchar(255) NOT NULL,
  `win` tinyint(1) NOT NULL,
  `lose` tinyint(1) NOT NULL,
  `intro` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `boards`
--
ALTER TABLE `boards`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `boards_golds`
--
ALTER TABLE `boards_golds`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `golds_tnts`
--
ALTER TABLE `golds_tnts`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `players`
--
ALTER TABLE `players`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `players_golds`
--
ALTER TABLE `players_golds`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `prospectors`
--
ALTER TABLE `prospectors`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `boards`
--
ALTER TABLE `boards`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `boards_golds`
--
ALTER TABLE `boards_golds`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `golds_tnts`
--
ALTER TABLE `golds_tnts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `players`
--
ALTER TABLE `players`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `players_golds`
--
ALTER TABLE `players_golds`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `prospectors`
--
ALTER TABLE `prospectors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
