DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `ModificarEstadoPedido`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `ModificarEstadoPedido`(IN pedido INT(10),IN idCQV INT(10),IN estado VARCHAR(40))
BEGIN
	/* FALTA LA BITACORA
	CALL BitacoraPedidoInsert(pedido);
	CALL BitacoraInsert(pedido,(SELECT domicilio_id FROM pedido WHERE id = pedido),operador,7);
	 */
	UPDATE pedido p SET
	p.Estado = estado,p.IdCQV = idCQV
	WHERE 
	p.id = pedido;
    END$$

DELIMITER ;