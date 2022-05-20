function fizzBuzz(max) {
    let arr = [];
  
    for (let i = 1; i <= max; i++) {
       {
      // number divisible by 3 and 5 will
          // always be divisible by 15, print
          // 'FizzBuzz' in place of the number
          if (i%15 == 0)
              
               arr.push("FizzBuzz");
               //document.write("FizzBuzz" + " ");
          
          // number divisible by 3? print 'Fizz'
          // in place of the number
          else if (i%3 == 0)
              
               arr.push("Fizz");
               //document.write("Fizz" + " ");			
          
          // number divisible by 5, print 'Buzz'
          // in place of the number
          else if (i%5 == 0)				
               arr.push("Buzz");
               //document.write("Buzz" + " ");			
      
          else // print the number	
           arr.push(i);
      }
    }
    return arr;
  }
  
  console.log(fizzBuzz(20));