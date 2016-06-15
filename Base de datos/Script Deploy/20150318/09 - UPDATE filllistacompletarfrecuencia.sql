DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `FillListACompletarFrecuencia`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `filllistacompletarfrecuencia`(IN frecuencia TINYINT(3))
BEGIN
	SELECT *
	 FROM pedido p
	JOIN movil o ON o.id=p.movil_id WHERE o.frecuencia_id=frecuencia 
	AND NOT ISNULL(operador_id) AND ISNULL(completado) AND NOT ISNULL(movil_id) 
	AND ISNULL(completado) AND NOT ISNULL(movil_id) 
	ORDER BY o.numero ASC ;
    END$$

DELIMITER ;