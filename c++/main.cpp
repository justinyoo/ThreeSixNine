#include <stdlib.h>
#include <cstring>
#include <string>
#include <iostream>

using namespace std;

int hasThreeSixNine(int number);

int main(int argc, char** argv){
    string strNum;
    int match = 0;
    for(int i = 1; i <= 100; i++){
        match = hasThreeSixNine(i);
        if(match){
            for(int x = 0; x < match; x++){
                cout << "clap ";
            }
            cout << "(" << i << ") ";
        } else {
            cout << i << " ";
        }
    }
}

int hasThreeSixNine(int number){
    int retVal = 0;
    int num = 0;
    string temp = "";
    char charNum;
    if(number == 0) return 0;
    while(number > 0){
        temp+=number%10+48;
        number/=10;
    }
    for(int i = 0; i < temp.length(); i++){
        charNum = temp[temp.length()-i-1];
        num = atoi(&charNum);
        if(num != 0 && !(num%3)) retVal++;
    }
    return retVal;
}
