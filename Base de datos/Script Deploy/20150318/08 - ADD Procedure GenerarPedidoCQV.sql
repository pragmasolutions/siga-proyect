DELIMITER $$

USE `apipe2909`$$

DROP PROCEDURE IF EXISTS `GenerarPedidoCQV`$$

CREATE DEFINER=`apipe`@`%` PROCEDURE `GenerarPedidoCQV`(IN cliente VARCHAR(250),IN fechahoraviaje DATETIME,IN observacion VARCHAR(240),
							IN usuario INT(10),IN categoria SMALLINT(5),IN domicilio INT(10),IN telefono INT(10),
							IN idCQV INT(10),IN Estado VARCHAR(40),IN Movil SMALLINT(5))
BEGIN
	INSERT INTO pedido 
	(cliente,
	fechahora,
	fechahora_viaje,
	observacion,
	usuario_id,
	pedido_categoria_id,
	domicilio_id,
	telefono_id,
	IdCQV,
	Estado,
	movil_id) 
	
	VALUES 
	(cliente,
	NOW(),
	fechahoraviaje,
	observacion,
	usuario,
	categoria,
	domicilio,
	telefono,
	IdCQV,
	Estado,
	(SELECT id FROM movil WHERE numero = Movil));
    END$$

DELIMITER ;