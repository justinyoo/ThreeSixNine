<?php
foreach(range(1,100) as $num) {	// 1부터 10까지 반복
	$out = '';			// 각 줄에 출력할 문자열
	$strn = "{$num}";	// 숫자를 문자열로 변경
	for($i=0,$n=strlen($strn); $i<$n; $i++) {	// 변경된 문자열 한 자씩 검사
		if(in_array($strn[$i], array(3,6,9))) $out .= '짝 ';	// 369가 있으면 "짝" 더함
	}
	echo (($out == '') ? $num : $out).'<br />';	// 출력값이 비면 원래 숫자 출력 아니면 "짝" 출력
}
?>