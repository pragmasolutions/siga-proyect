DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `DomicilioActualizar`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `DomicilioActualizar`(IN pid INT(10),IN calle VARCHAR(80),IN numero INT(10), 
	IN tipo ENUM('CASA','DEPARTAMENTO','OFICINA','HOTEL','LOCAL'),IN descripcion VARCHAR(250),IN interseccion VARCHAR(200),
	IN observacion VARCHAR(200),IN barrio INT (10), IN zona INT(10))
BEGIN
	DECLARE  vcalle INTEGER;
	DECLARE vinterseccion INTEGER;
	SET @vcalle= (SELECT c.voz_id FROM calle c WHERE c.calle = calle LIMIT 1);
	SET @vinterseccion= (SELECT c.voz_id FROM calle c WHERE c.calle = interseccion LIMIT 1);
	
	
	
	UPDATE domicilio 
	SET calle=calle,numero=numero,tipo=tipo,descripcion=descripcion,interseccion=interseccion,observacion=observacion
	,barrio_id=barrio,voz_calle_id= @vcalle,voz_interseccion_id= @vinterseccion,zona_id=zona,estado=0
	WHERE id=pid;
    END$$

DELIMITER ;