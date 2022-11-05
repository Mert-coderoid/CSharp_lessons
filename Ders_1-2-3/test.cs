/* In the middle of a nightmare, Maxine suddenly finds herself in a mysterious room with the following items:

A piece of paper with the word score and the integer  written on it.
A map of the castle where the room is located.
There are  rooms uniquely labeled from  to .
There are  bidirectional corridors connecting pairs of rooms. The value of score changes every time she travels up or down a corridor, and this value differs depending on her direction of travel along the corridor. Each corridor can be traveled any number of times in either direction.
Every room is reachable from every other room.
Maxine is located in the room labeled .
The exit is located in the room labeled . Once this room is reached, score is reduced modulo  and Maxine can (but is not required to) exit that level!
Assume some corridor  (where ) is associated with an integer, , and connects rooms  and . Then:

Traveling corridor  from room  to room  increases score by .
Traveling corridor  from room  to room  decreases score by .
There are  levels to Maxine's nightmare castle, and each one has a different set of values for , , and . Given the above information, help Maxine by finding and printing her maximum possible score for each level. Only you can help her wake up from this nightmare!

Note: Recall that the result of a modulo operation is always non-negative. For example, .

Input Format

The first line contains a single integer, , denoting the number of rooms.
Each of the  subsequent lines describes a corridor in the form of three space-separated integers denoting the respective values for , , and .
The next line contains a single integer, , denoting the number of queries.
Each of the  subsequent lines describes a level in the form of three space-separated integers denoting its respective , , and  values.

Constraints

, 
For each level:

The room layout is the same
Subtask

 for  of max score.
Output Format

For each of the  levels, print the maximum possible score for that level on a new line.

Sample Input

3
1 3 5
2 3 8
2 1 31
1
1 2 13
Sample Output

12
Explanation

The Sample Input represents the following setup:

longest-mod-path-sample.png

We want to travel from room  to room  while maximizing the value of score. There are at least two ways to achieve the maximum score value of :

Travel through corridors  times: 

.

Travel through corridors  times: 
, because  is the smallest non-negative integer  such that  divides . */