DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `DomicilioNuevo`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `DomicilioNuevo`(IN calle VARCHAR(80),IN numero INT(10), 
	IN tipo ENUM('CASA','DEPARTAMENTO','OFICINA','HOTEL','LOCAL'),IN descripcion VARCHAR(250),IN interseccion VARCHAR(200),
	IN observacion VARCHAR(200),IN barrio INT (10), IN zona INT(10),IN telefono INT(10))
BEGIN
	DECLARE  vcalle INTEGER;
	DECLARE vinterseccion INTEGER;
	DECLARE lastdomicilio INTEGER;
	SET @vcalle= (SELECT c.voz_id FROM calle c WHERE c.calle = calle LIMIT 1);
	SET @vinterseccion= (SELECT c.voz_id FROM calle c WHERE c.calle = interseccion LIMIT 1);
	
	
	
	INSERT INTO domicilio (calle,numero,tipo,descripcion,interseccion,observacion,barrio_id,voz_calle_id,voz_interseccion_id,zona_id,estado)
	VALUES (calle,numero,tipo,descripcion,interseccion,observacion,barrio,@vcalle,@vinterseccion,zona,0);
	
	/*aca insertamos en la tabla telefono_domicilio*/
	SET @lastdomicilio = LAST_INSERT_ID();
	INSERT INTO telefono_domicilio (domicilio_id,telefono_id,prioridad) VALUES (@lastdomicilio,telefono,0);
    END$$

DELIMITER ;