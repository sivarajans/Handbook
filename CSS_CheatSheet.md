# Cascading Style Sheet Cheat Sheet

Possible values are represented in _[ ]_, provide any one values from the array box.

#### Define the charset of CSS
```css
@charset "ISO-enANY"
```

#### font-face Definition
```css
@font-face {    
  font-family: new-font-name;    
  src:url('');    
  /* other font css ... */
}
```

#### Media Queries 
```css
@media screen, print { } 

/* example */
<link rel="stylesheet" media="screen and (min-width:40px) and (max-width:100px)" href="docPath.css"/>
```

#### background-color
```css
background: color image repeat attachment vertical-position horizontal-position;

attachement: [fixed | scroll | inherit]
vertical-position: [top | bottom | center]
horizontal-position: [left | right | center]

/* example */
backgorund: red url("home.png") no-repeat fixed 10px 10px;
backgorund: transparent none no-repeat inherit 0 0; 
```

#### brder & outline
```css
border: width style color;
outline: color style width;

style: [dashed | dotted | double | groove | hidden | inset | none | outset | ridge | solid]

/* example */
border: 1px solid red;
border: 2px solid rgb(40, 40, 40);
border: 3px dashed #fff;
outline: red solid 1px;
```

#### border-collapse
```css
border-collapse: collapse;
```

#### top, bottom, left, right 
Positioned elements works with these css. (fixed, absolute, relative) other than static/initial position.
```css
top: 5px;
bottom: 1em;
left: 2cm;
right: 3px;
```

#### float
moves the element to the given side.
```css
float: [left | right]

/* example */
float: left;
```

#### clear
works to clear side of floated elements.
```css
clear: [both | left | right]

/* example */
clear: both;
```

#### color
```css
color: red;
```

#### content
works only with `:before` or `:after`
```css
content: ' '
```

#### cursor
```css
cursor: [auto | pointer | crosshair | help, ...]
```

#### display
```css
display: [ inline | block | list-item | run-in | inline-block | table | inline-table | table-row-group | table-header-group | table-footer-group | table-row | table-column-group | tablecolumn | table-cell | table-caption | none | inherit ]

/* example */
display: block;
```

#### font
```css
font: style varient weight size family;

style: [normal | italic | oblique]
varient: [normal | small-caps]
weight: [normal | bold | lighter | bolder | 100 through 900, ...]
family: 'font-face-value or local fonts'

/* example */
font: italic small-caps 100 20px Calibri;
font: normal normal normal 1em Calibri;
```

#### width and height properties
```css
min-height: 100px;
height: 200px;
max-height: 300px;

min-width: 100px;
width: 300px;
max-width: 500px;
```

#### Text Properties
```css
letter-spacing: 2px;
word-spacing: 2px;
line-height: 2;
text-align: [center | left | right | ...]
text-decoration: [dashed | dotted | line-through | underline | ...]
text-indent: 2px;
text-transform: [capitalize | uppercase | lowercase | ...]
word-break: [break-all | break-word | ...]
word-wrap: [break-word | ...]
```

#### list-style
```css
list-style: [circle | disc | none | ...]
```

#### margin & padding
```css
margin: top right bottom left;
padding: top right bottom left;

/* example */
margin: 2px;
margin: 2px 3px;
margin: 3px 2px 1px 0;

padding: 3px;
padding: 5px 3px;
padding: 3px 3px 0 0;
```
#### overflow
```css
overflow: [auto | scroll | hidden | visible]
```

#### position
```css
position: [intial | static | absolute | fixed | relative]
```

#### visibility
```css
visibility: [visible | collapse | hidden | ...]
```

#### z-index
layering the controls, higher value gets layered on top.
```css
z-index: 5;
```


