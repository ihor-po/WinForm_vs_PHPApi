<?php
/**
 * Created by PhpStorm.
 * User: sobik
 * Date: 30.12.2018
 * Time: 08:04
 */

class LogHelper
{
    static function addLog($action, $data) {
        $date = new DateTime('NOW');

        $log = $date->format('Y-m-d H:i:s') . ' - ' . $action . ': ' . $data . PHP_EOL;
        if (file_exists('apiLog.log')) {
            file_put_contents('apiLog.log', $log, FILE_APPEND);
        } else {
            file_put_contents('apiLog.log', $log);
        }

    }
}