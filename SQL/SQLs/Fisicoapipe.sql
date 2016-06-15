--
-- ER/Studio 8.0 SQL Code Generation
-- Company :      Yugoo
-- Project :      apipe.dm1
-- Author :       Rodrigo
--
-- Date Created : Monday, August 05, 2013 13:16:34
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: agenda 
--

CREATE TABLE agenda(
    id              INT UNSIGNED   AUTO_INCREMENT,
    cliente         VARCHAR(80),
    inicio          DATE           DEFAULT 0 NOT NULL,
    fin             DATE           NOT NULL,
    domicilio_id    INT UNSIGNED   NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: aseguradora 
--

CREATE TABLE aseguradora(
    entidad_id    INT    NOT NULL,
    PRIMARY KEY (entidad_id)
)ENGINE=INNODB
;



-- 
-- TABLE: barrio 
--

CREATE TABLE barrio(
    id              INT UNSIGNED    AUTO_INCREMENT,
    nombre          VARCHAR(120)    NOT NULL,
    lectura         BIT(1)          DEFAULT 0 NOT NULL,
    voz_id          INT UNSIGNED,
    localidad_id    SMALLINT UNSIGNED  NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: barrio_zona 
--

CREATE TABLE barrio_zona(
    barrio_id    INT UNSIGNED  NOT NULL,
    zona_id      INT UNSIGNED  NOT NULL,
    PRIMARY KEY (barrio_id, zona_id)
)ENGINE=INNODB
;



-- 
-- TABLE: chofer 
--

CREATE TABLE chofer(
    id                        INT             NOT NULL,
    turno                     ENUM('DIURNO','NOCTURNO') NOT NULL,
    factura                   BIT(1)          DEFAULT 0 NOT NULL,
    carnet_vencimiento        DATE            NOT NULL,
    transporte_vencimiento    DATE            NOT NULL,
    observaciones             VARCHAR(250),
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: chofer_movil 
--

CREATE TABLE chofer_movil(
    chofer_id      INT             NOT NULL,
    movil_id       INT UNSIGNED    NOT NULL,
    inicio         DATE            NOT NULL,
    fin            DATE,
    observacion    VARCHAR(250),
    activo         BIT(1)          DEFAULT 1 NOT NULL,
    usuario_id     INT             NOT NULL,
    PRIMARY KEY (chofer_id, movil_id)
)ENGINE=INNODB
;



-- 
-- TABLE: cita 
--

CREATE TABLE cita(
    id           TINYINT UNSIGNED  AUTO_INCREMENT,
    dia          ENUM('LUNES','MARTES','MIERCOLES','JUEVES','VIERNES','SABADO','DOMINGO'),
    hora         TIME        NOT NULL,
    agenda_id    INT UNSIGNED  NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: cliente 
--

CREATE TABLE cliente(
    entidad_id              INT    NOT NULL,
    cliente_categoria_id    INT UNSIGNED  NOT NULL,
    PRIMARY KEY (entidad_id)
)ENGINE=INNODB
;



-- 
-- TABLE: cliente_categoria 
--

CREATE TABLE cliente_categoria(
    id             INT UNSIGNED   AUTO_INCREMENT,
    categoria      VARCHAR(50)    NOT NULL,
    descripcion    VARCHAR(50)    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: cupon 
--

CREATE TABLE cupon(
    id             INT UNSIGNED     AUTO_INCREMENT,
    cuota          TINYINT UNSIGNED  NOT NULL,
    vencimiento    DATE             NOT NULL,
    importe        DECIMAL(7, 2)    NOT NULL,
    pagado         BIT(1)           DEFAULT 0 NOT NULL,
    poliza_id      INT UNSIGNED     NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: domicilio 
--

CREATE TABLE domicilio(
    id                     INT UNSIGNED    AUTO_INCREMENT,
    calle                  VARCHAR(80)     NOT NULL,
    numero                 INT UNSIGNED    NOT NULL,
    tipo                   ENUM('CASA','DEPARTAMENTO','OFICINA','HOTEL','LOCAL') NOT NULL,
    descripcion            VARCHAR(250),
    interseccion           VARCHAR(200),
    observacion            VARCHAR(250),
    barrio_id              INT UNSIGNED    NOT NULL,
    voz_calle_id           INT UNSIGNED,
    voz_interseccion_id    INT UNSIGNED,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: entidad 
--

CREATE TABLE entidad(
    id                  INT            AUTO_INCREMENT,
    cuil                CHAR(13),
    apellido            VARCHAR(50)    NOT NULL,
    nombre              VARCHAR(50),
    estado_civil        enum('Casado','Soltero','Viudo','Divorciado','Concuvinato'),
    sexo                enum('Masculino','Femenino') DEFAULT 'Masculino' NOT NULL,
    fecha_nacimiento    DATE,
    tipo_documento      ENUM('D.N.I.','L.E.','L.C.','Pasaporte','Cédula Federal','Cédula Provincial'),
    nro_documento       INT            NOT NULL,
    observacion         VARCHAR(30),
    iva                 CHAR(100)      DEFAULT 'Consumidor Final',
    foto                BLOB,
    baja                BIT(18)        DEFAULT 0 NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: formulario 
--

CREATE TABLE formulario(
    id             SMALLINT        AUTO_INCREMENT,
    nombre_form    VARCHAR(30)     NOT NULL,
    detalle        VARCHAR(150)    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: formulario_rol 
--

CREATE TABLE formulario_rol(
    formulario_id    SMALLINT    NOT NULL,
    rol_id           SMALLINT UNSIGNED  NOT NULL,
    PRIMARY KEY (formulario_id, rol_id)
)ENGINE=INNODB
;



-- 
-- TABLE: frecuencia 
--

CREATE TABLE frecuencia(
    id        TINYINT UNSIGNED  AUTO_INCREMENT,
    numero    TINYINT UNSIGNED  NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: localidad 
--

CREATE TABLE localidad(
    id              SMALLINT UNSIGNED  AUTO_INCREMENT,
    nombre          VARCHAR(36)    NOT NULL,
    cp              SMALLINT       NOT NULL,
    provincia_id    SMALLINT UNSIGNED  NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: mail 
--

CREATE TABLE mail(
    id            INT UNSIGNED    AUTO_INCREMENT,
    direccion     VARCHAR(100)    NOT NULL,
    dominio       VARCHAR(80)     NOT NULL,
    contacto      VARCHAR(80),
    entidad_id    INT             NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: movil 
--

CREATE TABLE movil(
    id                INT UNSIGNED    AUTO_INCREMENT,
    numero            SMALLINT UNSIGNED  NOT NULL,
    color             VARCHAR(30)     NOT NULL,
    chapa             CHAR(10)        NOT NULL,
    marca             VARCHAR(30)     NOT NULL,
    modelo            VARCHAR(30)     NOT NULL,
    aire              BIT(1)          NOT NULL,
    baul              ENUM('CHICO','NORMAL','GRANDE') NOT NULL,
    habilitacion      DATE            NOT NULL,
    seguro            DATE            NOT NULL,
    en_zona           DATETIME,
    observacion       VARCHAR(250),
    alta              DATE            NOT NULL,
    baja              DATE,
    habilitado        BIT(1)          DEFAULT 1 NOT NULL,
    telefono          VARCHAR(18),
    titular_id        INT             NOT NULL,
    responsable_id    INT             NOT NULL,
    frecuencia_id     TINYINT UNSIGNED,
    zona_id           INT UNSIGNED    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: operador 
--

CREATE TABLE operador(
    entidad_id       INT        NOT NULL,
    frecuencia_id    TINYINT UNSIGNED,
    PRIMARY KEY (entidad_id)
)ENGINE=INNODB
;



-- 
-- TABLE: pais 
--

CREATE TABLE pais(
    id        SMALLINT UNSIGNED  AUTO_INCREMENT,
    nombre    VARCHAR(20)    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: pedido 
--

CREATE TABLE pedido(
    id                     INT UNSIGNED    AUTO_INCREMENT,
    cliente                VARCHAR(250)    NOT NULL,
    fechahora              DATETIME        NOT NULL,
    fechahora_viaje        DATETIME        NOT NULL,
    asignado               DATETIME,
    completado             DATETIME,
    cancelado              DATETIME        NOT NULL,
    observacion            VARCHAR(240),
    chofer_id              INT,
    movil_id               INT UNSIGNED,
    usuario_id             INT             NOT NULL,
    operador_id            INT,
    pedido_categoria_id    SMALLINT UNSIGNED  NOT NULL,
    domicilio_id           INT UNSIGNED    NOT NULL,
    telefono_id            INT UNSIGNED    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: pedido_categoria 
--

CREATE TABLE pedido_categoria(
    id        SMALLINT UNSIGNED  AUTO_INCREMENT,
    nombre    VARCHAR(80)    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: poliza 
--

CREATE TABLE poliza(
    id                INT UNSIGNED  AUTO_INCREMENT,
    numero            INT UNSIGNED  NOT NULL,
    aseguradora_id    INT    NOT NULL,
    movil_id          INT UNSIGNED  NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: provincia 
--

CREATE TABLE provincia(
    id         SMALLINT UNSIGNED  AUTO_INCREMENT,
    nombre     VARCHAR(22)    NOT NULL,
    pais_id    SMALLINT UNSIGNED  NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: reclamo 
--

CREATE TABLE reclamo(
    id                      INT UNSIGNED    AUTO_INCREMENT,
    fechahora               DATETIME        NOT NULL,
    asunto                  VARCHAR(120)    NOT NULL,
    finalizo                DATETIME,
    cliente_id              INT             NOT NULL,
    reclamo_categoria_id    SMALLINT UNSIGNED  NOT NULL,
    pedido_id               INT UNSIGNED,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: reclamo_categoria 
--

CREATE TABLE reclamo_categoria(
    id        SMALLINT UNSIGNED  AUTO_INCREMENT,
    nombre    VARCHAR(80)    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: reclamo_linea 
--

CREATE TABLE reclamo_linea(
    id            INT UNSIGNED    AUTO_INCREMENT,
    fechahora     DATETIME        NOT NULL,
    comentario    VARCHAR(250)    NOT NULL,
    usuario_id    INT             NOT NULL,
    reclamo_id    INT UNSIGNED    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: rol 
--

CREATE TABLE rol(
    id        SMALLINT UNSIGNED  AUTO_INCREMENT,
    nombre    VARCHAR(60),
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: session 
--

CREATE TABLE session(
    usuario_id    INT          NOT NULL,
    ip            CHAR(15)     NOT NULL,
    ttl           TIMESTAMP    NOT NULL,
    PRIMARY KEY (usuario_id)
)ENGINE=INNODB
;



-- 
-- TABLE: telefonista 
--

CREATE TABLE telefonista(
    usuario_id    INT            NOT NULL,
    interno       SMALLINT UNSIGNED  NOT NULL,
    password      VARCHAR(80)    NOT NULL,
    dominio       VARCHAR(60)    NOT NULL,
    PRIMARY KEY (usuario_id)
)ENGINE=INNODB
;



-- 
-- TABLE: telefono 
--

CREATE TABLE telefono(
    id                INT UNSIGNED    AUTO_INCREMENT,
    tipo              ENUM('PARTICULAR','CELULAR','TRABAJO','OTRO') NOT NULL,
    cod_area          VARCHAR(10),
    numero            VARCHAR(20)     NOT NULL,
    horario_manana    VARCHAR(40),
    horario_tarde     VARCHAR(40),
    observaciones     VARCHAR(100),
    entidad_id        INT             NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: telefono_domicilio 
--

CREATE TABLE telefono_domicilio(
    domicilio_id    INT UNSIGNED  NOT NULL,
    telefono_id     INT UNSIGNED  NOT NULL,
    prioridad       SMALLINT UNSIGNED  NOT NULL,
    PRIMARY KEY (domicilio_id, telefono_id)
)ENGINE=INNODB
;



-- 
-- TABLE: usuario 
--

CREATE TABLE usuario(
    entidad_id    INT            NOT NULL,
    usuario       VARCHAR(16)    NOT NULL,
    password      VARCHAR(50)    NOT NULL,
    activo        BIT(1)         DEFAULT 1 NOT NULL,
    PRIMARY KEY (entidad_id)
)ENGINE=INNODB
;



-- 
-- TABLE: usuario_rol 
--

CREATE TABLE usuario_rol(
    usuario_id    INT         NOT NULL,
    rol_id        SMALLINT UNSIGNED  NOT NULL,
    PRIMARY KEY (usuario_id, rol_id)
)ENGINE=INNODB
;



-- 
-- TABLE: usuario_sucursal 
--

CREATE TABLE usuario_sucursal(
    usuario_id     INT         NOT NULL,
    sucursal_id    SMALLINT UNSIGNED  NOT NULL,
    PRIMARY KEY (usuario_id, sucursal_id)
)ENGINE=INNODB
;



-- 
-- TABLE: voz 
--

CREATE TABLE voz(
    id        INT UNSIGNED  AUTO_INCREMENT,
    nombre    CHAR(30)    NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- TABLE: zona 
--

CREATE TABLE zona(
    id               INT UNSIGNED   AUTO_INCREMENT,
    nombre           VARCHAR(80)    NOT NULL,
    zona_padre_id    INT UNSIGNED   NOT NULL,
    PRIMARY KEY (id)
)ENGINE=INNODB
;



-- 
-- INDEX: TelUnique 
--

CREATE UNIQUE INDEX TelUnique ON telefono(cod_area, numero)
;
-- 
-- INDEX: nombreUnique 
--

CREATE UNIQUE INDEX nombreUnique ON voz(nombre)
;
-- 
-- TABLE: agenda 
--

ALTER TABLE agenda ADD CONSTRAINT Refdomicilio69 
    FOREIGN KEY (domicilio_id)
    REFERENCES domicilio(id)
;


-- 
-- TABLE: aseguradora 
--

ALTER TABLE aseguradora ADD CONSTRAINT Refentidad43 
    FOREIGN KEY (entidad_id)
    REFERENCES entidad(id)
;


-- 
-- TABLE: barrio 
--

ALTER TABLE barrio ADD CONSTRAINT Refvoz75 
    FOREIGN KEY (voz_id)
    REFERENCES voz(id)
;

ALTER TABLE barrio ADD CONSTRAINT Reflocalidad82 
    FOREIGN KEY (localidad_id)
    REFERENCES localidad(id)
;


-- 
-- TABLE: barrio_zona 
--

ALTER TABLE barrio_zona ADD CONSTRAINT Refbarrio38 
    FOREIGN KEY (barrio_id)
    REFERENCES barrio(id)
;

ALTER TABLE barrio_zona ADD CONSTRAINT Refzona39 
    FOREIGN KEY (zona_id)
    REFERENCES zona(id)
;


-- 
-- TABLE: chofer 
--

ALTER TABLE chofer ADD CONSTRAINT Refentidad49 
    FOREIGN KEY (id)
    REFERENCES entidad(id)
;


-- 
-- TABLE: chofer_movil 
--

ALTER TABLE chofer_movil ADD CONSTRAINT Refchofer51 
    FOREIGN KEY (chofer_id)
    REFERENCES chofer(id)
;

ALTER TABLE chofer_movil ADD CONSTRAINT Refmovil52 
    FOREIGN KEY (movil_id)
    REFERENCES movil(id)
;

ALTER TABLE chofer_movil ADD CONSTRAINT Refusuario55 
    FOREIGN KEY (usuario_id)
    REFERENCES usuario(entidad_id)
;


-- 
-- TABLE: cita 
--

ALTER TABLE cita ADD CONSTRAINT Refagenda70 
    FOREIGN KEY (agenda_id)
    REFERENCES agenda(id)
;


-- 
-- TABLE: cliente 
--

ALTER TABLE cliente ADD CONSTRAINT Refentidad41 
    FOREIGN KEY (entidad_id)
    REFERENCES entidad(id)
;

ALTER TABLE cliente ADD CONSTRAINT Refcliente_categoria42 
    FOREIGN KEY (cliente_categoria_id)
    REFERENCES cliente_categoria(id)
;


-- 
-- TABLE: cupon 
--

ALTER TABLE cupon ADD CONSTRAINT Refpoliza47 
    FOREIGN KEY (poliza_id)
    REFERENCES poliza(id)
;


-- 
-- TABLE: domicilio 
--

ALTER TABLE domicilio ADD CONSTRAINT Refvoz76 
    FOREIGN KEY (voz_calle_id)
    REFERENCES voz(id)
;

ALTER TABLE domicilio ADD CONSTRAINT Refvoz77 
    FOREIGN KEY (voz_interseccion_id)
    REFERENCES voz(id)
;

ALTER TABLE domicilio ADD CONSTRAINT Refbarrio36 
    FOREIGN KEY (barrio_id)
    REFERENCES barrio(id)
;


-- 
-- TABLE: formulario_rol 
--

ALTER TABLE formulario_rol ADD CONSTRAINT Refformulario9 
    FOREIGN KEY (formulario_id)
    REFERENCES formulario(id)
;

ALTER TABLE formulario_rol ADD CONSTRAINT Refrol34 
    FOREIGN KEY (rol_id)
    REFERENCES rol(id)
;


-- 
-- TABLE: localidad 
--

ALTER TABLE localidad ADD CONSTRAINT Refprovincias14 
    FOREIGN KEY (provincia_id)
    REFERENCES provincia(id)
;


-- 
-- TABLE: mail 
--

ALTER TABLE mail ADD CONSTRAINT Refentidad17 
    FOREIGN KEY (entidad_id)
    REFERENCES entidad(id)
;


-- 
-- TABLE: movil 
--

ALTER TABLE movil ADD CONSTRAINT Refzona72 
    FOREIGN KEY (zona_id)
    REFERENCES zona(id)
;

ALTER TABLE movil ADD CONSTRAINT Refentidad53 
    FOREIGN KEY (titular_id)
    REFERENCES entidad(id)
;

ALTER TABLE movil ADD CONSTRAINT Refentidad54 
    FOREIGN KEY (responsable_id)
    REFERENCES entidad(id)
;

ALTER TABLE movil ADD CONSTRAINT Reffrecuencia62 
    FOREIGN KEY (frecuencia_id)
    REFERENCES frecuencia(id)
;


-- 
-- TABLE: operador 
--

ALTER TABLE operador ADD CONSTRAINT Refentidad60 
    FOREIGN KEY (entidad_id)
    REFERENCES entidad(id)
;

ALTER TABLE operador ADD CONSTRAINT Reffrecuencia61 
    FOREIGN KEY (frecuencia_id)
    REFERENCES frecuencia(id)
;


-- 
-- TABLE: pedido 
--

ALTER TABLE pedido ADD CONSTRAINT Reftelefono_domicilio81 
    FOREIGN KEY (domicilio_id, telefono_id)
    REFERENCES telefono_domicilio(domicilio_id, telefono_id)
;

ALTER TABLE pedido ADD CONSTRAINT Refusuario56 
    FOREIGN KEY (usuario_id)
    REFERENCES usuario(entidad_id)
;

ALTER TABLE pedido ADD CONSTRAINT Refchofer_movil58 
    FOREIGN KEY (chofer_id, movil_id)
    REFERENCES chofer_movil(chofer_id, movil_id)
;

ALTER TABLE pedido ADD CONSTRAINT Refoperador63 
    FOREIGN KEY (operador_id)
    REFERENCES operador(entidad_id)
;

ALTER TABLE pedido ADD CONSTRAINT Refpedido_categoria71 
    FOREIGN KEY (pedido_categoria_id)
    REFERENCES pedido_categoria(id)
;


-- 
-- TABLE: poliza 
--

ALTER TABLE poliza ADD CONSTRAINT Refaseguradora45 
    FOREIGN KEY (aseguradora_id)
    REFERENCES aseguradora(entidad_id)
;

ALTER TABLE poliza ADD CONSTRAINT Refmovil46 
    FOREIGN KEY (movil_id)
    REFERENCES movil(id)
;


-- 
-- TABLE: provincia 
--

ALTER TABLE provincia ADD CONSTRAINT Refpais13 
    FOREIGN KEY (pais_id)
    REFERENCES pais(id)
;


-- 
-- TABLE: reclamo 
--

ALTER TABLE reclamo ADD CONSTRAINT Refcliente64 
    FOREIGN KEY (cliente_id)
    REFERENCES cliente(entidad_id)
;

ALTER TABLE reclamo ADD CONSTRAINT Refreclamo_categoria65 
    FOREIGN KEY (reclamo_categoria_id)
    REFERENCES reclamo_categoria(id)
;

ALTER TABLE reclamo ADD CONSTRAINT Refpedido66 
    FOREIGN KEY (pedido_id)
    REFERENCES pedido(id)
;


-- 
-- TABLE: reclamo_linea 
--

ALTER TABLE reclamo_linea ADD CONSTRAINT Refusuario73 
    FOREIGN KEY (usuario_id)
    REFERENCES usuario(entidad_id)
;

ALTER TABLE reclamo_linea ADD CONSTRAINT Refreclamo74 
    FOREIGN KEY (reclamo_id)
    REFERENCES reclamo(id)
;


-- 
-- TABLE: session 
--

ALTER TABLE session ADD CONSTRAINT Refusuario83 
    FOREIGN KEY (usuario_id)
    REFERENCES usuario(entidad_id)
;


-- 
-- TABLE: telefonista 
--

ALTER TABLE telefonista ADD CONSTRAINT Refusuario78 
    FOREIGN KEY (usuario_id)
    REFERENCES usuario(entidad_id)
;


-- 
-- TABLE: telefono 
--

ALTER TABLE telefono ADD CONSTRAINT Refentidad35 
    FOREIGN KEY (entidad_id)
    REFERENCES entidad(id)
;


-- 
-- TABLE: telefono_domicilio 
--

ALTER TABLE telefono_domicilio ADD CONSTRAINT Refdomicilio79 
    FOREIGN KEY (domicilio_id)
    REFERENCES domicilio(id)
;

ALTER TABLE telefono_domicilio ADD CONSTRAINT Reftelefono80 
    FOREIGN KEY (telefono_id)
    REFERENCES telefono(id)
;


-- 
-- TABLE: usuario 
--

ALTER TABLE usuario ADD CONSTRAINT Refentidad22 
    FOREIGN KEY (entidad_id)
    REFERENCES entidad(id)
;


-- 
-- TABLE: usuario_rol 
--

ALTER TABLE usuario_rol ADD CONSTRAINT Refrol33 
    FOREIGN KEY (rol_id)
    REFERENCES rol(id)
;

ALTER TABLE usuario_rol ADD CONSTRAINT fk_usuario_has_rol_usuario1 
    FOREIGN KEY (usuario_id)
    REFERENCES usuario(entidad_id)
;


-- 
-- TABLE: usuario_sucursal 
--

ALTER TABLE usuario_sucursal ADD CONSTRAINT Refusuario23 
    FOREIGN KEY (usuario_id)
    REFERENCES usuario(entidad_id)
;


-- 
-- TABLE: zona 
--

ALTER TABLE zona ADD CONSTRAINT Refzona37 
    FOREIGN KEY (zona_padre_id)
    REFERENCES zona(id)
;


