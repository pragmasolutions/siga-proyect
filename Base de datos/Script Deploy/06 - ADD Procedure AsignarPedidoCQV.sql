DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `AsignarPedidoCQV`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `AsignarPedidoCQV`(IN pedido INT(10),IN movil SMALLINT(5))
BEGIN
	/* FALTA LA BITACORA
	CALL BitacoraPedidoInsert(pedido);
	CALL BitacoraInsert(pedido,(SELECT domicilio_id FROM pedido WHERE id = pedido),operador,7);
	 */
	 
	DECLARE movilId INT;
	SET movilId = (SELECT id FROM movil WHERE numero = movil);
	 
	UPDATE pedido p SET
	p.asignado = NOW(),p.movil_id = movilId, p.chofer_id = 23386, p.operador_id = 99023,p.pedido_categoria_id= 7
	WHERE 
	p.id = pedido;
	
	CALL QuitarDeZona(movilId);
    END$$

DELIMITER ;