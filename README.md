# HTTP5101-Assgn2-AlbyBaby


There are 4 problems in this file 
1 J1 Problem
1 J2 Problem
2 J3 Problem

Problem J1: Next in line

Problem Description
You know a family with three children. Their ages form an arithmetic sequence: the difference in
ages between the middle child and youngest child is the same as the difference in ages between
the oldest child and the middle child. For example, their ages could be 5, 10 and 15, since both
adjacent pairs have a difference of 5 years.
Given the ages of the youngest and middle children, what is the age of the oldest child?
Input Specification
The input consists of two integers, each on a separate line. The first line is the age Y of the
youngest child (0 ≤ Y ≤ 50). The second line is the age M of the middle child (Y ≤ M ≤ 50).
Output Specification
The output will be the age of the oldest child.
Sample Input 1
12
15
Output for Sample Input 1
18
Sample Input 2
10
10
Output for Sample Input 2
10
Adapted J2 - Roll the Dice

Original Source : https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf
Diana is playing a game with two dice.
● One dice has m sides labelled 1, 2, 3 ..., m
● The other dice has n sides labelled 1, 2, 3, …, n
Write a program which determines how many ways she can roll the value of 10.
For example, when the first die has 6 sides (m=6) and the second die has 8 sides (n=8), there
are 5 ways to get the sum 10.
Input Specification
GET: http://localhost/api/J2/DiceGame/{m}/{n}
{m} - positive integer representing the number of sides on the first die
{n} - positive integer representing the number of sides on the second die
Value on first die (m=6) Value on second die (n=8) Sum
2 8 10
3 7 10
4 6 10
5 5 10
6 4 10
Example HTTP request Example Response
GET ../api/J2/DiceGame/6/8 There are 5 total ways to get the sum 10.
GET ../api/J2/DiceGame/12/4 There are 4 ways to get the sum 10.
GET ../api/J2/DiceGame/3/3 There are 0 ways to get the sum 10.
GET ../api/J2/Dicegame/5/5 There is 1 way to get the sum 10.

Problem J3: Hidden Palindrome
 
 
(I couldn't finish this problem)


Problem Description
A palindrome is a word which is the same when read forwards as it is when read backwards. For
example, mom and anna are two palindromes.
A word which has just one letter, such as a, is also a palindrome.
Given a word, what is the longest palindrome that is contained in the word? That is, what is the
longest palindrome that we can obtain, if we are allowed to delete characters from the beginning
and/or the end of the string?
Input Specification
The input will consist of one line, containing a sequence of at least 1 and at most 40 lowercase
letters.
Output Specification
Output the total number of letters of the longest palindrome contained in the input word.
Sample Input 1
banana
Output for Sample Input 1
5
Explanation for Output for Sample Input 1
The palindrome anana has 5 letters.
Sample Input 2
abracadabra
Output for Sample Input 2
3
Explanation for Output for Sample Input 2
The palindromes aca and ada have 3 letters, and there are no other palindromes in the input
which are longer.
Sample Input 3
abba
Output for Sample Input 3
4

Problem J3: Rovarspr ¨ aket ˚


Problem Description
In Sweden, there is a simple child’s game similar to Pig Latin called Rovarspr ¨ aket (Robbers Lan- ˚
guage).
In the CCC version of Rovarspr ¨ aket, every consonant is replaced by three letters, in the following ˚
order:
• the consonant itself;
• the vowel closest to the consonant in the alphabet (e.g., if the consonant is d, then the closest
vowel is e), with the rule that if the consonant falls exactly between two vowels, then the
vowel closer to the start of the alphabet will be chosen (e.g., if the consonant is c, then the
closest vowel is a);
• the next consonant in the alphabet following the original consonant (e.g., if the consonant is
d, then the next consonant is f) except if the original consonant is z, in which case the next
consonant is z as well.
Vowels in the word remain the same. (Vowels are a, e, i, o, u and all other letters are consonants.)
Write a program that translates a word from English into Rovarspr ¨ aket. ˚
Input Specification
The input consists of one word entirely composed of lower-case letters. There will be at least one
letter and no more than 30 letters in this word.
Output Specification
Output the word as it would be translated into Rovarspr ¨ aket on one line. ˚
Sample Input 1
joy
Output for Sample Input 1
jikoyuz
Sample Input 2
ham
Output for Sample Input 2
hijamon
