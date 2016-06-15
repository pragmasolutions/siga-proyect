DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `FillPedidoByCQV`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `FillPedidoByCQV`(IN id INT(10))
BEGIN
	SELECT * FROM pedido p WHERE IdCQV= id;
    END$$

DELIMITER ;