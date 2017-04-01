# String_Encryption

Write a method Encrypt(char letter) which encrypts the letter in the following way:
•	Take the first and the last digit of its ASCII code and append them together in a string.
•	Append at the start of the resulting string the character corresponding to:
o	the ASCII code of the letter + the last digit of the ASCII code of the letter
•	Then append at the end of the resulting string the character corresponding to:
o	the ASCII code of the letter - the first digit of the ASCII code of the letter
•	The method should return the encrypted string.
Example
•	j -> p16i
o	j’s ASCII code is 106 -> First digit – 1, last digit – 6
o	Append the first and last digit -> 16
o	Append the character, resulting from the ASCII code + last digit to the start -> 106 + 6 -> 112 -> p
o	Append the character, resulting from the ASCII code - first digit to the end -> 106 - 1 -> 105 -> i
o	End result -> p16i
Assume that the input for this method will always be valid.
The main program should read an input from the user - an integer N.
On the next N lines, you will receive characters. Encrypt them and append them to an encrypted string.
In the end, what you should have is a long encrypted string of characters like this:

7 S o f t U n i -> V83Kp11nh12ez16sZ85Mn10mn15h

Your task is to print the encrypted string.

Examples:

Input
7
B
i
r
a
H
a
x

Output H66<n15hv14qh97XJ72Ah97Xx10w