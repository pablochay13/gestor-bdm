-- MySqlBackup.NET 2.0.12
-- Dump Time: 2019-01-04 11:32:43
-- --------------------------------------
-- Server version 10.1.36-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of abrev_hoteles
-- 

DROP TABLE IF EXISTS `abrev_hoteles`;
CREATE TABLE IF NOT EXISTS `abrev_hoteles` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `hotel` varchar(95) COLLATE utf8_spanish_ci NOT NULL,
  `abreviatura_hotel` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table abrev_hoteles
-- 

/*!40000 ALTER TABLE `abrev_hoteles` DISABLE KEYS */;
INSERT INTO `abrev_hoteles`(`id`,`hotel`,`abreviatura_hotel`) VALUES
(1,'Brisas','BR'),
(2,'Krystal','KR'),
(3,'Hilton','HL'),
(4,'Barcelo','BC'),
(5,'Occidental','OC'),
(6,'Bahia Principe','BP'),
(7,'Park Royal','PR'),
(8,'Gpo Vistana Westin','VW'),
(9,'Playa Resorts','PL'),
(10,'Seadust','SD'),
(11,'Palace Resorts','PLC'),
(12,'Atelier','ATL'),
(13,'Oasis','OA'),
(14,'Paradisus','PPC'),
(15,'Isla Huatulco','IH'),
(16,'Park Inn By Radisson','PINB'),
(17,'AM RESORTS','AM'),
(18,'Holiday Inn Express Guadalajara Aeropuerto','EMO'),
(19,'SANDOS','SAN'),
(20,'PRINCESS MEXICO','PRSS'),
(21,'BEST WESTERN PLUS PUEBLA','BWP'),
(22,'BEST WESTERN PLUS GRAND HOTEL MORELIA','BWP'),
(23,'BEST WESTERN PLUS POSADA DE DON VASCO','VW'),
(24,'PRINCESS HOTEL & RESORTS REPUBLICA DOMINICANA','PRSS'),
(25,'MANSION DEL CANTADOR','MDC'),
(26,'Courtyard By Marriott Monterrey Aeropuerto','OPTIMA'),
(27,'Microtel Inn and Suites by Wyndham Culiacan','WYND'),
(28,'Hampton Inn Guadalajara Aeropuerto','OPTIMA'),
(29,'Courtyard By Marriott Monterrey San Jeronimo Valle','OPTIMA'),
(30,'Corporativo Brisas','BR'),
(31,'HOTEL RADISSON MONTERREY SAN JERONIMO','PRSS'),
(32,'Hilton Garden Inn Veracruz Boca del Rio','OPTIMA'),
(33,'GRAND VELAS  RIVIERA MAYA','BETE'),
(34,'GRAND VELAS LOS CABOS','BETE'),
(35,'GRAND VELAS RIVIERA NAYARIT','BETE'),
(36,'CASAS VELAS','BETE'),
(37,'SAN DIEGO TOURISM AUTHORITY','USA'),
(38,'TRANSPORTES CANCUN SEA ADVENTURES','TCSA'),
(39,'CANCUN PASSION','CPSS'),
(40,'HOTEL REAL DE CHAPALA, VILLAS DANZA DEL SOL, CABO BLANCO HOTEL & MARINA','UAG'),
(41,'Valentin Imperial Riviera Maya','VAL'),
(42,'HOTELES SOLARIS','VSOL');
/*!40000 ALTER TABLE `abrev_hoteles` ENABLE KEYS */;

-- 
-- Definition of abrev_pauta
-- 

