/*
SQLyog Ultimate - MySQL GUI v8.2 
MySQL - 5.5.27 : Database - apipe
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`apipe` /*!40100 DEFAULT CHARACTER SET latin1 */;

/*Table structure for table `agenda` */

DROP TABLE IF EXISTS `agenda`;

CREATE TABLE `agenda` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `cliente` varchar(80) DEFAULT NULL,
  `inicio` date NOT NULL DEFAULT '0000-00-00',
  `fin` date NOT NULL,
  `domicilio_id` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refdomicilio69` (`domicilio_id`),
  CONSTRAINT `Refdomicilio69` FOREIGN KEY (`domicilio_id`) REFERENCES `domicilio` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `aseguradora` */

DROP TABLE IF EXISTS `aseguradora`;

CREATE TABLE `aseguradora` (
  `entidad_id` int(10) NOT NULL,
  PRIMARY KEY (`entidad_id`),
  CONSTRAINT `Refentidad43` FOREIGN KEY (`entidad_id`) REFERENCES `entidad` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `baja` */

DROP TABLE IF EXISTS `baja`;

CREATE TABLE `baja` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `MotivoId` int(11) DEFAULT NULL COMMENT 'Motivo de baja tipificado',
  `Observaciones` varchar(250) DEFAULT NULL COMMENT 'Observaciones',
  `MovilId` int(11) DEFAULT NULL COMMENT 'Id de movil',
  `UsuarioId` int(11) DEFAULT NULL COMMENT 'Id usuario que da la baja',
  PRIMARY KEY (`id`),
  KEY `FK_movilbaja` (`MovilId`),
  KEY `FK_usuariobaja` (`UsuarioId`),
  KEY `FK_MotivoBaja` (`MotivoId`),
  CONSTRAINT `FK_MotivoBaja` FOREIGN KEY (`MotivoId`) REFERENCES `motivobaja` (`id`),
  CONSTRAINT `FK_movilbaja` FOREIGN KEY (`MovilId`) REFERENCES `movil` (`id`),
  CONSTRAINT `FK_usuariobaja` FOREIGN KEY (`UsuarioId`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `barrio` */

DROP TABLE IF EXISTS `barrio`;

CREATE TABLE `barrio` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(120) NOT NULL,
  `lectura` bit(1) NOT NULL DEFAULT b'0',
  `voz_id` int(10) DEFAULT NULL,
  `localidad_id` smallint(5) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refvoz75` (`voz_id`),
  KEY `Reflocalidad82` (`localidad_id`),
  CONSTRAINT `Reflocalidad82` FOREIGN KEY (`localidad_id`) REFERENCES `localidad` (`id`),
  CONSTRAINT `Refvoz75` FOREIGN KEY (`voz_id`) REFERENCES `voz` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=597 DEFAULT CHARSET=latin1;

/*Table structure for table `barrio_zona` */

DROP TABLE IF EXISTS `barrio_zona`;

