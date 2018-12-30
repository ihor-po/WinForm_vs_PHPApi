<?php
//include_once 'Country.php';
include_once '../views/functions.php';
require_once 'common.php';
require_once 'LogHelper.php';

//connect();
if(checkToken($_POST['token'])){

    switch ($_POST['param'])
    {
        case 'getCountries':
            $items = Common::getAllCountries();
            echo json_encode($items);
            break;

        case 'addCountry':
            $newCountry = $_POST['country'];
            $items = Common::addNewCountry($newCountry);

            if($items){
                LogHelper::addLog('Add new country', $newCountry);
                echo 200;
            }
            else
            {
                echo 500;
            }
            break;

        case 'getCountryById':
            $id = $_POST['countryId'];
            $res = Common::getCountryById($id);
            echo json_encode($res);
            break;

        case 'updateCountryById':
            $id = $_POST['countryId'];
            $country = $_POST['country'];
            $res = Common::updateCountryById($id, $country);

            if($res){
                LogHelper::addLog('Update country by Id', $id . ' => new country Name: ' . $country);
                echo 200;
            }
            else
            {
                echo 500;
            }
            break;

        case 'deleteCountryById':
            $id = $_POST['countryId'];
            $res = Common::deleteCountryById($id);

            if($res){
                LogHelper::addLog('Delete country by ID', $id);
                echo 200;
            }
            else
            {
                echo 500;
            }
            break;

        case 'getCities':
            $items = Common::getCountryCities($_POST['countryId']);
            echo json_encode($items);
            break;

        case 'createCity':
            $city = str_replace('\\','', $_POST['city']);
            $city = json_decode($city, true);

            $items = Common::createNewCity($city);
            if($items){
                LogHelper::addLog('Add new city', 'newCity: ' . $city['cityName'] . '; Country ID: ' . $city['countryId']);
                echo 200;
            }
            else
            {
                echo 500;
            }
            break;
            break;

        case 'updateCity':
            $city = str_replace('\\','', $_POST['city']);
            $city = json_decode($city, true);

            $res = Common::updateCityById($city);

            if($res){
                $data = $city['id'] . '; cityName: ' . $city['cityName'] . '; countryID: ' . $city['countryId'];
                LogHelper::addLog('Update city by Id',  $data);
                echo 200;
            }
            else
            {
                LogHelper::addLog('Update city by Id ERROR',  $res);
                echo 500;
            }
            break;

        case 'deleteCity':
            $id = $_POST['city'];
            $res = Common::deleteCity($id);

            if($res){
                LogHelper::addLog('Delete City ID', $id);
                echo 200;
            }
            else
            {
                LogHelper::addLog('Delete city ERROR',  $res);
                echo 500;
            }
            break;
    }

}else
    echo '<h1 class="text-danger">Your token is BAD</h1>';