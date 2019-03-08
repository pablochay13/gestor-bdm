-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-02-2019 a las 17:15:13
-- Versión del servidor: 10.1.32-MariaDB
-- Versión de PHP: 5.6.36

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd-media`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `abrev_hoteles`
--

CREATE TABLE `abrev_hoteles` (
  `id` int(11) NOT NULL,
  `hotel` varchar(95) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `abreviatura_hotel` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `abrev_hoteles`
--

INSERT INTO `abrev_hoteles` (`id`, `hotel`, `abreviatura_hotel`) VALUES
(1, 'Brisas', 'BR'),
(2, 'Krystal', 'KR'),
(3, 'Hilton', 'HL'),
(4, 'Barcelo', 'BC'),
(5, 'Occidental', 'OC'),
(6, 'Bahia Principe', 'BP'),
(7, 'Park Royal', 'PR'),
(8, 'Gpo Vistana Westin', 'VW'),
(9, 'Playa Resorts', 'PL'),
(10, 'Seadust', 'SD'),
(11, 'Palace Resorts', 'PLC'),
(12, 'Atelier', 'ATL'),
(13, 'Oasis', 'OA'),
(14, 'Paradisus', 'PPC'),
(15, 'Isla Huatulco', 'IH'),
(16, 'Park Inn By Radisson', 'PINB'),
(17, 'AM RESORTS', 'AM'),
(18, 'Holiday Inn Express Guadalajara Aeropuerto', 'EMO'),
(19, 'SANDOS', 'SAN'),
(20, 'PRINCESS MEXICO', 'PRSS'),
(21, 'BEST WESTERN PLUS PUEBLA', 'BWP'),
(22, 'BEST WESTERN PLUS GRAND HOTEL MORELIA', 'BWP'),
(23, 'BEST WESTERN PLUS POSADA DE DON VASCO', 'VW'),
(24, 'PRINCESS HOTEL & RESORTS REPUBLICA DOMINICANA', 'PRSS'),
(25, 'MANSION DEL CANTADOR', 'MDC'),
(26, 'Courtyard By Marriott Monterrey Aeropuerto', 'OPTIMA'),
(27, 'Microtel Inn and Suites by Wyndham Culiacan', 'WYND'),
(28, 'Hampton Inn Guadalajara Aeropuerto', 'OPTIMA'),
(29, 'Courtyard By Marriott Monterrey San Jeronimo Valle', 'OPTIMA'),
(30, 'Corporativo Brisas', 'BR'),
(31, 'HOTEL RADISSON MONTERREY SAN JERONIMO', 'PRSS'),
(32, 'Hilton Garden Inn Veracruz Boca del Rio', 'OPTIMA'),
(33, 'GRAND VELAS  RIVIERA MAYA', 'BETE'),
(34, 'GRAND VELAS LOS CABOS', 'BETE'),
(35, 'GRAND VELAS RIVIERA NAYARIT', 'BETE'),
(36, 'CASAS VELAS', 'BETE'),
(37, 'SAN DIEGO TOURISM AUTHORITY', 'USA'),
(38, 'TRANSPORTES CANCUN SEA ADVENTURES', 'TCSA'),
(39, 'CANCUN PASSION', 'CPSS'),
(40, 'HOTEL REAL DE CHAPALA, VILLAS DANZA DEL SOL, CABO BLANCO HOTEL & MARINA', 'UAG'),
(41, 'Valentin Imperial Riviera Maya', 'VAL'),
(42, 'HOTELES SOLARIS', 'VSOL');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `abrev_pauta`
--

CREATE TABLE `abrev_pauta` (
  `id` int(11) NOT NULL,
  `nombre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `abreviatura_pauta` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `abrev_pauta`
--

INSERT INTO `abrev_pauta` (`id`, `nombre`, `abreviatura_pauta`) VALUES
(1, 'Marketing Fund', 'MKF'),
(2, 'Media', 'MD'),
(3, 'BD Travel', 'BDT'),
(4, 'Marketing-Media COO', 'MKMMDCO'),
(5, 'Cooperados', 'COO'),
(6, 'Cash', 'CASH'),
(7, 'OI Modificatoria', 'MOD');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `account_manager`
--

CREATE TABLE `account_manager` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `area` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `account_manager`
--

INSERT INTO `account_manager` (`id`, `nombre`, `area`, `correo`) VALUES
(1, 'Vinicius De Melo Rizato', 'null', 'accountmanager3@bestday.com'),
(2, 'Bettina Bonett Paludo', 'null', 'null'),
(3, 'Genaro Emmanuel Orduña Calvillo', 'null', 'null'),
(4, 'German Hoth Palmerin', 'null', 'null'),
(5, 'Yudilia Marisol Chan Cruz', 'null', 'null');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `archivos`
--