CREATE TABLE `barrio_zona` (
  `barrio_id` int(10) NOT NULL,
  `zona_id` int(10) NOT NULL,
  PRIMARY KEY (`barrio_id`,`zona_id`),
  KEY `Refzona39` (`zona_id`),
  CONSTRAINT `Refbarrio38` FOREIGN KEY (`barrio_id`) REFERENCES `barrio` (`id`),
  CONSTRAINT `Refzona39` FOREIGN KEY (`zona_id`) REFERENCES `zona` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `basegir` */

DROP TABLE IF EXISTS `basegir`;

CREATE TABLE `basegir` (
  `numero` bigint(20) DEFAULT NULL,
  `apellido` varchar(250) DEFAULT NULL,
  `nombre` varchar(250) DEFAULT NULL,
  `cp` varchar(250) DEFAULT NULL,
  `localidad` varchar(250) DEFAULT NULL,
  `nose` varchar(100) DEFAULT NULL,
  `direccion` varchar(250) DEFAULT NULL,
  `altura` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `bitacora` */

DROP TABLE IF EXISTS `bitacora`;

CREATE TABLE `bitacora` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pedido_id_bitacora` int(11) DEFAULT NULL,
  `domicilio_id_bitacora` int(11) DEFAULT NULL,
  `usuario_id` int(11) DEFAULT NULL,
  `operacion_id` int(11) DEFAULT NULL,
  `fechahora` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_usuario` (`usuario_id`),
  KEY `FK_Domiciliobitacora` (`domicilio_id_bitacora`),
  KEY `FK_pedidobitacora` (`pedido_id_bitacora`),
  KEY `FK_operacion` (`operacion_id`),
  CONSTRAINT `FK_operacion` FOREIGN KEY (`operacion_id`) REFERENCES `operacion` (`id`),
  CONSTRAINT `FK_Domiciliobitacora` FOREIGN KEY (`domicilio_id_bitacora`) REFERENCES `domiciliobitacora` (`autonumerico`),
  CONSTRAINT `FK_pedidobitacora` FOREIGN KEY (`pedido_id_bitacora`) REFERENCES `pedidobitacora` (`autonumerico`),
  CONSTRAINT `FK_usuario` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2243 DEFAULT CHARSET=latin1;

/*Table structure for table `calle` */

DROP TABLE IF EXISTS `calle`;

CREATE TABLE `calle` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `calle` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=650 DEFAULT CHARSET=latin1;

/*Table structure for table `chofer` */

DROP TABLE IF EXISTS `chofer`;

CREATE TABLE `chofer` (
  `entidad_id` int(10) NOT NULL,
  `turno` enum('DIURNO','NOCTURNO') NOT NULL,
  `factura` bit(1) NOT NULL,
  `carnet_vencimiento` date NOT NULL,
  `transporte_vencimiento` date NOT NULL,
  `observaciones` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`entidad_id`),
  CONSTRAINT `Refentidad49` FOREIGN KEY (`entidad_id`) REFERENCES `entidad` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `chofer_movil` */

DROP TABLE IF EXISTS `chofer_movil`;

CREATE TABLE `chofer_movil` (
  `chofer_id` int(10) NOT NULL DEFAULT '23386',
  `movil_id` int(10) NOT NULL,
  `inicio` date NOT NULL DEFAULT '2012-11-16',
  `fin` date DEFAULT NULL,
  `observacion` varchar(250) DEFAULT NULL,
  `activo` bit(1) NOT NULL DEFAULT b'1',
  `usuario_id` int(10) NOT NULL DEFAULT '1',
  PRIMARY KEY (`chofer_id`,`movil_id`),
  KEY `Refmovil52` (`movil_id`),
  KEY `Refusuario55` (`usuario_id`),
  CONSTRAINT `Refchofer51` FOREIGN KEY (`chofer_id`) REFERENCES `chofer` (`entidad_id`),
  CONSTRAINT `Refmovil52` FOREIGN KEY (`movil_id`) REFERENCES `movil` (`id`),
  CONSTRAINT `Refusuario55` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `cita` */

DROP TABLE IF EXISTS `cita`;

CREATE TABLE `cita` (
  `id` tinyint(3) NOT NULL AUTO_INCREMENT,
  `dia` enum('LUNES','MARTES','MIERCOLES','JUEVES','VIERNES','SABADO','DOMINGO') DEFAULT NULL,
  `hora` time NOT NULL,
  `agenda_id` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refagenda70` (`agenda_id`),
  CONSTRAINT `Refagenda70` FOREIGN KEY (`agenda_id`) REFERENCES `agenda` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `cliente` */

DROP TABLE IF EXISTS `cliente`;

CREATE TABLE `cliente` (
  `entidad_id` int(10) NOT NULL,
  `cliente_categoria_id` int(10) NOT NULL,
  PRIMARY KEY (`entidad_id`),
  KEY `Refcliente_categoria42` (`cliente_categoria_id`),
  CONSTRAINT `Refcliente_categoria42` FOREIGN KEY (`cliente_categoria_id`) REFERENCES `cliente_categoria` (`id`),
  CONSTRAINT `Refentidad41` FOREIGN KEY (`entidad_id`) REFERENCES `entidad` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `cliente_categoria` */

DROP TABLE IF EXISTS `cliente_categoria`;

CREATE TABLE `cliente_categoria` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `categoria` varchar(50) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Table structure for table `convenio` */

DROP TABLE IF EXISTS `convenio`;

CREATE TABLE `convenio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Fechahora` datetime DEFAULT NULL COMMENT 'Fecha hora de creacion',
  `Observacion` varchar(250) DEFAULT NULL COMMENT 'Observaciones de convenio',
  `MovilId` int(11) DEFAULT NULL COMMENT 'FK Movil',
  `UsuarioId` int(11) DEFAULT NULL COMMENT 'Usuario que genero el convenio',
  PRIMARY KEY (`id`),
  KEY `FK_movil` (`MovilId`),
  KEY `FK_usuarioconvenio` (`UsuarioId`),
  CONSTRAINT `FK_usuarioconvenio` FOREIGN KEY (`UsuarioId`) REFERENCES `usuario` (`entidad_id`),
  CONSTRAINT `FK_movil` FOREIGN KEY (`MovilId`) REFERENCES `movil` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `cuotaplan` */

DROP TABLE IF EXISTS `cuotaplan`;

CREATE TABLE `cuotaplan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `FechaPago` date DEFAULT NULL COMMENT 'Fecha tentativa de pago',
  `FechaReal` date DEFAULT NULL COMMENT 'Fecha real de pago',
  `MontoPago` decimal(10,0) DEFAULT NULL COMMENT 'Monto de cuota',
  `MontoReal` decimal(10,0) DEFAULT NULL COMMENT 'Monto Pagado de cuota',
  `Observacion` varchar(250) DEFAULT NULL COMMENT 'Observacion de la cuota',
  `Entregado` bit(1) DEFAULT NULL COMMENT 'Entregado|No entregado',
  `FechaEntrega` datetime DEFAULT NULL COMMENT 'Fecha de entrega de la cuota',
  `ResponsableEntrega` varchar(250) DEFAULT NULL COMMENT 'Aclaracion sobre la persona a la que se entrega el pago',
  `EncargadoId` int(11) DEFAULT NULL COMMENT 'FK encargado al que se entrega',
  `UsuarioId` int(11) DEFAULT NULL COMMENT 'FK Usuario que cobra cuota',
  `PlanId` int(11) DEFAULT NULL COMMENT 'FK del plan',
  PRIMARY KEY (`id`),
  KEY `FK_EncargadoRetira` (`EncargadoId`),
  KEY `FK_UsuarioCuota` (`UsuarioId`),
  KEY `FK_PlanPago` (`PlanId`),
  CONSTRAINT `FK_PlanPago` FOREIGN KEY (`PlanId`) REFERENCES `planpago` (`id`),
  CONSTRAINT `FK_EncargadoRetira` FOREIGN KEY (`EncargadoId`) REFERENCES `encargado` (`entidadid`),
  CONSTRAINT `FK_UsuarioCuota` FOREIGN KEY (`UsuarioId`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `cupon` */

DROP TABLE IF EXISTS `cupon`;

CREATE TABLE `cupon` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `cuota` tinyint(3) NOT NULL,
  `vencimiento` date NOT NULL,
  `importe` decimal(7,2) NOT NULL,
  `pagado` bit(1) NOT NULL DEFAULT b'0',
  `poliza_id` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refpoliza47` (`poliza_id`),
  CONSTRAINT `Refpoliza47` FOREIGN KEY (`poliza_id`) REFERENCES `poliza` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `documento` */

DROP TABLE IF EXISTS `documento`;

CREATE TABLE `documento` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `FechaHora` datetime DEFAULT NULL COMMENT 'Fecha de creacion del documento',
  `Ubicacion` varchar(150) DEFAULT NULL COMMENT 'Enlace a la imagen',
  `MovilId` int(11) DEFAULT NULL COMMENT 'Id movil',
  `ChoferId` int(11) DEFAULT NULL COMMENT 'Id del chofer de la que se genera el documento',
  `EncargadoId` int(11) DEFAULT NULL COMMENT 'Id del encargado del movil por el que se esta generando el documento',
  `UsuarioId` int(11) DEFAULT NULL COMMENT 'Id del usuario que genera',
  `Tipo de Documento` int(11) DEFAULT NULL COMMENT 'Id del tipo de documento',
  PRIMARY KEY (`id`),
  KEY `FK_TipoDocumentoId` (`Tipo de Documento`),
  KEY `FK_MovilDocumento` (`MovilId`),
  KEY `FK_ChoferDocumento` (`ChoferId`),
  KEY `FK_UsuarioDocumento` (`UsuarioId`),
  KEY `FK_EncargadoId` (`EncargadoId`),
  CONSTRAINT `FK_EncargadoId` FOREIGN KEY (`EncargadoId`) REFERENCES `encargado` (`entidadid`),
  CONSTRAINT `FK_ChoferDocumento` FOREIGN KEY (`ChoferId`) REFERENCES `chofer` (`entidad_id`),
  CONSTRAINT `FK_MovilDocumento` FOREIGN KEY (`MovilId`) REFERENCES `movil` (`id`),
  CONSTRAINT `FK_TipoDocumentoId` FOREIGN KEY (`Tipo de Documento`) REFERENCES `tipodocumento` (`id`),
  CONSTRAINT `FK_UsuarioDocumento` FOREIGN KEY (`UsuarioId`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `domicilio` */

DROP TABLE IF EXISTS `domicilio`;

CREATE TABLE `domicilio` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `calle` varchar(80) NOT NULL,
  `numero` int(10) DEFAULT NULL,
  `tipo` enum('CASA','DEPARTAMENTO','OFICINA','HOTEL','LOCAL') NOT NULL,
  `descripcion` varchar(250) DEFAULT NULL,
  `interseccion` varchar(200) DEFAULT NULL,
  `observacion` varchar(250) DEFAULT NULL,
  `barrio_id` int(10) NOT NULL,
  `voz_calle_id` int(10) DEFAULT NULL,
  `voz_interseccion_id` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `Refvoz76` (`voz_calle_id`),
  KEY `Refvoz77` (`voz_interseccion_id`),
  KEY `Refbarrio36` (`barrio_id`),
  CONSTRAINT `Refbarrio36` FOREIGN KEY (`barrio_id`) REFERENCES `barrio` (`id`),
  CONSTRAINT `Refvoz76` FOREIGN KEY (`voz_calle_id`) REFERENCES `voz` (`id`),
  CONSTRAINT `Refvoz77` FOREIGN KEY (`voz_interseccion_id`) REFERENCES `voz` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=78847 DEFAULT CHARSET=latin1;

/*Table structure for table `domiciliobitacora` */

DROP TABLE IF EXISTS `domiciliobitacora`;

CREATE TABLE `domiciliobitacora` (
  `id` int(10) NOT NULL,
  `calle` varchar(80) NOT NULL,
  `numero` int(10) DEFAULT NULL,
  `tipo` enum('CASA','DEPARTAMENTO','OFICINA','HOTEL','LOCAL') NOT NULL,
  `descripcion` varchar(250) DEFAULT NULL,
  `interseccion` varchar(200) DEFAULT NULL,
  `observacion` varchar(250) DEFAULT NULL,
  `barrio_id` int(10) NOT NULL,
  `voz_calle_id` int(10) DEFAULT NULL,
  `voz_interseccion_id` int(10) DEFAULT NULL,
  `autonumerico` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`autonumerico`),
  KEY `Refvoz76` (`voz_calle_id`),
  KEY `Refvoz77` (`voz_interseccion_id`),
  KEY `Refbarrio36` (`barrio_id`),
  KEY `FK_domicilio` (`id`),
  CONSTRAINT `FK_domicilio` FOREIGN KEY (`id`) REFERENCES `domicilio` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `encargado` */

DROP TABLE IF EXISTS `encargado`;

CREATE TABLE `encargado` (
  `entidadid` int(11) NOT NULL,
  `TipoEncargado` int(11) DEFAULT NULL COMMENT 'Id de tipo',
  PRIMARY KEY (`entidadid`),
  KEY `FK_TipoEncargado` (`TipoEncargado`),
  CONSTRAINT `FK_TipoEncargado` FOREIGN KEY (`TipoEncargado`) REFERENCES `tipoencargado` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `encargadomovil` */

DROP TABLE IF EXISTS `encargadomovil`;

CREATE TABLE `encargadomovil` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `MovilId` int(11) DEFAULT NULL COMMENT 'FK de movil',
  `EncargadoId` int(11) DEFAULT NULL COMMENT 'FK de encargado',
  `UsuarioId` int(11) DEFAULT NULL COMMENT 'FK de usuario',
  `activo` bit(1) DEFAULT NULL COMMENT 'Bit para ver si el encargado es actualmente activo. 1 activo|0 desactivado',
  PRIMARY KEY (`id`),
  KEY `FK_MovilEncargado` (`MovilId`),
  KEY `FK_EncargadoMovil` (`EncargadoId`),
  KEY `FK_usuarioencargadomovil` (`UsuarioId`),
  CONSTRAINT `FK_usuarioencargadomovil` FOREIGN KEY (`UsuarioId`) REFERENCES `usuario` (`entidad_id`),
  CONSTRAINT `FK_EncargadoMovil` FOREIGN KEY (`EncargadoId`) REFERENCES `encargado` (`entidadid`),
  CONSTRAINT `FK_MovilEncargado` FOREIGN KEY (`MovilId`) REFERENCES `movil` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `entidad` */

DROP TABLE IF EXISTS `entidad`;

CREATE TABLE `entidad` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `cuil` char(13) DEFAULT NULL,
  `apellido` varchar(50) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `estado_civil` enum('Casado','Soltero','Viudo','Divorciado','Concuvinato') DEFAULT NULL,
  `sexo` enum('Masculino','Femenino') DEFAULT 'Masculino',
  `fecha_nacimiento` date DEFAULT NULL,
  `tipo_documento` enum('D.N.I.','L.E.','L.C.','Pasaporte','Cédula Federal','Cédula Provincial') DEFAULT NULL,
  `nro_documento` int(11) NOT NULL,
  `mail` varchar(50) DEFAULT NULL,
  `observacion` varchar(30) DEFAULT NULL,
  `iva` char(100) DEFAULT 'Consumidor Final',
  `foto` blob,
  `baja` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=57758 DEFAULT CHARSET=latin1;

/*Table structure for table `formulario` */

DROP TABLE IF EXISTS `formulario`;

CREATE TABLE `formulario` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `nombre_form` varchar(30) NOT NULL,
  `detalle` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

/*Table structure for table `formulario_rol` */

DROP TABLE IF EXISTS `formulario_rol`;

CREATE TABLE `formulario_rol` (
  `formulario_id` smallint(6) NOT NULL,
  `rol_id` smallint(5) NOT NULL,
  PRIMARY KEY (`formulario_id`,`rol_id`),
  KEY `Refrol34` (`rol_id`),
  CONSTRAINT `Refformulario9` FOREIGN KEY (`formulario_id`) REFERENCES `formulario` (`id`),
  CONSTRAINT `Refrol34` FOREIGN KEY (`rol_id`) REFERENCES `rol` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `frecuencia` */

DROP TABLE IF EXISTS `frecuencia`;

CREATE TABLE `frecuencia` (
  `id` tinyint(3) NOT NULL AUTO_INCREMENT,
  `numero` tinyint(3) NOT NULL,
  `EstadoFila` char(1) NOT NULL DEFAULT 'i',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Table structure for table `legajo` */

DROP TABLE IF EXISTS `legajo`;

CREATE TABLE `legajo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL COMMENT 'Fecha de creación',
  `Observacion` varchar(250) DEFAULT NULL COMMENT 'Observaciones del movimiento',
  `MovimientoLegajo` int(11) DEFAULT NULL COMMENT 'FK Movimiento Legajo',
  `ChoferId` int(11) DEFAULT NULL COMMENT 'FK Chofer',
  `EncargadoId` int(11) DEFAULT NULL COMMENT 'FK encargado',
  `Usuario` int(11) DEFAULT NULL COMMENT 'FK Usuario',
  PRIMARY KEY (`id`),
  KEY `FK_ChoferLegajo` (`ChoferId`),
  KEY `FK_Encargadolegajo` (`EncargadoId`),
  KEY `FK_Movimientolegajo` (`MovimientoLegajo`),
  KEY `FK_usuariolegajo` (`Usuario`),
  CONSTRAINT `FK_usuariolegajo` FOREIGN KEY (`Usuario`) REFERENCES `usuario` (`entidad_id`),
  CONSTRAINT `FK_ChoferLegajo` FOREIGN KEY (`ChoferId`) REFERENCES `chofer` (`entidad_id`),
  CONSTRAINT `FK_Encargadolegajo` FOREIGN KEY (`EncargadoId`) REFERENCES `encargado` (`entidadid`),
  CONSTRAINT `FK_Movimientolegajo` FOREIGN KEY (`MovimientoLegajo`) REFERENCES `movimientolegajo` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `legajomovil` */

DROP TABLE IF EXISTS `legajomovil`;

CREATE TABLE `legajomovil` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL COMMENT 'Fecha de creacion',
  `FechaDesde` datetime DEFAULT NULL COMMENT 'Fecha desde',
  `FechaHasta` datetime DEFAULT NULL COMMENT 'Fecha Hasta',
  `MovilId` int(11) DEFAULT NULL COMMENT 'FK de movil',
  `Observación` varchar(250) DEFAULT NULL COMMENT 'Observaciones de la entrada del legajo ',
  `UsuarioId` int(11) DEFAULT NULL COMMENT 'FK usuario que inicia la linea de legajo',
  `MovimientoMovilId` int(11) DEFAULT NULL COMMENT 'FK Movimiento Movil',
  PRIMARY KEY (`id`),
  KEY `FK_legajomovil` (`MovilId`),
  KEY `FK_usuariolegajomovil` (`UsuarioId`),
  KEY `FK_Movimientolegajomovil` (`MovimientoMovilId`),
  CONSTRAINT `FK_Movimientolegajomovil` FOREIGN KEY (`MovimientoMovilId`) REFERENCES `movimientomovil` (`id`),
  CONSTRAINT `FK_legajomovil` FOREIGN KEY (`MovilId`) REFERENCES `movil` (`id`),
  CONSTRAINT `FK_usuariolegajomovil` FOREIGN KEY (`UsuarioId`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `llamada` */

DROP TABLE IF EXISTS `llamada`;

CREATE TABLE `llamada` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fechahora` datetime DEFAULT NULL,
  `telefono_id` int(11) DEFAULT NULL,
  `usuario_id` int(11) DEFAULT NULL,
  `numero` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_telefono` (`telefono_id`),
  KEY `FK_user` (`usuario_id`),
  CONSTRAINT `FK_user` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`),
  CONSTRAINT `FK_telefono` FOREIGN KEY (`telefono_id`) REFERENCES `telefono` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=246857 DEFAULT CHARSET=latin1;

/*Table structure for table `localidad` */

DROP TABLE IF EXISTS `localidad`;

CREATE TABLE `localidad` (
  `id` smallint(5) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(36) NOT NULL,
  `cp` smallint(6) NOT NULL,
  `provincia_id` smallint(5) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refprovincias14` (`provincia_id`),
  CONSTRAINT `Refprovincias14` FOREIGN KEY (`provincia_id`) REFERENCES `provincia` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24876 DEFAULT CHARSET=latin1;

/*Table structure for table `mail` */

DROP TABLE IF EXISTS `mail`;

CREATE TABLE `mail` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `contacto` varchar(80) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `dominio` varchar(80) NOT NULL,
  `entidad_id` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refentidad17` (`entidad_id`),
  CONSTRAINT `Refentidad17` FOREIGN KEY (`entidad_id`) REFERENCES `entidad` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `motivobaja` */

DROP TABLE IF EXISTS `motivobaja`;

CREATE TABLE `motivobaja` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) DEFAULT NULL COMMENT 'Descripcion del motivo de la baja',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `motivodeuda` */

DROP TABLE IF EXISTS `motivodeuda`;

CREATE TABLE `motivodeuda` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) DEFAULT NULL COMMENT 'Deuda Alquiler|Deuda multa|Deuda taller',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `movil` */

DROP TABLE IF EXISTS `movil`;

CREATE TABLE `movil` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `numero` smallint(5) NOT NULL,
  `color` varchar(30) NOT NULL,
  `chapa` char(10) NOT NULL,
  `marca` varchar(30) NOT NULL,
  `modelo` varchar(30) NOT NULL,
  `aire` bit(1) NOT NULL,
  `baul` enum('CHICO','NORMAL','GRANDE') NOT NULL,
  `habilitacion` date NOT NULL DEFAULT '2012-11-16',
  `seguro` date NOT NULL DEFAULT '2012-11-16',
  `en_zona` datetime DEFAULT NULL,
  `observacion` varchar(250) DEFAULT NULL,
  `alta` date NOT NULL DEFAULT '2012-11-16',
  `baja` date DEFAULT NULL,
  `habilitado` bit(1) NOT NULL DEFAULT b'1',
  `telefono` varchar(18) DEFAULT NULL,
  `titular_id` int(10) NOT NULL DEFAULT '23387',
  `responsable_id` int(10) NOT NULL DEFAULT '23388',
  `frecuencia_id` tinyint(3) DEFAULT NULL,
  `zona_id` int(10) NOT NULL DEFAULT '1',
  `Motor` varchar(30) DEFAULT NULL,
  `Chasis` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `Refentidad53` (`titular_id`),
  KEY `Refentidad54` (`responsable_id`),
  KEY `Reffrecuencia62` (`frecuencia_id`),
  KEY `Refzona72` (`zona_id`),
  CONSTRAINT `Refentidad53` FOREIGN KEY (`titular_id`) REFERENCES `entidad` (`id`),
  CONSTRAINT `Refentidad54` FOREIGN KEY (`responsable_id`) REFERENCES `entidad` (`id`),
  CONSTRAINT `Reffrecuencia62` FOREIGN KEY (`frecuencia_id`) REFERENCES `frecuencia` (`id`),
  CONSTRAINT `Refzona72` FOREIGN KEY (`zona_id`) REFERENCES `zona` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2173 DEFAULT CHARSET=latin1;

/*Table structure for table `movimientolegajo` */

DROP TABLE IF EXISTS `movimientolegajo`;

CREATE TABLE `movimientolegajo` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) DEFAULT NULL COMMENT 'Suspensión|queja de cliente|deuda|etc.',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `movimientomovil` */

DROP TABLE IF EXISTS `movimientomovil`;

CREATE TABLE `movimientomovil` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) DEFAULT NULL COMMENT 'Descripcion: taller|carnet|seguro|etc.',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `movimientorol` */

DROP TABLE IF EXISTS `movimientorol`;

CREATE TABLE `movimientorol` (
  `MovimientoMovilid` int(11) NOT NULL,
  `RolId` smallint(5) NOT NULL,
  PRIMARY KEY (`MovimientoMovilid`,`RolId`),
  KEY `FK_movimientorol` (`RolId`),
  CONSTRAINT `FK_movimientorol` FOREIGN KEY (`RolId`) REFERENCES `rol` (`id`),
  CONSTRAINT `FK_movrolmovi` FOREIGN KEY (`MovimientoMovilid`) REFERENCES `movimientomovil` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `operacion` */

DROP TABLE IF EXISTS `operacion`;

CREATE TABLE `operacion` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

/*Table structure for table `operador` */

DROP TABLE IF EXISTS `operador`;

CREATE TABLE `operador` (
  `entidad_id` int(10) NOT NULL,
  `frecuencia_id` tinyint(3) DEFAULT NULL,
  PRIMARY KEY (`entidad_id`),
  KEY `Reffrecuencia61` (`frecuencia_id`),
  CONSTRAINT `Refentidad60` FOREIGN KEY (`entidad_id`) REFERENCES `entidad` (`id`),
  CONSTRAINT `Reffrecuencia61` FOREIGN KEY (`frecuencia_id`) REFERENCES `frecuencia` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `pais` */

DROP TABLE IF EXISTS `pais`;

CREATE TABLE `pais` (
  `id` smallint(5) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Table structure for table `pedido` */

DROP TABLE IF EXISTS `pedido`;

CREATE TABLE `pedido` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `cliente` varchar(250) NOT NULL,
  `fechahora` datetime NOT NULL,
  `fechahora_viaje` datetime NOT NULL,
  `asignado` datetime DEFAULT NULL,
  `completado` datetime DEFAULT NULL,
  `cancelado` datetime DEFAULT NULL,
  `observacion` varchar(240) DEFAULT NULL,
  `chofer_id` int(10) DEFAULT NULL,
  `movil_id` int(10) DEFAULT NULL,
  `usuario_id` int(10) NOT NULL,
  `operador_id` int(10) DEFAULT NULL,
  `pedido_categoria_id` smallint(5) NOT NULL,
  `domicilio_id` int(10) NOT NULL,
  `telefono_id` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refusuario56` (`usuario_id`),
  KEY `Refchofer_movil58` (`chofer_id`,`movil_id`),
  KEY `Refoperador63` (`operador_id`),
  KEY `Refpedido_categoria71` (`pedido_categoria_id`),
  KEY `Reftelefono_domicilio81` (`domicilio_id`,`telefono_id`),
  CONSTRAINT `Refchofer_movil58` FOREIGN KEY (`chofer_id`, `movil_id`) REFERENCES `chofer_movil` (`chofer_id`, `movil_id`),
  CONSTRAINT `Refoperador63` FOREIGN KEY (`operador_id`) REFERENCES `operador` (`entidad_id`),
  CONSTRAINT `Refpedido_categoria71` FOREIGN KEY (`pedido_categoria_id`) REFERENCES `pedido_categoria` (`id`),
  CONSTRAINT `Reftelefono_domicilio81` FOREIGN KEY (`domicilio_id`, `telefono_id`) REFERENCES `telefono_domicilio` (`domicilio_id`, `telefono_id`),
  CONSTRAINT `Refusuario56` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB AUTO_INCREMENT=187627 DEFAULT CHARSET=latin1;

/*Table structure for table `pedido_categoria` */

DROP TABLE IF EXISTS `pedido_categoria`;

CREATE TABLE `pedido_categoria` (
  `id` smallint(5) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Table structure for table `pedidobitacora` */

DROP TABLE IF EXISTS `pedidobitacora`;

CREATE TABLE `pedidobitacora` (
  `id` int(10) NOT NULL,
  `cliente` varchar(250) NOT NULL,
  `fechahora` datetime NOT NULL,
  `fechahora_viaje` datetime NOT NULL,
  `asignado` datetime DEFAULT NULL,
  `completado` datetime DEFAULT NULL,
  `cancelado` datetime DEFAULT NULL,
  `observacion` varchar(240) DEFAULT NULL,
  `chofer_id` int(10) DEFAULT NULL,
  `movil_id` int(10) DEFAULT NULL,
  `usuario_id` int(10) NOT NULL,
  `operador_id` int(10) DEFAULT NULL,
  `pedido_categoria_id` smallint(5) NOT NULL,
  `domicilio_id` int(10) NOT NULL,
  `telefono_id` int(10) NOT NULL,
  `autonumerico` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`autonumerico`),
  KEY `Refusuario56` (`usuario_id`),
  KEY `Refchofer_movil58` (`chofer_id`,`movil_id`),
  KEY `Refoperador63` (`operador_id`),
  KEY `Refpedido_categoria71` (`pedido_categoria_id`),
  KEY `Reftelefono_domicilio81` (`domicilio_id`,`telefono_id`),
  KEY `FK_pedido` (`id`),
  CONSTRAINT `FK_pedido` FOREIGN KEY (`id`) REFERENCES `pedido` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `planpago` */

DROP TABLE IF EXISTS `planpago`;

CREATE TABLE `planpago` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL COMMENT 'Fecha inicio tramite',
  `Observacion` varchar(250) DEFAULT NULL COMMENT 'Mas detalles de la deuda',
  `TotalDeuda` decimal(10,0) DEFAULT NULL COMMENT 'Monto total de la deuda',
  `Cuotas` int(11) DEFAULT NULL COMMENT 'Cantidad de cuotas',
  `MontoPagado` decimal(10,0) DEFAULT NULL COMMENT 'Monto de lo que tiene pagado hasta el momento',
  `MotivoDeudaId` int(11) DEFAULT NULL COMMENT 'FK Motivo Deuda',
  `ChoferId` int(11) DEFAULT NULL COMMENT 'FK Chofer',
  `MovilId` int(11) DEFAULT NULL COMMENT 'FK Movil',
  `UsuarioId` int(11) DEFAULT NULL COMMENT 'FK Usuario',
  `EncargadoId` int(11) DEFAULT NULL COMMENT 'FK Encargado, solo se va a usar cuando no se puede relacionar con un movil.. ',
  PRIMARY KEY (`id`),
  KEY `FK_Motivoplanpago` (`MotivoDeudaId`),
  KEY `FK_Choferplanpago` (`ChoferId`),
  KEY `FK_Encargadoplanpago` (`EncargadoId`),
  KEY `FK_Movilplanpago` (`MovilId`),
  KEY `FK_Usuarioplanpago` (`UsuarioId`),
  CONSTRAINT `FK_Usuarioplanpago` FOREIGN KEY (`UsuarioId`) REFERENCES `usuario` (`entidad_id`),
  CONSTRAINT `FK_Choferplanpago` FOREIGN KEY (`ChoferId`) REFERENCES `chofer` (`entidad_id`),
  CONSTRAINT `FK_Encargadoplanpago` FOREIGN KEY (`EncargadoId`) REFERENCES `encargado` (`entidadid`),
  CONSTRAINT `FK_Motivoplanpago` FOREIGN KEY (`MotivoDeudaId`) REFERENCES `motivodeuda` (`id`),
  CONSTRAINT `FK_Movilplanpago` FOREIGN KEY (`MovilId`) REFERENCES `movil` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `poliza` */

DROP TABLE IF EXISTS `poliza`;

CREATE TABLE `poliza` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `numero` int(10) NOT NULL,
  `aseguradora_id` int(10) NOT NULL,
  `movil_id` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refaseguradora45` (`aseguradora_id`),
  KEY `Refmovil46` (`movil_id`),
  CONSTRAINT `Refaseguradora45` FOREIGN KEY (`aseguradora_id`) REFERENCES `aseguradora` (`entidad_id`),
  CONSTRAINT `Refmovil46` FOREIGN KEY (`movil_id`) REFERENCES `movil` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `provincia` */

DROP TABLE IF EXISTS `provincia`;

CREATE TABLE `provincia` (
  `id` smallint(5) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(22) NOT NULL,
  `pais_id` smallint(5) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refpais13` (`pais_id`),
  CONSTRAINT `Refpais13` FOREIGN KEY (`pais_id`) REFERENCES `pais` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

/*Table structure for table `reclamo` */

DROP TABLE IF EXISTS `reclamo`;

CREATE TABLE `reclamo` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `fechahora` datetime NOT NULL,
  `asunto` varchar(120) NOT NULL,
  `finalizo` datetime DEFAULT NULL,
  `cliente_id` int(10) NOT NULL,
  `reclamo_categoria_id` smallint(5) NOT NULL,
  `pedido_id` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `Refcliente64` (`cliente_id`),
  KEY `Refreclamo_categoria65` (`reclamo_categoria_id`),
  KEY `Refpedido66` (`pedido_id`),
  CONSTRAINT `Refcliente64` FOREIGN KEY (`cliente_id`) REFERENCES `cliente` (`entidad_id`),
  CONSTRAINT `Refpedido66` FOREIGN KEY (`pedido_id`) REFERENCES `pedido` (`id`),
  CONSTRAINT `Refreclamo_categoria65` FOREIGN KEY (`reclamo_categoria_id`) REFERENCES `reclamo_categoria` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4160 DEFAULT CHARSET=latin1;

/*Table structure for table `reclamo_categoria` */

DROP TABLE IF EXISTS `reclamo_categoria`;

CREATE TABLE `reclamo_categoria` (
  `id` smallint(5) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Table structure for table `reclamo_linea` */

DROP TABLE IF EXISTS `reclamo_linea`;

CREATE TABLE `reclamo_linea` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `fechahora` datetime NOT NULL,
  `comentario` varchar(250) NOT NULL,
  `usuario_id` int(10) NOT NULL,
  `reclamo_id` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refusuario73` (`usuario_id`),
  KEY `Refreclamo74` (`reclamo_id`),
  CONSTRAINT `Refreclamo74` FOREIGN KEY (`reclamo_id`) REFERENCES `reclamo` (`id`),
  CONSTRAINT `Refusuario73` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4777 DEFAULT CHARSET=latin1;

/*Table structure for table `rol` */

DROP TABLE IF EXISTS `rol`;

CREATE TABLE `rol` (
  `id` smallint(5) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Table structure for table `session` */

DROP TABLE IF EXISTS `session`;

CREATE TABLE `session` (
  `usuario_id` int(10) NOT NULL,
  `ip` char(15) NOT NULL,
  `ttl` datetime NOT NULL,
  PRIMARY KEY (`usuario_id`),
  CONSTRAINT `Refusuario831` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `telefonista` */

DROP TABLE IF EXISTS `telefonista`;

CREATE TABLE `telefonista` (
  `usuario_id` int(10) NOT NULL,
  `interno` smallint(5) NOT NULL,
  `password` varchar(80) NOT NULL,
  `dominio` varchar(60) NOT NULL,
  PRIMARY KEY (`usuario_id`),
  CONSTRAINT `Refusuario78` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `telefono` */

DROP TABLE IF EXISTS `telefono`;

CREATE TABLE `telefono` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `tipo` enum('PARTICULAR','CELULAR','TRABAJO','OTRO') NOT NULL,
  `cod_area` varchar(10) DEFAULT NULL,
  `numero` varchar(20) NOT NULL,
  `horario_manana` varchar(40) DEFAULT NULL,
  `horario_tarde` varchar(40) DEFAULT NULL,
  `observaciones` varchar(100) DEFAULT NULL,
  `entidad_id` int(10) NOT NULL,
  `ivr` bit(1) DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `TelUnique` (`cod_area`,`numero`),
  KEY `Refentidad35` (`entidad_id`),
  CONSTRAINT `Refentidad35` FOREIGN KEY (`entidad_id`) REFERENCES `entidad` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=57668 DEFAULT CHARSET=latin1;

/*Table structure for table `telefono_domicilio` */

DROP TABLE IF EXISTS `telefono_domicilio`;

CREATE TABLE `telefono_domicilio` (
  `domicilio_id` int(10) NOT NULL,
  `telefono_id` int(10) NOT NULL,
  `prioridad` smallint(5) NOT NULL,
  `baja` bit(1) DEFAULT b'1',
  PRIMARY KEY (`domicilio_id`,`telefono_id`),
  KEY `Reftelefono80` (`telefono_id`),
  CONSTRAINT `Refdomicilio79` FOREIGN KEY (`domicilio_id`) REFERENCES `domicilio` (`id`),
  CONSTRAINT `Reftelefono80` FOREIGN KEY (`telefono_id`) REFERENCES `telefono` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `tipodocumento` */

DROP TABLE IF EXISTS `tipodocumento`;

CREATE TABLE `tipodocumento` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) DEFAULT NULL COMMENT 'Descripcion del documento',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `tipoencargado` */

DROP TABLE IF EXISTS `tipoencargado`;

CREATE TABLE `tipoencargado` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) DEFAULT NULL COMMENT 'Descripcion del tipo de encargado',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `entidad_id` int(10) NOT NULL,
  `usuario` varchar(16) NOT NULL,
  `password` varchar(50) NOT NULL,
  `activo` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`entidad_id`),
  CONSTRAINT `Refentidad22` FOREIGN KEY (`entidad_id`) REFERENCES `entidad` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `usuario_rol` */

DROP TABLE IF EXISTS `usuario_rol`;

CREATE TABLE `usuario_rol` (
  `usuario_id` int(10) NOT NULL,
  `rol_id` smallint(5) NOT NULL,
  PRIMARY KEY (`usuario_id`,`rol_id`),
  KEY `Refrol33` (`rol_id`),
  CONSTRAINT `fk_usuario_has_rol_usuario1` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`),
  CONSTRAINT `Refrol33` FOREIGN KEY (`rol_id`) REFERENCES `rol` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `usuario_sucursal` */

DROP TABLE IF EXISTS `usuario_sucursal`;

CREATE TABLE `usuario_sucursal` (
  `usuario_id` int(10) NOT NULL,
  `sucursal_id` smallint(5) NOT NULL,
  PRIMARY KEY (`usuario_id`,`sucursal_id`),
  CONSTRAINT `Refusuario23` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`entidad_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `voz` */

DROP TABLE IF EXISTS `voz`;

CREATE TABLE `voz` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` char(30) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombreUnique` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Table structure for table `zona` */

DROP TABLE IF EXISTS `zona`;

CREATE TABLE `zona` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(80) NOT NULL,
  `zona_padre_id` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `Refzona37` (`zona_padre_id`),
  CONSTRAINT `Refzona37` FOREIGN KEY (`zona_padre_id`) REFERENCES `zona` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

/* Trigger structure for table `pedido` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `incPrioridad` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'apipe'@'%' */ /*!50003 TRIGGER `incPrioridad` BEFORE INSERT ON `pedido` FOR EACH ROW BEGIN
UPDATE telefono_domicilio SET prioridad=prioridad+1 WHERE telefono_id=NEW.telefono_id AND domicilio_id=NEW.domicilio_id;
END */$$


DELIMITER ;

/* Trigger structure for table `pedido` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `nuevo_pedido` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'apipe'@'%' */ /*!50003 TRIGGER `nuevo_pedido` AFTER INSERT ON `pedido` FOR EACH ROW BEGIN
DECLARE varIP CHAR(20);
DECLARE done INT DEFAULT 0;
DECLARE c1 CURSOR FOR 
SELECT ip from session
WHERE TIME_TO_SEC(TIMEDIFF(NOW(),ttl))<600;
DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
OPEN c1;
REPEAT
FETCH c1 INTO varIP;
IF NOT done THEN
SET @exec_var = sys_exec(CONCAT('/usr/local/sbin/apipe.sh  ', varIP,' ',NEW.id));
END IF;
UNTIL done END REPEAT;
CLOSE c1;
END */$$


DELIMITER ;

/* Trigger structure for table `pedido` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `cambio_pedido` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'apipe'@'%' */ /*!50003 TRIGGER `cambio_pedido` AFTER UPDATE ON `pedido` FOR EACH ROW BEGIN
DECLARE varIP CHAR(20);
DECLARE done INT DEFAULT 0;
DECLARE c1 CURSOR FOR 
SELECT ip from session
WHERE TIME_TO_SEC(TIMEDIFF(NOW(),ttl))<600;
DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
OPEN c1;
REPEAT
FETCH c1 INTO varIP;
IF NOT done THEN
SET @exec_var = sys_exec(CONCAT('/usr/local/sbin/apipe.sh  ', varIP,' ',NEW.id));
END IF;
UNTIL done END REPEAT;
CLOSE c1;
END */$$


DELIMITER ;

/* Trigger structure for table `reclamo_linea` */

DELIMITER $$

/*!50003 DROP TRIGGER*//*!50032 IF EXISTS */ /*!50003 `reclamo_pedido` */$$

/*!50003 CREATE */ /*!50017 DEFINER = 'apipe'@'%' */ /*!50003 TRIGGER `reclamo_pedido` AFTER INSERT ON `reclamo_linea` FOR EACH ROW BEGIN
DECLARE varIP CHAR(20);
DECLARE done INT DEFAULT 0;
DECLARE c1 CURSOR FOR 
 SELECT ip from session
 WHERE TIME_TO_SEC(TIMEDIFF(NOW(),ttl))<600;
DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
OPEN c1;
REPEAT
FETCH c1 INTO varIP;
IF NOT done THEN
SET @exec_var = sys_exec(CONCAT('echo RECLAMO_LINEA,', NEW.id,' | nc ',varIP,' 6600 &'));
END IF;
UNTIL done END REPEAT;
CLOSE c1;
END */$$


DELIMITER ;

/* Procedure structure for procedure `atendidosPorHora` */

/*!50003 DROP PROCEDURE IF EXISTS  `atendidosPorHora` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`apipe`@`%` PROCEDURE `atendidosPorHora`(in fecha date)
BEGIN
SELECT DATE(fechahora) AS Fecha,HOUR(fechahora)AS Hora,usuario AS Telefonista,  COUNT(*) AS Atendidos 
FROM pedido, usuario
WHERE pedido.usuario_id = usuario.entidad_id AND date(pedido.fechahora)= date(fecha)
GROUP BY DATE(fechahora),HOUR(fechahora), usuario_id;
    END */$$
DELIMITER ;

/* Procedure structure for procedure `atendidosPorUsuario` */

/*!50003 DROP PROCEDURE IF EXISTS  `atendidosPorUsuario` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`apipe`@`%` PROCEDURE `atendidosPorUsuario`()
BEGIN
	SELECT DATE(fechahora) as fecha, usuario_id, COUNT(*) as total FROM pedido GROUP BY DATE(fechahora) order by date(fechahora) desc;
END */$$
DELIMITER ;

/* Procedure structure for procedure `atendidosPorUsuarioParam` */

/*!50003 DROP PROCEDURE IF EXISTS  `atendidosPorUsuarioParam` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`apipe`@`%` PROCEDURE `atendidosPorUsuarioParam`(in telefonista integer)
BEGIN
	SELECT DATE(fechahora), COUNT(*) FROM pedido where usuario_id= telefonista GROUP BY DATE(fechahora);
END */$$
DELIMITER ;

/* Procedure structure for procedure `setSession` */

/*!50003 DROP PROCEDURE IF EXISTS  `setSession` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `setSession`(IN usuarioID INT(11))
    COMMENT 'Actualiza la Secion'
BEGIN
SET @IP=(select substr(host,1,POSITION(':' IN host)-1) from information_schema.processlist WHERE ID=connection_id());
INSERT INTO session (usuario_id,ip) VALUES (usuarioID,@IP) ON DUPLICATE KEY UPDATE ip=@IP;
END */$$
DELIMITER ;

/* Procedure structure for procedure `sp_cancelados` */

/*!50003 DROP PROCEDURE IF EXISTS  `sp_cancelados` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`apipe`@`%` PROCEDURE `sp_cancelados`(in fecha date)
SELECT DATE(fechahora_viaje) AS Fecha, COUNT(p.id) AS Cancelados FROM pedido p WHERE 
DATE(fechahora_viaje)=date(fecha) AND cancelado GROUP BY DATE(fechahora_viaje) */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
