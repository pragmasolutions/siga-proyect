DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `apipe2909`.`ActualizarContador`(IN idparam INT(11))
    BEGIN
	UPDATE contador
	SET contador=contador + 1
	WHERE id = idparam;
    END$$

DELIMITER ;