DROP TABLE IF EXISTS `abrev_pauta`;
CREATE TABLE IF NOT EXISTS `abrev_pauta` (
  `id` int(11) NOT NULL,
  `nombre` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `abreviatura_pauta` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table abrev_pauta
-- 

/*!40000 ALTER TABLE `abrev_pauta` DISABLE KEYS */;
INSERT INTO `abrev_pauta`(`id`,`nombre`,`abreviatura_pauta`) VALUES
(1,'Marketing Fund','MKF'),
(2,'Media','MD'),
(3,'BD Travel','BDT'),
(4,'Marketing-Media COO','MKMMDCO'),
(5,'Cooperados','COO'),
(6,'Cash','CASH'),
(7,'OI Modificatoria','MOD');
/*!40000 ALTER TABLE `abrev_pauta` ENABLE KEYS */;

-- 
-- Definition of account_manager
-- 

DROP TABLE IF EXISTS `account_manager`;
CREATE TABLE IF NOT EXISTS `account_manager` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `area` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table account_manager
-- 

/*!40000 ALTER TABLE `account_manager` DISABLE KEYS */;
INSERT INTO `account_manager`(`id`,`nombre`,`area`,`correo`) VALUES
(1,'Vinicius De Melo Rizato','null','accountmanager3@bestday.com'),
(2,'Bettina Bonett Paludo','null','null'),
(3,'Genaro Emmanuel Orduña Calvillo','null','null'),
(4,'German Hoth Palmerin','null','null'),
(5,'Yudilia Marisol Chan Cruz','null','null');
/*!40000 ALTER TABLE `account_manager` ENABLE KEYS */;

-- 
-- Definition of archivos
-- 

DROP TABLE IF EXISTS `archivos`;
CREATE TABLE IF NOT EXISTS `archivos` (
  `id_archivos` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_archivo` varchar(45) DEFAULT NULL,
  `ruta_archivo` varchar(45) DEFAULT NULL,
  `saldos_id_saldos` varchar(45) NOT NULL,
  PRIMARY KEY (`id_archivos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table archivos
-- 

/*!40000 ALTER TABLE `archivos` DISABLE KEYS */;

/*!40000 ALTER TABLE `archivos` ENABLE KEYS */;

-- 
-- Definition of clientes
-- 

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `id_clientes` int(110) NOT NULL AUTO_INCREMENT,
  `region` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `id_hanna` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `razon_social` varchar(450) COLLATE utf8_spanish_ci DEFAULT NULL,
  `nombre_comercial` varchar(450) COLLATE utf8_spanish_ci DEFAULT NULL,
  `siglas_hanna` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sigla_hoteles` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `abrev_hotel` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_clientes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table clientes
-- 

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;

/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- 
-- Definition of ejecutivo_daf
-- 

DROP TABLE IF EXISTS `ejecutivo_daf`;
CREATE TABLE IF NOT EXISTS `ejecutivo_daf` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `area` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table ejecutivo_daf
-- 

/*!40000 ALTER TABLE `ejecutivo_daf` DISABLE KEYS */;
INSERT INTO `ejecutivo_daf`(`id`,`nombre`,`area`,`correo`) VALUES
(1,'Ana Yah','','null'),
(2,'Lenny Meraz','','null'),
(3,'Jacqueline Olguin','','null'),
(4,'Genobeva Zarate','','null'),
(5,'Sheila Barnet','','null');
/*!40000 ALTER TABLE `ejecutivo_daf` ENABLE KEYS */;

-- 
-- Definition of landings
-- 

DROP TABLE IF EXISTS `landings`;
CREATE TABLE IF NOT EXISTS `landings` (
  `id_landings` int(11) NOT NULL AUTO_INCREMENT,
  `hotel` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `url` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `fecha_solicitud` varchar(450) COLLATE utf8_spanish_ci NOT NULL,
  `fecha_entrega` varchar(450) COLLATE utf8_spanish_ci NOT NULL,
  `account` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `tipo` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `activa` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_landings`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table landings
-- 

/*!40000 ALTER TABLE `landings` DISABLE KEYS */;

/*!40000 ALTER TABLE `landings` ENABLE KEYS */;

-- 
-- Definition of medios
-- 

DROP TABLE IF EXISTS `medios`;
CREATE TABLE IF NOT EXISTS `medios` (
  `id_medios` int(11) NOT NULL AUTO_INCREMENT,
  `medio` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `formato` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `specs` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `tipo_compra` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `precio_unitario` int(11) NOT NULL,
  `pais` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `division` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_medios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table medios
-- 

/*!40000 ALTER TABLE `medios` DISABLE KEYS */;

/*!40000 ALTER TABLE `medios` ENABLE KEYS */;

-- 
-- Definition of saldos_media
-- 

DROP TABLE IF EXISTS `saldos_media`;
CREATE TABLE IF NOT EXISTS `saldos_media` (
  `id_saldos` int(11) NOT NULL AUTO_INCREMENT,
  `clave_hann` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `siglas` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `folio_m` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `razon_social` varchar(100) COLLATE utf8_spanish_ci DEFAULT NULL,
  `nombre_comercial` varchar(100) COLLATE utf8_spanish_ci DEFAULT NULL,
  `monto_pauta` double DEFAULT NULL,
  `divisa` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `pauta` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `market_manager` varchar(100) COLLATE utf8_spanish_ci DEFAULT NULL,
  `anticipo` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `estatus_cobrado` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `estatus_facturacion` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `enero` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `febrero` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `marzo` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `abril` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `mayo` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `junio` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `julio` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `agosto` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `septiembre` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `octubre` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `noviembre` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `diciembre` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `forma_pago` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `account_manager` varchar(100) COLLATE utf8_spanish_ci DEFAULT NULL,
  `daf` varchar(450) COLLATE utf8_spanish_ci DEFAULT NULL,
  `comentarios` varchar(450) COLLATE utf8_spanish_ci DEFAULT NULL,
  `activa` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `hotel_siglas` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `forma_calculo` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `porcentaje` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cene` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fene` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cfeb` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `ffeb` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cmar` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fmar` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cabr` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fabr` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cmay` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fmay` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cjun` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fjun` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cjul` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fjul` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cago` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fago` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `csep` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fsep` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `coct` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `foct` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cnov` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fnov` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `cdic` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `fdic` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `senero` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sfebrero` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `smarzo` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sabril` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `smayo` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sjunio` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sjulio` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sagosto` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sseptiembre` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `soctubre` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `snoviembre` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `sdiciembre` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  `nacional` varchar(45) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_saldos`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table saldos_media
-- 

/*!40000 ALTER TABLE `saldos_media` DISABLE KEYS */;
INSERT INTO `saldos_media`(`id_saldos`,`clave_hann`,`siglas`,`folio_m`,`fecha`,`razon_social`,`nombre_comercial`,`monto_pauta`,`divisa`,`pauta`,`market_manager`,`anticipo`,`estatus_cobrado`,`estatus_facturacion`,`enero`,`febrero`,`marzo`,`abril`,`mayo`,`junio`,`julio`,`agosto`,`septiembre`,`octubre`,`noviembre`,`diciembre`,`forma_pago`,`account_manager`,`daf`,`comentarios`,`activa`,`hotel_siglas`,`forma_calculo`,`porcentaje`,`cene`,`fene`,`cfeb`,`ffeb`,`cmar`,`fmar`,`cabr`,`fabr`,`cmay`,`fmay`,`cjun`,`fjun`,`cjul`,`fjul`,`cago`,`fago`,`csep`,`fsep`,`coct`,`foct`,`cnov`,`fnov`,`cdic`,`fdic`,`senero`,`sfebrero`,`smarzo`,`sabril`,`smayo`,`sjunio`,`sjulio`,`sagosto`,`sseptiembre`,`soctubre`,`snoviembre`,`sdiciembre`,`nacional`) VALUES
(1,'PRUEBA','PRUEBA','PRUEBA','2018-10-23 00:00:00','PRUEBA','PRUEBA',0,'PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','PRUEBA','NO','PRUEBA','PRUEBA','PRUEBA','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','','','','','','','','','','','','',''),
(2,'5000517','AM','2018-12-MD-ID-AM-1','2018-10-23 00:00:00','AM RESORTS','AM RESORTS',350000,'USD','MD','Evelin Melgarejo','0','','','','175000','','','','175000','','','','','','','Transferencia','Genaro Emmanuel Orduña Calvillo','Ana Yah','','SI','Brisas','Producción-Dashboard','1','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','NO','','SI','','','','SI','','','','','','','');
/*!40000 ALTER TABLE `saldos_media` ENABLE KEYS */;

-- 
-- Definition of supply_manager
-- 

DROP TABLE IF EXISTS `supply_manager`;
CREATE TABLE IF NOT EXISTS `supply_manager` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8_spanish_ci NOT NULL,
  `area` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(45) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table supply_manager
-- 

/*!40000 ALTER TABLE `supply_manager` DISABLE KEYS */;
INSERT INTO `supply_manager`(`id`,`nombre`,`area`,`correo`) VALUES
(1,'Lucia Maria Del Carmen Perez Rovira','null','null'),
(2,'Giselda Vanegas Bustamante','null','null'),
(3,'Marcos Ramírez','null','null'),
(4,'Erika Lizette Arguelles Lazcano','null','null'),
(5,'Maria Carmen Angulo','null','null'),
(6,'Margarita Larra?aga ','null','null'),
(7,'Rubi Alejandrina Cuevas Bates','null','null'),
(8,'Christian Beatriz Ortiz Caballero','null','null'),
(9,'Luis Alberto Burgos Gonzalez','null','null'),
(10,'Ileana Aubry Gonzalez','null','null'),
(11,'Angel Mena','null','null'),
(12,'Osiris Anahi Carrillo Lopez','null','null'),
(13,'Cindy Quiñones','null','null'),
(14,'Alicia Ruiz Mendoza','null','null'),
(15,'Adriana Mota Sandoval','null','null'),
(16,'Yahaira Montaño Alvarado','null','null'),
(17,'Alma Angelica Jimenez','null','null'),
(18,'Fabiola  Jimenez Ramirez','null','null'),
(19,'Claudia Contle Rivera','null','null'),
(20,'Vanessa Pureco Perez','null','null'),
(21,'Carmen Santillín','null','null'),
(22,'Sara Bertha Perez Campos','null','null'),
(23,'Osiris Carrillo','null','null'),
(24,'Giedre Kolosovskyte','null','null'),
(25,'Yaritza Ramirez','null','null'),
(26,'Diana Basa Compean Arquieta','null','null'),
(27,'Ingrid Nieves','null','null'),
(28,'Alma Alvarez','null','null'),
(29,'Alfonso de la Peña Rosenzweig','null','null'),
(30,'Sonnie Tesorero Martinez','null','null'),
(31,'Alejandra Dolores Gomez Sanchez','null','null'),
(32,'Evelin Melgarejo','null','null'),
(33,'Patricia Llanas Puente','null','null'),
(34,'Andrea Camera Paula','null','null'),
(35,'Fiona Taylor','null','null'),
(36,'Hazel Morett','null','null'),
(37,'Ingrid Nieves','null','null'),
(38,'Bernardo Millan','null','null'),
(39,'Maribel Fernandez Mejia','null','null'),
(40,'Maria Isabel Steta','null','null'),
(41,'Marvin Canche','null','null');
/*!40000 ALTER TABLE `supply_manager` ENABLE KEYS */;

-- 
-- Definition of tc
-- 

DROP TABLE IF EXISTS `tc`;
CREATE TABLE IF NOT EXISTS `tc` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `diario_oficial` double NOT NULL,
  `planeacion_financiera` double NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table tc
-- 

/*!40000 ALTER TABLE `tc` DISABLE KEYS */;
INSERT INTO `tc`(`id`,`diario_oficial`,`planeacion_financiera`,`fecha`) VALUES
(1,22,12,'2018-12-04 00:00:00'),
(2,20.5123,0,'2018-12-05 00:00:00'),
(3,20.5672,0,'2018-12-06 00:00:00'),
(4,20.4705,20.5223,'2018-12-07 00:00:00'),
(5,20.2609,20.5223,'2018-12-10 00:00:00'),
(6,20.3621,20.5223,'2018-12-11 00:00:00'),
(7,20.3621,20.5223,'2018-12-12 00:00:00'),
(8,20.2889,20.5223,'2018-12-13 00:00:00'),
(9,20.1126,20.5223,'2018-12-18 00:00:00'),
(10,20.1277,20.5223,'2018-12-19 00:00:00'),
(11,0,0,'2019-01-03 00:00:00'),
(12,0,0,'2019-01-04 00:00:00');
/*!40000 ALTER TABLE `tc` ENABLE KEYS */;

-- 
-- Definition of usuarios
-- 

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id_usuarios` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(450) COLLATE utf8_spanish_ci NOT NULL,
  `usuario` varchar(450) COLLATE utf8_spanish_ci NOT NULL,
  `password` varchar(450) COLLATE utf8_spanish_ci NOT NULL,
  `correo` varchar(450) COLLATE utf8_spanish_ci NOT NULL,
  `privilegios` varchar(450) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_usuarios`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

-- 
-- Dumping data for table usuarios
-- 

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios`(`id_usuarios`,`nombre`,`usuario`,`password`,`correo`,`privilegios`) VALUES
(1,'Laura Morales','Lauramorales','Media2018','lmorales@bestday.com','admin'),
(2,'Pablo Chay','chay0s','chay1318','pabloc.hay@bestday.com','admin');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2019-01-04 11:32:51
-- Total time: 0:0:0:7:181 (d:h:m:s:ms)
