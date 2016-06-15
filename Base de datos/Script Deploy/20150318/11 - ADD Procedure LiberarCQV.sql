DELIMITER $$

CREATE
    /*[DEFINER = { user | CURRENT_USER }]*/
    PROCEDURE `apipe2909`.`LiberarCQV`(IN pedido INT(10))
    /*LANGUAGE SQL
    | [NOT] DETERMINISTIC
    | { CONTAINS SQL | NO SQL | READS SQL DATA | MODIFIES SQL DATA }
    | SQL SECURITY { DEFINER | INVOKER }
    | COMMENT 'string'*/
    BEGIN
/* FALTA LA BITACORA */
	UPDATE pedido p SET p.operador_id = NULL, p.movil_id= NULL, Estado="Pendiente_Apipe"
	WHERE 	p.id = pedido;
    END$$

DELIMITER ;