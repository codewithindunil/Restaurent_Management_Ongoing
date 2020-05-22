-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 22, 2020 at 11:12 AM
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
(69, '10', '1', 'Large', '2', '250', '500', '4/4/2020 8:03:2'),
(70, '10', '1', 'Medium', '6', '150', '900', '4/4/2020 8:51:0'),
(71, '10', '1', 'Medium', '6', '150', '900', '4/4/2020 8:51:1'),
(72, '10', '1', 'Medium', '1', '150', '150', '5/22/2020 1:01:'),
(73, '10', '1', 'Medium', '1', '150', '150', '5/22/2020 1:01:'),
(74, '10', '1', 'Medium', '2', '150', '300', '5/22/2020 1:01:'),
(75, '10', '1', 'Medium', '2', '150', '300', '5/22/2020 1:01:'),
(76, '10', '1', 'Medium', '2', '150', '300', '5/22/2020 1:01:'),
(77, '10', '1', 'Medium', '14', '150', '2100', '5/22/2020 1:16:'),
(78, '10', '1', 'Medium', '99', '150', '14850', '5/22/2020 1:22:'),
(79, '10', '1', 'Medium', '123', '150', '18450', '5/22/2020 1:28:'),
(80, '10', '1', 'Medium', '2', '150', '300', '5/22/2020 2:35:'),
(81, '10', '1', 'Large', '2', '250', '500', '5/22/2020 2:35:'),
(82, '10', '1', 'Medium', '3', '150', '450', '5/22/2020 2:36:'),
(83, '10', '1', 'Large', '4', '250', '1000', '5/22/2020 2:36:'),
(84, '11', '1', 'Medium', '5', '150', '750', '5/22/2020 2:39:'),
(85, '11', '1', 'Large', '10', '250', '2500', '5/22/2020 2:39:');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=86;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
