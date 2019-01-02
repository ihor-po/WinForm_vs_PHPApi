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

        case 'getHotels':
            if (isset($_POST) && !empty($_POST['countryId']) && !empty($_POST['cityId'])){
                $items = Common::getCityHotels($_POST['countryId'], $_POST['cityId']);
                echo json_encode($items);
            }
            else
            {
                LogHelper::addLog('Get Hotels ERROR', 'Error POST request' );
                echo 500;
            }
            break;

        case 'createHotel':
            if (isset($_POST) && !empty($_POST['hotel'])) {
                $hotel = str_replace('\\', '', $_POST['hotel']);
                $hotel = json_decode($hotel, true);

                $items = Common::createNewHotel($hotel);
                if ($items) {
                    $data = 'newHotel: ' . $hotel['hotelName'] . '; Country ID: ' . $hotel['countryId'] . '; CityID: ' . $hotel['cityId'];
                    LogHelper::addLog('Add new hotel', $data);
                    echo 200;
                } else {
                    echo 500;
                }
            } else {
                LogHelper::addLog('Create Hotel ERROR', 'Error POST request' );
                echo 500;
            }
            break;

        case 'updateHotel':
            if (isset($_POST) && !empty($_POST['hotel'])) {
                $hotel = str_replace('\\', '', $_POST['hotel']);
                $hotel = json_decode($hotel, true);

                $res = Common::updateHotelById($hotel);

                if ($res) {
                    $data = 'Hotel: ' . $hotel['hotelName'] . '; Country ID: ' . $hotel['countryId'] . '; CityID: ' . $hotel['cityId'];
                    LogHelper::addLog('Update hotel by Id', $data);
                    echo 200;
                } else {
                    LogHelper::addLog('Update hotel by Id ERROR', $res);
                    echo 500;
                }
            } else {
                LogHelper::addLog('Update Hotel ERROR', 'Error POST request' );
                echo 500;
            }
            break;

        case 'deleteHotel':
            if (isset($_POST) && !empty($_POST['hotel'])) {
                $id = $_POST['hotel'];
                $res = Common::deleteHotel($id);

                if ($res) {
                    LogHelper::addLog('Delete Hotel ID', $id);
                    echo 200;
                } else {
                    LogHelper::addLog('Delete Hotel ERROR', $res);
                    echo 500;
                }
            } else {
                LogHelper::addLog('Delete Hotel ERROR', 'Error POST request' );
                echo 500;
            }
            break;
    }

}else
    echo '<h1 class="text-danger">Your token is BAD</h1>';