<?php  
function rgbToXY($color)
{
foreach(['R','G','B'] as $val)
		{
		    //make range from 0 to 1
		    $color[$val]= $color[$val]/255;
		    //apply gamma correction for more vivid colors
		    $color[$val]=($color[$val]>0.04045)?pow(($color[$val]+0.055)/(1.0+0.055),2.4):($color[$val]/12.92);
		}
//convert to XYZ
$X=$color['R']* 0.649926+$color['G']*0.103455+$color['B']*0.197109;
$Y=$color['R']* 0.234327+$color['G']*0.743075+$color['B']*0.022598;
$Z=$color['R']* 0.000000+$color['G']*0.053077+$color['B']*1.035763;
if(($X+$Y+$Z)==0)
    {
        $xVal=0;
        $yVal=0;
        
    }else{
      //calculate XY vals
		$xVal=$X/($X+$Y+$Z);
		$yVal=$Y/($X+$Y+$Z);  
    }
// The Y of XYZvalue indicates the brightness of the converted color.
$bri= $Y;
return [$xVal,$yVal,$bri];
}

function setColor($xVal,$yVal,$bri){

	    $data = array("on" =>"true", "xy"=>"[$xVal,$yVal]","bri"=>$bri); 
	 	 $data_string = json_encode($data);    
	    echo $data_string;  
	    //use your own bridge ip, user, bulb                                                                            
	    $ch = curl_init("http://<bridge ip address>/api/<user>/lights/<bulb url>/state");                                                                      
	    curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "PUT");                              
	    curl_setopt($ch, CURLOPT_POSTFIELDS, $data_string);                  
	    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
	    curl_setopt($ch, CURLOPT_HTTPHEADER, array(

	    'Content-Type: application/json',                                                                                
	    'Content-Length: ' . strlen($data_string))                                                                       
	    );                                                                                                                   

	    $result = curl_exec($ch);
	    print_r($result);
}

if(isset($_GET['id']))
	//authentication user if needed by adding a password / token
	//no real use of id in this project before release
	if(isset($_GET['R'],$_GET['B'],$_GET['B']))
	{
		$color= array('R'=>(int)$_GET['R'],'G'=>(int)$_GET['G'],'B'=>(int)$_GET['B'],);
		$XY=rgbToXY($color);
		//cast to philipsy
		setColor($XY[0],$XY[1],$XY[2]);
	}

?>

