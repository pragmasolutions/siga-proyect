DELIMITER |
DROP PROCEDURE IF EXISTS setSession|
CREATE PROCEDURE setSession(IN usuarioID INT(11))
    COMMENT 'Actualiza la Secion'
BEGIN
SET @IP=(select substr(host,1,POSITION(':' IN host)-1) from information_schema.processlist WHERE ID=connection_id());
INSERT INTO session (usuario_id,ip) VALUES (usuarioID,@IP) ON DUPLICATE KEY UPDATE ip=@IP;
END
|