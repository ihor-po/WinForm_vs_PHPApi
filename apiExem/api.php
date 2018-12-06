<?php
include_once 'Country.php';
include_once '../views/functions.php';
require_once 'common.php';

//connect();
if(checkToken($_POST['token'])){

    switch ($_POST['param'])
    {
        case 'getCountries':
            $c = new Common();
            $items = $c->getAllCountries();
            //file_put_contents('test.txt', json_encode($items));

            echo json_encode($items);
            break;

        case 'addCountry':
            $newCountry = $_POST['country'];
            $c = new Common();
            $items = $c->addNewCountry($newCountry);

            if($items){
                echo 200;
            }
            else
            {
                echo 500;
            }
            break;

        case 'getCountryById':
            $id = $_POST['countryId'];
            $c = new Common();
            $res = $c->getCountryById($id);
            echo json_encode($res);
            break;

        case 'updateCountryById':
            $id = $_POST['countryId'];
            $country = $_POST['country'];
            $c = new Common();
            $res = $c->updateCountryById($id, $country);
            file_put_contents('test.txt', json_encode($res));
            if($res){
                echo 200;
            }
            else
            {
                echo 500;
            }
            break;

        case 'deleteCountryById':
            $id = $_POST['countryId'];
            $c = new Common();
            $res = $c->deleteCountryById($id);
//            file_put_contents('test.txt', json_encode($res));
            if($res){
                echo 200;
            }
            else
            {
                echo 500;
            }
            break;
    }

}else
    echo '<h1 class="text-danger">Your token is BAD</h1>';