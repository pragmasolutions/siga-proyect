DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `CancelarPedidoCQV`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `CancelarPedidoCQV`(IN pedido INT(10),IN telefonista INT(10),IN movilNro SMALLINT(5))
BEGIN
	/* BITACORA Insertar en bitacora con pedido_id_bitacora = pedido, usuario_id = telefonista y operacion_id= 3 
	call BitacoraInsert(pedido,(SELECT domicilio_id FROM pedido WHERE id = pedido),telefonista,3);*/
	DECLARE movilId INT(10);
	SET movilId = (SELECT id FROM movil WHERE numero = movilNro);
	UPDATE movil m SET m.en_zona= NOW(), m.zona_id = 12 WHERE m.id = movilId;
	
	UPDATE pedido p SET
	p.cancelado = NOW()
	WHERE 
	p.id = pedido;
    END$$

DELIMITER ;