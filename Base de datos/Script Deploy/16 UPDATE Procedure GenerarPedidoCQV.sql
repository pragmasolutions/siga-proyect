DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `GenerarPedido`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `GenerarPedido`(IN cliente VARCHAR(250),IN fechahoraviaje DATETIME,IN observacion VARCHAR(240),IN usuario INT(10),IN categoria SMALLINT(5),IN domicilio INT(10),IN telefono INT(10))
BEGIN
	INSERT INTO pedido 
	(cliente,fechahora,fechahora_viaje,observacion,usuario_id,pedido_categoria_id,domicilio_id,telefono_id,estado) 
	VALUES (cliente,NOW(),fechahoraviaje,observacion,usuario,categoria,domicilio,telefono,"Pendiente_Apipe");
    END$$

DELIMITER ;