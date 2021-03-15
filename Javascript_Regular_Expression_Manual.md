# JavaScript Regular Expression Manual

## Main Scope
`/` - start and end of regular expression

`\` - escape 

`.` - anything allowed

`\b` - boundary - checks for non-word (`\W`) character

`\w` - only alphabetical

`\W` - other than `\w` - non-word

`\s` - only spaces, tab, newline are allowed

`\S` - other than `\s` - non-space

`\d` - only numbers are allowed

`\D` - other than `\d` - non-digit

`[]` - set,  given expression in the sets are allowed

`^` - either starts with OR exclusion in `[^]`

`$` - ends with

`|` - alteration (OR case)

`()` - capturning group

`(?:)` - non-capturing

`A(?=B)` - positive look ahead - select A if A followed by B 

`A(?!B)` - negative look ahead - select A if A is not followed by B

`(?<=A)B` - positive look behind - select B if A preceded by B

`(?<!A)B` - negative look behind - select B if A is not preceded by B

## Quantifiers
`{n}` - fixed quantity limit

`{n,}` - minimun quantity limit

`{n,n}` - minimum to maximum quantity limit

`+` - one or more is allowed

`*` - zero or more is allowed

`?` - zero or one is allowed

## Greedy and Lazy Search
Greedy and lazy search works in the quantifiers.   
_Greedy_ - default search mode - searches until the sequence matches.  
_Lazy_ - moves to next search pattern once the patterns matches minimum requirement.  

`?` - Used as lazy operator.  

```Javascript
// example
'Hello #God# and #Devil#'.match(/#.+#/g)  // `"God" and "Devil"` - 1 element matches as greedy `.` matches even # and then search comeback from end to see # at end again.
'Hello #God# and #Devil#'.match(/#.+?#/g)  // `"God"` and `"Devil"` - 2 element matches, Lazy `?` stops the match for `.` in `G` and looks for `"` until it finds
```

## Reference of Capturing Group
`\n` - capturning number like `\1`

## Use References in Regular Expression
Using reference in same Regular Expression avoids rewriting same expression.

#### By Name 
String _RegEx_ is named as *love* and reused in regex by `\k<name>`, so here it is `\k<love>`  
```Javascript
/(?<love>RegEx) or \k<love>/g.exec("RegEx or RegEx") // matches "RegEx or RegEx"
```

#### By Reference number \n
Capturing group number 1 is used in regex here.
```Javascript
/(RegEx) or \1/g.exec("RegEx or RegEx") // matches "RegEx or RegEx"
```

## Flags
`i` - case in-sensitive

`g` - global search

`u` - unicode

`m` - multiline search

`y` - sticky mode

`s` - dotall mode - . to match newline `\n`

## Use in String Functions

1. `"string".match(/pattern/)` - provides the following output.   
If `g` global search then,     
Returns an array containing all the matched elements.  
OR        
array - containing matched string in index 0 along with capturing group values from index 1 to n.  
index - the first matched index position      
input - original input string   

2. `"string".search(/pattern/)` - find the index of the first matched position, else -1

3. `"string".split(/pattern/, limit)` - split based on given pattern and output as array, limit to find specified length.

4. `"string".replace(/pattern/, 'replaceValue')` - replaces the given value in matched postions

## Use from Regular Expression Type

1. `/pattern/.exec("string")` - executes the pattern in the string   
array - containing matched string in index 0 along with capturing group values from index 1 to n.  
index - the first matched index position     
input - original input string   

2. `/pattern/.test("string")` - return true if matches else false.



Thank you for reading my docs.
If you feel anything can be updated, please create pull request.
