<?php

define('DB_HOST', 'localhost');
define('DB_NAME', 'travel');
define('DB_PORT', '3306');
define('DB_USER', 'tr_agent');
define('DB_PASS', '010djqnb050');
define('TB_COUNTRIES', 'countries');

//use PDO;

class Common {

    private $db;

    function DB() {

        if ($this->db == null) {
            try
            {
                $dsn = 'mysql:host=' . DB_HOST . ';dbname=' . DB_NAME . ';port=' . DB_PORT . ';';
                $this->db = new PDO($dsn, DB_USER, DB_PASS);
                $this->db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            }
            catch (\PDOException $ex)
            {
                echo ($ex->getMessage());
            }
        }
    }

    function getAllCountries() {
        $this->DB();
        $_tb = TB_COUNTRIES;
        $stmt = $this->db->prepare("SELECT * FROM $_tb ORDER BY countryName");
        $stmt->execute();

        return $stmt->fetchAll(PDO::FETCH_OBJ);
    }

    function addNewCountry($country) {
        $_tb = TB_COUNTRIES;
        $this->DB();
        $sql = "INSERT INTO $_tb (countryName) 
                VALUES (:countryName)";
        $stmt = $this->db->prepare($sql);

        return $stmt->execute([
            ':countryName' => $country
        ]);
    }

    function getCountryById($id) {
        $_tb = TB_COUNTRIES;
        $this->DB();
        $sql = "SELECT * FROM $_tb WHERE id = :_id";
        $stmt = $this->db->prepare($sql);
        $stmt->execute([
            ':_id' => $id
        ]);

        return $stmt->fetch(PDO::FETCH_OBJ);
    }

    function updateCountryById($id, $country) {
        $_tb = TB_COUNTRIES;
        $this->DB();
        $sql = "UPDATE $_tb SET countryName = :country
                WHERE id = :_id";
        $stmt = $this->db->prepare($sql);
        return $stmt->execute([
            ':_id' => $id,
            ':country' => $country
        ]);
    }

    function deleteCountryById($id) {
        $_tb = TB_COUNTRIES;
        $this->DB();
        $sql = "DELETE FROM $_tb WHERE id = :_id";
        $stmt = $this->db->prepare($sql);
        $stmt->execute([
            ':_id' => $id,
        ]);

        return $stmt->rowCount();
    }
}