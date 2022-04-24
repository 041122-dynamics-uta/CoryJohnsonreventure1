# !/bin/bash
 



 Calculator ( ) {
echo "Enter Two numbers : "
read a
read b
 
echo "Enter Choice :"
echo "1. Addition"
echo "2. Subtraction"
echo "3. Multiplication"
echo "4. Division"
read ch
 

case $ch in
  1)
    res=$((a + b)) 
    ;;
  2)
    res=$((a - b)) 
    ;;
  3)
    res=$((a \* b)) 
    ;;
  4) if [ $b == 0 ]; then
      echo "$b is 0 or some other arithmetic error occurred" Select
  else res=$((a / b)) 

fi
    ;;
esac
echo $res
echo "Would you like to try another calculation?(y/n)"
Select

}

Select(){
read input
if [[ "$input" == Y || "$input" == y ]]
    then
      Calculator
elif [[ "$input" == N || "$input" == n ]]
    then
        exit

fi
}

Calculator





