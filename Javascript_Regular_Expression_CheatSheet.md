# JavaScript Regular Expression Cheat Sheet

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
`{n}` or `{n,n}` - qualifier limit

`+` - one or more is allowed

`*` - zero or more is allowed

`?` - zero or one is allowed



## Reference of Capturing Group
`\n` - capturning number like `\1`


## Flags
`i` - case in-sensitive

`g` - global search

`u` - unicode

`m` - multiline search

`y` - sticky mode

`s` - dotall mode - . to match newline `\n`

## Use in String Functions

1. `"string".match(/pattern/)` - provides the following output.    
array - containing matched string in index 0 along with capturing group values   
index - the matched index position    
input - original input string  

2. `"string".search(/pattern/)` - find the index of the position matched, else -1

3. `"string".split(/pattern/, limit)` - split based on given pattern and output as array, limit to find specified length.

4. `"string".replace(/pattern/, 'replaceValue')` - replaces the given value in matched postions

## Use from Regular Expression Type

1. `/pattern/.exec("string")` - executes the pattern in the string   
Returns same values as `string.match`

2. `/pattern/.test("string"` - return true if matches else false.




