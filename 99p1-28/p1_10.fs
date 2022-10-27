// Find the last element of a list.
let myLast (l: 'a list): int =
    List.last l
    
// Find the last but one element of a list.
let myButLast =

// Find the K'th element of a list. The first element in the list is number 1.
let elementAt (coll: 'a list) (n: int) =
    coll[n]

// Find the number of elements of a list.
let myLength (l: 'a list): int =
    l.Length
    
// Reverse a list.
let myReverse (l: 'a list): 'a list =
    List.rev l
    
// Find out whether a list is a palindrome. A palindrome can be read forward or backward; e.g. (x a m a x).
let isPalindrome (l: 'a list): bool =
    l = (List.rev l)
    
// Transform a list, possibly holding lists as elements into a `flat' list by replacing each list with its elements (recursively).
let myFlatten =

// If a list contains repeated elements they should be replaced with a single copy of the element. The order of the elements should not be changed.
let compress =

// Pack consecutive duplicates of list elements into sublists. If a list contains repeated elements they should be placed in separate sublists.
let pack =

// Run-length encoding of a list. Use the result of problem P09 to implement the so-called run-length encoding data compression method. Consecutive duplicates of elements are encoded as lists (N E) where N is the number of duplicates of the element E.
let encode =
