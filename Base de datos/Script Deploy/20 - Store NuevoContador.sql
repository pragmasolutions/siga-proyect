DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `NuevoContador`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `NuevoContador`(IN fechaInicio DATETIME)
BEGIN
	INSERT INTO `contador` 
	(`fechainicio`, 
	`contador`)
	VALUES
	(fechaInicio, 
	0);
    END$$

DELIMITER ;