CREATE TABLE `archivos` (
  `id_archivos` int(11) NOT NULL,
  `nombre_archivo` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `ruta_archivo` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `saldos_id_saldos` varchar(45) CHARACTER SET latin1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `centro_beneficio`
--

CREATE TABLE `centro_beneficio` (
  `id` int(11) NOT NULL,
  `region` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `negociacion` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `centro_beneficio` varchar(30) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cuenta` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `centro_beneficio`
--

INSERT INTO `centro_beneficio` (`id`, `region`, `negociacion`, `centro_beneficio`, `cuenta`) VALUES
(1, 'MX ', 'MEDIA', 'M10XMED000', '4000100017 - Ingresos por publicidad'),
(2, 'MX ', 'Marketing Fund', 'M10XMED000', '4000100017 - Ingresos por publicidad'),
(3, 'MX ', 'Cash In', 'M10XMED000', '4000100017 - Ingresos por publicidad'),
(4, 'MX ', 'Años Anteriores', 'M10XMED000', '4000100017 - Ingresos por publicidad'),
(5, 'MX ', 'BD Travel', 'M10ICUNFIT', '4000100017 - Ingresos por publicidad'),
(6, 'MX ', 'Marketing-Media COO', 'M10XMED000', '4000100017 - Ingresos por publicidad'),
(7, 'MX ', 'Marketing-Media COO', 'M10XCOM000', '6000299000 - Refacturación Costes Publicidad'),
(8, 'MX ', 'Externos', 'M10XMED000', '4000100017 - Ingresos por publicidad'),
(9, 'NORT&CA', 'MEDIA', 'M10XMED000', '4000100017 - Ingresos por publicidad'),
(10, 'RO, AND, CEN', 'MEDIA', '4-2-02-02-000', 'Ingresos por Publicidad Particulares B2C'),
(11, 'RO, AND, CEN', 'Marketing Fund', '4-2-02-02-000', 'Ingresos por Publicidad Particulares B2C'),
(12, 'BRA', 'MEDIA', 'No aplica', 'No aplica'),
(13, 'BRA', 'Marketing Fund', 'No aplica', 'No aplica'),
(14, 'RED', 'Cash In', 'No aplica', 'No aplica');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id_clientes` int(110) NOT NULL,
  `region` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `id_hanna` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `razon_social` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `nombre_comercial` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `siglas_hanna` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sigla_hoteles` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `abrev_hotel` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id_clientes`, `region`, `id_hanna`, `razon_social`, `nombre_comercial`, `siglas_hanna`, `sigla_hoteles`, `abrev_hotel`) VALUES
(1, 'MX', '5000896', 'LA ISLA HUATULCO, S.A. DE C.V.', 'LA ISLA HUATULCO AND BEACH CLUB', 'LIHBC', 'Isla Huatulco', 'IH'),
(2, 'MX', '5000466', 'PROMOTORA PUNTA NIZUC. S.A DE C.V', 'Nizuc Resort and Spa ', 'NRS', 'NIZUC', 'NIZUC'),
(3, 'MX', '5001391', 'Operadora Hacienda del Mar, S.A. de C.V.', 'Sheraton grand los cabos hacienda del mar.', 'SGCH', 'SHERATON', 'SHE'),
(4, 'MX', '5000937', 'Inmobiliaria Valiant S DE RL DE CV', 'MARRIOTT RESORT PUERTO VALLARTA', 'MRPV', 'MARRIOTT PTO VALLARTA', 'MARRPTO'),
(5, 'MX', '5001392', 'Inversiones Turisticas Cancun, S.A. de C.V.', 'Jw marriott cancun resort & spa', 'JMCRS', 'MARRIOTT CANCUN', 'MARRCUN'),
(6, 'MX', '5000884', 'Inmobiliaria Canopo, S.A de C.V', 'Marriott Cancun Resort', 'MCR', 'MARRIOTT CANCUN', 'MARRCUN'),
(7, 'MX', '5000582', 'HOTELES VALLARTA 205, S. DE RL. DE CV.', 'Westin puerto vallarta', 'WPV', 'WESTIN', 'WESTIN'),
(8, 'MX', '5000638', 'Sabeldos SA de CV ', 'Catalonia Hoteles', 'CH', 'CATALONIA', 'CATA'),
(9, 'NORT&CA', '5000557', 'PALMILLA NV', 'MAJESTIC RESORTS', 'MR', 'MAJESTIC', 'MAJESTIC'),
(10, 'MX', '5000963', 'MANSION DEL CANTADOR, SA DE CV', 'MANSION DEL CANTADOR', 'MC', 'CANTADOR', 'CANTA'),
(11, 'MX', '5000673', 'Grupo Hotelero H de A SA de CV', 'Best Western Plus Gran Hotel Morelia ', 'BWPGHM', 'BEST WESTERN', 'BWP'),
(12, 'MX', '5000252', 'OPERADORA DEL HOTEL VILLA MONTAÑA,S.A. DE C.V.', 'VILLA MONTAÑA HOTEL & SPA', 'VMHS', 'MONTAÑA', 'MONT'),
(13, 'MX', '5000047', 'ADMINISTRACION DE HOTELES CONTINENTAL, SA DE CV', 'BEST WESTERN PLUS PUEBLA', 'BWPP', 'BEST WESTERN', 'BWP'),
(14, 'MX', '5000187', 'OPERADORA DIANA DEL BOSQUE S.A DE C. V', 'DIANA DEL BOSQUE, HOTEL VICTORIA, CASA DE LOS DULCES SUEÑOS', 'DB,HV,CDS', 'BOSQUE', 'BOSQUE'),
(15, 'MX', '5000326', 'OPERADORA TURISTICA TARIACURI, SA DE CV', 'HOWARD JOHNSON DE LA CALLE REAL', 'HJCR', 'HOWARD', 'HOWARD'),
(16, 'MX', '5000128', 'CONCORD INN OPERADORA S.A DE C.V', 'HOTELES BF', 'HB', 'BF', 'BF'),
(17, 'MX', '5000276', 'OPERADORA NORMANDIE, S.A. DE C.V.', 'CANTERA DIEZ BOUTIQUE', 'CDB', 'CANTERA', 'CANTERA'),
(18, 'MX', '5000189', 'OPERADORA DESIRE SAPI DE CV', 'DESIRE RIVIERA MAYA PEARL RESORT / DESIRE RIVIERA MAYA RESORT', 'DRMPR/DRMR', 'DESIRE', 'DESIRE'),
(19, 'MX', '5000189', 'OPERADORA DESIRE SAPI DE CV', 'TEMPTATION CANCUN RESORT', 'TCR', 'TEMPTATION', 'TEMP'),
(20, 'MX', '5000189', 'OPERADORA DESIRE SAPI DE CV', 'TEMPTATION CANCUN RESORT', 'TCR', 'TEMPTATION', 'TEMP'),
(21, 'MX', '5001392', 'INVERSIONES TURISTICA CANCUN, SA DE CV', 'JM MARRIOTT CANCUN', 'JWC', 'MARRIOTT CANCUN', 'MARRCUN'),
(22, 'MX', '5000210', 'OPERADORA HOTELERA BRISAS, S.A. DE C.V.', 'CORPORATIVO', 'CORPOR.', 'Brisas', 'BR'),
(23, 'MX', '5000494', 'PROMOTORA TURISTICA PUNTA BETE SAPI DE CV', 'CASA VELAS', 'CVELAS', 'CASA', 'BETE'),
(24, 'MX', '5001253', 'PROMOTORA TURISTICA PUNTA BETE SAPI DE CV', 'GRAND VELAS LOS CABOS', 'GVC', 'GRAND', 'BETE'),
(25, 'MX', '5001252', 'PROMOTORA TURISTICA PUNTA BETE SAPI DE CV', 'GRAND VELAS NAYARIT', 'GVN', 'NAYARIT', 'BETE'),
(26, 'MX', '5001254', 'PROMOTORA TURISTICA PUNTA BETE SAPI DE CV', 'GRAND VELAS RIVIERA MAYA', 'GVRM', 'RIVIERA', 'BETE'),
(27, 'MX', '5001255', 'PROMOTORA TURISTICA PUNTA BETE SAPI DE CV', 'CASA VALLARTA', 'CVALLA', 'CVALLARTA', 'BETE'),
(28, 'MX', '5001340', 'REAL DE MINAS DE QUERETARO SA DE CV', 'REAL DE MINAS TRADICIONAL QUERETARO', 'RMTQ', 'REAL DE MINAS', 'REALDM'),
(29, 'MX', '5000350', 'CARIBOTELS DE MEXICO S.A. DE C.V.', 'Melia Cozumel Golf All Inclusive ', 'MCGAI', 'MELIA COZUMEL', 'MELIA'),
(30, 'MX', '5001684', 'Playa Resorts Management', ' Sanctuary Cap Cana - All Inclusive By Playa Hotels & Resorts ', ' SCCAI ', 'Playa Resorts', 'PL'),
(31, 'MX', '5001261', 'CAMERON DEL PACIFICO, S. de R.L. de C.V', ' Hyatt Ziva Puerto Vallarta All Inclusive Resort ', ' HZPVAIR ', 'Playa Resorts', 'PL'),
(32, 'MX', '5001684', 'Playa Resorts Management', ' Hyatt Ziva Rose Hall ', ' HZRH ', 'Playa Resorts', 'PL'),
(33, 'MX', '12000091', 'Inmobiliaria y Proyectos TRPlaya S. de R.L. de C.V.', ' The Royal Playa Del Carmen ', ' RPC ', 'Playa Resorts', 'PL'),
(34, 'MX', '12000089', 'Gran Desing & Factory S. de R.L. de C.V.', ' Hyatt Zilara Cancun ', ' HZPC ', 'Playa Resorts', 'PL'),
(35, 'MX', '5000451', 'CAMERON DEL CARIBE S DE RL DE CV', ' Hyatt Ziva Cancun ', ' HZC ', 'Playa Resorts', 'PL'),
(36, 'MX', '5001262', 'PLAYA CABOS BAJA, S. DE R.L. DE C.V.', ' Hyatt Ziva Los Cabos All Inclusive Experience ', ' HZCAIE ', 'Playa Resorts', 'PL'),
(37, 'MX', '12000107', 'Playa Gran S. de RL de CV', ' Panama Jack Resorts Gran Porto Playa Del Carmen ', ' PJGPPC ', 'Playa Resorts', 'PL'),
(38, 'MX', '12000058', 'Desarrollos GCR S de RL de CV', ' Panama Jack Resorts Gran Caribe Cancun ', ' PJRGCC ', 'Playa Resorts', 'PL'),
(39, 'MX', '5000843', 'COMPAÑÍA HOTELERA REGIOMONTANA SA DE CV', 'CASA MAYA CANCUN', 'CMC', 'CASA MAYA CANCUN', 'CASAM'),
(40, 'MX', '5001270', 'GO ESPEDITIONS SA DE CV', 'GO NATURAL EXPLORERS', 'GNE', 'GO NATURAL EXPLORERS', 'GONTRL'),
(41, 'NORT&CA', '5001239', 'Social Inversiones Abey S.A', ' Princess Hotels Republica Dominicana ', ' PHRD ', 'PRINCESS', 'PRINCESS'),
(42, 'MX', '5000403', 'EXPLOTACIONES DEL CARIBE,S.A DE C.V', ' Platinum Yucatan Princess All Suites and Spa Resort Adults Only ', ' PYPASSRA ', 'PRINCESS', 'PRINCESS'),
(43, 'MX', '5000039', 'ARESOL CABOS SA DE CV ', 'PARADISUS LOS CABOS ', 'PC', 'PARADISUSCBO', 'MELIA'),
(44, 'MX', '5000217', 'OPERADORES DE HOTELES CHAHUE SA DE CV', 'HOTEL CASTILLO HUATULCO, HOTEL & BEACH CLUB', 'HCH,HB', 'CASTILLO', 'CASTL'),
(45, 'MX', '5000246', 'OPERADORA DE HOTELES SAN JERONIMO SA DE CV', 'Courtyard By Marriott Monterrey San Jerónimo Valle', 'CMMSJV', 'COURTYARD SAN', 'OPTIMA'),
(46, 'MX', '5000169', 'OPERADORA DE APODACA SA DE CV', 'COURTYARD BY MARRIOTT MONTERREY AEROPUERTO', 'CMMA', 'COURTYARD MTY', 'OPTIMA'),
(47, 'MX', '5000849', 'HOTELES Y SERVICIOS CASA BLANCA SA DE CV', 'FAIRFIELD INN BY MARRIOTT MONTERREY AEROPUERTO', 'FIMMA', 'FAIRFIELD', 'OPTIMA'),
(48, 'MX', '5000730', 'HOTELERA DE APODACA SA DE CV', ' HAMPTON INN MONTERREY AEROPUERTO ', ' HIMA ', 'HAMPTON', 'OPTIMA'),
(49, 'MX', '5000226', 'OPERADORA DE HOTELES LA FE SA DE CV', ' WYNDHAM GARDEN MONTERREY NORTE ', ' WGMN ', 'WYNDHAM', 'OPTIMA'),
(50, 'MX', '5000222', 'OPERADORA DE HOTELES EL SALTO JALISCO SA DE CV', ' HAMPTON INN GUADALAJARA AEROPUERTO ', ' HIGA ', 'HAMPTON', 'OPTIMA'),
(51, 'MX', '5000419', 'EMPRESAS OPTIMA SA DE CV', ' HOLIDAY INN EXPRESS GUADALAJARA AEROPUERTO ', ' HIEGA ', 'Holiday', 'OPTIMA'),
(52, 'MX', '5000465', 'PROMOTORA PLATINIUM SA DE CV', ' HILTON GARDEN INN VERACRUZ BOCA DEL RIO ', ' HGIVBR ', 'BOCA DEL RIO', 'OPTIMA'),
(53, 'MX', '11000014', 'Prodigios Interactivos SA ', 'Paradisus', 'P', 'Paradisus', 'PARADISUS '),
(54, 'MX', '5000150', 'MCLIGHT OPERADORA SA DE CV', ' RADISSON DEL REY SA DE CV ', ' RR ', 'RADISSON', 'OPTIMA'),
(55, 'MX', '5001312', 'ADMINISTRADORA Y OPERADORA DE HOTELES JAD SA DE CV', ' PARK INN BY RADISSON MAZATLAN ', ' PIRM ', 'Park Inn By Radisson', 'OPTIMA'),
(56, 'MX', '5000415', 'EXPLOTADORA DE INMUEBLES LA MORENA SA DE CV', 'COPACABANA BEACH HOTEL ACAPULCO', 'CBHA', 'COPACABANA', 'COPA'),
(57, 'MX', '5000360', 'Corporativo Pata Salada del Sur SA de CV ', 'Almar Resort Luxury LGTB Beach Front Experience ', 'ARL-LGTB', 'ALMAR', 'ALMAR'),
(58, 'MX', '5000958', 'MACA SA de CV ', 'Aranzazu Centro Histórico Guadalajara ', 'ACHP', 'ARANZAZU', 'ZAZU'),
(59, 'MX', '5001346', 'HOSPEDAJE QUEBEC EJECUTIVO SA DE CV ', 'First Class Hotel Providencia ', 'FCHP', 'First Class Hotel Providencia ', 'FISRT'),
(60, 'MX', '5000139', 'Management  Group  S.A. de C.V./ ', 'All Ritmo Cancun Resort and Waterpark', 'ARCRW', 'All Ritmo Cancun Resort and Waterpark', 'RITMO'),
(61, 'MX', '5000093', 'Bisol Vallarta S.A. de C.V', 'Meliá Puerto Vallarta All Inclusive ', 'MPVAI', 'Meliá Puerto Vallarta All Inclusive ', 'MELIA'),
(62, 'MX', '5000732', 'HOSTAL DEL ARCANGEL, S.A. DE C.V. ', 'Misión Arcángel Puebla (Franquicia)', 'MAP', 'MISION', 'MISION'),
(63, 'MX', '5000589', 'SUROZA, S.A. DE C.V.', 'Misión Patzcuaro Centro Historico', 'MPCH', 'MISION', 'MISION'),
(64, 'MX', '5000968', 'APODACA MISION, S.A. DE C.V.', 'Misión Express Aeropuerto La Fe', 'MEALA', 'MISION', 'MISION'),
(65, 'MX', '5001351', 'MIME EXPRESS, S.A. DE C.V.', 'Misión Express Merida Atabrisa', 'MEMA', 'MISION', 'MISION'),
(66, 'MX', '5000077', 'EDUARDO RAFAEL BLANCO GUILLAUMIN', 'Misión Express Xalapa Centro ', 'MEXC', 'MISION', 'MISION'),
(67, 'MX', '5000803', 'HOTELERA MISION AGUASCALIENTES S.A. DE C.V  ', 'Misión Aguascalientes Norte', 'MAN', 'MISION', 'MISION'),
(68, 'MX', '5000613', 'TURISMO DE TABASCO, S.A. DE C.V. ', 'Misión Express Villahermosa', 'MEV', 'MISION', 'MISION'),
(69, 'MX', '5001361', 'PUEFAZA S.A. DE C.V.', 'Misión Merida Panamericana', 'MMP', 'MISION', 'MISION'),
(70, 'MX', '5001207', 'HOTELERA MISION AGUASCALIENTES S.A. DE C.V.', 'Misión Aguascalientes Sur', 'MAS', 'MISION', 'MISION'),
(71, 'MX', '5000541', 'SANCOMAN, S.A. DE C.V.', 'Misión San Miguel Allende', 'MSMA', 'MISION', 'MISION'),
(72, 'MX', '5000338', 'PRADOS CAMELINAS SA DE CV', 'Misión Catedral Morelia ', 'MCM', 'MISION', 'MISION'),
(73, 'MX', '5000527', 'ROMISI, S.A. DE C.V.', 'Misión Queretaro Express', 'MQE', 'MISION', 'MISION'),
(74, 'MX', '5000545', 'SARMIS, S.A. DE C.V.', 'Misión Argento Zacatecas', 'MAZ', 'MISION', 'MISION'),
(75, 'MX', '5001388', 'OPERADORA MISION DURANGO S.A. DE C.V.', 'Misión Durango Express ', 'MDE', 'MISION', 'MISION'),
(76, 'MX', '5000554', 'SOFIA EXPRESS S.A. DE C.V.   ', 'Misión Pachuca Express ', 'MPE', 'MISION', 'MISION'),
(77, 'MX', '5001352', 'SUZALLA S.A. DE C.V.', 'Misión Express Saltillo', 'MES', 'MISION', 'MISION'),
(78, 'MX', '5000334', 'PLAZA ALAMO, S.A. DE C.V.', 'Misión Tampico Express', 'MTE', 'MISION', 'MISION'),
(79, 'MX', '5001353', 'PROHOHUA, S.A. DE C.V.', 'Misión Express Celaya', 'MEC', 'MISION', 'MISION'),
(80, 'MX', '5000977', 'SANCOMAN, S.A. DE C.V.', 'Misión Valle de Bravo', 'MVB', 'MISION', 'MISION'),
(81, 'MX', '5000979', 'SANCOMAN, S.A. DE C.V.', 'Misión Casa Colorada', 'MCC', 'MISION', 'MISION'),
(82, 'MX', '5000649', 'ZATLAMA, S.A. DE C.V.', 'Misión San Cristobal', 'MSC', 'MISION', 'MISION'),
(83, 'MX', '5001385', 'TURISTICA CORDIAL S.A. DE C.V.   ', 'Misión los Cocuyos ', 'MCO', 'MISION', 'MISION'),
(84, 'MX', '5000059', 'AGENCIAMISION S.A. DE C.V.', 'Misión Guadalajara', 'MG', 'MISION', 'MISION'),
(85, 'MX', '5000853', 'HOSTERIA DE SAN FELIPE, S.A. DE C.V.', 'Misión Patzcuaro ', 'MP', 'MISION', 'MISION'),
(86, 'MX', '5000147', 'MISION MAYA, S.A. DE C.V.', 'Misión Guanajuato', 'MG', 'MISION', 'MISION'),
(87, 'MX', '5000347', 'PROMOTORA HOTELERA MISION MORELOS, S.A. DE C.V.', 'Misión Cuernavaca', 'MC', 'MISION', 'MISION'),
(88, 'MX', '5000349', 'PROMOTORA HOTELERA MISION QUERETARO SA DE CV   ', 'Misión Juriquilla', 'MJ', 'MISION', 'MISION'),
(89, 'MX', '5000977', 'SANCOMAN, S.A. DE C.V.', 'Misión Comanjilla', 'MCO', 'MISION', 'MISION'),
(90, 'MX', '5001382', 'ALMUDENA MISION SA DE CV', 'Misión Campeche ', 'MC', 'MISION', 'MISION'),
(91, 'MX', '5000504', 'PALENZARO, S.A. DE C.V.  ', 'Misión Cd.Valles', 'MCV', 'MISION', 'MISION'),
(92, 'MX', '5000478', 'PROHOTMON S.A. DE C.V.', 'Misión Monterrey', 'MM', 'MISION', 'MISION'),
(93, 'MX', '5000861', 'HOTEL SURPAL, S.A. DE C.V.  ', 'Misión Palenque', 'MP', 'MISION', 'MISION'),
(94, 'MX', '5000647', 'ZAMIRO, S.A. DE C.V.', 'Misión Mazatlán', 'MM', 'MISION', 'MISION'),
(95, 'MX', '5001383', 'B.G. HOTELERIA S.A. DE C.V. ', 'Misión Xalapa ', 'MX', 'MISION', 'MISION'),
(96, 'MX', '5000822', 'HOZAMIS, S.A. DE C.V.', 'Misión Orizaba', 'MO', 'MISION', 'MISION'),
(97, 'MX', '5001363', 'MISION LA MURALLA S.A. DE C.V.', 'Misión Muralla', 'MM', 'MISION', 'MISION'),
(98, 'MX', '5000146', 'MISION LG S.A. DE C.V.', 'Misión Torreón', 'MTE', 'MISION', 'MISION'),
(99, 'MX', '5000154', 'MISION SAN GIL S.A. DE C.V. ', 'Misión San Gil', 'MSG', 'MISION', 'MISION'),
(100, 'MX', '5000646', 'ZAFAMI, S.A. DE C.V.', 'Misión Chautla', 'MCH', 'MISION', 'MISION'),
(101, 'MX', '5000698', 'GDL MISION, S.A. DE C.V.', 'Misión Colima', 'MC', 'MISION', 'MISION'),
(102, 'MX', '5001367', 'LUZAMI, S.A. DE C.V. ', 'Misión Oaxaca', 'MO', 'MISION', 'MISION'),
(103, 'MX', '5001364', 'MISION LA MURALLA, S.A. DE C.V.', 'Misión Jalpan', 'MJ', 'MISION', 'MISION'),
(104, 'MX', '5000098', 'CHAUTLAZA, S.A. DE C.V.  ', 'Misión Toreo', 'MTE', 'MISION', 'MISION'),
(105, 'MX', '5001365', 'MISION LA MURALLA, S.A. DE C.V. ', 'Misión Conca', 'MC', 'MISION', 'MISION'),
(106, 'MX', '5000693', 'GRUPO INTERNACIONAL DE PROMOCIONES SA DE CV', 'GOLDEN PARNASSUS RESORT AND SPA', 'GPRS', 'GOLDEN PARNASSUS RESORT AND SPA', 'GOLDEN'),
(107, 'MX', '5000928', 'INMOBILIARIA TURISTICA DEL CARMEN SA DE CV', 'KORE TULUM RETREAT & SPA RESORT', 'KTR&SR', 'KORE TULUM RETREAT & SPA RESORT', 'KORE'),
(108, 'MX', '5000268', 'Operadora Mega S.A. de C.V', 'Flamingo Cancun Resort ', 'FCR', 'FLAMINGO', 'FLAM'),
(109, 'MX', '5001389', 'Promotora de Inmuebles de la Riviera Maya SA de CV', 'Viva Wyndham Resorts', 'VWR', 'VIVA WYNDHAM', 'VIVAW'),
(110, 'MX', '5000622', 'VARHAM SA de CV', 'Galería Plaza Reforma ', 'GPR', 'Brisas', 'BR'),
(111, 'MX', '5000792', 'Hoteles Las Hadas Resorts SA de CV', 'Las Hadas Manzanillo ', 'LHM', 'Brisas', 'BR'),
(112, 'MX', '5000739', 'Hoteles Las Brisas SA de CV', 'Las Brisas Acapulco ', 'LBA', 'Brisas', 'BR'),
(113, 'MX', '5000178', 'Organización Brisas Huatulco SA de CV', 'Las Brisas Huatulco ', 'LBH', 'Brisas', 'BR'),
(114, 'MX', '5000738', 'Hotel Brisa Ixtapa SA de CV', 'Las Brisas Ixtapa ', 'LBI', 'Brisas', 'BR'),
(115, 'MX', '5000797', 'Hoteles Jurica SA de CV', 'Hacienda Jurica ', 'HJ', 'Brisas', 'BR'),
(116, 'NORT&CA', '5001400', 'Tucan Resorts S.R.L.', 'Blue Diamond Resorts Cuba', 'BDRC', 'Blue Diamond Resorts Cuba', 'BLUECUBA'),
(117, 'NORT&CA', '5001240', 'Inversiones azul del este dominicana sa ', 'Catalonia bavaro beach', 'CBB', 'CATALONIA', 'CATA'),
(118, 'MX', '5000507', 'Raoz asesores s de rl de cv', 'Las torres gemelas', 'LTG', 'Las torres gemelas', 'TORRES'),
(119, 'MX', '5001395', 'Cabbian hotels and condo s de rl de cv', 'Cabbian hotels and condo', 'CHC', 'Cabbian hotels and condo', 'CABBIAN'),
(120, 'MX', '5000052', 'ADMINISTRADORA INTEGRAL BAHÍA DE SANTA LUCIA S. A. DE C. V', 'Playa Suites Acapulco. ', 'PSA', 'Playa Suites Acapulco. ', 'PLAYASTS'),
(121, 'MX', '5000517', 'AM RESORTS', 'Am resort', 'AM', 'AM RESORTS', 'AM'),
(122, 'NORT&CA', 'BUSINESS ONE', 'PR LATIN AMERICA, INC', 'HEDONISM JAMAICA/BREEZES BAHAMAS/HOLIDAY INN RESORT', 'HSJ', 'HEDONISM JAMAICA/BREEZES BAHAMAS/HOLIDAY INN ', 'LATINAM'),
(123, 'NORT&CA', 'BUSINESS ONE', 'PR LATIN AMERICA, INC', 'KENNEDY SPACE VISITOR COMPLEX', 'KSVC', 'KENNEDY SPACE VISITOR COMPLEX', 'LATINAM'),
(124, 'MX', '5000403', 'Explotaciones del caribe sa de cv', 'princess Hotels- Mexico', 'PHM', 'PRINCESS', 'PRINCESS'),
(125, 'MX', 'BUSINESS ONE', 'ANTARISUITE CINTERMEX SA DE CV', 'CINTERMEX', 'C', 'CINTERMEX', 'CINTER'),
(126, 'MX', 'BUSINESS ONE', 'ANTARISUITE CINTERMEX SA DE CV', 'GALERIAS', 'G', 'GALERIAS', 'GALERIAS'),
(127, 'MX', '5000493', 'PROMOTORA TECKA DEL NORTE DA DE CV', 'VALLE', 'V', 'VALLE', 'VALLE'),
(128, 'MX', '5001487', 'SANDOS INTERNACIONAL SA DE CV', 'SANDOS HOTELS & RESORTS ', 'S', 'SANDOS', 'SANDOS'),
(129, 'MX', '5000046', 'DESARROLLOS DINE SA DE CV', 'PALLADIUM HOTEL GROUP', 'PHG', 'PALLADIUM', 'PALLA'),
(130, 'MX', '5000673', 'H de A Corporativo ', 'Best Western Plus Posadas de Don Vasco', 'BWPPDV', 'BEST WESTERN', 'BWP'),
(131, 'MX', '5000047', 'Administración de Hoteles Continental SA de CV', 'Best Western Plus Puebla', 'BWPP', 'BEST WESTERN', 'BWP'),
(132, 'MX', '5001256', 'PROMOTORA TURISTICA PUNTA BETE SAPI DE CV', 'Velas resorts', 'VR', 'VELAS', 'BETE'),
(133, 'MX', '5000635', 'Valentin playa del secreto sa de cv', 'Valentin imperial riviera', 'VIR', 'Valentin', 'VALE'),
(134, 'MX', '5000620', 'UNIVERSIDAD AUTONOMA DE GUADALAJARA A.C', 'HOTELES REAL', 'HR', 'CHAPALA', 'CHA'),
(135, 'MX', '5000909', 'ISLA NATURA BEACH HUATULCO S.A. DE C.V.', 'ISLA NATURA BEACH HUATULCO', 'INBH', 'Isla Huatulco', 'IH'),
(136, 'NORT&CA', '5000740', 'Hoteles Best Western, AC ', 'Best Western México', 'BWM', 'Best Western México', 'BESTW'),
(137, 'MX', '5001215', 'Nuevo hotel rosita y anexos sa de cv', 'Hotel rosita y pescadora', 'HRP', 'Hotel rosita y pescadora', 'ROSITA'),
(138, 'MX', '5000181', 'OPERADORA LOS CABOS SA DE CV', 'MARINA FIESTA RESORT AND SPA', 'MFRS', 'MARINA FIESTA RESORT AND SPA', 'MARINA'),
(139, 'MX', '5001226', 'PUERTO BAHIA RESIDENCE SA DE CV', 'GRAND SIRENIS MATLALI HILLS RESORT', 'GSMHR', 'GRAND SIRENIS MATLALI HILLS RESORT', 'SIRENIS'),
(140, 'MX', '5000727', 'Hoteles los arcos de occidente sa de cv', 'Hotel playa los arcos, los arcos suites, casa doña susana.', 'HPA/AS/CDS', 'Hotel playa los arcos, los arcos suites, casa', 'ARCOS'),
(141, 'NORT&CA', '5001715', 'Brand USA', 'Choose Chicago', 'CHOSE', 'BRAND', 'BRAND'),
(142, 'NORT&CA', '5001574', 'The rodriguez group', 'Experiencia kissimmes', 'EK', 'Experiencia kissimmes', 'KISS'),
(143, 'MX', '11000044', 'EAN SERVICES LLC', 'ALAMO', 'ALM', 'ALAMO', 'EAN'),
(144, 'MX', '5000208', 'Operadora de hoteles buenaventura sa de cv', 'hoteles buenaventura', 'HB', 'hoteles buenaventura', 'BUENAVN'),
(145, 'NORT&CA', '5000662', 'Melody maker hotel sa de cv', 'MELODY MAKER CANCUN', 'MMC', 'MELODY', 'MELODY'),
(146, 'MX', '5000632', 'VALLARTA INTERNACIONAL SA DE CV', 'Sheraton Buganvilias Beach and Spa Resort Puerto Vallarta', 'SBBSRPV', 'Sheraton Buganvilias Beach and Spa Resort Pue', 'BUGANV'),
(147, 'MX', '5000697', 'GRAN MARLIN HOTELS, S.A DE C.V.', 'GRAN FESTIVALL All INCLUSIVE ', 'GFAI', 'GRAN FESTIVALL All INCLUSIVE ', 'FESTIVAL'),
(148, 'MX', '5000285', 'OPERADORA PACIFIC PALACE SA DE CV', 'OCEANO PALACE / LUNA PALACE /', 'OP,LP,PPBTH,', 'OCEANO PALACE / LUNA PALACE /', 'OCEANO'),
(149, 'MX', '5000954', 'LATINOAMERICANA DE HOTELES, S.A. DE C.V.', 'CROWN PARADISE CLUB PUERTO VALLARTA Y CROWN PARADISE GOLDEN PUERTO VALLARTA', 'CPCPVCPG', 'CROWN PARADISE CLUB PUERTO VALLARTA Y CROWN P', 'CROWN'),
(150, 'MX', '5000522', 'RINOVAL DE MEXICO S.A DE C.V', 'MARIVAL RESORT & SUITES ALL INCLUSIVE AND MARIVAL KIDS', 'MRSAIMK', 'MARIVAL RESORT & SUITES ALL INCLUSIVE AND MAR', 'MARIVAL'),
(151, 'MX', '5000522', 'RINOVAL DE MEXICO S.A DE C.V', 'SUITES FAMILY EMOTION ALL INCLUSIVE BY MARIVAL RESORT', 'SFEAIMR', 'SUITES FAMILY EMOTION ALL INCLUSIVE BY MARIVA', 'MARIVAL'),
(152, 'MX', '5000487', 'PERLA TAPATIA SA DE CV', 'HOTEL MORALES HISTORIAL AND COLONIAL DOWNTOWN CORE', 'HMHCDC', 'HOTEL MORALES HISTORIAL AND COLONIAL DOWNTOWN', 'MORALES'),
(153, 'MX', '7000037', 'Servicios de hoteleria xalba sa de cv', 'Holiday inn express and suites puebla angelopolis', 'HIESPA', 'Holiday inn express and suites puebla angelop', 'ANGELOP'),
(154, 'MX', '5000396', 'DESTILADERAS RESORT OPERATIONS,S.ADE C.V', 'RANCHO BANDERAS ALL SUITES RESORTS PUNTA DE MITA', 'RBASRPM', 'RANCHO', 'RANCHO'),
(155, 'MX', '5001756', 'SERVICIOS TURISTICOS DE MARFIL, SA DE CV', 'HOTEL GRAN PLAZA & CONVENTION CENTER GUANAJUATO', 'HGPCCG', 'HOTEL GRAN PLAZA & CONVENTION CENTER GUANAJUA', 'CNTGTO'),
(156, 'MX', '12000057', 'Coporacion hotelera hispano mexicano sa de cv', 'Family concierge at paradius la esmeralda', 'FCPE', 'Family concierge at paradius la esmeralda', 'PARADISUS '),
(157, 'MX', '5000852', 'HOTELERA SF, S. DE R.L. DE C.V.', 'THE HACIENDA AT HILTON PUERTO VALLARTA', 'THAHPV', 'THE HACIENDA AT HILTON PUERTO VALLARTA', 'KRYSTAL'),
(158, 'MX', '5000954', 'LATINOAMERICANA DE HOTELES, S.A. DEC.V.', 'Crown paradise golden puerto vallarta', 'CPGPV', 'Crown paradise golden puerto vallarta', 'CROWN'),
(159, 'MX', '5000139', 'MANAGEMENT GROUP SA DE CV', 'All Ritmo Cancun Resort and Waterpark', 'ARCRW', 'RITMO', 'RITMO'),
(160, 'MX', '5000071', 'ADMINISTRACIONES PROFESIONALES DE VALLARTA, S.A. DE C.V.', 'MARIVAL RESIDENCES LUXURY DE VALLARTA', 'MRLV', 'MARIVAL RESIDENCES LUXURY DE VALLARTA', 'MARIVAL'),
(161, 'MX', '5001673', 'OPERADORA PRIMAVERA DE SAN MIGUEL DE ALLENDE, SA DE CV', 'CASA PRIMAVERA HOTEL BOUTIQUE AND SPA', 'CPHBS', 'CASA PRIMAVERA HOTEL BOUTIQUE AND SPA', 'CASAPMVA'),
(162, 'MX', '5000954', 'LATINOAMERICANA DE HOTELES, S.A. DEC.V.', 'Crown Paradise Club Puerto Vallarta ', 'CPGPV', 'Crown Paradise Club Puerto Vallarta ', 'CROWN'),
(163, 'NORT&CA', '5001440', 'Inversiones aguayuna sas', 'Blue beach punta cana luxury resort', 'BBPCLR', 'Blue beach punta cana luxury resort', 'BLUEPTAC'),
(164, 'MX', '5000301', 'Operadora de servicios turisticos ho gelada sa de cv ', 'Lq hotel by la quinta puebla palmas', 'HQPP', 'Lq hotel by la quinta puebla palmas', 'LGHOTEL'),
(165, 'MX', '12000057', 'Coporacion hotelera hispano mexicano sa de cv', 'ROYAL SERVICE AT PARDISUS LA PERLA', 'RSPP', 'ROYAL SERVICE AT PARDISUS LA PERLA', 'PARADISUS '),
(166, 'NORT&CA', '5001579', 'FCH CLIPPERTON SA DE CV', 'HOTEL & SUITES CLIPPERTON SA DE CV', 'HSC', 'HOTEL & SUITES CLIPPERTON SA DE CV', 'CLIPPERTON'),
(167, 'MX', '5000350', 'Caribotels de mexico sa de cv', 'Melia Cozumel Golf All Inclusive ', 'MCGAI', 'MELIA COZUMEL', 'MELIA'),
(168, 'MX', '5001437', 'Milenium Grupo Hotelero Mexicano SA de CV', 'Milenium Grupo Hotelero Mexicano,', 'MGHM', 'Milenium Grupo Hotelero Mexicano,', 'MILENIUM'),
(169, 'MX', '5000109', 'cala formentor sa de cv', 'paradisus cancun resort by melia', 'PCRM', 'ParadisusC', 'MELIA'),
(170, 'MX', '5001560', 'Impulsora plaza zaragoza sa de cv', 'City express suites puebla finsa', 'CESPF', 'City express suites puebla finsa', 'EXPRESS'),
(171, 'NORT&CA', '5001396', 'Embajada de Republica Dominicana', 'Embajada de Republica Dominicana', 'ERD', 'Embajada de Republica Dominicana', 'EMBRDC'),
(172, 'MX', '5001540', 'Tamaran resort sa de cv', 'The five beach hotel &residences', 'TFBH', 'The five beach hotel &residences', 'THEFIVE'),
(173, 'MX', '5000423', 'EXPO VACATIONS, S.A. DE C.V.', 'FLAMINGO VALLARTA HOTEL & MARINA', 'FVHM', 'FLAMINGO VALLARTA HOTEL & MARINA', 'FLAMINGOV'),
(174, 'MX', '5000480', 'PRESTADORA DE SERVICIOS CASTRO ENRIQUEZ', 'LA CASONA SAN MIGUEL DE ALLENDE', 'LCSMA', 'LA CASONA SAN MIGUEL DE ALLENDE', 'CASONA'),
(175, 'MX', '5000852', 'HOTELERA SF, S. DE R.L. DE C.V.', 'KRYSTAL GRAND INSURGENTES SUR ', 'KGIS', 'KRYSTAL GRAND INSURGENTES SUR ', 'KRYSTAL'),
(176, 'MX', '5001438', 'Grupo hotelera samar sa de cv', 'Mia reef isla muejeres resorts', 'MRIMR', 'Mia reef isla muejeres resorts', 'MIAREEF'),
(177, 'MX', '5001561', 'Urban hotels s de rl de cv', 'Four points by sheraton puebla', 'FPSP', 'Four points by sheraton puebla', 'FOURPOINTS'),
(178, 'MX', '5000597', '3 ESQUINAS SAPI DE CV', '3 ESQUINAS SMALL LUXURY HOTEL', '3 ESLH', '3 ESQUINAS SMALL LUXURY HOTEL', '3ESQUINA'),
(179, 'MX', '5001193', 'FIDEICOMISO F/1596', 'AC HOTEL GUADALAJARA MEXICO', 'AHGM', 'AC HOTEL GUADALAJARA MEXICO', 'ACHOTEL'),
(180, 'MX', '5001252', 'PROMOTORA TURISTICA PUNTA BETE SAPI DE CV', 'GRAND VELAS RIVIERA NAYARIT', 'GVRN', 'NAYARIT', 'BETE'),
(181, 'MX', '5000866', 'HURAKENNA SA DE CV', 'HOTEL LAS PALMAS BY THE SEA', 'HPTS', 'HOTEL LAS PALMAS BY THE SEA', 'PALMAS'),
(182, 'NORT&CA', '11000035', 'NBC UNIVERSAL', 'UNIVERSAL STUDIOS HOLLYWOOD', 'USH', 'UNIVERSAL STUDIOS HOLLYWOOD', 'UNIVERSAL'),
(183, 'MX', '5000565', 'SERVICIOS HOTELEROS DE PRESTIGIO,S.A. DE C.V.', 'GRAND LAS NUBES BY INMENSE', 'GLNI', 'GRAND LAS NUBES BY INMENSE', 'NUBES'),
(184, 'MX', '5000938', 'IMPULSORA DE ZIRAHUEN, S.A. DE C.V.', 'ZIRAHUEN FOREST AND RESORT', 'ZFR', 'ZIRAHUEN FOREST AND RESORT', 'ZIRAHUEN'),
(185, 'MX', '5000682', 'GRAN HOTEL REAL DE PUEBLA SA DE CV ', 'Gran hotel real de puebla ', 'GHRP', 'BEST WESTERN', 'BWP'),
(186, 'MX', '5000175', 'OPERADORA BADI SA DE CV', 'GRAND ISLA NAVIDAD RESORT', 'GINR', 'GRAND ISLA NAVIDAD RESORT', 'ISLANV'),
(187, 'MX', '5000852', 'HOTELERA SF, S. DE R.L. DE C.V.', 'KRYSTAL URBAN MONTERREY ', 'KUM', 'KRYSTAL URBAN MONTERREY ', 'KRYSTAL'),
(188, 'MX', '5000408', 'EPI Gestion México, S.A. de C.V.', 'Sandos Hoteles & Resorts', 'SHR', 'EPI', 'SANDOS'),
(189, 'MX', '5000001', 'Hotel royal plaza sa de cv', 'Staybridge suites puebla', 'SSP', 'Staybridge suites puebla', 'STAYBR'),
(190, 'MX', '5000000', 'Inmobiliaria turistica de puebla sa de cv', 'Holiday inn puebla finsa', 'HIPF', 'Holiday inn puebla finsa', 'HOLIDAY'),
(191, 'MX', '5001541', 'REAL ESTATE VALUE MANAGEMENT SA DE CV', 'THE FIVES DOWTOWN HOTEL ', 'TFDH', 'THE FIVES DOWTOWN HOTEL ', 'THEFIVEDW'),
(192, 'MX', '5001671', 'GRUPO HOTELERO ARCADA, S.A. DE C.V.', 'HOTEL ARCADA SAN MIGUEL', 'HASM', 'HOTEL ARCADA SAN MIGUEL', 'ARCADA'),
(193, 'MX', '5000462', 'BCO Mismaloya S de RL de CV', 'Barceló Puerto Vallarta ', 'BPV', 'Barcelo', 'BC'),
(194, 'MX', '5000840', 'Hotel royal courts sa de cv', 'best westerm plus royal', 'BWPR', 'best westerm plus royal', 'BESTW'),
(195, 'MX', '5000477', 'JOSE LUIS GAONA ALVARADO', 'HOTEL HISTORIA MORELIA', 'HHM', 'HOTEL HISTORIA MORELIA', 'HISTORIAM'),
(196, 'MX', '5000887', 'INMOBILIARIA GOPAK, SA DE CV', 'HOTEL BALCON DEL CIELO', 'HBC', 'HOTEL BALCON DEL CIELO', 'BALCON'),
(197, 'MX', '5000852', 'HOTELERA SF, S. DE R.L. DE C.V.', 'KRYSTAL BEACH ACAPULCO ', 'KBA', 'KRYSTAL BEACH ACAPULCO ', 'KRYSTAL'),
(198, 'MX', '5001542', 'grupo inmobiliaria mosa sa de cv', 'The ritz carton cancun', 'TRCC', 'The ritz carton cancun', 'RITZ'),
(199, 'MX', '5000724', 'Hotel Alameda SA de CV', 'Galeria Plaza Veracruz', 'GPV', 'Brisas', 'BR'),
(200, 'MX', '5001140', 'MIGUEL ANGEL RUIZ AGUILAR', 'HOTEL VICTORIA MORELIA', 'HVM', 'HOTEL VICTORIA MORELIA', 'VICTORIA'),
(201, 'MX', '5000601', 'RIUSA II S.A.CFI A07632474', 'RIU HOTELES & RESORTS', 'RIU', 'RIU HOTELES & RESORTS', 'RIU'),
(202, 'MX', '5000318', 'OPERADORA TURISTICA MENHIR, SA DE CV', 'HOTEL VILLA VARADERO', 'HVV', 'HOTEL VILLA VARADERO', 'VARADERO'),
(203, 'MX', '5000796', 'Hipocampo sa de cv', 'Ostar grupo hotelero', 'OGH', 'Ostar grupo hotelero', 'OSTAR'),
(204, 'MX', '5000784', 'Hotel geneve sa de cv', 'Ostar grupo hotelero', 'OGH', 'Ostar grupo hotelero', 'OSTAR'),
(205, 'MX', '5000808', 'HOTEL MARENA SA DE CV', 'HOTELES BUENAVENTURA', 'HB', 'HOTELES BUENAVENTURA', 'BUENAVN'),
(206, 'MX', '5000634', 'VILLA MIRASOL DE SAN MIGUEL DE ALLENDE SA DE CV', 'HOTEL VILLA MIRASOL', 'HVM', 'HOTEL VILLA MIRASOL', 'MIRASOL'),
(207, 'MX', '5000260', 'OPERADORA LOS JUANINOS, S.A. DE C.V.', 'HOTEL LOS JUANIÑOS', 'HLJ', 'HOTEL LOS JUANIÑOS', 'JUANIÑOS'),
(208, 'MX', '5001620', 'GRUPO HOTELERO MEGAMEX SA DE CV', 'POSADA VISTA BELLA', 'PVB', 'POSADA VISTA BELLA', 'VISTAB'),
(209, 'MX', '5000948', 'kaal operadora de hoteles sa de cv', 'sleep inn monclova', 'SIM', 'sleep inn monclova', 'SLEEP'),
(210, 'NORT&CA', '5001390', 'Leisure Pass Group', 'Leisure Pass Group', 'LPG', 'Leisure Pass Group', 'LEISURE'),
(211, 'MX', '5000213', 'OPERADORA HOTELERA DEL CORREDOR MAYAKOBA, S.A. DE C.V.', 'Fairmont mayakoba', 'FM', 'Fairmont', 'FAIR'),
(212, 'MX', '5001674', 'IMPULSORA TURISTICA PERMAN,S. DE R.L. DE C.V.', 'MANSION VIRREYES', 'MV', 'MANSION VIRREYES', 'VIRREYES'),
(213, 'MX', '5001755', 'GUALDRA, S.A. DE C.V.', 'HOTEL GUANAJUATO', 'HG', 'HOTEL GUANAJUATO', 'TLGTO'),
(214, 'MX', '5001217', 'OPERADORA HUESPED Y HUESPED,S.A. DE C.V.', 'REAL DE LEYENDAS', 'RL', 'REAL DE LEYENDAS', 'LEYENDAS'),
(215, 'MX', '5000118', 'CORPORATIVO HOTELERO SAN DIEGO S.A.DE C.V.', 'HOTEL SAN DIEGO', 'HSD', 'HOTEL SAN DIEGO', 'SANDIEGO'),
(216, 'MX', '5000812', 'HOTEL LA MORADA, S.A. DE C.V.', 'LA MORADA HOTEL', 'LMH', 'LA MORADA HOTEL', 'MORADA'),
(217, 'MX', '5000879', 'INMOBILIARIA ALCUPILE S.A. DE C.V.', 'HOTEL EL CARMEN', 'HEC', 'HOTEL EL CARMEN', 'ELCARMEN'),
(218, 'MX', '5001255', 'PROMOTORA TURISTICA PUNTA BETE SAPI DE CV', 'VELLAS VALLARTA', 'VV', 'VELAS', 'BETE'),
(219, 'NORT&CA', '5000624', 'VISIT US INC ', 'IBEROSTAR VISIT', 'IV', 'IBEROSTAR VISIT', 'IBEROSTAR'),
(220, 'MX', '5001109', 'GRACIELA PATIÑO PEÑA', 'HOTEL ESTEFANIA', 'HE', 'HOTEL ESTEFANIA', 'ESTEFANIA'),
(221, 'MX', '5000777', 'HOTELERA FERROGAL S.A DE C.V', 'ARBOREA HOTEL', 'AH', 'ARBOREA HOTEL', 'ARBOREA'),
(222, 'MX', '5000099', 'CORPORATIVO BDLT S.A. DE C.V.', 'LAS PERGOLAS', 'LP', 'PERGOLAS', 'PER'),
(223, 'MX', '5000333', 'PROMOTORA DE ACTIVIDADES DEPORTIVAS PAC, S.A. DE C.V.', 'REAL ZAPOPAN', 'RZ', 'REAL ZAPOPAN', 'RZAPOPAN'),
(224, 'MX', '5000442', 'Gonzalez  asesoramiento turistico tulum sa de cv', 'KOOX HOTELES', 'KH', 'KOOX HOTELES', 'KOOX'),
(225, 'MX', '5000731', 'HOTELERA ARVASE, S.A. DE C.V.', 'Villa divina', 'VD', 'Villa divina', 'SANMARINO'),
(226, 'MX', '5000902', 'INMOBILIARIA KASAMARINA,S.A. DE C.V.', 'THE REEF 28', 'TREEF 28', 'REEF', 'REEF'),
(227, 'MX', '5000079', 'BASICHOTEL SA DE CV', 'BASIC HOTEL', 'BH', 'BASIC', 'BASIC'),
(228, 'MX', '5000731', 'HOTELERA ARVASE, S.A. DE C.V.', 'san marino', 'SM', 'san marino', 'SANMARINO'),
(229, 'MX', '5000190', 'Operadora y desarrolladora ixzi sa de cv', 'MN HOTELES', 'MH', 'MN HOTELES', 'MNHOTLS'),
(230, 'MX', '5001208', 'HOTELERA PLAYA PARAISO,S.A DE C.V', 'IBEROSTAR', 'IBERO', 'IBEROSTAR', 'ISTAR'),
(231, 'MX', '5001672', 'VALERIA LEON ORTEGA', 'CASA MUUK', 'CM', 'CASA MUUK', 'MUUK'),
(232, 'MX', '5000259', 'JFG INTEGRACION EN MEDIOS PUBLICITARIOS SA DE CV', 'INMEPP', 'I', 'INMEPP', 'JUANIÑOS'),
(233, 'MX', '5000472', 'PROMOCION QUINTANARROENSE DE TOURS SA DE CV', 'OASIS HOTEL & RESORTS', 'OASIS', 'Oasis', 'OA'),
(234, 'MX', '11000016', 'TERRANOVA DIRECTORSHIP, S.L.', 'WANOS', 'W', 'WANOS', 'WANOS'),
(235, 'MX', '5000559', 'Servicios Hoteleros Calzada SAPI de CV', 'Perla Central', 'PC', 'Perla Central', 'PERLACTL'),
(236, 'MX', '5000950', 'KARISMA RESORTS DE MEXICO SA DE CV', 'KARISMA HOTELS & RESORTS', 'KHR', 'KARISMA', 'KARI'),
(237, 'MX', '5000465', 'PROMOTORA PLATINIUM SA DE CV', ' OPTIMA Hoteles  ', ' OH ', 'OPTIMA', 'OPTIMA'),
(238, 'NORT&CA', '5001701', 'SUNCARIBE GESTAO  E INVESTIMEINTOS HOTELEIROS', 'ACCOR HOTELS CUBA ', 'AHC', 'ACCOR HOTELS CUBA ', 'ACCOR'),
(239, 'NORT&CA', '5001574', 'The rodriguez group', 'Visit Florida ', 'EK', 'Visit Florida ', 'VISIT'),
(240, 'MX', '5000584', 'SWEET SAN FRANCISCO SA DE CV ', 'HOTEL SAN FRANCISCO CENTRO HISTORICO ', 'SSF', 'NOVA', 'NOVA'),
(241, 'MX', '5000514', 'RIO LERMA 162  SA DE CV ', 'HOTEL DEL ANGEL ', 'HA', 'NOVA', 'NOVA'),
(242, 'MX', '5000498', 'PROMOCIONES TURISTICAS RAJOJA SA ', 'HOTEL RIAZOR AEROPUERTO ', 'HRA', 'RIAZOR', 'RIAZOR'),
(243, 'MX', '5000338', 'PRADOS CAMELINAS SA DE CV', 'CITY EXPRESS SATELITE', 'CES', 'CITY EXPRESS', 'EXPRESS'),
(244, 'MX', '5001724', 'OPERADORA MEXPLA SAN LUIS POTOSI, SA DE CV', 'GRAN HOTEL CONCORDIA ', 'GHC', 'GRAN HOTEL CONCORDIA ', 'CONCORDIA'),
(245, 'MX', '5000269', 'OPERADORA MEXPLA GUANAJUATO S.A. DE C.V.', 'HOTEL SUITES MEXICO PLAZA GUANAJUATO', 'HSMPG', 'HOTEL SUITES MEXICO PLAZA GUANAJUATO', 'SUITES'),
(246, 'MX', '5000233', 'OPERADORA DE HOTELES DE LUJO SA DE CV ', 'BEL AIR COLLECTION RESORT AND SPA CANCUN ', 'BACRASC', 'BEL AIR', 'BELAIR'),
(247, 'MX', '5001720', 'OPERADORA DE HOTELES BELLAMAR SA DE CV ', 'OLA ALTAS INN & SPA ', 'OAI', 'OLA ALTAS INN & SPA ', 'OLAS'),
(248, 'MX', '5001730', 'OPERACION EFICIENTE DE HOTELES SA DE CV ', 'HOTEL SUITES MEXICO PLAZA CAMPESTRE ', 'HSMPC', 'HOTEL SUITES MEXICO PLAZA CAMPESTRE ', 'SUITES'),
(249, 'MX', '5001668', 'OMC GOURMET  SA DE CV ', 'HOTEL LEPANDO ', 'HP', 'HOTEL LEPANDO ', 'LEPANDO'),
(250, 'MX', '5000057', 'AMX MANZANILLO HOLDINGS ', 'TESORO MANZANILLO ', 'TM', 'TESORO MANZANILLO ', 'TESORO'),
(251, 'MX', '5001722', 'LOVE IT SA DE CV ', 'LOVE IT CONSULADO', 'LIC', 'LOVE', 'LOVE'),
(252, 'MX', '5000944', 'JJJ EXPRESS TRAVEL SERVICES SA DE CV ', 'HOTEL AZULEJOS', 'HA', 'HOTEL AZULEJOS', 'AZULEJOS'),
(253, 'MX', '5000944', 'JJJ EXPRESS TRAVEL SERVICES SA DE CV ', 'HOTEL AMALA ', 'HA', 'HOTEL AMALA ', 'AMALA'),
(254, 'MX', '5000944', 'JJJ EXPRESS TRAVEL SERVICES SA DE CV ', 'HOTEL KRON  ', 'HK', 'HOTEL KRON  ', 'KRON'),
(255, 'MX', '5000852', 'HOTELERA SF, S. DE R.L. DE C.V.', 'KRYSTAL URBAN MONTERREY ', 'KUM', 'KRYSTAL URBAN MONTERREY ', 'KRYSTAL'),
(256, 'MX', '5000852', 'HOTELERA SF, S. DE R.L. DE C.V.', 'THE HACIENDA AT HILTON PUERTO VALLARTA ALL INCLUSIVE ADULTS ONLY ', 'KUM', 'THE HACIENDA AT HILTON PUERTO VALLARTA ALL IN', 'KRYSTAL'),
(257, 'MX', '5001521', 'HOTELERA CENTRO HISTORICO SA DE CV ', 'HOTEL RITZ CIUDAD DE MEXICO ', 'HRCM', 'HOTEL RITZ CIUDAD DE MEXICO ', 'RITZ'),
(258, 'MX', '5001731', 'HOTEL JENA, S.A. DE C.V.', 'RAMADA REFORMA ', 'RR', 'RAMADA REFORMA ', 'RAMADA '),
(259, 'NORT&CA', '5001741', 'MARRIOTT INTERNATIONAL, INC.', 'MARRIOTT INTERNATIONAL, INC.', 'MI', 'MARRIOTT INTERNATIONAL, INC.', 'MARRIOT'),
(260, 'MX', '5001112', 'JOSE ALBERTO PEREZ BARBA', 'HOTEL BEST WESTERN POSADA CHAHUE', 'HBWPC', 'HOTEL BEST WESTERN POSADA CHAHUE', 'BESTW'),
(261, 'MX', '5000967', 'Administradora Hotelera del Centro S.A. de C.V.', 'Hotel El Ejecutivo By Reforma Avenue', 'HEBR', 'Hotel El Ejecutivo By Reforma Avenue', 'EJECUTIVO'),
(262, 'NORT&CA', '5001733', 'ARUBA TOURISM AUTHORITY', 'ARUBA TOURISM AUTHORITY', 'ATA', 'ARUBA TOURISM AUTHORITY', 'ARUBA'),
(263, 'MX', '5001685', 'ASOCIACION DE HOTELES DE COZUMEL A.C', 'ASOCIACION DE HOTELES DE COZUMEL', 'AHC', 'ASOCIACION DE HOTELES DE COZUMEL', 'ASOCHCZL'),
(264, 'MX', '5001743', 'BEATRIZ TORRES VIVANCO ', 'CASA DE LOS DULCES SUEÑOS ', 'CDS', 'CASA DE LOS DULCES SUEÑOS ', 'DULCESÑS'),
(265, 'MX', '5000453', 'BCO HUATULCO S DE RL  DE CV ', 'BARCELO HUATULCO ', 'BH', 'Barcelo', 'BC'),
(266, 'MX', '5001686', 'CELACANTO SERVICIOS TURISTICOS S DE RL CV', 'VAMAR VALLARTA ALL INCLUSIVE  MARINA AND BEACH RESORT ', 'VVIMBR', 'VAMAR VALLARTA ALL INCLUSIVE  MARINA AND BEAC', 'VAMAR'),
(267, 'MX', '5000368', 'COMERCIALIZADORA VISTA BALLENA SA DE CV ', 'HACIENDA ENCANTADA RESORT AND RESIDENCE ', 'HERR', 'HACIENDA ENCANTADA RESORT AND RESIDENCE ', 'ENCANTADA'),
(268, 'MX', '5001723', 'CV RESORTS  SA DE CV ', 'COSTA SUR RESORT & SPA ', 'CSRS', 'COSTA SUR RESORT & SPA ', 'COSTASUR'),
(269, 'MX', '5000375', 'DECAMERON SA DE CV ', 'ROYAL DE CAMERON LOS CABOS ', 'RCC', 'ROYAL DE CAMERON LOS CABOS ', 'ROYALCMRO'),
(270, 'MX', '5000429', 'FRIENDLY HOLA VALLARTA SA DE CV', 'Friendly Vallarta family inclusive Beach Resort & Spa ', 'FVFIB', 'Friendly Vallarta family inclusive Beach Reso', 'FRIENDLY'),
(271, 'MX', '5000682', 'GRAN HOTEL REAL DE PUEBLA SA DE CV ', 'BEST WESTERN PLUS PUEBLA ', 'BWPP', 'BEST WESTERN', 'BWP'),
(272, 'MX', '5001291', 'GRUPO CARRZZOCCO SA DE CV ', 'HOTEL PLAZA POBLANA ', 'HPP', 'HOTEL PLAZA POBLANA ', 'PLAZAPBL'),
(273, 'MX', '5000764', 'HOTELES CORAL SA DE CV', 'HISTORICO CENTRAL ', 'HC', 'HISTORICO CENTRAL ', 'HISTORICOCTL'),
(274, 'MX', '5001742', 'PROMOCIONES RIO PLATA SA DE CV ', 'MARQUIS REFORMA', 'MR', 'MARQUIS REFORMA', 'MARQUIS'),
(275, 'MX', '5001744', 'SERVICIOS TURISTICOS LA MANSION  SA DE CV ', 'MANSION MERIDA ON THE PARK ', 'MMOTP', 'MANSION MERIDA ON THE PARK ', 'MANSIONMER'),
(276, 'MX', '5000746', 'HOTELERA CANCO SA DE CV', 'VISTA PLAYA DE ORO MANZANILLO', 'VPOM', 'VISTA PLAYA DE ORO MANZANILLO', 'VISTAPLYA'),
(277, 'MX', '5000375', 'DECAMERON SA DE CV', 'ROYAL DECAMERON COMPLEX RIVIERA NAYARIT', 'RDCRN', 'ROYAL DECAMERON COMPLEX RIVIERA NAYARIT', 'ROYALCMRO'),
(278, 'MX', '5001542', 'GRUPO INMOBILIARIO MOSA SA DE CV ', 'The ritz carton cancun', 'TRCC', 'The ritz carton cancun', 'RITZ'),
(279, 'MX', '5001514', 'COCOTEROS DEL SUR S DE RL DE CV', 'FLAMINGO', 'F', 'FLAMINGO', 'FLAMINGO '),
(280, 'MX', '11000042', 'REGIOSUR OH SA DE CV', 'GRUPO REGIO', 'R', 'GRUPO REGIO', 'REGIO'),
(281, 'MX', '11000047', 'PURA VIDA PRESTOBAR, S.R.L.C.V.', 'BOVINOS', 'B', 'BOVINOS', 'BOVINOS'),
(282, 'MX', '5001600', 'TRANSPORTES EJECUTIVOS DE LUJO,S.A. DE C.V.', 'Cancun Passion', 'CP', 'PASSION', 'PASSION'),
(283, 'MX', '5001580', 'OPERADORA MEAT & BONE, SA DE CV', 'OPERADORA MEAT & BONE', 'OM', 'OPERADORA MEAT & BONE', 'MEAT'),
(284, 'MX', '11000048', 'VIAJES ACUATICOS TURQUESA,S.A DE C.V', 'MARINA MAROMA', 'MM', 'MARINA MAROMA', 'MAROMA'),
(285, 'MX', '11000045', 'INFINITO MAYA,S.A DE C.V', 'PARQUE MAYA CANCUN', 'IM', 'PARQUE MAYA CANCUN', 'PARKMAYA'),
(286, 'MX', '5001270', 'GO ESPEDITIONS,S.A DE C.V', 'GO NATURAL', 'GN', 'GO NATURAL', 'GONATURAL'),
(287, 'MX', '5001298', 'EMPRESAS TURISTICAS NACIONALES S.A DE C.V', 'PLAYA MIA GRAND BEACH PARK', 'PMGBP', 'PLAYA MIA GRAND BEACH PARK', 'PLAYAMIA'),
(288, 'MX', '11000072', 'AVENTURAS MAYAS SA DE CV', 'AVENTURAS MAYA', 'AM', 'AVENTURAS MAYA', 'AVENTURASM'),
(289, 'MX', '5001272', 'CANCUN SEA ADVENTURES SAPI DE C.V', 'CANCUN ADVENTURES', 'CA', 'CANCUN ADVENTURES', 'CANCUNADVT'),
(290, 'MX', '11000067', 'CONTROLADORA DOLPHIN, S.A. DE C.V.', 'DOLPHIN DISCOVERY', 'DD', 'DOLPHIN DISCOVERY', 'DOLPHIN'),
(291, 'MX', '5001271', 'Marina punta tampa sa de cv', 'Marina el cid', 'MC', 'Marina el cid', 'EL CID'),
(292, 'MX', '11000071', 'GALEON CAPITAN HOOK SA DE CV', 'Capitan Hook', 'CH', 'Capitan Hook', 'HOOK'),
(293, 'MX', '5001228', 'DE TODOS MODOS VIAJAMOS,S.A DE C.V', 'CUCURUMBE', 'C', 'CUCURUMBE', 'CUCRUMBE'),
(294, 'MX', '11000070', 'Alltour Native, SA DE CV', 'Alltour Native', 'AN', 'Alltour Native', 'NATIVE'),
(295, 'MX', '5001274', 'OPERADORA DE MARINAS SA DE CV', 'MARINA ALBATROS', 'MA', 'MARINA ALBATROS', 'ALBATROS'),
(296, 'MX', '5001601', 'Grupo Industrial Hotelero, SA de CV', 'COCO BONGO', 'CBO', 'COCO BONGO', 'COCO'),
(297, 'MX', '5001439', 'MARINA DEL SOL MAYA,S.A DE C.V', 'MARINA SUNRISE', 'MS', 'MARINA SUNRISE', 'MSUNRISE'),
(298, 'MX', '11000043', 'GRUPO INDUSTRIAL DE PLAYA, S.A DE C.V.', 'COCO BONGO', 'CB', 'COCO BONGO', 'COCO'),
(299, 'MX', '5001273', 'BJM DELIVERY, S.A. DE C.V.', 'AQUAWORLD', 'AQ', 'AQUAWORLD', 'AQUAWORLD'),
(300, 'MX', '7000031', 'Experiencias Xcaret Parques S.A.P.I. de C.V. ', 'Grupo Xcaret', 'xcaret', 'XCARET', 'XCA'),
(301, 'MX', 'BUSSINES ONE', 'Rio Secreto SA de CV', 'RIO SECRETO', 'RS', 'RIO SECRETO', 'RIOSECR'),
(302, 'MX', '7000025', 'Tagepa SAPI sa de cv', 'Tagepa', 'TAG', 'Tagepa', 'TAGEPA'),
(303, 'MX', '12000057', 'CORPORACION HOTELERA HISPANO MEXICANA', 'PARADISUS PLAYA DEL CARMEN LA ESMERALDA', 'PPCLE', 'Paradisus', 'PPC'),
(304, 'MX', '5001312', 'ADMINISTRADORA Y OPERADORA DE HOTELES JAD SA DE CV', 'OPTIMA HOTELES', 'OH', 'OPTIMA HOTELES', 'OPTIMA'),
(305, 'MX', '5001700', 'DEUTSCHE BANK MEXICO, S.A. IBM DIVISION FIDUCIARIA F/1616', 'MARRIOT PUEBLA', 'MP', 'MARRIOT PUEBLA', 'WYNDHAM'),
(306, 'MX', '5001700', 'DEUTSCHE BANK MEXICO, S.A. IBM DIVISION FIDUCIARIA F/1616', 'WYNDHAM GARDEN PLAYA DEL CARMEN', 'WGPC', 'WYNDHAM GARDEN PLAYA DEL CARMEN', 'WYNDHAM'),
(307, 'MX', '5001700', 'DEUTSCHE BANK MEXICO, S.A. IBM DIVISION FIDUCIARIA F/1616', 'WYNDHAM GARDEN MONTERREY VALLE REAL', 'WGMVR', 'WYNDHAM GARDEN MONTERREY VALLE REAL', 'WYNDHAM'),
(308, 'MX', '5001700', 'DEUTSCHE BANK MEXICO, S.A. IBM DIVISION FIDUCIARIA F/1616', 'WYNDHAM GARDEN LEON CENTRO MAX', 'WGLCM', 'WYNDHAM GARDEN LEON CENTRO MAX', 'WYNDHAM'),
(309, 'MX', '5000673', 'H DE A CORPORATIVO, S.A. DE C.V.', 'BEST WESTERN PLUS GRAND HOTEL MORELIA', 'BWPGHM', 'BEST WESTERN', 'BWP'),
(310, 'MX', '5001521', 'HOTELERA CENTRO HISTORICO, S.A. DE C.V.', 'HOTEL RITZ CIUDAD DE MEXICO', 'HRCM', 'HOTEL RITZ CIUDAD DE MEXICO', 'RITZ'),
(311, 'MX', '5001662', 'LUNA BRILLANTE, S.A.', 'RADISSON DECAPOLIS PANAMA CITY', 'RDPC', 'RADISSON DECAPOLIS PANAMA CITY', 'RADISSON'),
(312, 'NORT&CA', '5001661', 'MEGAPOLIS INVESTMENT GROUP INC', 'HARD ROCK HOTEL PANAMA MEGAPOLIS', 'HRHPM', 'HARD ROCK HOTEL PANAMA MEGAPOLIS', 'HARD'),
(313, 'MX', '5001730', 'OPERACION EFICIENTE DE HOTELES S.A. DE C.V.', 'HOTEL SUITES MEXICO PLAZA CAMPESTRE', 'HSMPC', 'HOTEL SUITES MEXICO PLAZA CAMPESTRE', 'HTLSUITES'),
(314, 'MX', '5000175', 'OPERADORA BADI,.S.A DE C.V', 'GRAND ISLA NAVIDAD RESORT', 'GINR', 'GRAND ISLA NAVIDAD RESORT', 'ISLANV'),
(315, 'MX', '5000187', 'OPERADORA DIANA DEL BOSQUE S.A DE C. V', 'HOTEL DIANA DEL BOSQUE', 'HDDB', 'HOTEL DIANA DEL BOSQUE', 'BOSQUE'),
(316, 'MX', '5000190', 'OPERADORA Y DESARROLLADORA IXZI S.A.DE C.V.', 'MANSION DE LOS SUEÑOS', 'MDLS', 'MANSION DE LOS SUEÑOS', 'SUEÑOS'),
(317, 'MX', '5000338', 'PRADOS CAMELINAS, S. A. DE C. V.', 'WYNDHAM GARDEN POLANCO', 'WGPC', 'WYNDHAM', 'WYND'),
(318, 'MX', '5000508', 'REY CORTES, S.A. DE C.V.', 'HOTEL ZOCALO CENTRAL', 'HZC', 'HOTEL ZOCALO CENTRAL', 'ZOCALO'),
(319, 'MX', '5000572', 'SERVICIOS E INMUEBLES TURISTICOS, S. DE R.L. DE C.V.', 'HILTON GUADALAJARA', 'HG', 'Hilton', 'HL'),
(320, 'MX', '5001732', 'UNIÓN IMPULSORA DE HOTELES,S.A. DE C.V.', 'HOTEL CASA BLANCA', 'HCB', 'HOTEL CASA BLANCA', 'CASABLC'),
(321, 'MX', 'PENDIENTE', 'LUNAR HOTEL ROOMS II CORP', 'BLUE DIAMOND RESORTS  ', 'BDR', 'BLUE DIAMOND', 'BLUEDIA'),
(322, 'MX', '5001290', 'ASOCIACION DE HOTELES Y MOTELES DE BAHIAS DE HUATULCO A.C.', 'ASOCIACION DE HOTELES Y MOTELES DE BAHIAS DE HUATULCO', 'ADHH', 'ASOCIACION DE HOTELES Y MOTELES DE BAHIAS DE ', 'HTLMTLBAHIA'),
(323, 'MX', '5001759', 'AVIAREPS S DE RL DE CV', 'AVIAREPS', 'AVIAREPS', 'AVIAREPS', 'AVIAREPS'),
(324, 'MX', '5001442', 'CENTRO VACACIONAL MIRAMAR SOLIDARIDAD,S.A DE C.V', 'CLUB MAEVA MIRAMAR TAMPICO', 'CMMT', 'CLUB MAEVA MIRAMAR TAMPICO', 'CLUBMAEVA'),
(325, 'MX', '5000385', 'DESARROLLADORA HOTELERA DE LA RIVIERA, SA DE CV', 'ROYALTON RIVIERA CANCUN RESORT AND SPA', 'RRCRAS', 'ROYALTON RIVIERA CANCUN RESORT AND SPA', 'ROYALTON'),
(326, 'MX', '5000383', 'DIAMOND HOTELS NUEVO VALLARTA S.A. DE C.V.', 'OCCIDENTAL NUEVO VALLARTA', 'ONV', 'Occidental', 'OC'),
(327, 'NORT&CA', '5000530', 'DISNEY', 'WDW Q2 march Campaigns', 'PENDIENTE', 'DISNEY', 'DISNEY'),
(328, 'MX', '5001651', 'EKO PARK LOS CABOS SA DE CV', 'Wild Canyon', 'WC', 'Wild Canyon', 'WILD'),
(329, 'MX', '5000667', 'GRUBARGES GESTION HOTELERA MEXICANA, S.A. DE C.V', 'OCCIDENTAL QUERETARO', 'OQ', 'Occidental', 'OC'),
(330, 'MX', '5001347', 'Grupo Hotelero Mexicano S.A. de C.V.', 'HOTEL POSADA GUADALAJARA', 'HPG', 'HOTEL POSADA GUADALAJARA', 'POSADAGDL'),
(331, 'MX', '5001578', 'HOTEL HOYO UNO, S. DE R.L. DE C.V.', 'ANDAZ MAYAKOBA A CONCEPT BY HYATT', 'AMCBH', 'ANDAZ MAYAKOBA A CONCEPT BY HYATT', 'ANDAZR'),
(332, 'MX', '5000841', 'HOTELES REAL DE CHIHUAHUA .S A DE C.V', 'SHERATON CHIHUAHUA SOBERANO', 'SCS', 'SHERATON CHIHUAHUA SOBERANO', 'SHERATON'),
(333, 'MX', '5000934', 'IMPULSORA TURISTICA DE TABASCO SA DE CV', 'VIVA VILLAHERMOSA', 'VV', 'VIVA VILLAHERMOSA', 'VIVAVILLA'),
(334, 'MX', '5000907', 'IMSALMAR, S.A. DE C.V.', 'YES INN NUEVO VERACRUZ', 'YINV', 'YES INN NUEVO VERACRUZ', 'OSTAR'),
(335, 'MX', '5000907', 'IMSALMAR, S.A. DE C.V.', 'LORETO BAY GOLF RESORT AND SPA AT BAJA', 'LBGRS', 'LORETO BAY GOLF RESORT AND SPA AT BAJA', 'OSTAR'),
(336, 'MX', '5000907', 'IMSALMAR, S.A. DE C.V.', 'HOTEL RACQUEL CUERNAVACA', 'HRC', 'HOTEL RACQUEL CUERNAVACA', 'OSTAR'),
(337, 'NORT&CA', '5001245', 'MERLIN ENTERTAINMENTS GROUP US HOLDING, INC', 'LEGOLAND FLORIDA RESORT', 'LFR', 'LEGOLAND FLORIDA RESORT', 'LEGOLAND'),
(338, 'NORT&CA', '5000176', 'MGM RESORTS INTERNACIONAL', 'MGM', 'MGM', 'MGM', 'MGM'),
(339, 'MX', '5001441', 'MUNICIPIO DE MORELIA MICHOACAN', 'SECRETARIA DE TURISMO MUNICIPAL', 'STM', 'SECRETARIA DE TURISMO MUNICIPAL', 'MUNMRL'),
(340, 'MX', '5001485', 'OPERADORA IXSOL, S.A. DE C.V.', 'CALA DE MAR', 'CM', 'CALA DE MAR', 'CALA MAR'),
(341, 'NORT&CA', '5001714', 'Orange County Convention and Visitors Bureau', 'VISIT ANAHEIM', 'VA', 'VISIT ANAHEIM', 'VISIT'),
(342, 'MX', '5000491', 'PARAISO TURISTICO GD, SA DE CV', 'GRUPO DIESTRA', 'GD', 'CORPDIESTRA', 'DIESTRA'),
(343, 'MX', '19000018', 'PROCUREKA, S.A. DE C.V', 'SEADUST CANCUN FAMILY RESORT', 'SCFR', 'Seadust', 'SD'),
(344, 'MX', '11000046', 'STARCOM WORLDWIDE, S. A. DE C. V.', 'WORLDWIDE', 'W', 'WORLDWIDE', 'WORLDWIDE'),
(345, 'MX', '5001810', 'ALFONSO TOVAR LEDEZMA', 'HOTEL SEÑORIAL QUERETARO', 'PENDIENTE', 'HOTEL SEÑORIAL QUERETARO', 'SEÑORIAL'),
(346, 'MX', '5000082', 'BEIRAVIA SA DE CV', 'DOMUN HOTEL', 'PENDIENTE', 'DOMUN HOTEL', 'DOMUN'),
(347, 'MX', '5001315', 'Desarrollo Flamingo, S.A. de C.V.', 'FLAMINGO INN', 'PENDIENTE', 'FLAMINGO', 'FLAMINN'),
(348, 'MX', '5001191', 'DESARROLLO OPTIMA, SA DE CV', 'SAFI ROYAL LUXURY TOWERS', 'PENDIENTE', 'SAFI ROYAL LUXURY TOWERS', 'SAFIROYAL'),
(349, 'MX', '5001795', 'HOTELERA YALKUITO, S.A. DE C.V.', 'GRAND SIRENIS RIVIERA MAYA', 'PENDIENTE', 'GRAND SIRENIS RIVIERA MAYA', 'SIRENIS'),
(350, 'MX', '5000867', 'HOTELEROS VALHER SA DE CV', 'VN HOTEL', 'PENDIENTE', 'VN HOTEL', 'VNHOTEL'),
(351, 'MX', '5000849', 'HOTELES Y SERVICIOS CASA BLANCA, S.ADE C.V', 'Fairfield Inn By Marriott Monterrey Aeropuerto', 'PENDIENTE', 'Fairfield Inn By Marriott Monterrey Aeropuert', 'FAIRFIELD'),
(352, 'MX', '5000910', 'INMOBILIARIA OGAME, S.A. DE C.V.', 'HOTEL MIRAGE', 'PENDIENTE', 'HOTEL MIRAGE', 'MIRAGE'),
(353, 'MX', '5000898', 'INMUEBLES IBERIA DE QUERETARO, S.A. DE C.V.', 'HOTEL MIRABEL', 'PENDIENTE', 'HOTEL MIRABEL', 'MIRABEL'),
(354, 'MX', '5001813', 'OPERADORA ALAMEDA PARK SA DE CV', 'PLAZA CAMELINAS', 'PENDIENTE', 'PLAZA CAMELINAS', 'CAMELINAS'),
(355, 'MX', '5001720', 'OPERADORA DE HOTELES BELLAMAR, S.A. DE C.V.', 'OLAS ALTAS INN HOTEL & SPA', 'PENDIENTE', 'OLAS ALTAS INN HOTEL & SPA', 'OLAS'),
(356, 'MX', '5000211', 'OPERADORA DE HOTELES CITY EXPRESS, S.A. DE C.V.', 'CITY EXPRESS  ', 'PENDIENTE', 'CITY EXPRESS  ', 'CITYEXPRESS'),
(357, 'MX', '5001814', 'OPERADORA DE HOTELES TURISTICOS ZONA SUR', 'VILLA BALU HOTEL BOUTIQUE', 'PENDIENTE', 'VILLA BALU HOTEL BOUTIQUE', 'VBALU'),
(358, 'MX', '5001815', 'OPERADORA RUMBO AL TROPICO, SA DE CV', 'LAS NUBES DE HOLBOX', 'PENDIENTE', 'LAS NUBES DE HOLBOX', 'NUBESHBL'),
(359, 'MX', '5001793', 'SOL INTEGRAL, SRL DE CV', 'ECOVERGEL HOTEL BOUTIQUE', 'PENDIENTE', 'ECOVERGEL HOTEL BOUTIQUE', 'ECOVERGEL'),
(360, 'NORT&CA', '5001811', 'WYNN RESORTS, LTD', 'WYNN LAS VEGAS LLC', 'PENDIENTE', 'WYNN LAS VEGAS LLC', 'WYNN'),
(361, 'NORT&CA', '5000740', 'HOTELES BEST WESTERN AC', 'BEST WESTERN MEXICO', 'PENDIENTE', 'BEST WESTERN MEXICO', 'BESTW'),
(362, 'MX', '5001820', 'COMPAÑÍA IBEROAMERICANA DE SERVICIOS TURISTICOS, SA', 'IMPRESSIVE HOTELS AND RESORTS', 'PENDIENTE', 'IMPRESSIVE HOTELS AND RESORTS', 'IMPRESSIVE'),
(363, 'MX', '5000713', 'HOTEL AGUA ESCONDIDA, SA DE CV', 'HOTEL AGUA ESCONDIDA', 'PENDIENTE', 'HOTEL AGUA ESCONDIDA', 'AGUAESC'),
(364, 'MX', '5001823', 'MOTELES MEXICANOS, S.A. DE C.V.', 'HOTEL LOMA LINDA TAXCO', 'PENDIENTE', 'HOTEL LOMA LINDA TAXCO', 'LOMAL'),
(365, 'MX', '5001822', 'MAJUL SAJA SA DE CV', 'BEST WESTERN TAXCO', 'PENDIENTE', 'BEST WESTERN TAXCO', 'BESTW'),
(366, 'MX', '5001821', 'GRUPO TAXCO HOTEL SA DE CV', 'POSADA DE LA MISION HOTEL MUSEO JARDIN', 'PENDIENTE', 'POSADA DE LA MISION HOTEL MUSEO JARDIN', 'MUSEOJRD'),
(367, 'MX', '5001819', 'FRANCISCO JAVIER CASTILLO GARCIA', 'HOTEL POSADA SAN JAVIER', 'PENDIENTE', 'HOTEL POSADA SAN JAVIER', 'POSADAJV'),
(368, 'MX', '5001876', 'AEROENLACES NACIONALES SA DE CV', 'VIVAAEROBUS', 'PENDIENTE', 'VIVA', 'VIVA'),
(369, 'MX', 'PENDIENTE', 'OPERADOR DE SERVICIOS TURISTICOS RIO SR DE L DE CV', 'HOTEL RIO QUERETARO', 'PENDIENTE', 'HOTEL RIO QUERETARO', 'RIOQTO'),
(370, 'MX', 'PENDIENTE', 'SHOOTVENIRS SAPI DE CV', 'SHOOTVENIRS ', 'PENDIENTE', 'SHOOTVENIRS ', 'SHOOTVENIRS'),
(371, 'MX', '5001188', 'CORPORACIÓN INMOBILIARIA KTRC, S.A.DE .C.V.', 'HARD ROCK HOTELS MEXICO', 'HRHM', 'HARD ROCK', 'HARD'),
(372, 'NORT&CA', 'PENDIENTE', 'FELTRIM RESORT LLC', 'FELTRIM RESORT LLC / BALMORAL RESORT FLORIDA', 'PENDIENTE', 'FELTRIM RESORT LLC / BALMORAL RESORT FLORIDA', 'FELTRIM'),
(373, 'NORT&CA', 'PENDIENTE', 'EXPERIENCE KISSIMMEE', 'EXPERIENCE KISSIMMEE', 'PENDIENTE', 'KISSIMMEE', 'KISS'),
(374, 'NORT&CA', '5001877', 'THE COSMOPOLITAM LAS VEGAS', 'NEVADA PROPERTY 1 LLC', 'PENDIENTE', 'NEVADA', 'NEVADA'),
(375, 'MX', '5001247', 'VILLAS SOLARIS, S. DE R.L. DE C.V.', 'HOTELES SOLARIS', 'HSJ', 'SOLARIS', 'SOLAR'),
(376, 'MX', '5001893', 'HOTELES ACA VIEW', 'Playa Suites Acapulco. ', 'PSA', 'SUITES', 'SUITES'),
(377, 'MX', 'PENDIENTE', 'PROMOTORA TIIM, SA DE CV', 'ALOFT CANCUN', 'PENDIENTE', 'ALOFT', 'ALOFT'),
(378, 'MX', 'PENDIENTE', 'TRANSPORTES CANCUN SEA ADVENTURES SA DE CV', 'TRANSPORTES CANCUN SEA ADVENTURES', 'PENDIENTE', 'ADVENTURES', 'ADVEN'),
(379, 'MX', 'PENDIENTE', 'INMOBILIARIA RUIZ SOUZA SA DE CV', 'SR HOTEL', 'PENDIENTE', 'SR', 'SR'),
(380, 'MX', 'PENDIENTE', 'OPERADORA MARINA PLAYA BLANCA, SA DE CV', 'RENAISSANCE CANCUN', 'PENDIENTE', 'RENAISSANCE', 'RENA'),
(381, 'MX', '5000863', 'HOTELES TURISTICOS DE IXTAPA, S.A.DE C.V.', 'Emporio Ixtapa', 'EI', 'EMPORIO', 'DIESTRA'),
(382, 'MX', '5000186', 'OPERADORA COMPOSTELA VALLARTA, S.A.DE C.V.', 'Samba Vallarta', 'SV', 'EMPORIO', 'DIESTRA'),
(383, 'MX', '5000373', 'OPERADORA DIESTRA CANCUN,S.A DE C.V', 'Emporio Cancun', 'EC', 'EMPORIO', 'DIESTRA'),
(384, 'MX', '5000199', 'OPERADORA EMPORIO VERACRUZ, S.A DE C.V.', 'Emporio Veracruz', 'EV', 'EMPORIO', 'DIESTRA'),
(385, 'MX', '5000200', 'OPERADORA EMPORIO ZACATECAS, S.A.DE C.V.', 'Emporio Zacatecas', 'EZ', 'EMPORIO', 'DIESTRA'),
(386, 'MX', '5000316', 'OPERADORA TORNAZ DE MAZATLAN,S.A. DE C.V.', 'Emporio Mazatlan', 'EM', 'EMPORIO', 'DIESTRA'),
(387, 'MX', '5000311', 'OPERADORA TURISTICA EMPORIO REFORMA, SA DE CV', 'Emporio Reforma', 'ER', 'EMPORIO', 'DIESTRA'),
(388, 'MX', '5000553', 'SERVICIOS EXTERNOS PARA HOTELES, S.A. DE C.V.', 'Emporio Acapulco', 'EA', 'EMPORIO', 'DIESTRA'),
(389, 'MX', '5000369', 'Corporacion Villagroup, SA de CV', 'Villa La Estancia Beach Resort & Spa Cabo', 'VEBRS', 'VILLA ESTANCIA', 'VILLAGROUP'),
(390, 'MX', '5000369', 'Corporacion Villagroup, SA de CV', 'Villa Del Palmar Beach Resort And Spa Cabo', 'VPBRSC', 'VILLA PALMAR', 'VILLAGROUP'),
(391, 'MX', '5000369', 'Corporacion Villagroup, SA de CV', 'Villa Del Mar Puerto Vallarta By Villa Group ', 'VMPVVG', 'VILLA MAR', 'VILLAGROUP'),
(392, 'MX', '5000369', 'Corporacion Villagroup, SA de CV', 'Villa Del Palmar Beach Resort And Spa Vallarta ', 'VDPBRSV', 'VILLA PALMARVAL', 'VILLAGROUP'),
(393, 'MX', '5000369', 'Corporacion Villagroup, SA de CV', 'Villa Del Palmar Flamingos Beach Resort And  Spa', 'VDPFBRS', 'VILLA PALMARFLA', 'VILLAGROUP'),
(394, 'MX', '5000369', 'Corporacion Villagroup, SA de CV', 'Villa La Estancia Riviera Nayarit By Villa Group', 'VERNVG', 'VILLA ESTANCIARN', 'VILLAGROUP'),
(395, 'MX', '5000163', 'NYX DEVELOPMENT,S.A DE C.V', 'NYX HOTEL CANCUN', 'NYX', 'NYX', 'NYX'),
(396, 'MX', '5001219', 'HOTELERA PALACE RESORTS SAPI CV ', 'PALACE', 'OPR', 'Palace Resorts', 'PLC'),
(397, 'MX', '5001292', 'Conjunto Desarrollo marina mar sa de cv', 'Paradise beach resort and spa', 'PBRS', 'PARADISE', 'PARADISE'),
(398, 'MX', '5001293', 'HOTELERA SUNRISE, S.A DE C.V', 'HACIENDA TRES RIOS RESORT, SPA & NATURE PARK', '', 'TRES RIOS', '3RIOS'),
(399, 'NORT&CA', '5000558', 'POSADAS USA ', 'GRUPO POSADAS RESORT', 'GPR', 'POSADAS', 'POSADAS');
INSERT INTO `clientes` (`id_clientes`, `region`, `id_hanna`, `razon_social`, `nombre_comercial`, `siglas_hanna`, `sigla_hoteles`, `abrev_hotel`) VALUES
(400, 'MX', '5000535', 'Representaciones Turísticas Mexico, S.A. de C.V.', 'Grand Bahia Principe Coba', 'GBPC', 'Bahia Principe', 'BP'),
(401, 'MX', '5000535', 'Representaciones Turísticas Mexico, S.A. de C.V.', 'Luxury Bahia Principe Akumal Don Pablo Collection', 'LBPADPC', 'Bahia Principe', 'BP'),
(402, 'MX', '5000535', 'Representaciones Turisticas Mexico, S.A. de C.V.', 'Grand Bahia Principe Tulum', 'GBPT', 'Bahia Principe', 'BP'),
(403, 'MX', '5000535', 'Representaciones Turisticas Mexico, S.A. de C.V.', 'Luxury Bahia Principe Sian Kaan Don Pablo Collection', 'LBPSKDPC', 'Bahia Principe', 'BP'),
(404, 'MX', '5000458', 'BCO Kukulkan, S de RL de CV', 'Occidental Costa Cancun ', 'OCC', 'Barcelo', 'BC'),
(405, 'MX', '5000500', 'BCO Tucancun, S de RL de CV ', 'Occidental Tucancun', 'OT', 'Barcelo', 'BC'),
(406, 'MX', '5000370', 'Cozumel Villages, SA de CV', 'Occidental Cozumel', 'OC', 'Occidental', 'OC'),
(407, 'MX', '5000379', 'DESARROLLO FLAMENCO RIVIERA, S.A. DE C.V.', 'Occidental at Xcaret Destination', 'OXD', 'Occidental', 'OC'),
(408, 'MX', '5000381', 'Diamond Hotels Cozumel, SA de CV', 'Allegro Cozumel', 'AC', 'Occidental', 'OC'),
(409, 'MX', '5000384', 'Diamond Hotels Playacar , s.a. de c.v.', 'Allegro Playacar', 'AP', 'Occidental', 'OC'),
(410, 'MX', '5000657', 'GRUBARGES GESTION HOTELERA MEXICANA, S.A. DE C.V', 'Occidental JF Puebla', 'OJP', 'Occidental', 'OC'),
(411, 'MX', '5000689', 'Grubarges Inversiones Hoteleras Mexicanas, S. de R.L. de C.V.', 'Barcelo Ixtapa', 'BI', 'Barcelo', 'BC'),
(412, 'MX', '5000377', 'HOSPITALIDAD TURISTICA, S.A. DE C.V.', 'Barcelo Gran Faro Los Cabos', 'BGFC', 'Barcelo', 'BC'),
(413, 'MX', '5000846', 'Hotel Royal Playacar,s.a. de c.v.', 'Royal Hideaway Playacar Adults Only', 'RHPAO', 'Occidental', 'OC'),
(414, 'MX', '5000456', 'Primavera Inn, S. de R.L. de C.V.', 'Occidental Cuernavaca', 'OC', 'Barcelo', 'BC'),
(415, 'MX', '5001182', 'Quiroocan, S.A. de C.V.', 'Barcelo Mexico Reforma', 'BMR', 'Barcelo', 'BC'),
(416, 'MX', '5000506', 'Quiroocan, S.A. de C.V.', 'Barcelo Maya Tropical', 'BMT', 'Barcelo', 'BC'),
(417, 'MX', '5000506', 'Quiroocan, S.A. de C.V.', 'Barcelo Maya Caribe ', 'BMC', 'Barcelo', 'BC'),
(418, 'MX', '5000506', 'Quiroocan, S.A. de C.V.', 'Barcelo Maya Colonial ', 'BMC', 'Barcelo', 'BC'),
(419, 'MX', '5000506', 'Quiroocan, S.A. de C.V.', 'Barcelo Maya Beach ', 'BMB', 'Barcelo', 'BC'),
(420, 'MX', '5000506', 'Quiroocan, S.A. de C.V.', 'Barcelo Maya Palace', 'BMP', 'Barcelo', 'BC'),
(421, 'MX', '5000127', 'CHARTWELL INMOBILIARIA DE MONTERREY,S DE RL DE CV', 'HILTON GARDEN INN MONTERREY  ', 'HGIM', 'Krystal', 'KR'),
(422, 'MX', '5000112', 'Consorcio Hotelero Aeropuerto Monterrey SAPI De CV', 'HILTON GARDEN INN MONTERREY AEROPUERTO', 'HGIMA', 'Hilton', 'HL'),
(423, 'MX', '5000897', 'INMOBILIARIA EN HOTELERIA VALLARTA SANTA FE S DE R.L DE C.V', 'The Hacienda At Hilton Puerto Vallarta', 'THHPV', 'Hilton', 'HL'),
(424, 'MX', '5000897', 'INMOBILIARIA EN HOTELERIA VALLARTA SANTA FE S DE R.L DE C.V', 'HILTON PUERTO VALLARTA', 'HPV', 'Hilton', 'HL'),
(425, 'MX', '5000643', 'YAMAN SA DE CV', 'HAMPTON INN & SUITES BY HILTON PARAISO', 'HISHP', 'Hilton', 'HL'),
(426, 'MX', '5000038', 'ARRENDADORA LOS ANGELES VALLARTA S.A DE C.V', 'KRYSTAL GRAND NUEVO VALLARTA', 'KGNV', 'Krystal', 'KR'),
(427, 'MX', '5000124', 'CHARTWELL INMOBILIARIA DE JUAREZ, S.DE R.L C.V.', 'Krystal Bussines Hotel Cd. Juarez', 'KBHCJ', 'Krystal', 'KR'),
(428, 'MX', '5000685', 'GRUPO HOTELERO SF DE MEXICO S DE R.L.DE C.V', 'KRYSTAL BEACH ACAPULCO', 'KBA', 'Krystal', 'KR'),
(429, 'MX', '5000744', 'HOTELERA CARACOL,S.A DE C.V', 'KRYSTAL IXTAPA', 'KI', 'Krystal', 'KR'),
(430, 'MX', '5000757', 'HOTELERA CHICOME ,S.A DE C.V', 'KRYSTAL CANCUN', 'KC', 'Krystal', 'KR'),
(431, 'MX', '5000757', 'HOTELERA CHICOME ,S.A DE C.V', 'Krystal Club All Inclusive', 'KCLCAI', 'Krystal', 'KR'),
(432, 'MX', '5000893', 'INMOBILIARIA EN HOTELERIA CANCUN SANTA FE S DE RL DE C.V', 'KRYSTAL GRAND PUNTA CANCUN', 'KGPC', 'Krystal', 'KR'),
(433, 'MX', '5000893', 'INMOBILIARIA EN HOTELERIA CANCUN SANTA FE S DE RL DE C.V', 'Altitude By Krystal Grand Punta Cancun-All Inclusive', 'AKGPCA', 'Krystal', 'KR'),
(434, 'MX', '5000894', 'INMOBILIARIA HOTELERA CANCUN URBAN S. DE R.L. DE C.V.', 'KRYSTAL URBAN CANCUN', 'KUC', 'Krystal', 'KR'),
(435, 'MX', '5001404', 'INMOBILIARIA K SUITES 1991', 'KRYSTAL GRAND SUITES INSURGENTES', 'KGSI', 'Krystal', 'KR'),
(436, 'MX', '5000152', 'MOTELES Y RESTORANES MARIA BARBARA, S.A DE C.V', 'KRYSTAL SATELITE MARIA BARBARA', 'KSMB', 'Krystal', 'KR'),
(437, 'MX', '5000242', 'Operadora De Hoteles Pachuca SA De CV', 'Krystal Pachuca', 'KP', 'Krystal', 'KR'),
(438, 'MX', '5000256', 'OPERADORA INCA SA DE CV', 'KRYSTAL MONTERREY', 'KM', 'Krystal', 'KR'),
(439, 'MX', '5000332', 'Promotora Los Angeles Cabos S.A. De C.V.', 'Krystal Grand Los Cabos All Inclusive', 'KGCAI', 'Krystal', 'KR'),
(440, 'MX', '5000332', 'Promotora Los Angeles Cabos S.A. De C.V.', 'Residence By Krystal Grand All Inclusive', 'RKGAI', 'Krystal', 'KR'),
(441, 'MX', '5001306', 'Promotora Turistica Mexicana, S.A. DE C.V.', 'NH Krystal Puerto Vallarta', 'NKPV', 'Krystal', 'KR'),
(442, 'MX', '5000563', 'SERVICIOS HOTELEROS METROPOLITANOS S.A. DE C.V', 'Krystal Urban Aeropuerto Ciudad de Mexico', 'KUACM', 'Krystal', 'KR'),
(443, 'MX', '5000580', 'Sf Partners Ii S. De R.L. De C.V.', 'Krystal Urban Guadalajara', 'KUG', 'Krystal', 'KR'),
(444, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe San Juan', 'GBPSJ', 'Bahia Principe', 'BP'),
(445, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe El Portillo', 'GBPP', 'Bahia Principe', 'BP'),
(446, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe La Romana', 'GBPR', 'Bahia Principe', 'BP'),
(447, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe Jamaica', 'GBPJ', 'Bahia Principe', 'BP'),
(448, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe Coba', 'GBPCOBA', 'Bahia Principe', 'BP'),
(449, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe Tulum', 'GBPTULUM', 'Bahia Principe', 'BP'),
(450, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'GRAND BAHIA PRINCIPE BAVARO RESORT', 'GBP', 'Bahia Principe', 'BP'),
(451, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe Turquesa', 'GBPT', 'Bahia Principe', 'BP'),
(452, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe Punta Cana', 'GBPPC', 'Bahia Principe', 'BP'),
(453, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Grand Bahia Principe Cayacoa', 'GBPC', 'Bahia Principe', 'BP'),
(454, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Luxury Bahia Principe Akumal Don Pablo Collection', 'LBPADPC', 'Bahia Principe', 'BP'),
(455, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Luxury Bahia Principe Ambar Don Pablo Collection', 'LBPAMBARDPC', 'Bahia Principe', 'BP'),
(456, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Luxury Bahia Principe Bouganville Adults Only Don Pablo Collection', 'LBPBAODPC', 'Bahia Principe', 'BP'),
(457, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Luxury Bahia Principe Cayo Levantado Don Pablo Collection', 'LBPCLDPC', 'Bahia Principe', 'BP'),
(458, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Luxury Bahia Principe Esmeralda Don Pablo Collection', 'LBPEDPC', 'Bahia Principe', 'BP'),
(459, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Luxury Bahia Principe Runaway Bay Adults Only DPC', 'LBPRBAO', 'Bahia Principe', 'BP'),
(460, 'MX', '5000637', 'KIPPIN S.A., LUSSEMBURGO CADEMPINO BRANCH   VAT Nº: CHE110607281', 'Luxury Bahia Principe Sian Kaan Don Pablo Collection', 'LBPSKDPC', 'Bahia Principe', 'BP'),
(461, 'MX', '5000516', 'Allegro Palm Beach VBA', 'Barcelo Aruba', 'BA', 'Occidental', 'OC'),
(462, 'MX', '5000518', 'Bahia Langosta Tamarindo Ltda', 'Occidental Tamarindo', 'OT', 'Barcelo', 'BC'),
(463, 'MX', '5000519', 'Barcelo Gestion Hotelera', 'Barceló Guatemala City', 'BGC', 'Barcelo', 'BC'),
(464, 'MX', '5000520', 'BCLO BRISA PUNTA CANA B.V', 'Occidental Caribe ', 'OC', 'Barcelo', 'BC'),
(465, 'MX', '5000521', 'Corporacion Algard', 'Barcelo San Jose', 'BSJ', 'Barcelo', 'BC'),
(466, 'MX', '5001237', 'Hoteles e inversiones sa de cv', 'Barcelo san salvador', 'BSS', 'Barcelo', 'BC'),
(467, 'MX', '5000543', 'Marina Punta Piedra Amarilla, S.A.', 'Barcelo Tambor ', 'BT', 'Barcelo', 'BC'),
(468, 'MX', '5000552', 'Montelimar, SA', 'Barcelo Montelimar ', 'BM', 'Barcelo', 'BC'),
(469, 'MX', '5000556', 'Occidental  smeralda S.A', 'Occidental Papagayo All Inclusive Adults Only', 'OPAIAO', 'Occidental', 'OC'),
(470, 'MX', '5000593', 'PROMOTORA HBP, S.A.', 'Occidental Panama City', 'OPC', 'Occidental', 'OC'),
(471, 'MX', '5001513', 'Restaurant Lina C. x A.', 'Barcelo Santo Domingo', 'BSD', 'Barcelo', 'BC'),
(472, 'MX', '5000532', 'Grupo Amano Internacional; SA ', 'Barceló Managua ', 'BM', 'Barcelo', 'BC'),
(473, 'MX', '5001512', 'Hotelera Bavaro S.A.', 'Barcelo Bavaro Palace', 'BBP', 'Barcelo', 'BC'),
(474, 'MX', '5001512', 'Hotelera Bavaro S.A.', 'Barcelo Bavaro Beach Adults Only', 'BBBAO', 'Barcelo', 'BC'),
(475, 'MX', '11000009', 'OCCIFITUR DOMINICANA, SRL', 'El Embajador a Royal Hideaway Hotel', 'EERHH', 'Occidental', 'OC'),
(476, 'MX', 'PENDIENTE', 'Inversora Internacional Hotelera Srl', 'Occidental Punta Cana', 'PENDIENTE', 'Occidental', 'OC'),
(477, 'MX', 'PENDIENTE', 'INMOBILIARIA GALERIA PLAZA IRAPUATO', 'GALERIA PLAZA IRAPUATO', 'PENDIENTE', 'Brisas', 'BR'),
(478, 'MX', 'PENDIENTE', 'SERVICIOS INTEGRALES PIN', 'IBIS IRAPUATO', 'PENDIENTE', 'Hilton', 'HL'),
(479, 'MX', 'PENDIENTE', 'INMOBILIARIA HOTELERA DEL BAJIO SF', 'CLEVIA GRAND HOTEL', 'PENDIENTE', 'Hilton', 'HL'),
(480, 'MX', 'PENDIENTE', 'OPERADORA PALACE RESORTS', 'PALACE RESORTS', 'PENDIENTE', 'Palace Resorts', 'PLC'),
(481, 'MX', 'PENDIENTE', 'ATELIER DE HOTELES', 'ATELIER DE HOTELES', 'PENDIENTE', 'Atelier', 'ATL'),
(482, 'MX', '5000474', 'BCO RESORTS MANZANILLO', 'BARCELO KARMINA', 'BK', 'Barcelo', 'BC'),
(483, 'MX', '5000102', 'COZUMEL CARIBE SA DE CV', 'GRAND PARK ROYAL COZUMEL', 'GPRC', 'Park Royal', 'PR'),
(484, 'MX', '5000885', 'INMOBILIARIA CANCUN CARIBE', 'THE VILLAS CANCUN BY GRAND PARK ROYAL CANCUN CARIBE', 'TVCGPRCC', 'Park Royal', 'PR'),
(485, 'MX', '5000106', 'COMERCIALIZADORA Y DESARROLLADORA OCEAN SA DE CV', 'PARK ROYAL LOS CABOS', 'PRC', 'Park Royal', 'PR'),
(486, 'MX', '5000889', 'LARTES SA DE CV', 'Park Royal Puerto Vallarta All Inclusive Family Beach Resort', 'PRPVAIFB', 'Park Royal', 'PR'),
(487, 'MX', '5000438', 'GPO ADMINISTRADOR INMOBILIARIO SA DE CV', 'PARK ROYAL MAZATLAN', 'PRM', 'Park Royal', 'PR'),
(488, 'MX', '5000885', 'INMOBILIARIA CANCUN CARIBE', 'GRAND PARK ROYAL CANCUN CARIBE', 'GPRCC', 'Park Royal', 'PR'),
(489, 'MX', '5000389', 'DESARROLLADORA INMOBILIARIA DEL SUR SA DE CV', 'PARK ROYAL IXTAPA', 'PRI', 'Park Royal', 'PR'),
(490, 'MX', '5000539', 'SERVICIOS ADMINISTRATIVOS ETISA SA DE CV', 'PARK ROYAL ACAPULCO', 'PRA', 'Park Royal', 'PR'),
(491, 'MX', '5000454', 'PROMOTORA DE INMUEBLES DEL CARIBE SA DE CV', 'PARK ROYAL CANCUN', 'PRC', 'Park Royal', 'PR'),
(492, 'MX', '5000878', 'INMOBILIARIA ALEMI SA DE CV', 'PARK ROYAL HUATULCO', 'PRH', 'Park Royal', 'PR'),
(493, 'MX', 'PENDIENTE', 'HOTELES CANCUN K20', 'THE WESTIN RESORT & SPA CANCUN', 'PENDIENTE', 'Gpo Vistana Westin', 'VW'),
(494, 'MX', 'PENDIENTE', 'TURISTICA CANCUN', 'THE WESTIN LAGUNAMAR RESORT OCEAN VILLAS & SPA', 'PENDIENTE', 'Gpo Vistana Westin', 'VW'),
(495, 'MX', 'PENDIENTE', 'HOTELES CABOS K22.5', 'THE WESTIN LOS CABOS RESORT VILLAS & SPA', 'PENDIENTE', 'Gpo Vistana Westin', 'VW'),
(496, 'MX', 'PENDIENTE', 'RESORT ROOM SALES', 'HYATT ZIVA ROSE HALL Y HYATT ZILARA ROSE HALL', 'PENDIENTE', 'Playa Resorts', 'PL'),
(497, 'MX', 'PENDIENTE', 'INVERSIONES GINARK', 'SANCTUARY CAP CANA ALL INCLUSIVE BY PLAYA HOTELS RESORTS', 'PENDIENTE', 'Playa Resorts', 'PL'),
(498, 'MX', 'PENDIENTE', 'INVERSIONES GINARK', 'HILTON LA ROMANA BY PLAYA HOTELS RESORTS', 'PENDIENTE', 'Playa Resorts', 'PL'),
(499, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Holiday Inn Puebla La Noria', 'HIPAI', 'Presidente', 'PRE'),
(500, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Presidente Intercontinental Ciudad de Mexico', 'PICM', 'Presidente', 'PRE'),
(501, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Holiday inn Resort Los Cabos All Inclusive', 'HIRLCAI', 'Presidente', 'PRE'),
(502, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Presidente Intercontinental Cancun Resort', 'PICRS', 'Presidente', 'PRE'),
(503, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Presidente Intercontinental Santa Fe', 'PISF', 'Presidente', 'PRE'),
(504, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Presidente Intercontinental Guadalajara', 'PIG', 'Presidente', 'PRE'),
(505, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Holiday inn Resort Ixtapa All Inclusive', 'HIRIAI', 'Presidente', 'PRE'),
(506, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'HOLIDAY INN EXPRESS & SUITES CELAYA', 'HIE&SC', 'Presidente', 'PRE'),
(507, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Presidente Intercontinental Cozumel Resort and Spa', 'PICRS', 'Presidente', 'PRE'),
(508, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Presidente Intercontinental Villa Mercedes', 'PIVM', 'Presidente', 'PRE'),
(509, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Presidente Intercontinental Puebla', 'PENDIENTE', 'Presidente', 'PRE'),
(510, 'MX', '5001891', 'HOTELES Y CENTROS ESPECIALIZADOS, S.A.', 'Holiday Inn Express Puebla', 'PENDIENTE', 'Presidente', 'PRE'),
(511, 'MX', '5000416', 'ESMERALDA MANAGEMENT SA DE CV', 'BLUEBAY GRAND ESMERALDA', 'BGE', 'Bluebay', 'BLUE'),
(512, 'MX', '5000883', 'inviertiendo en el Caribe SA DE CV', 'EL DORADO ROYALE RIVIERA MAYA', 'EDRRM', 'KARISMA', 'KARI'),
(513, 'MX', '5000883', 'inviertiendo en el Caribe SA DE CV', 'EL DORADO CASITAS, RIVIERA MAYA', 'EDC, R', 'KARISMA', 'KARI'),
(514, 'MX', '5000949', 'OPERADORA GENTION SA DE CV', 'GENERATIONS RIVIERA MAYA', 'GRM', 'KARISMA', 'KARI'),
(515, 'MX', '5000237', 'OPERADORA HOLIDAY EN LA PLAYA SA DE CV', 'EL DORADO SEASIDE SUITES PALM', 'EDSSP', 'KARISMA', 'KARI'),
(516, 'MX', '5000237', 'OPERADORA HOLIDAY EN LA PLAYA SA DE CV', 'EL DORADO SEASIDE SUITES INFINITY', 'EDSSI', 'KARISMA', 'KARI'),
(517, 'MX', '5000264', 'OPERADORA MAROMITA SA DE CV', 'EL DORADO MAROMA RIVIERA MAYA', 'EDMRM', 'KARISMA', 'KARI'),
(518, 'MX', '5000270', 'OPERADORA MARE LUZA SA DE CV', 'AZUL BEACH RESORT RIVIERA CANCUN', 'PENDIENTE', 'KARISMA', 'KARI'),
(519, 'MX', '5000262', 'OPERADORA LUZA SA DE CV', 'AZUL BEACH RESORT RIVIERA MAYA', 'ABRRM', 'KARISMA', 'KARI'),
(520, 'MX', '5000050', 'AITANA HOTELERA SA DE CV', 'AZUL BEACH RESORT THE FIVES', 'ABRTF', 'KARISMA', 'KARI'),
(521, 'NORT&CA', 'PENDIENTE', 'MBUY', 'Los Angeles Tourism & Convention Bureau', 'PENDIENTE', 'ANGELES', 'ANGEL'),
(522, 'MX', 'PENDIENTE', 'Novo City Acapulco, SA de CV', 'Hotel Romano Palace', 'PENDIENTE', 'NOVA', 'NOVA'),
(523, 'MX', 'PENDIENTE', 'Operadora de Hotel Punto Coral', 'Microtel Inn and Suites by Wyndham Culiacan', 'PENDIENTE', 'WYNDHAM', 'WYND'),
(524, 'MX', 'PENDIENTE', 'Operadora Perlas Beach, SA de CV', 'Imperial Las Perlas', 'PENDIENTE', 'IMPERIAL', 'IMPERIAL'),
(525, 'MX', 'PENDIENTE', 'PENINSULAR DE HOTELES, SA DE CV', 'HOTEL ADHARA HACIENDA CANCUN', 'PENDIENTE', 'ADHARA', 'ADHARA'),
(526, 'NORT&CA', 'PENDIENTE', 'SAN DIEGO TOURISM AUTHORITY', 'SAN DIEGO TOURISM AUTHORITY', 'PENDIENTE', 'SAN DIEGO', 'DIEGO'),
(527, 'MX', 'PENDIENTE', 'Servicios Turisticos de Marfin, SA de CV', 'Hotel Gran Plaza & Convention Center Guanajuato', 'PENDIENTE', 'GRAN PLAZA', 'GRAN'),
(528, 'MX', 'PENDIENTE', 'Operadora Punto Cavao, SA de CV', 'The Palms Resort of Mazatlan', 'PENDIENTE', 'THE PALMS', 'OPTIMA'),
(529, 'RO & AND', '367488', 'Carflo S.A.', 'Bisonte Palace', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(530, 'RO & AND', '86056', 'Argenta Tower Hotel & Suites SA', 'Argenta Tower Hotel and Suites', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(531, 'RO & AND', '143808', 'Limay S.A.', 'Fueguino Hotel Patagónico', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(532, 'RO & AND', 'MX001107', 'ARIZA MERCEDES', 'Terrazas del Calafate', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(533, 'RO & AND', '15075', 'Apart Urbana SA', 'Urbana Suites Apart', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(534, 'RO & AND', '122390', 'Marial Constructora SA', 'Urbana Class Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(535, 'RO & AND', '69414', 'Sarmiento Palace Hotel S.A', 'Sarmiento Palace Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(536, 'RO & AND', '252317', 'Hotel Crillon SA', 'Crillon Hotel Mendoza', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(537, 'RO & AND', '14857', 'Inmobiliaria Lamaro S. A.', 'Cristoforo Colombo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(538, 'RO & AND', '317067', 'Syosset Sociedad Anónima', 'Soft Bariloche Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(539, 'RO & AND', '91754', 'Hotel Villa de Merlo S.A.', 'Hotel Spa Villa de Merlo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(540, 'RO & AND', 'PENDIENTE', 'Gavarda Hermanos S.A.S.', 'Hotel Casa Los Puntales', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(541, 'RO & AND', 'MX002725', 'PUNTA SABIONI S.R.L', 'Grand Hotel Termas de Rio Hondo by HS', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(542, 'RO & AND', 'MX002874', 'Quintero Eduardo Felix', 'Condor Suites Apart', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(543, 'RO & AND', '29059', 'H.C.A  S.A', 'Four Seasons Hotel Buenos Aires', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(544, 'RO & AND', 'MX001915', 'MUIÑO SA', 'Hotel Principado Downtown', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(545, 'RO & AND', '14850', 'Loitegui S.A. (Recoleta)', 'Loi suites Recoleta', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(546, 'RO & AND', '487086', 'Zenkiu S.R.L', 'Hotel Bisonte Libertad', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(547, 'RO & AND', '133636', 'Ludesol S.A.', 'Best Western Pedro Figari Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(548, 'RO & AND', '353034', 'Facitur SA', 'Costa Colonia', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(549, 'RO & AND', 'PENDIENTE', 'Hotel Casa de La Trinidad SAS', 'Hotel Casa de La Trinidad', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(550, 'RO & AND', '486336', 'OPERADORA LANESRA S.A.S', 'Hotel Allure Chocolat', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(551, 'RO & AND', '486336', 'OPERADORA LANESRA S.A.S', 'Hotel Allure Bon Bon', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(552, 'RO & AND', '368593', 'Romimar S.A.', 'Romimar', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(553, 'RO & AND', '28381', 'Consorcio Hotelero Sudamericano SA (Excelsior ASU)', 'Excelsior Inn', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(554, 'RO & AND', 'MX003023', 'IRSA- GALERIAS PACÍFICO S.A', 'Llao Llao Hotel and Resort Golf', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(555, 'RO & AND', 'MX001813', 'Mamevi SA', 'Carles Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(556, 'RO & AND', '358697', 'Fiswey S.A.', 'Intercity Montevideo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(557, 'RO & AND', '24029', 'TREMUN S.A', 'Tremun Mirador del Lago', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(558, 'RO & AND', 'MX003118', 'THE OFFICE BA SA', 'Arelauquen Lodge, A tribute Portfolio Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(559, 'RO & AND', 'MX000247', 'Turismo Taitao SA', 'Hoteles Presidente', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(560, 'RO & AND', 'PENDIENTE', 'Protucaribe Ltda', 'Hotel Las Americas', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(561, 'RO & AND', 'PENDIENTE', 'Promotora Turística del Caribe S.A', 'Hotel Las Americas Torre del Mar', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(562, 'RO & AND', 'MX002276', 'Fideicomiso 62.550/2011', 'Esplendor Montevideo A Wyndham Grand Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(563, 'RO & AND', 'MX002222', 'Easy Life S.A.', 'Dazzler Colonia', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(564, 'RO & AND', '452274', 'Fideicomiso de Administración Hotelera Humboldt 1652', 'Dazzler Palermo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(565, 'RO & AND', '258173', 'Fideicomiso de Administración Maipú 850', 'Dazzler Maipu', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(566, 'RO & AND', 'PENDIENTE', 'Jemad S.R.L', 'Esplendor Palermo Soho', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(567, 'RO & AND', '70779', 'Argenfield S.A', 'Dazzler San Martin', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(568, 'RO & AND', 'MX001571', 'Sinclair 2929 S.A', 'Dazzler Polo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(569, 'RO & AND', '287165', 'Hostels Argentina sa', 'Dazzler San Telmo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(570, 'RO & AND', '14993', 'Hotel Plaza Francia S.A.', 'Esplendor Plaza Francia', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(571, 'RO & AND', '258486', 'Administradora de Hoteles Sa  (Hollywood)', 'Esplendor Palermo Hollywood', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(572, 'RO & AND', '362765', 'Desarrollo Maipu S.a', 'Esplendor Mendoza', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(573, 'RO & AND', '337707', 'KLP Emprendimientos SA', 'InterContinental Mendoza Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(574, 'RO & AND', '428766', 'Idea S.A', 'Alto Calafate Hotel Patagonico', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(575, 'RO & AND', 'PENDIENTE', 'Los Cauquenes Usuahia SA', 'Los Cauquenes Usuahia SA', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(576, 'RO & AND', '408897', 'Albaril S.A.', '2122 Hotel Art Design', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(577, 'RO & AND', 'MX000022', 'Muzery S.A.', 'Esplendor Cervantes', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(578, 'RO & AND', 'MX003118', 'THE OFFICE BA SA', 'Auberge Du Vin, A Tribute Portfolio Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(579, 'RO & AND', '358577', 'COMERCIAL DE TURISMO S.A(falls iguazu)', 'Falls Iguazu Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(580, 'RO & AND', '295893', 'Casino de Rosario S.A.', 'Hotel Casino Pullman City Center Rosario', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(581, 'RO & AND', '28381', 'Consorcio Hotelero Sudamericano SA (Excelsior ASU)', 'Excelsior Asunción', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(582, 'RO & AND', 'MX000305', 'Hotelera e inmobiliaria nueva Ltda', 'Hoteles Neruda Chile', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(583, 'RO & AND', '14817', 'Ambiente S.A. (Amerian Cordoba)', 'Amerian Cordoba', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(584, 'RO & AND', '149918', 'Compañía Hotelera Cartagena Plaza Ltda', 'Hotel Cartagena Plaza', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(585, 'RO & AND', 'MX000703', 'Ballena Azul S.A.S', 'Hotel la Ballena Azul', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(586, 'RO & AND', '410739', 'Nimbari SA', 'Orpheo Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(587, 'RO & AND', 'MX000890', 'EAF S.A.', 'La Perla', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(588, 'RO & AND', 'MX001786', 'Serviconsult SA', 'Hotel Buenos Aires Inn', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(589, 'RO & AND', '14866', 'Hoteles Del Sol S.A.', 'Aeroparque Inn', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(590, 'RO & AND', 'MX000315', 'Hotelera Renta Home Ltda.', 'Rent a Home Lyon', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(591, 'RO & AND', 'PENDIENTE', 'Plutarco Arteaga Vidal y Compañía S en C.', 'Hotel Luisitana', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(592, 'RO & AND', 'MX003197', 'ASOCIACION MUTUAL SINDICAL MERCANTIL', 'UNIT SANTA ROSA', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(593, 'RO & AND', 'MX002936', 'Fideicomiso de Administracion Salta Suites', 'Brizo Salta', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(594, 'RO & AND', '15114', 'Ebon S.A.', 'Bel Air Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(595, 'RO & AND', '486782', 'FIDEICOMISO DE ADMINISTRACIÓN FLATS DEL POLO', 'FLATS DEL POLO', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(596, 'RO & AND', '14781', 'Iruña S.C.A', 'Hotel Iruña', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(597, 'RO & AND', '14781', 'Iruña S.C.A', 'Hotel Presidente MDQ', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(598, 'RO & AND', '121834', 'Operadora Rivendell SA', 'Hotel Riviera (Mar del Plata)', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(599, 'RO & AND', '14589', 'Red Hotelera Iberoamericana S.A.', 'Hotel Costa Galana', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(600, 'RO & AND', '354020', 'Canaria Hispana S.A Union Transitoria de Empresas', 'HA Posadas Urbano', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(601, 'RO & AND', 'MX003217', 'FIDEICOMISO HA FLATS - IQ RECOLETA PLAZA', 'FLATS - IQ RECOLETA PLAZA', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(602, 'RO & AND', '76013', 'Cia. Comercial El Dorado Ltda.', 'Hotel Dorado Plaza', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(603, 'RO & AND', 'MX001052', 'ODODEON FEDERICO EDUARDO Y BOGA J FCO SOC DE H', 'Hosteria del Viejo Molino', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(604, 'RO & AND', '486924', 'Cyan Recoleta Hotel S.R.L', 'Cyan Recoleta Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(605, 'RO & AND', '278970', 'La Cantera iguazú Srl', 'La Cantera Jungle Lodge', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(606, 'RO & AND', '68192', 'Corporación Hotelera Metor', 'Melia Lima', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(607, 'RO & AND', '195691', 'La Gloria Hoteleria S.A.', 'Hotel Guarani Asuncion', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(608, 'RO & AND', '273947', 'Américas Towers Sa', 'Cyan Américas', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(609, 'RO & AND', '273717', 'Hoteles del Plata Sa', 'Cyan Hotel de las Americas', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(610, 'RO & AND', 'MX003278', 'GUAMAFLO SA', 'Grand Brizo Buenos Aires', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(611, 'RO & AND', '14779', 'Arona S.A.', 'Del Comahue Neuquen', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(612, 'RO & AND', '14779', 'Arona S.A.', 'Hotel Comahue Business', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(613, 'RO & AND', 'MX001087', 'Caribe Hoteles and Suites SAS', 'Hotel Azuan Suites', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(614, 'RO & AND', '489006', 'DT Hoteles y Inn S.A.S.', 'Hotel Marina Suites', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(615, 'RO & AND', '251341', 'Fideicomiso Cilene del Faro', 'Cilene del Faro Suites and Spa', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(616, 'RO & AND', '14976', 'Le Parc S.R.L.', 'Garden Parc', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(617, 'RO & AND', '168641', 'All Flags S.A.', 'Villa Huinid Hotel Bustillo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(618, 'RO & AND', '14944', 'Hotel del Sol SRL (Tucumán)', 'Hotel del Sol  (Tucumán)', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(619, 'RO & AND', 'MX003241', 'FIDEICOMISO LE PETIT RENTAL SUITES', 'LE PETIT SUITES', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(620, 'RO & AND', 'MX003250', 'Fideicomiso de Administracion Neuquen Soho I', 'Cyan Soho Neuquen Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(621, 'RO & AND', '182962', 'Arpatur S.R.L.', 'Cyan Calafate', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(622, 'RO & AND', '486924', 'Cyan Recoleta Hotel S.R.L', 'Cyan Recoleta Suites', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(623, 'RO & AND', 'MX001901', 'FIDEICOMISO MADERO URBANO SUITES', 'CH MADERO', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(624, 'RO & AND', 'MX000442', 'Don Hoteles Argentina SRL', 'Don el Faro Boutique Hotel & Spa', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(625, 'RO & AND', 'MX000442', 'Don Hoteles Argentina SRL', 'Don Los Cerros Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(626, 'RO & AND', '168641', 'All Flags S.A.', 'Villa Huinid Los Pioneros', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(627, 'RO & AND', 'MX001419', 'Hoteles y Gestión SRL', 'Wyndham Nordelta Tigre', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(628, 'RO & AND', 'PENDIENTE', 'Grupo Empresarial HEB SAS', 'Eco Boutique Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(629, 'RO & AND', 'MX000720', 'Gop Management Hotelero SRL', 'Amerian Salta.', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(630, 'RO & AND', 'HO0144', 'Solvera S.R.L', 'Solvera S.R.L', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(631, 'RO & AND', 'MX000027', 'Grupo Latino SRL', 'Ramada Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(632, 'RO & AND', 'MX000653', 'Itin SA', 'Howard Johnson Hotel Yerba Buena', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(633, 'RO & AND', '70703', 'International Hotel Development SA', 'Esplendor Buenos Aires', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(634, 'RO & AND', '327320', 'BITANIA 26 S.A.', 'Esplendor Savoy Rosario Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(635, 'RO & AND', 'PENDIENTE', 'Espacio Otamendi S.A.', 'Dazzler Campana', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(636, 'RO & AND', '418073', 'Fid Adm Hot Boulevard Guillermo Brown 367', 'Dazzler Pto. Madryn', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(637, 'RO & AND', '328599', 'Servi Hoteles ltda', 'Hotel Costa del Sol', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(638, 'RO & AND', 'MX000664', 'Tour Vacation Hoteles Azul SAS', 'On Vacation Caribbean', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(639, 'RO & AND', '14976', 'Hotel Le Parc Sociedad por Acciones Simplificada', 'Hotel Le Parc Medellin', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(640, 'RO & AND', '74609', 'Natur SRL', 'Hotel Chaco', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(641, 'RO & AND', '14817', 'Ambiente S.A. (Amerian Cordoba)', 'Amerian Executive Cordoba', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(642, 'RO & AND', '21624', 'Emprendimientos Inmobiliarios S.A.', 'Amerian Executive Park Mendoza', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(643, 'RO & AND', '14817', 'Ambiente S.A (Amerian Mar del Plata)', 'Amerian Merit Mar del Plata', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(644, 'RO & AND', '14817', 'Ambiente S.A', 'Amerian Bs. As.', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(645, 'RO & AND', '14817', 'Ambiente S.A', 'Merit San Telmo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(646, 'RO & AND', '175964', 'Operadores Hoteleros Regency S.A.', 'Hotel Bogota Regency', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(647, 'RO & AND', 'PENDIENTE', 'Conceptos Hoteleros SRL', 'HTL 9 de Julio', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(648, 'RO & AND', '24481', 'Sunset Port S.A', 'Raices Aconcagua', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(649, 'RO & AND', 'PENDIENTE', 'Servincluidos Ltda.', 'Hoteles Decameron', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(650, 'BRA', 'NO APLICA', 'Ritz Lagoa da Anta', 'Ritz Lagoa da Anta', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(651, 'BRA', 'NO APLICA', 'Ramada Suites Recife Boa Viagem', 'Ramada Suites Recife Boa Viagem', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(652, 'BRA', 'NO APLICA', 'Ritz Suites Home Service', 'Ritz Suites Home Service', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(653, 'BRA', 'NO APLICA', 'Esuites Sion  Savassi MG, Belo Horizonte', 'Esuites Sion  Savassi MG, Belo Horizonte', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(654, 'BRA', 'NO APLICA', 'Ramada Suites São Paulo Itaim Bibi NewCiti', 'Ramada Suites São Paulo Itaim Bibi NewCiti', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(655, 'BRA', 'NO APLICA', 'Hotel Taroba', 'Hotel Taroba', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(656, 'BRA', 'NO APLICA', 'Ouro Minas Palace Hotel', 'Ouro Minas Palace Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(657, 'BRA', 'NO APLICA', 'Marazul Hotel', 'Marazul Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(658, 'BRA', 'NO APLICA', 'Quality São Caetano', 'Quality São Caetano', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(659, 'BRA', 'NO APLICA', 'Hotel Regina ', 'Hotel Regina ', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(660, 'BRA', 'NO APLICA', 'Hotel Laghetto Viverone Bento', 'Hotel Laghetto Viverone Bento', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(661, 'BRA', 'NO APLICA', 'Sol Ipanema Hotel', 'Sol Ipanema Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(662, 'BRA', 'NO APLICA', 'Vila Gale Rio', 'Vila Gale Rio', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(663, 'BRA', 'NO APLICA', 'Ramada Encore Minascasa, Belo Horizonte', 'Ramada Encore Minascasa, Belo Horizonte', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(664, 'BRA', 'NO APLICA', 'CostaSol Pipa', 'CostaSol Pipa', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(665, 'BRA', 'NO APLICA', 'Olinda Rio Hotel', 'Olinda Rio Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(666, 'BRA', 'NO APLICA', 'Gran Melia', 'Gran Melia', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(667, 'BRA', 'NO APLICA', 'Ramada Encore Ribalta', 'Ramada Encore Ribalta', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(668, 'BRA', 'NO APLICA', 'Ramada Encore Minascasa', 'Ramada Encore Minascasa', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(669, 'BRA', 'NO APLICA', 'Sao Salvador Hoteis e Convencoes', 'Sao Salvador Hoteis e Convencoes', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(670, 'BRA', 'NO APLICA', 'Hibiscus Beach', 'Hibiscus Beach', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(671, 'BRA', 'NO APLICA', 'Hotel Laghetto Viverone Moinhos, Porto Alegre', 'Hotel Laghetto Viverone Moinhos, Porto Alegre', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(672, 'BRA', 'NO APLICA', 'Mama Shelter', 'Mama Shelter', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(673, 'BRA', 'NO APLICA', 'Pousada Aldeia Portuguesa, Porto Seguro', 'Pousada Aldeia Portuguesa, Porto Seguro', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(674, 'BRA', 'NO APLICA', 'Ramada Suites Recife Boa Viagem, Recife', 'Ramada Suites Recife Boa Viagem, Recife', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(675, 'BRA', 'NO APLICA', 'Santa Teresa Hotel RJ MGallery By Sofitel', 'Santa Teresa Hotel RJ MGallery By Sofitel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(676, 'BRA', 'NO APLICA', 'Canada Hotel, Rio de Janeiro', 'Canada Hotel, Rio de Janeiro', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(677, 'BRA', 'NO APLICA', 'Vila Gale Cumbuco', 'Vila Gale Cumbuco', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(678, 'BRA', 'NO APLICA', 'Vila Gale Fortaleza', 'Vila Gale Fortaleza', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(679, 'BRA', 'NO APLICA', 'Vila Gale Salvador', 'Vila Gale Salvador', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(680, 'BRA', 'NO APLICA', 'Vila Gale Mares', 'Vila Gale Mares', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(681, 'BRA', 'NO APLICA', 'Grande Hotel da Barra', 'Grande Hotel da Barra', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(682, 'BRA', 'NO APLICA', 'Pousada Colonial Chile', 'Pousada Colonial Chile', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(683, 'BRA', 'NO APLICA', 'Bahiamar Hotel', 'Bahiamar Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(684, 'BRA', 'NO APLICA', 'Vila Gale Angra', 'Vila Gale Angra', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(685, 'BRA', 'NO APLICA', 'Vila Gale Cabo', 'Vila Gale Cabo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(686, 'BRA', 'NO APLICA', 'Patachocas', 'Patachocas', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(687, 'BRA', 'NO APLICA', 'Hotel Laghetto Toscana, Gramado', 'Hotel Laghetto Toscana, Gramado', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(688, 'BRA', 'NO APLICA', 'LSH BARRA', 'LSH BARRA', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(689, 'BRA', 'NO APLICA', 'San Marino Suite Hotel', 'San Marino Suite Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(690, 'BRA', 'NO APLICA', 'Catussaba Resort Hotel, Salvador', 'Catussaba Resort Hotel, Salvador', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(691, 'BRA', 'NO APLICA', 'Maceió Atlantic Suites, Maceio', 'Maceió Atlantic Suites, Maceio', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(692, 'BRA', 'NO APLICA', 'Portal Ville  Rede Soberano', 'Portal Ville  Rede Soberano', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(693, 'BRA', 'NO APLICA', 'Viale Cataratas Hotel', 'Viale Cataratas Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(694, 'BRA', 'NO APLICA', 'Rede San Juan / ', 'Rede San Juan / ', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(695, 'BRA', 'NO APLICA', 'Monte Pascoal Praia Hotel Salvador', 'Monte Pascoal Praia Hotel Salvador', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(696, 'BRA', 'NO APLICA', 'Catussaba Resort Hotel', 'Catussaba Resort Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(697, 'BRA', 'NO APLICA', 'Caravela Pousada', 'Caravela Pousada', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(698, 'BRA', 'NO APLICA', 'Hotel Braston São Paulo', 'Hotel Braston São Paulo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(699, 'BRA', 'NO APLICA', 'Acqua Suites Maceió', 'Acqua Suites Maceió', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(700, 'BRA', 'NO APLICA', 'Hotel Laghetto Gramado, Gramado', 'Hotel Laghetto Gramado, Gramado', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(701, 'BRA', 'NO APLICA', 'Transoceanico Praia Hotel, Porto Seguro', 'Transoceanico Praia Hotel, Porto Seguro', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(702, 'BRA', 'NO APLICA', 'Recanto Cataratas', 'Recanto Cataratas', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(703, 'BRA', 'NO APLICA', 'Brisamar Hotel & SPA São Luís', 'Brisamar Hotel & SPA São Luís', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(704, 'BRA', 'NO APLICA', 'Next Barra Prime', 'Next Barra Prime', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(705, 'BRA', 'NO APLICA', 'CASA ROSA', 'CASA ROSA', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(706, 'BRA', 'NO APLICA', 'Aldeia da Praia', 'Aldeia da Praia', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(707, 'BRA', 'NO APLICA', 'Martur', 'Martur', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(708, 'BRA', 'NO APLICA', 'San Francisco Plazza Hotel', 'San Francisco Plazza Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(709, 'BRA', 'NO APLICA', 'Golden Tulip Ipanema Plaza', 'Golden Tulip Ipanema Plaza', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(710, 'BRA', 'NO APLICA', 'Hotel Laghetto Toscana', 'Hotel Laghetto Toscana', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(711, 'BRA', 'NO APLICA', 'Sol Plaza Sleep, Salvador', 'Sol Plaza Sleep, Salvador', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(712, 'BRA', 'NO APLICA', 'Catussaba Suites', 'Catussaba Suites', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(713, 'BRA', 'NO APLICA', 'Esuites Sion  Savassi', 'Esuites Sion  Savassi', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(714, 'BRA', 'NO APLICA', 'Casa Nova Hotel', 'Casa Nova Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(715, 'BRA', 'NO APLICA', 'Quality Sao Caetano do Sul', 'Quality Sao Caetano do Sul', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(716, 'BRA', 'NO APLICA', 'Comfort São Caetano', 'Comfort São Caetano', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(717, 'BRA', 'NO APLICA', 'Hotel Laghetto Centro, Gramado', 'Hotel Laghetto Centro, Gramado', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(718, 'BRA', 'NO APLICA', 'Transoceanico Praia Hotel', 'Transoceanico Praia Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(719, 'BRA', 'NO APLICA', 'Sofitel Ipanema', 'Sofitel Ipanema', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(720, 'BRA', 'NO APLICA', 'Majestic Rio Palace', 'Majestic Rio Palace', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(721, 'BRA', 'NO APLICA', 'Mar Paraiso ', 'Mar Paraiso ', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(722, 'BRA', 'NO APLICA', 'Arena Copacabana Hotel / Boleto', 'Arena Copacabana Hotel / Boleto', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(723, 'BRA', 'NO APLICA', 'Arena Leme Hotel / Boleto', 'Arena Leme Hotel / Boleto', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(724, 'BRA', 'NO APLICA', 'Arena Ipanema Hotel /Boleto', 'Arena Ipanema Hotel /Boleto', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(725, 'BRA', 'NO APLICA', 'Oceano Praia Hotel', 'Oceano Praia Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(726, 'BRA', 'NO APLICA', 'HPLUS ', 'HPLUS ', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(727, 'BRA', 'NO APLICA', 'Hotel Sonata de Iracema, Fortaleza', 'Hotel Sonata de Iracema, Fortaleza', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(728, 'BRA', 'NO APLICA', 'Malai Manso Resort Iate Golf Convention & SPA', 'Malai Manso Resort Iate Golf Convention & SPA', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(729, 'BRA', 'NO APLICA', 'Bourbon Cascavel', 'Bourbon Cascavel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(730, 'BRA', 'NO APLICA', 'Buzios Beach Resort', 'Buzios Beach Resort', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(731, 'BRA', 'NO APLICA', 'Real Classic Bahia Hotel', 'Real Classic Bahia Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(732, 'BRA', 'NO APLICA', 'Ramada Encore Belo Horizonte Luxemburgo - Virgínia', 'Ramada Encore Belo Horizonte Luxemburgo - Virgínia', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(733, 'BRA', 'NO APLICA', 'Next Barra Prime, Rio de Janeiro', 'Next Barra Prime, Rio de Janeiro', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(734, 'BRA', 'NO APLICA', 'Rafain Palace Hotel and Convention Center', 'Rafain Palace Hotel and Convention Center', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(735, 'BRA', 'NO APLICA', 'Sofitel Rio de Janeiro Ipanema (ex Caesar Park), Rio de Janeiro', 'Sofitel Rio de Janeiro Ipanema (ex Caesar Park), Rio de Janeiro', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(736, 'BRA', 'NO APLICA', 'Majestic Rio Palace Hotel, Rio de Janeiro', 'Majestic Rio Palace Hotel, Rio de Janeiro', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(737, 'BRA', 'NO APLICA', 'Tamandaré Plaza Hotel', 'Tamandaré Plaza Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(738, 'BRA', 'NO APLICA', 'Flats Bueno Em Goiania', 'Flats Bueno Em Goiania', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(739, 'BRA', 'NO APLICA', 'Portobello Ondina Praia', 'Portobello Ondina Praia', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(740, 'BRA', 'NO APLICA', 'Hotel Olinda Rio', 'Hotel Olinda Rio', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(741, 'BRA', 'NO APLICA', 'Maceio Mar Hotel', 'Maceio Mar Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(742, 'BRA', 'NO APLICA', 'Bourbon Cataratas Convention and Spa Resort', 'Bourbon Cataratas Convention and Spa Resort', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(743, 'BRA', 'NO APLICA', 'Bourbon Atibaia Convention & Spa Resort', 'Bourbon Atibaia Convention & Spa Resort', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(744, 'BRA', 'NO APLICA', 'Bourbon Curitiba Convention Hotel', 'Bourbon Curitiba Convention Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(745, 'BRA', 'NO APLICA', 'Sol Barra, Salvador', 'Sol Barra, Salvador', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(746, 'BRA', 'NO APLICA', 'Taguatur Eventos e Turismo ', 'Taguatur Eventos e Turismo ', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(747, 'BRA', 'NO APLICA', 'Yes Receptivo', 'Yes Receptivo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(748, 'BRA', 'NO APLICA', 'Village Porto de Galinhas', 'Village Porto de Galinhas', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(749, 'BRA', 'NO APLICA', 'Indytur Operadora de Receptivo', 'Indytur Operadora de Receptivo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(750, 'BRA', 'NO APLICA', 'NATAL DUNNAS', 'NATAL DUNNAS', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(751, 'BRA', 'NO APLICA', 'VISUAL PRAIA HOTEL', 'VISUAL PRAIA HOTEL', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(752, 'BRA', 'NO APLICA', 'RIFÓLES PRAIA HOTEL', 'RIFÓLES PRAIA HOTEL', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(753, 'BRA', 'NO APLICA', 'GRAN MARQUISE', 'GRAN MARQUISE', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(754, 'BRA', 'NO APLICA', 'OÁSIS ATLANTICO', 'OÁSIS ATLANTICO', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(755, 'BRA', 'NO APLICA', ' Praia Centro Hotel', ' Praia Centro Hotel', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(756, 'BRA', 'NO APLICA', 'Delta Transfer', 'Delta Transfer', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(757, 'BRA', 'NO APLICA', 'Adval Turismo', 'Adval Turismo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(758, 'BRA', 'NO APLICA', 'YES TURISMO', 'YES TURISMO', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(759, 'BRA', 'NO APLICA', 'Fontur Turismo', 'Fontur Turismo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(760, 'RED', 'NO APLICA', 'Hispaniola Adventures', 'Runner Adventure', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(761, 'RED', 'NO APLICA', 'Blue Marine', 'Blue Marine Punta Cana', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(762, 'RED', 'NO APLICA', 'Eco Caribe Adventures', 'Eco Adventures', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(763, 'RED', 'NO APLICA', 'Multigestiones Cenrex', 'Multigestiones Cenrex', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(764, 'RED', 'NO APLICA', 'Rancho  Victoria Caribenio, SRL', 'Rancho Caribenio', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(765, 'RED', 'NO APLICA', 'United Petroleum, Grupo Haina SRL', 'United Petroleum, Grupo Haina SRL', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(766, 'RED', 'NO APLICA', 'Parques del Este LTD', 'Dolphin Explorer', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(767, 'RED', 'NO APLICA', 'Marinarium', 'Marinarium', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(768, 'RED', 'NO APLICA', 'Adventure Boogies SRL', 'Adventures Boogies', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(769, 'RED', 'NO APLICA', 'Cats Sailing Adventure', 'Cats Sailing Adventure', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(770, 'RED', 'NO APLICA', 'Go Excursions SRL', 'Go Cayo Excursions and Brokers', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(771, 'RED', 'NO APLICA', 'Industrias Entretenimiento Punta Cana SRL', 'Cocobongo', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(772, 'RED', 'NO APLICA', 'Caribbean Adventures', 'Power Adventures', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(773, 'RED', 'NO APLICA', 'Administradora B-Max Punta Cana S.R.L.', 'Bluemall Puntacana', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(774, 'RED', 'NO APLICA', 'Jungle Zip Line SRL', 'Super Jeep Expedition', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(775, 'RED', 'NO APLICA', 'Dolphin Downtown PC', 'Down Town', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(776, 'RED', 'NO APLICA', 'Inversiones Arrecife', 'Manati Park', 'NO APLICA', 'NO APLICA', 'NO APLICA'),
(777, 'RED', 'NO APLICA', 'Side by Side Adventures SRL', 'Side by Side', 'NO APLICA', 'NO APLICA', 'NO APLICA');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contrato_status`
--

CREATE TABLE `contrato_status` (
  `id` int(11) NOT NULL,
  `concepto` varchar(600) COLLATE utf8_unicode_ci NOT NULL,
  `color` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `region` varchar(60) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `contrato_status`
--

INSERT INTO `contrato_status` (`id`, `concepto`, `color`, `region`) VALUES
(8, 'Contrato Firmados y Archivado', '', 'MX, RO, AND,CEN, BRA, NORT&CA,RED'),
(9, 'Contrato Liberado por Legal en Fisico a Supply para recabar Firmas', '', 'MX, RO, AND,CEN, BRA, NORT&CA,RED'),
(10, 'Contratos Listos, pendiente de recoger el Original en Legal por Supply', '', 'MX, RO, AND,CEN, BRA, NORT&CA,RED'),
(11, 'Contratos pendientes que Supply haga cambios solicitados por Legal', '', 'MX, RO, AND,CEN, BRA, NORT&CA,RED'),
(12, 'Contratos pendientes de Revision por Legal', '', 'MX, RO, AND,CEN, BRA, NORT&CA,RED'),
(13, 'No se Firmos por Instrucciones de Supply', '', 'MX, RO, AND,CEN, BRA, NORT&CA,RED'),
(14, 'Contratos Pendientes de Entregar Documentacion a Legal', '', 'MX, RO, AND,CEN, BRA, NORT&CA,RED');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ejecutivo_daf`
--

CREATE TABLE `ejecutivo_daf` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `area` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ejecutivo_daf`
--

INSERT INTO `ejecutivo_daf` (`id`, `nombre`, `area`, `correo`) VALUES
(1, 'Ana Yah', '', 'null'),
(2, 'Lenny Meraz', '', 'null'),
(3, 'Jacqueline Olguin', '', 'null'),
(4, 'Genobeva Zarate', '', 'null'),
(5, 'Sheila Barnet', '', 'null');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `esquema_comision`
--

CREATE TABLE `esquema_comision` (
  `id` int(11) NOT NULL,
  `region` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `negociacion` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `esquema` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `porcentaje` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `vendedor` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `esquema_comision`
--

INSERT INTO `esquema_comision` (`id`, `region`, `negociacion`, `esquema`, `porcentaje`, `vendedor`) VALUES
(1, 'MX ', 'MEDIA', 'Q', 'Q1,Q2,Q3,Q4', 'Supply Manager'),
(2, 'MX ', 'Marketing Fund', 'Q', 'Q1,Q2,Q3,Q4', 'Supply Manager'),
(3, 'MX ', 'Cash In', '%', '0.02', 'Supply Manager'),
(4, 'MX ', 'Cash In', '%', '0.02', 'Account Manager'),
(5, 'MX ', 'Años Anteriores', '%', '0.01', 'Senior Supply Manager'),
(6, 'MX ', 'Años Anteriores', '%', '0.03', 'Supply Manager'),
(7, 'MX ', 'BD Travel', '%', '0.01', 'Supply Manager'),
(8, 'MX ', 'Marketing-Media COO', '%', '0.0125', 'Supply Manager'),
(9, 'MX ', 'Marketing-Media COO', '%', '0.00625', 'Operadores & backoffice de coops '),
(10, 'MX ', 'Marketing-Media COO', '%', '0.00625', 'Account Manager'),
(11, 'RO, AND, CEN', 'MEDIA', '%', '0.015', 'Senior Supply Manager'),
(12, 'RO, AND, CEN', 'Marketing Fund', '%', '0.05', 'Supply Manager'),
(13, 'BRA', 'MEDIA', '%', '0.01', 'Senior Supply Manager'),
(14, 'BRA', 'Marketing Fund', '%', '0.05', 'Supply Manager'),
(15, 'NORT&CA', 'Cash In', '%', '0.005', 'Senior Supply Manager'),
(16, 'NORT&CA', 'Cash In', '%', '0.03', 'Supply Manager'),
(17, 'RED', 'Cash In', '%', '0.02', 'Supply Manager'),
(18, 'MX ', 'Externos', '%', '1 al 30', 'Vendedor');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `landings`
--

CREATE TABLE `landings` (
  `id_landings` int(11) NOT NULL,
  `hotel` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `url` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `fecha_solicitud` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `fecha_entrega` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `account` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `tipo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `activa` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medios`
--

CREATE TABLE `medios` (
  `id_medios` int(11) NOT NULL,
  `medio` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `formato` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `specs` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `tipo_compra` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `precio_unitario` int(11) NOT NULL,
  `pais` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `division` varchar(50) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ordenes_insercion`
--

CREATE TABLE `ordenes_insercion` (
  `id_ordenes` int(11) NOT NULL,
  `folio_media` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `status_OI` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `sigla_pais` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `tipo_pauta` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `categoria` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `contrato` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `razon_social` varchar(200) CHARACTER SET latin1 DEFAULT NULL,
  `nombre_comercial` varchar(200) CHARACTER SET latin1 DEFAULT NULL,
  `sigla_hotel` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `sigla_hanna` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `clave_hanna` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `centro_bneficio` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_pauta` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anticipo_pauta` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `porcentaje_mkf` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `vig_desde_mkf` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `vig_hasta_mkf` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `forma_calculo` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_fijo` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_fijo_iva` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `divisa` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `vig_monto_desde` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `vig_monto_hasta` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `transf_bancaria` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `compensacion` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `noches` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `ambas` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_comision` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `observaciones` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `supply_manager` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `ejecutivo_daf` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `account_manager` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `archivo` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `enero` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `febrero` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `marzo` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `abril` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `mayo` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `junio` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `julio` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `agosto` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `septiembre` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `octubre` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `noviembre` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `diciembre` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_ene` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_feb` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_mar` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_abr` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_may` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_jun` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_jul` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_ago` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_sep` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_oct` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_nov` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `anio_dic` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_ene` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_feb` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_mar` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_abr` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_may` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_jun` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_jul` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_ago` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_sep` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_oct` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_nov` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_dic` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_ene` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_feb` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_mar` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_abr` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_may` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_jun` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_jul` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_ago` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_sep` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_oct` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_nov` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `facturado_dic` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_ene` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_feb` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_mar` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_abr` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_may` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_jun` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_jul` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_ago` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_sep` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_oct` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_nov` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `cobrado_dic` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_ene` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_feb` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_mar` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_abr` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_may` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_jun` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_jul` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_ago` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_sep` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_oct` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_nov` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_cobro_dic` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_ene` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_feb` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_mar` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_abr` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_may` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_jun` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_jul` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_ago` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_sep` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_oct` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_nov` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `esquema_dic` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_ene` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_feb` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_mar` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_abr` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_may` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_jun` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_jul` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_ago` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_sep` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_oct` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_nov` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `fecha_com_dic` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_pautado` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_facturado` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `monto_cobrado` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `porcentaje_pautado` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `porcentaje_facturado` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
  `porcentaje_cobrado` varchar(45) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ordenes_insercion`
--

INSERT INTO `ordenes_insercion` (`id_ordenes`, `folio_media`, `status_OI`, `sigla_pais`, `tipo_pauta`, `categoria`, `contrato`, `razon_social`, `nombre_comercial`, `sigla_hotel`, `sigla_hanna`, `clave_hanna`, `centro_bneficio`, `monto_pauta`, `anticipo_pauta`, `porcentaje_mkf`, `vig_desde_mkf`, `vig_hasta_mkf`, `forma_calculo`, `monto_fijo`, `monto_fijo_iva`, `divisa`, `vig_monto_desde`, `vig_monto_hasta`, `transf_bancaria`, `compensacion`, `noches`, `ambas`, `esquema_comision`, `observaciones`, `supply_manager`, `ejecutivo_daf`, `account_manager`, `archivo`, `enero`, `febrero`, `marzo`, `abril`, `mayo`, `junio`, `julio`, `agosto`, `septiembre`, `octubre`, `noviembre`, `diciembre`, `anio_ene`, `anio_feb`, `anio_mar`, `anio_abr`, `anio_may`, `anio_jun`, `anio_jul`, `anio_ago`, `anio_sep`, `anio_oct`, `anio_nov`, `anio_dic`, `monto_ene`, `monto_feb`, `monto_mar`, `monto_abr`, `monto_may`, `monto_jun`, `monto_jul`, `monto_ago`, `monto_sep`, `monto_oct`, `monto_nov`, `monto_dic`, `facturado_ene`, `facturado_feb`, `facturado_mar`, `facturado_abr`, `facturado_may`, `facturado_jun`, `facturado_jul`, `facturado_ago`, `facturado_sep`, `facturado_oct`, `facturado_nov`, `facturado_dic`, `cobrado_ene`, `cobrado_feb`, `cobrado_mar`, `cobrado_abr`, `cobrado_may`, `cobrado_jun`, `cobrado_jul`, `cobrado_ago`, `cobrado_sep`, `cobrado_oct`, `cobrado_nov`, `cobrado_dic`, `fecha_cobro_ene`, `fecha_cobro_feb`, `fecha_cobro_mar`, `fecha_cobro_abr`, `fecha_cobro_may`, `fecha_cobro_jun`, `fecha_cobro_jul`, `fecha_cobro_ago`, `fecha_cobro_sep`, `fecha_cobro_oct`, `fecha_cobro_nov`, `fecha_cobro_dic`, `esquema_ene`, `esquema_feb`, `esquema_mar`, `esquema_abr`, `esquema_may`, `esquema_jun`, `esquema_jul`, `esquema_ago`, `esquema_sep`, `esquema_oct`, `esquema_nov`, `esquema_dic`, `fecha_com_ene`, `fecha_com_feb`, `fecha_com_mar`, `fecha_com_abr`, `fecha_com_may`, `fecha_com_jun`, `fecha_com_jul`, `fecha_com_ago`, `fecha_com_sep`, `fecha_com_oct`, `fecha_com_nov`, `fecha_com_dic`, `monto_pautado`, `monto_facturado`, `monto_cobrado`, `porcentaje_pautado`, `porcentaje_facturado`, `porcentaje_cobrado`) VALUES
(1, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '2019-01-22', '2019-01-22', '', '0', '0', '', '2019-01-22', '2019-01-22', 'No', 'No', 'No', 'No', '', '', '', '', '', 'nom', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '', '', '', '', '', '', '', '', '', '', '', '', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '2019-01-22', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paises`
--

CREATE TABLE `paises` (
  `id` int(11) NOT NULL,
  `region` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `abrev` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL,
  `cluster` varchar(45) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `paises`
--

INSERT INTO `paises` (`id`, `region`, `abrev`, `cluster`) VALUES
(1, 'México', 'MX', NULL),
(2, 'Norteamerica & Caribe', 'Nort&Ca', NULL),
(3, 'Rola', 'RO', NULL),
(4, 'Región Andina', 'AND', NULL),
(5, 'Centroamerica', 'CEN', NULL),
(6, 'Republica Dominicana', 'RED', NULL),
(7, 'Brasil', 'BRA', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `saldos_media`
--

CREATE TABLE `saldos_media` (
  `id_saldos` int(11) NOT NULL,
  `clave_hann` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `siglas` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `folio_m` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `razon_social` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `nombre_comercial` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `monto_pauta` double DEFAULT NULL,
  `divisa` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `pauta` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `market_manager` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `anticipo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `estatus_cobrado` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `estatus_facturacion` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `enero` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `febrero` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `marzo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `abril` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `mayo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `junio` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `julio` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `agosto` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `septiembre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `octubre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `noviembre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `diciembre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `forma_pago` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `account_manager` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `daf` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `comentarios` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `activa` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `hotel_siglas` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `forma_calculo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `porcentaje` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cene` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fene` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cfeb` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `ffeb` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cmar` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fmar` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cabr` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fabr` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cmay` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fmay` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cjun` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fjun` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cjul` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fjul` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cago` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fago` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `csep` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fsep` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `coct` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `foct` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cnov` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fnov` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `cdic` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `fdic` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `senero` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sfebrero` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `smarzo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sabril` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `smayo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sjunio` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sjulio` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sagosto` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sseptiembre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `soctubre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `snoviembre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `sdiciembre` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL,
  `nacional` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `saldos_media`
--

INSERT INTO `saldos_media` (`id_saldos`, `clave_hann`, `siglas`, `folio_m`, `fecha`, `razon_social`, `nombre_comercial`, `monto_pauta`, `divisa`, `pauta`, `market_manager`, `anticipo`, `estatus_cobrado`, `estatus_facturacion`, `enero`, `febrero`, `marzo`, `abril`, `mayo`, `junio`, `julio`, `agosto`, `septiembre`, `octubre`, `noviembre`, `diciembre`, `forma_pago`, `account_manager`, `daf`, `comentarios`, `activa`, `hotel_siglas`, `forma_calculo`, `porcentaje`, `cene`, `fene`, `cfeb`, `ffeb`, `cmar`, `fmar`, `cabr`, `fabr`, `cmay`, `fmay`, `cjun`, `fjun`, `cjul`, `fjul`, `cago`, `fago`, `csep`, `fsep`, `coct`, `foct`, `cnov`, `fnov`, `cdic`, `fdic`, `senero`, `sfebrero`, `smarzo`, `sabril`, `smayo`, `sjunio`, `sjulio`, `sagosto`, `sseptiembre`, `soctubre`, `snoviembre`, `sdiciembre`, `nacional`) VALUES
(1, 'PRUEBA', 'PRUEBA', 'PRUEBA', '2018-10-23', 'PRUEBA', 'PRUEBA', 0, 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'NO', 'PRUEBA', 'PRUEBA', 'PRUEBA', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', '', '', '', '', '', '', '', '', '', '', '', '', ''),
(2, '5000517', 'AM', '2018-12-MD-ID-AM-1', '2018-10-23', 'AM RESORTS', 'AM RESORTS', 350000, 'USD', 'MD', 'Evelin Melgarejo', '0', '', '', '', '175000', '', '', '', '175000', '', '', '', '', '', '', 'Transferencia', 'Genaro Emmanuel OrduÃ±a Calvillo', 'Ana Yah', '', 'SI', 'Brisas', 'ProducciÃ³n-Dashboard', '1', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', 'NO', '', 'SI', '', '', '', 'SI', '', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `supply_manager`
--

CREATE TABLE `supply_manager` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `area` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(45) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `supply_manager`
--

INSERT INTO `supply_manager` (`id`, `nombre`, `area`, `correo`) VALUES
(1, 'Lucia Maria Del Carmen Perez Rovira', 'null', 'null'),
(2, 'Giselda Vanegas Bustamante', 'null', 'null'),
(3, 'Marcos Ramírez', 'null', 'null'),
(4, 'Erika Lizette Arguelles Lazcano', 'null', 'null'),
(5, 'Maria Carmen Angulo', 'null', 'null'),
(6, 'Margarita Larra?aga ', 'null', 'null'),
(7, 'Rubi Alejandrina Cuevas Bates', 'null', 'null'),
(8, 'Christian Beatriz Ortiz Caballero', 'null', 'null'),
(9, 'Luis Alberto Burgos Gonzalez', 'null', 'null'),
(10, 'Ileana Aubry Gonzalez', 'null', 'null'),
(11, 'Angel Mena', 'null', 'null'),
(12, 'Osiris Anahi Carrillo Lopez', 'null', 'null'),
(13, 'Cindy Quiñones', 'null', 'null'),
(14, 'Alicia Ruiz Mendoza', 'null', 'null'),
(15, 'Adriana Mota Sandoval', 'null', 'null'),
(16, 'Yahaira Montaño Alvarado', 'null', 'null'),
(17, 'Alma Angelica Jimenez', 'null', 'null'),
(18, 'Fabiola  Jimenez Ramirez', 'null', 'null'),
(19, 'Claudia Contle Rivera', 'null', 'null'),
(20, 'Vanessa Pureco Perez', 'null', 'null'),
(21, 'Carmen SantillÃ­n', 'null', 'null'),
(22, 'Sara Bertha Perez Campos', 'null', 'null'),
(23, 'Osiris Carrillo', 'null', 'null'),
(24, 'Giedre Kolosovskyte', 'null', 'null'),
(25, 'Yaritza Ramirez', 'null', 'null'),
(26, 'Diana Basa Compean Arquieta', 'null', 'null'),
(27, 'Ingrid Nieves', 'null', 'null'),
(28, 'Alma Alvarez', 'null', 'null'),
(29, 'Alfonso de la PeÃ±a Rosenzweig', 'null', 'null'),
(30, 'Sonnie Tesorero Martinez', 'null', 'null'),
(31, 'Alejandra Dolores Gomez Sanchez', 'null', 'null'),
(32, 'Evelin Melgarejo', 'null', 'null'),
(33, 'Patricia Llanas Puente', 'null', 'null'),
(34, 'Andrea Camera Paula', 'null', 'null'),
(35, 'Fiona Taylor', 'null', 'null'),
(36, 'Hazel Morett', 'null', 'null'),
(37, 'Ingrid Nieves', 'null', 'null'),
(38, 'Bernardo Millan', 'null', 'null'),
(39, 'Maribel Fernandez Mejia', 'null', 'null'),
(40, 'Maria Isabel Steta', 'null', 'null'),
(41, 'Marvin Canche', 'null', 'null');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tc`
--

CREATE TABLE `tc` (
  `id` int(11) NOT NULL,
  `diario_oficial` double NOT NULL,
  `planeacion_financiera` double NOT NULL,
  `fecha` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `tc`
--

INSERT INTO `tc` (`id`, `diario_oficial`, `planeacion_financiera`, `fecha`) VALUES
(1, 22, 12, '2018-12-04 00:00:00'),
(2, 20.5123, 0, '2018-12-05 00:00:00'),
(3, 20.5672, 0, '2018-12-06 00:00:00'),
(4, 20.4705, 20.5223, '2018-12-07 00:00:00'),
(5, 20.2609, 20.5223, '2018-12-10 00:00:00'),
(6, 20.3621, 20.5223, '2018-12-11 00:00:00'),
(7, 20.3621, 20.5223, '2018-12-12 00:00:00'),
(8, 20.2889, 20.5223, '2018-12-13 00:00:00'),
(9, 20.1126, 20.5223, '2018-12-18 00:00:00'),
(10, 20.1277, 20.5223, '2018-12-19 00:00:00'),
(11, 0, 0, '2019-01-03 00:00:00'),
(12, 0, 0, '2019-01-04 00:00:00'),
(13, 19.2456, 20.1287, '2019-01-10 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuarios` int(11) NOT NULL,
  `nombre` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `usuario` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `password` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL,
  `privilegios` varchar(450) CHARACTER SET utf8 COLLATE utf8_spanish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_usuarios`, `nombre`, `usuario`, `password`, `correo`, `privilegios`) VALUES
(1, 'Laura Morales', 'Lauramorales', 'Media2018', 'lmorales@bestday.com', 'admin'),
(2, 'Pablo Chay', 'chay0s', 'chay1318', 'pabloc.hay@bestday.com', 'admin');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `abrev_hoteles`
--
ALTER TABLE `abrev_hoteles`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `abrev_pauta`
--
ALTER TABLE `abrev_pauta`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `account_manager`
--
ALTER TABLE `account_manager`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `archivos`
--
ALTER TABLE `archivos`
  ADD PRIMARY KEY (`id_archivos`);

--
-- Indices de la tabla `centro_beneficio`
--
ALTER TABLE `centro_beneficio`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id_clientes`);

--
-- Indices de la tabla `contrato_status`
--
ALTER TABLE `contrato_status`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `ejecutivo_daf`
--
ALTER TABLE `ejecutivo_daf`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `esquema_comision`
--
ALTER TABLE `esquema_comision`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `landings`
--
ALTER TABLE `landings`
  ADD PRIMARY KEY (`id_landings`);

--
-- Indices de la tabla `medios`
--
ALTER TABLE `medios`
  ADD PRIMARY KEY (`id_medios`);

--
-- Indices de la tabla `ordenes_insercion`
--
ALTER TABLE `ordenes_insercion`
  ADD PRIMARY KEY (`id_ordenes`);

--
-- Indices de la tabla `paises`
--
ALTER TABLE `paises`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `saldos_media`
--
ALTER TABLE `saldos_media`
  ADD PRIMARY KEY (`id_saldos`);

--
-- Indices de la tabla `supply_manager`
--
ALTER TABLE `supply_manager`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `tc`
--
ALTER TABLE `tc`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuarios`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `abrev_hoteles`
--
ALTER TABLE `abrev_hoteles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT de la tabla `account_manager`
--
ALTER TABLE `account_manager`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `archivos`
--
ALTER TABLE `archivos`
  MODIFY `id_archivos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `centro_beneficio`
--
ALTER TABLE `centro_beneficio`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id_clientes` int(110) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=778;

--
-- AUTO_INCREMENT de la tabla `contrato_status`
--
ALTER TABLE `contrato_status`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de la tabla `ejecutivo_daf`
--
ALTER TABLE `ejecutivo_daf`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `esquema_comision`
--
ALTER TABLE `esquema_comision`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de la tabla `landings`
--
ALTER TABLE `landings`
  MODIFY `id_landings` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `medios`
--
ALTER TABLE `medios`
  MODIFY `id_medios` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `ordenes_insercion`
--
ALTER TABLE `ordenes_insercion`
  MODIFY `id_ordenes` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `paises`
--
ALTER TABLE `paises`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `saldos_media`
--
ALTER TABLE `saldos_media`
  MODIFY `id_saldos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `supply_manager`
--
ALTER TABLE `supply_manager`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT de la tabla `tc`
--
ALTER TABLE `tc`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuarios` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
