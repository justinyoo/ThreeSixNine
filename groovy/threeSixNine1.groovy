// groovy 한줄 버전이예요.
// 일단 1..100 까지 각 숫자 뒤에 \n (줄넘김) 을 붙여서 한덩어리 문자열로 만들어요
// 이제 전체 문자열에서 3/6/9 를 찾아서 모조리 "짝"으로 바꿔요..예~
// for,each,closure 가 없어서 성능상 이익 같지만,
// join, regular expression search 그리고 replaceAll 등의 성능과 trade off 일 것 같아요.
print (((1..100).join('\n')=~/([^369\n]*[369][^369\n]*)/).replaceAll('짝'))