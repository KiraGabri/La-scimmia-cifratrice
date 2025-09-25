-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Mag 26, 2021 alle 19:49
-- Versione del server: 10.4.17-MariaDB
-- Versione PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `monkey`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `mkeys`
--

CREATE TABLE `mkeys` (
  `IDKey` int(11) NOT NULL,
  `Utente_ID` int(11) DEFAULT NULL,
  `KeyLength` int(11) DEFAULT NULL,
  `valTrasposizione` varchar(510) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `mkeys`
--

INSERT INTO `mkeys` (`IDKey`, `Utente_ID`, `KeyLength`, `valTrasposizione`) VALUES
(4, 1, 8, '51 38 36 34 43 34 47 34'),
(5, 1, 13, '32 69 61 75 48 75 74 75 42 61 78 69 75'),
(6, 1, 25, '43 34 48 48 81 74 44 42 69 45 56 57 81 75 48 63 13 74 66 14 67 67 16 78 34'),
(7, 1, 36, '43 34 48 48 81 74 44 42 69 45 56 57 81 75 48 63 13 74 66 14 67 67 16 78 34 22 13 15 22 18 22 16 17 16 15 15'),
(8, 1, 50, '43 34 48 48 81 74 44 42 69 45 56 57 81 75 48 63 13 74 66 14 67 67 16 78 34 22 13 15 22 18 22 16 17 16 15 15 72 67 66 72 68 72 66 68 67 75 71 70 67 67'),
(9, 1, 9, '42 75 74 71 65 15 13 15 13'),
(10, 1, 15, '36 69 61 74 74 69 42 75 78 61 74 64 69 15 16'),
(11, 1, 17, '41 61 48 63 69 73 73 69 61 34 60 35 65 72 69 63 65'),
(12, 1, 10, '33 75 74 71 65 85 40 75 74 67'),
(13, 1, 115, '43 75 74 48 75 74 75 38 75 32 69 61 75 33 75 74 71 65 85 33 69 64 64 85 40 75 74 67 48 63 69 73 73 69 61 51 65 78 61 34 79 69 79 80 65 74 80 65 43 65 79 79 81 74 75 41 75 78 75 51 75 79 80 78 69 41 75 78 65 73 38 76 79 81 73 41 61 80 69 74 75 41 61 80 69 74 61 41 61 41 65 41 69 15 21 17 13 22 17 15 13 15 13 15 13 15 13 15 13 22 21 15 18 20 16'),
(14, 1, 3, '72 81 73'),
(15, 1, 1, '72'),
(16, 1, 3, '72 65 84'),
(17, 1, 4, '78 61 85 73');

-- --------------------------------------------------------

--
-- Struttura della tabella `mstrings`
--

CREATE TABLE `mstrings` (
  `IDStrings` int(11) NOT NULL,
  `Key_ID` int(11) DEFAULT NULL,
  `monkeyString` varchar(255) DEFAULT NULL,
  `CryptoString` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `mstrings`
--

INSERT INTO `mstrings` (`IDStrings`, `Key_ID`, `monkeyString`, `CryptoString`) VALUES
(1, 4, ';-?(_Or%0KT', '$3+.428j@?)'),
(2, 4, 'pIrUYAv[07:', '$3+.428j@?)'),
(3, 4, '5r]!KDbw[4+mGCO%-s{Ll17', '#+x)83@/8}1<4TdQeXST[Rb'),
(4, 8, 'i[A!JBf-Khk))/4', '!5BC?^}@vANk%}a'),
(5, 8, '!', 'g'),
(6, 4, 'p+H$D{8URt:n[RA~Nx8Ofcyl:^J+TUg6Vq&Gq{q,*', 'fV^V8<J:=:7&B0:<G=1-B-<)G=70:-BTgVYZ8RiU@'),
(7, 8, 'I`dcouNMWT05c2tb]K~]T,{e&N>Wo.hxkCa(`/1H$', '^Rje_eGBOAK>iY;Y}bOuZNyU6-|y$y)BD@DGUt||Q'),
(8, 8, '*dYl<sXoXw', '8^ll$z[]y`'),
(9, 8, '&j;)y0BU:tFr', '8~1l1*[Yu`ll'),
(10, 8, 'b9:elh0rTb@Msd=SRqB]pW`s1#Q2U[@$dKCz~%=HlRtU$', 'ylty;;rr3&z+B+?Y#RQ(ZR|i=0w%$~0&~{;;wprusxoDD'),
(11, 8, '!_', '+!'),
(12, 8, 'YDn', ',~1'),
(13, 8, '7iAt=WMpt35Tx[~}9xT)rn9F<j5~V.<+Ub,/iA6>BckMMDi0>Y~X5m5w*~GEqM|^g(mZ5aC)W8>8jUEKJZ9[:/mMF}a8M0jc?yG', ',~1JfO:DYDSG]Y9StXK}PI*]5{oy!${zz#~vTWUQO]UMW_SZLO++10RJ8*F68:^K9@uJKkOCt](zi~}t#u$&vx[WKTQfMMVXWXO'),
(14, 8, '#Z/HeQED4ijA$}qf?!h^b*;At^,.)iA[E.Q4Jg<#k&rp)I:b?PZMcD~2', 'z+BBef@5]HLDiK:@iJVjWClS0zsp-#|#r~`.hcbhdjdfdlh1YHA/:MoO'),
(15, 4, '[-5xpG^10kV(:IhP~3q&D54xr8]!P{>?1=3<*a1R)H0ua[12Lu/RQAB4DFjQ/u$_>Ca.f<ZY8P4;#fqg.W-b:1=whb=|gWh{ig[]JxMR@C', '8+=.8-9-;3793(=1>37.B8J-N=#A,CNC3G$!E9OBS+#!5&0~>4mivrsd~nolB-=n{unx!rwl+PNI-&7&J-;&19:ctJHG`[`Xh]X[e*;-=3'),
(16, 4, '35{yFW=TN/|D.=jR]bet/.dj/((', '8+=.8-9-;64@g^_Q+nfjpjbVgXX'),
(17, 8, 'Bwx3x1B)DKeAFb7ts){~(D>jajN', '0&I<_U65M=HW1+`oa6(U,/B&UHA'),
(18, 8, 'BCm2@w!', '0vxx(}a'),
(19, 8, 'bU9Hu06', '0vxx(}a'),
(20, 8, 'hlreIhn', '0vxx(}a'),
(21, 8, ',hOJwPW', '0vxx(}a'),
(22, 8, '(=cnUuJ', '0vxx(}a'),
(23, 8, '0PPwxrop(z><PIoH)fByw', '0v01rk_]l/qb{fGOobR$I'),
(24, 9, 'pYp,E|b+IgTd', '~_]Z:(|Pz7R^'),
(25, 9, '9y(KWDt3j=*x1dS4(', 'yTb_Z}|TmAdO`Ta%x'),
(26, 9, 'il|', 'weW'),
(27, 9, 'k%', 'AX'),
(28, 9, 'g6syi/58JS', 'y_]/Ncvpz='),
(29, 9, 'j92iv~(fjp', 'nXOZ9_{~V='),
(30, 12, 'Vg_`>', 'k^cPW'),
(31, 12, 'mvzOTO:t0', 'fXRO_E;^U'),
(32, 11, 'ea=!zwzMcf7m$Q$H=d', 'vB+H[VbJA*E3QM@LY.'),
(33, 13, 'qgc#ut;,<x!f*yt-X7#va}Q[JcIOD~,YDy`$#pL-=t4P?JqWU397FE*)[A1}CZrS1_S7dcZH..V*#E5xGWXW|$gE7|^,0do6fyfN8+rr@nnl=32uOM6kaicm', 'z_W(XO]9C8JUXn_aZ+m8R8Sh;~(yfy!)ig]3BN>!PF34$.}pKbppGdP;Sb9j#&,%~_#bU[7XZhR2IdRfb=O]KcS2J;T=Tt}s$,,}|x}w(t!~{*~|w|(1^WC`'),
(34, 13, ')6Z{xq', 'm[R=[O'),
(35, 13, 'v{ra{6Ba,VUmc%;P', 'm[R=[O<+F)WET9dO'),
(36, 13, '`y<v>{^>JpmRh@;x', 'm[R=[O<+F)WET9dO'),
(37, 13, 'PB6WUEug?#s{R$-&', 'm[R=[O<+F)WET9dO'),
(38, 13, 'OC%', '=_W'),
(39, 13, 'Ka', '8_'),
(40, 13, '5|', 'Ce'),
(41, 14, '(5', 'ak'),
(42, 4, 'qE.1&&!L@:qiy/IUNJFOWXjiF|<GS2WIaq#5TC%{K0v_7!I@@.DAXUUz@Bgn', 'K?)-65:5N1;<<9C5>2?~55C,G9WXa[`;@Y<?eRcZj_]XdZhZlPNLUTd[f`=V'),
(43, 15, '#98--CAqEQP@~sK2c5eMysg8hfsciFD+$jqJ3jp2W9s!WrX=-eS9Au6&LG4)', 'abMSS[S[dS`cY`][STdHR[]R][|!~%ybU|af%y|$!$$!$$$$$ssss{}%{%b}'),
(44, 15, '4|]>y-q/', 'WTQW]TQ]'),
(45, 15, 'D{%Mv=', 'z~z!$!'),
(46, 15, '|Nu/cI', 'z~z!$!'),
(47, 15, 'B;+Mln', 'z~z!$!'),
(48, 15, '>A~#10', 'z~z!$!'),
(49, 15, 'r/1`f)', 'z~z!$!'),
(50, 15, '+<ZBqg', 'z~z!$!'),
(51, 14, 'FdJ-T(', 'z+{!.#'),
(52, 14, 'a%ZIW^', 'z+{!.#'),
(53, 14, 'uZMcMq', 'z+{!.#'),
(54, 16, 'Yth#9eo', '@9C49L7'),
(55, 16, ']#fq%vF', '@9C49L7'),
(56, 16, 'y^dF(nH', '@9C49L7'),
(57, 16, 'c)OjuWJ', '@9C49L7'),
(58, 16, '[q,nvI+', '@9C49L7'),
(59, 16, 'eHPZ5|W', '@9C49L7'),
(60, 17, '?Jm12e:', 'F5D5F5D'),
(61, 11, 'PHW=b$&m.rL5q3sut111I$0', 'kSFL`N[X+jR(SPR6N;GCUdV'),
(62, 11, ']hYvOt&14FKMAfZVLp2SRUb', 'kSFL`N[X+jR(SPR6N;GCUdV'),
(63, 11, ')6oYsf<**', 'kSFL`N[X+'),
(64, 15, 'T<Lk', '0UM['),
(65, 4, 'U,YmR', '%/420'),
(66, 4, 'I<pA!~Jh', '{3)4=/A5'),
(67, 16, 'Zi~89)o7$', '9JhZFkPTL'),
(68, 4, 'ZDNM', 'u865');

-- --------------------------------------------------------

--
-- Struttura della tabella `musers`
--

CREATE TABLE `musers` (
  `IDUtente` int(11) NOT NULL,
  `NomeUtente` varchar(30) DEFAULT NULL,
  `Password` varchar(64) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `musers`
--

INSERT INTO `musers` (`IDUtente`, `NomeUtente`, `Password`) VALUES
(1, 'a', '-842352705'),
(2, 'b', '-842352706');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `mkeys`
--
ALTER TABLE `mkeys`
  ADD PRIMARY KEY (`IDKey`),
  ADD KEY `Utente_ID` (`Utente_ID`);

--
-- Indici per le tabelle `mstrings`
--
ALTER TABLE `mstrings`
  ADD PRIMARY KEY (`IDStrings`),
  ADD KEY `Key_ID` (`Key_ID`);

--
-- Indici per le tabelle `musers`
--
ALTER TABLE `musers`
  ADD PRIMARY KEY (`IDUtente`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `mkeys`
--
ALTER TABLE `mkeys`
  MODIFY `IDKey` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT per la tabella `mstrings`
--
ALTER TABLE `mstrings`
  MODIFY `IDStrings` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;

--
-- AUTO_INCREMENT per la tabella `musers`
--
ALTER TABLE `musers`
  MODIFY `IDUtente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `mkeys`
--
ALTER TABLE `mkeys`
  ADD CONSTRAINT `mkeys_ibfk_1` FOREIGN KEY (`Utente_ID`) REFERENCES `musers` (`IDUtente`);

--
-- Limiti per la tabella `mstrings`
--
ALTER TABLE `mstrings`
  ADD CONSTRAINT `mstrings_ibfk_1` FOREIGN KEY (`Key_ID`) REFERENCES `mkeys` (`IDKey`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
