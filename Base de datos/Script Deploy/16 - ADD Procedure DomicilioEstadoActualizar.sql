DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `DomicilioEstadoActualizar`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `DomicilioEstadoActualizar`(IN pid INT(10),IN estado INTEGER)
BEGIN
	
	UPDATE domicilio SET estado=estado WHERE id=pid;
    END$$

DELIMITER ;