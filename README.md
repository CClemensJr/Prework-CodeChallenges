# Prework Code Challenges

This repo is all about storing the solutions to the code challenges that need to be completed before starting the Code Fellows Code 401 .Net course on January 7th, 2019.

## The Problems
### Problem 1: Array Max Result

#### Problem Statement
Given an array select a number that exists, and output the computated "score". The method you create should take in
both an array of integers and the integer the user selected.

Create a Console application that requests 5 numbers between 1-10. Output the array to the console and Ask the user to
select a number. After the selection, output the "score" of the number chosen.

#### Selection and Scoring Algorithm
You can select any number from the list, however your scoring will be depend on the frequency of that number in the list. 
E.g for [2,2,3,5,4] if you pick 2 your score will be 4 (2 * 2) but if you pick 5 your score will be 5 (5 * 1)

#### Input Format
An array of integers, and the number chosen.

#### Sample Input
[6,4,4,1,3] , 4

#### Sample Output
8


<hr />

### Problem 2: Leap Year Calculator

#### Problem Statement
Given a year, report if it is a leap year.

The tricky thing here is that a leap year in the Gregorian calendar occurs:

```
on every year that is evenly divisible by 4
  except every year that is evenly divisible by 100
    unless the year is also evenly divisible by 400

```

For example, 1997 is not a leap year, but 1996 is. 1900 is not a leap year, but 2000 is.



<hr />

### Problem 3: Perfect Sequence

#### Problem Statement
Given a sequence. Return "Yes" if the sequence is considered a perfect sequence. Otherwise, return "No"

#### Perfect Sequences
A perfect sequence is a sequence such that all of its elements are non-negative integers and the product of all of them is equal to their sum. 
For example: [2,2], [1,3,2] and [0,0,0,0] are perfect sequences and [4,5,6] and [0,2,-2] are not perfect sequences. Negative numbers of any kind are not valid in 
a perfect sequence

#### Input Format
An array of integers (may not be sorted)

#### Sample Input
[1,3,2]

#### Sample Output
Yes

#### Explanation
1 * 3 * 2 = 6 && 1 + 3 + 2 = 6


<hr />

### Problem 4: Sum of Rows

#### Problem Statement
Given a matrix of integers. Return the sum of each row in a single dimensional array. 

#### Input Format
A multidimensional array with the dimensions of **m x n** (m = rows, n = columns).

1. Duplicate integers are possible.
2. Negative numbers are possible
3. Both **m** and **n** can vary in length

The user should specify the length and the width of the array within the console. To populate the numbers, you may randomly generate them, or have the user input one by one.

***The method should take in the multidimensional array and return the single dimensional array with the sums***

#### Sample Input
```csharp
int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
```

^^ The actual input would just be `myArray`, but the above code shows the pre-initialization before the method is called. 

#### Sample Output

{15,40,65} <-- an integer array


## Solution Verification
### Problem 1:
#### Sample Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/array_max_result_sample_input.PNG?raw=true "Sample Input")
#### Random Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/array_max_result_random_input.PNG?raw=true "Random Input")

### Problem 2:
#### Sample Valid Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/leap_year_calculator_sample_valid_input.PNG?raw=true "Sample Valid Input")
#### Sample Invalid Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/leap_year_calculator_sample_invalid_input.PNG?raw=true "Sample Invalid Input")
#### Custom Valid Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/leap_year_calculator_custom_valid_input.PNG?raw=true "Custom Valid Input")
#### Custom Invalid Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/leap_year_calculator_custom_invalid_input.PNG?raw=true "Custom Invalid Input")

### Problem 3:
#### Sample Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/perfect_sequence_sample_valid_input.PNG?raw=true "Sample Input")
#### Custom Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/perfect_sequence_custom_invalid_input.PNG?raw=true "Custom Input")

### Problem 4:
#### Sample Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/sum_of_rows_sample_input.PNG?raw=true "Sample Input.")
#### Random Input:
![alt text](https://github.com/CClemensJr/Prework-CodeChallenges/blob/master/solution-images/sum_of_rows_random_input.PNG?raw=true "Random Input.")



