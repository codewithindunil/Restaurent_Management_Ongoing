-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 31, 2020 at 04:07 PM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restauretdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `itemlist_tb`
--

CREATE TABLE `itemlist_tb` (
  `id` int(11) NOT NULL,
  `itemCode` varchar(15) NOT NULL,
  `itemName` varchar(15) NOT NULL,
  `size` varchar(15) NOT NULL,
  `price` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `itemlist_tb`
--

INSERT INTO `itemlist_tb` (`id`, `itemCode`, `itemName`, `size`, `price`) VALUES
(1, '1', 'Butter Scotch P', 'Medium', '150'),
(2, '1', 'Butter Scotch P', 'Large', '250');

-- --------------------------------------------------------

--
-- Table structure for table `orders_tb`
--

CREATE TABLE `orders_tb` (
  `id` int(11) NOT NULL,
  `orderNo` varchar(15) NOT NULL,
  `itemCode` varchar(15) NOT NULL,
  `size` varchar(15) NOT NULL,
  `qty` varchar(15) NOT NULL,
  `eachPrice` varchar(15) NOT NULL,
  `total` varchar(15) NOT NULL,
  `date` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orders_tb`
--

INSERT INTO `orders_tb` (`id`, `orderNo`, `itemCode`, `size`, `qty`, `eachPrice`, `total`, `date`) VALUES
(13, '1', '1', 'Medium', '2', '150', '300', '2312'),
(20, '2', '1', 'Medium', '1', '150', '150', '3/31/2020 2:36:'),
(21, '2', '1', 'Medium', '2', '150', '300', '3/31/2020 2:36:'),
(22, '2', '1', 'Large', '1', '250', '250', '3/31/2020 2:36:'),
(23, '3', '1', 'Medium', '2', '150', '300', '3/31/2020 3:20:'),
(24, '4', '1', 'Medium', '2', '150', '300', '3/31/2020 3:24:'),
(25, '4', '1', 'Large', '2', '250', '500', '3/31/2020 3:25:'),
(26, '5', '1', 'Medium', '2', '150', '300', '3/31/2020 3:25:'),
(27, '5', '1', 'Large', '2', '250', '500', '3/31/2020 3:26:'),
(28, '6', '1', 'Medium', '2', '150', '300', '3/31/2020 3:29:'),
(29, '6', '1', 'Large', '3', '250', '750', '3/31/2020 3:29:'),
(30, '7', '1', 'Medium', '2', '150', '300', '3/31/2020 6:38:'),
(31, '7', '1', 'Large', '3', '250', '750', '3/31/2020 6:39:'),
(32, '8', '1', 'Medium', '2', '150', '300', '3/31/2020 6:40:'),
(33, '8', '1', 'Large', '2', '250', '500', '3/31/2020 6:40:'),
(34, '8', '1', 'Large', '23', '250', '5750', '3/31/2020 6:41:'),
(35, '9', '1', 'Medium', '2', '150', '300', '3/31/2020 6:41:'),
(36, '9', '1', 'Large', '1', '250', '250', '3/31/2020 6:42:'),
(37, '10', '1', 'Large', '2', '250', '500', '3/31/2020 6:44:'),
(38, '10', '1', 'Large', '2', '250', '500', '3/31/2020 6:44:'),
(39, '10', '1', 'Medium', '34', '150', '5100', '3/31/2020 6:44:'),
(40, '10', '1', 'Medium', '2', '150', '300', '3/31/2020 6:49:'),
(41, '10', '1', 'Medium', '2', '150', '300', '3/31/2020 6:52:'),
(42, '10', '1', 'Large', '2', '250', '500', '3/31/2020 6:52:'),
(43, '10', '1', 'Medium', '22', '150', '3300', '3/31/2020 7:00:'),
(44, '10', '1', 'Medium', '3', '150', '450', '3/31/2020 7:00:'),
(45, '10', '1', 'Large', '3', '250', '750', '3/31/2020 7:01:'),
(46, '10', '1', 'Medium', '4', '150', '600', '3/31/2020 7:03:'),
(47, '10', '1', 'Large', '4', '250', '1000', '3/31/2020 7:03:'),
(48, '10', '1', 'Medium', '2', '150', '300', '3/31/2020 7:31:'),
(49, '10', '1', 'Large', '2', '250', '500', '3/31/2020 7:31:');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(15) NOT NULL,
  `email` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `itemlist_tb`
--
ALTER TABLE `itemlist_tb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `orders_tb`
--
ALTER TABLE `orders_tb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `itemlist_tb`
--
ALTER TABLE `itemlist_tb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `orders_tb`
--
ALTER TABLE `orders_tb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
