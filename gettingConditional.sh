#!/bin/bash

echo Jusat say [Y/N]

read input
if [ $input == "Y"]
	then
	echo YES
elif [ $input == "N"]
	then
	echo NO
else
echo Please select [Y/N]
fi
