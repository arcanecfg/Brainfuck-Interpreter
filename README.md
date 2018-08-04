Brainfuck Interpreter
======
## What is Brainfuck?
Brainfuck is the most famous esoteric programming language, and has inspired the creation of a host of other languages.
Brainfuck operates on an array of memory cells, also referred to as the tape, each initially set to zero. There is a pointer, initially pointing to the first memory cell.

#### Command	Description
```
>	Move the pointer to the right
<	Move the pointer to the left
+	Increment the memory cell under the pointer
-	Decrement the memory cell under the pointer
.	Output the character signified by the cell at the pointer
,	Input a character and store it in the cell at the pointer
[	Jump past the matching ] if the cell under the pointer is 0
]	Jump back to the matching [ if the cell under the pointer is nonzero
```
Read more: https://esolangs.org/wiki/Brainfuck

## What is this?
This is an interpreter for Brainfuck written in C#.

![alt text](https://puu.sh/B8HfR/31bf446b16.gif "Screenshot")



