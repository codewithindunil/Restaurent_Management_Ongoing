-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2020 at 02:02 PM
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
  `price` varchar(15) NOT NULL,
  `availability` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `itemlist_tb`
--

INSERT INTO `itemlist_tb` (`id`, `itemCode`, `itemName`, `size`, `price`, `availability`) VALUES
(1, '1', 'Butter Scotch P', 'Medium', '150', ''),
(2, '1', 'Butter Scotch P', 'Large', '250', ''),
(3, '2', 'test', 'test', 'test', ''),
(4, '3', 'test', 'test', 'test', '');

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
(49, '10', '1', 'Large', '2', '250', '500', '3/31/2020 7:31:'),
(50, '10', '1', 'Medium', '2', '150', '300', '4/4/2020 1:49:1'),
(51, '10', '1', 'Large', '3324', '250', '831000', '4/4/2020 1:50:0'),
(52, '10', '1', 'Medium', '22', '150', '3300', '4/4/2020 1:51:3'),
(53, '10', '1', 'Medium', '2', '150', '300', '4/4/2020 1:55:0'),
(54, '10', '1', 'Medium', '2', '150', '300', '4/4/2020 1:55:5'),
(55, '10', '1', 'Large', '5', '250', '1250', '4/4/2020 1:57:3'),
(56, '10', '1', 'Medium', '2', '150', '300', '4/4/2020 1:59:0'),
(57, '10', '1', 'Medium', '1', '150', '150', '4/4/2020 7:05:4'),
(58, '10', '1', 'Large', '2', '250', '500', '4/4/2020 7:06:2'),
(59, '10', '1', 'Large', '2', '250', '500', '4/4/2020 7:06:4'),
(60, '10', '1', 'Medium', '1', '150', '150', '4/4/2020 7:08:4'),
(61, '10', '1', 'Large', '3', '250', '750', '4/4/2020 7:13:4'),
(62, '10', '1', 'Medium', '3', '150', '450', '4/4/2020 7:14:1'),
(63, '10', '1', 'Medium', '4', '150', '600', '4/4/2020 7:14:3'),
(64, '10', '1', 'Medium', '3', '150', '450', '4/4/2020 7:23:4'),
(65, '10', '1', 'Large', '2', '250', '500', '4/4/2020 7:41:3'),
(66, '10', '1', 'Medium', '2', '150', '300', '4/4/2020 7:58:1'),
(67, '10', '1', 'Medium', '2', '150', '300', '4/4/2020 7:58:1'),
(68, '10', '1', 'Medium', '2', '150', '300', '4/4/2020 7:59:2'),
(69, '10', '1', 'Large', '2', '250', '500', '4/4/2020 8:03:2'),
(70, '10', '1', 'Medium', '6', '150', '900', '4/4/2020 8:51:0'),
(71, '10', '1', 'Medium', '6', '150', '900', '4/4/2020 8:51:1');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(15) NOT NULL,
  `email` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  `privilages` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `password`, `privilages`) VALUES
(1, 'indunil', 'asdasd', '123', ''),
(2, 'admin', 'admin', 'admin', '1');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `orders_tb`
--
ALTER TABLE `orders_tb`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
