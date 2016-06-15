DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `FillListPendientesIVR`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `FillListPendientesIVR`()
BEGIN
    /*Procedimiento que trae la cantidad de pedidos pendientes*/
    SELECT * FROM pedido p
WHERE ISNULL(movil_id) AND((SELECT TIMEDIFF(p.fechahora_viaje,(SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s'))))<'00:11:00') 
AND ISNULL(operador_id) AND ISNULL(cancelado) AND ISNULL(completado) AND Estado = 'Pendiente_CQV' ORDER BY pedido_categoria_id DESC, fechahora_viaje ASC 
                    ;
    END$$

DELIMITER ;