# BRACKET SEQUENCE
### **Description**

By definition, a bracket sequence can contain only brackets such as *[ ]*, *{ }*, and *( )*. A balanced bracket sequence is the one that can be obtained by the following rules:
1. An empty sequence is a balanced bracket sequence.
2. If sequence A is a balanced bracket sequence, then each of sequences [A], {A}, and (A) are balanced.
3. If sequences A and B are balanced, sequence AB is balanced too.
4.
For example, *{[]}()* is a balanced bracket sequence, but *][* is not.

Suppose a sequence of integer numbers that codes a bracket sequence is given. Check whether the given sequence codes the balanced bracket sequence.

### **Input**
 1. Quantity of the brackets in the sequence, a positive integer.
 2. Members of the sequence, integers, where positive integers denote right brackets and negative ones denote left brackets. An absolute integer value shows the type of the bracket:

&nbsp;

    1 – round bracket.

    2 – curly bracket.

    3 – square bracket.

### **Output**
An integer can be either:
- One, if the given sequence codes the balanced bracket sequence.
- Zero, in the other case.

### **Complexity:**
O(n).

### **Additional memory:**
O(1).

### **Tags:** #stack, #balanced bracket sequence

Project code: BracketSequence

### **Examples:**
Input:

6 -2 -3 3 2 -1 1

Output:

1

Input:

2 3 -3

Output:

0

### **Calculations**
*Example 1.* If we decode `{-2 -3 3 2 -1 1}`, we will have *{[ ]}()* that is a balanced bracket sequence.

*Example 2.* If we decode `{3 -3}`, we will have *][* that isn’t balanced.
