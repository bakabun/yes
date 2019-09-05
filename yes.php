<?php
define('BUF_MAX_SIZE', 65536);

$inputString = (count($argv) > 1 ? $argv[1] : "y") . "\n";
$count = BUF_MAX_SIZE / floor(strlen($inputString));
$output = "";
for ($i = 0; $i < $count; $i += strlen($inputString)) {
	$output .= $inputString;
}
while (true) echo $output;
