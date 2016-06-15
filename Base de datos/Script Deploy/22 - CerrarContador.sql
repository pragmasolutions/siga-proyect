DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `CerrarContador`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `CerrarContador`(IN idparam INT(11))
BEGIN
	UPDATE contador
	SET fechafin=NOW()
	WHERE id = idparam;
    END$$

DELIMITER ;