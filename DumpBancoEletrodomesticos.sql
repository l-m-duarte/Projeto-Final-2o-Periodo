

CREATE DATABASE IF NOT EXISTS bd_eletrodomesticos
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_0900_ai_ci;

USE bd_eletrodomesticos;

DROP PROCEDURE IF EXISTS sp_insereEletrodomestico;
DROP PROCEDURE IF EXISTS sp_listaEletrodomesticos;
DROP PROCEDURE IF EXISTS sp_listaDonos;
DROP PROCEDURE IF EXISTS sp_removeEletrodomestico;
DROP PROCEDURE IF EXISTS update_eletrodomestico;
DROP PROCEDURE IF EXISTS sp_insereDono;

DROP TABLE IF EXISTS eletrodomesticos;
DROP TABLE IF EXISTS donos;

CREATE TABLE donos (
    iddono INT NOT NULL AUTO_INCREMENT,
    dono VARCHAR(45) DEFAULT NULL,
    PRIMARY KEY (iddono)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE eletrodomesticos (
    ideletrodomestico INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(45) DEFAULT NULL,
    potencia DOUBLE DEFAULT NULL,
    tempoMedioAtivo DOUBLE DEFAULT NULL,
    fk_dono INT NOT NULL,
    PRIMARY KEY (ideletrodomestico),
    KEY dono_idx (fk_dono),
    CONSTRAINT eletrodomestico_dono
        FOREIGN KEY (fk_dono) REFERENCES donos (iddono)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DELIMITER ;;
CREATE PROCEDURE sp_insereEletrodomestico(
    p_nome VARCHAR(45),
    p_potencia DOUBLE,
    p_tempoMedioAtivo DOUBLE,
    p_dono INT
)
BEGIN
    INSERT INTO eletrodomesticos
        (nome, potencia, tempoMedioAtivo, fk_dono)
    VALUES
        (p_nome, p_potencia, p_tempoMedioAtivo, p_dono);
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE sp_listaEletrodomesticos()
BEGIN
    SELECT
        e.ideletrodomestico,
        e.nome,
        e.potencia,
        e.tempoMedioAtivo,
        d.dono
    FROM eletrodomesticos e
    INNER JOIN donos d
        ON d.iddono = e.fk_dono;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE sp_listaDonos()
BEGIN
    SELECT iddono, dono
    FROM donos;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE sp_removeEletrodomestico(p_ideletrodomestico INT)
BEGIN
    DELETE FROM eletrodomesticos
    WHERE eletrodomesticos.ideletrodomestico = p_ideletrodomestico;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE update_eletrodomestico(
    p_ideletrodomestico INT,
    p_nome VARCHAR(45),
    p_dono INT,
    p_potencia DOUBLE,
    p_tempoMedioAtivo DOUBLE
)
BEGIN
    UPDATE eletrodomesticos
    SET
        nome = p_nome,
        fk_dono = p_dono,
        potencia = p_potencia,
        tempoMedioAtivo = p_tempoMedioAtivo
    WHERE ideletrodomestico = p_ideletrodomestico;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE sp_insereDono(p_nomeDono VARCHAR(45))
BEGIN
    INSERT INTO donos (dono)
    VALUES (p_nomeDono);
END ;;
DELIMITER ;
