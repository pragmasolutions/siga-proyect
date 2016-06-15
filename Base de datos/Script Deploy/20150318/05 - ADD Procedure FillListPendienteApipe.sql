DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `FillListPendientesApipe`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `FillListPendientesApipe`()
BEGIN
    /*Procedimiento que trae la cantidad de pedidos pendientes*/
    SELECT * FROM pedido p
WHERE ISNULL(movil_id) AND((SELECT TIMEDIFF(p.fechahora_viaje,(SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s'))))<'00:11:00') 
AND ISNULL(operador_id) AND ISNULL(cancelado) AND ISNULL(completado) AND Estado = 'Cancelado_sistema_no_disponible' ORDER BY pedido_categoria_id DESC, fechahora_viaje ASC 
                    ;
    END$$

DELIMITER ;