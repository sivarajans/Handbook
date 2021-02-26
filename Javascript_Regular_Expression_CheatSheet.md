# JavaScript Regular Expression Cheat Sheet

## Main Scope
`/` - start and end of regular expression

`\` - escape 

`.` - anything allowed

`\w` - only alphabetical

`\W` - other than `\w` - non-word

`\s` - only spaces, tab, newline are allowed

`\S` - other than `\s` - non-space

`\d` - only numbers are allowed

`\D` - other than `\d` - non-digit

`[]` - set,  given expression in the sets are allowed

`^` - either starts with OR exclusion in `[^]`

`$` - ends with

`()` - capturning group

`(?:)` - non-capturing

`|` - alteration (OR case)

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

