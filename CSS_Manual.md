# Cascading Style Sheet Manual

Possible values are represented in _[ ]_, provide any one values from the array box.

#### Define the charset of CSS
```css
@charset "ISO-enANY"
```

#### Media Queries 
```css
@media screen, print { ...css } 

/* OR */

<link rel="stylesheet" media="screen and (min-width:40px) and (max-width:100px)" href="docPath.css"/>
```

#### font-face
```css
/* example */
@font-face {    
  font-family: new-font-name;    
  src:url('');    
  /* other font css ... */
}
```

#### background
```css
background: color image repeat attachment vertical-position horizontal-position;

attachement => [fixed | scroll | inherit]
vertical-position => [top | bottom | center]
horizontal-position => [left | right | center]

/* example */
backgorund: red url("home.png") no-repeat fixed 10px 10px;
backgorund: transparent none no-repeat inherit 0 0; 

/* other background props */
background-clip: [border | padding]
background-size: 50px 30px;

```

#### brder & outline & border-radius
```css
border: width style color;
outline: color style width;
border-radius: 3px;

style => [dashed | dotted | double | groove | hidden | inset | none | outset | ridge | solid]

/* example */
border: 1px solid red;
border: 2px solid rgb(40, 40, 40);
border: 3px dashed #fff;
outline: red solid 1px;

/* other border props */
border-collapse: collapse;
```
#### box-shadow
```css
box-shadow: where x-offset y-offset blur spead color;

where - default - outside / inset;

/* example */
box-shadow: red 1px 3px 30px 2px;
```

#### box-sizing
```css
box-sizing: [border-box | content-box]
```

#### opacity
max value is 1 indicating visible.
```css
/* example */
opacaity: 1;
```

#### border-image
```css
border-image: source slice width outset repeat;

source => image url
slice => unit to slice the image. (corners are 4 and edge regions 4 and center one can be filled with 'fill' keyword. (top right bottom left - for splitting differently in image)
width => width to accomdate splitted image
outset => how much unit outside of border
repeat => [repeat, round, stretch, space]

/* example */
border-image: url(background-image) 50px 20px 100px 30px repeat;
```

#### top, bottom, left, right 
Positioned elements works with these css. (fixed, absolute, relative) other than static/initial position.
```css
/* example */
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
/* example */
color: red;
```

#### content
Only works with `:before` or `:after` syntax
```css
/* example */
content: ' '
```

#### cursor
```css
cursor: [auto | pointer | crosshair | help | ...]

/* example */
cursor: pointer;
```

#### pointer-events
Changes behaviour of events associated with pointer.  
```css
/* There are also SVG only property values associated with this */
pointer-events: [auto | none]

/* example */
pointer-events: none;
```

#### display
Set the display type for the element, display: none hides the element with no space in UI.
```css
display: [ inline | block | flex | grid | none | inherit ]

/* example */
display: block;


display: flex;
flex-direction: row | column | row-reverse | column_reverse;

/* flex-children can mention below. */
flex: 1;

flex-grow -- how much it can grow when space available
flex-shrink -- how much it can shrink when no space
flex-basis -- initial space


display: grid;
grid-template-rows: 1fr 2fr;
grid-template-columns: repeat(4, 1fr);

/* grid children */
grid-column: 1 / 4; -- from 1st line to 4th line -- 3 cells.
grid-row: 1 / 3;  -- from 1st line to 3rd line. - taking 2 rows.


/* alignments on grid and flex */
align-items - vertial alignment
align-content - horizonal content alignment
just-content - horizontal content alignment
justify-item - vertical item alignment - used in grid

```

#### font
```css
font: style variant weight size family;

style => [normal | italic | oblique]
variant => [normal | small-caps]
weight => [normal | bold | lighter | bolder | 100 through 900 | ...]
family => 'font-face-value or local fonts'

/* example */
font: italic small-caps 100 20px Calibri;
font: normal normal normal 1em Calibri;
```

#### width and height properties
```css
/* example */
min-height: 100px;
height: 200px;
max-height: 300px;

min-width: 100px;
width: 300px;
max-width: 500px;
```

#### Text Properties
```css
/* example */
letter-spacing: 2px;
word-spacing: 2px;
line-height: 2;
text-align: [center | left | right | ...]
text-decoration: [dashed | dotted | line-through | underline | ...]
text-indent: 2px;
text-transform: [capitalize | uppercase | lowercase | ...]
word-break: [break-all | break-word | ...]
word-wrap: [break-word | ...]


text-shadow: horizontal-offset vertical-offset blur-radius color;

/* example */
text-shadow: 1px 2px 10px red;
```

#### list-style
```css
list-style: [circle | disc | none | ...]

/* example */
list-style: none;
```

#### margin & padding
Spacing elements through margin and padding properties.
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
Set effect when element is overflow from its container
```css
overflow: [auto | scroll | hidden | visible]

/* example */
overflow: hidden;
```

#### position
Set the positioned value of element
```css
position: [intial | static | absolute | fixed | relative | sticky]

fixed => relative to window / initial containing block
sticky => scrolls and stays within window
absolute, static, relative, sticky - relative to positioned ancestor
static => normally flows in the document (top, right, bottom, left and z-index have no effect)


/* example */
position: absolute;
```

#### visibility
Hides the element from UI, but allocates the space.
```css
visibility: [visible | collapse | hidden | ...]

/* example */
visibility: hidden;
```

#### z-index
Layering the controls, higher value gets layered on top.
```css
/* example */
z-index: 5;
```

#### keyframes
keyframes are used in animation-name property.
```css
@keyframes keyframename 
{ 
  from {...css} 
  percentage {...css} 
  to {...css} 
}

/* example */
@keyframes keyframename {
  from {top: 0px;}
  20% { top: 100px }
  to {top: 200px;}
}
```

#### animation
Animative effect on elements.
```css
animation: name duration timing-function delay iteration-count direction;

timing-function => [cubicbezier(number,number,number,number) | ease | ease-in | ease-in-out | ease-out | linear]
iteration-count => [infinite | 1 to ... ]
direction => [normal | alternate]

/* example */
animation: animation-name 20s ease-in 1s 10 normal; 
```
#### perspective
Sets the 3d perspective.
```css
/* example */
perspective: 20px;
perspective-origin: 50% 50%;
```

#### transform
Change element view position, angle, make size changes, skew changes.
```css
/* short hand form */
transform: rotate(angle) scale(x-axis-scale, y-axis-scale) skew(x-axis-angle, y-axis-angle) translate(x-axis-size, y-axis-size);

transform: rotateX(angle) rotateY(angle) rotateZ(angle) scaleX(scale) scaleY(scale) skewX(angle) skewY(angle) translateX(size) translateY(size);

/* example */
transform: rotate(45deg) scale(1.2, 1.2);
transform: rotate(30deg) scale(1, 1) skew(20deg, 20deg) translate(10px, 10px); 
transform: rotateX(30deg) rotateY(20deg) rotateZ(10deg) scaleX(1.1) scaleY(1.2) skewX(20deg) skewY(20deg) translateX(10px) translateY(20px);
transform: rotateX(30deg) scaleX(1.1);
```

#### transform-origin
Sets the base of ratoted element (works with transform)
```css
transform-origin: [left | right | center | top | bottom]

/* example */
transform-origin: left;
```

#### transform-style
Set the 3d plane of child elements, if preserve-3d, child elements get its own 3d plane.
```css
transform-style: [flat | preserve-3d]

/* example */
transform-style: flat;
```

#### transition
Animative property for user interactions.
```css
transition: property duration timing-function delay;

property => any supported css property name
timing-function => [cubicbezier(number,number,number,number) | ease | ease-in | ease-in-out | ease-out | linear]

/* example */
transition: color 1s ease-in 0.1s;
color: red;
```

#### backface-visibility
Rotated element will have reverse info post 90 degree movement, this property allows to hide or show it, will the content as mirrored when visible.
```css
backface-visibility: [hidden | visible]

/* example */
backface-visibility: visible;
```

#### Gradients 
Gradients are very useful for replacing image properties and achieve greater effect.
```css
linear-gradient (start-angle, color from-unit to-unit, ..., color from-unit to-unit)
repeating-linear-gradient (start-angle, color from-unit to-unit, ..., color from-unit to-unit)

radial-gradient (radius-x radius-y at pos-x pos-y, color from-unit to-unit, ..., color from-unit to-unit)
repeating-radial-gradient (radius-x radius-y at pos-x pos-y, color from-unit to-unit, ..., color from-unit to-unit)

conic-gradient (from angle at pos-x pos-y, color from-unit to-unit, ..., color from-unit to-unit)
repeating-conic-gradient (from angle at pos-x pos-y, color from-unit to-unit, ..., color from-unit to-unit)


start-angle -- starts from bottom to top as default - 0 degree means to bottom to top
pos-x and pos-y -- position to start drawing
from-unit, to-unit -- any unit

note - displays exact mentioned color in between given 2 units... adjacent makes gradients.

/* example */
background: linear-gradient(30deg, red 0% 20%, blue 65% 70%, green 80%, yellow);
background: repeating-linear-gradient(30deg, red 3%, blue 6% 7%, green 8%, yellow 10%);
background: radial-gradient(50% 50%, red 35%, blue 65%, green 80%, yellow 100%);
background: repeating-radial-gradient(50% 50%, red 3%, blue 6%, green 8%, yellow 10%);
background: conic-gradient(from 0deg at 50% 50%, red 0 25%, blue 25% 50%, green 50% 75%, yellow 100%)
background: repeating-conic-gradient(from 0deg at 50% 50%, red 0 10%, blue 15% 20%, green 25% 30%, yellow 40%)

/* when value of radial-position goes below 50%, repeating gradient shows up. if more than 50% then it can show only one cycle. */
background: repeating-radial-gradient(20% 20%, red 35%, blue 65%, green 80%, yellow 100%);
```

#### filter
filter is amazing property that alters the look in variety of ways.
```css
filter: url('image') blur(size) contrast(percentage) greyscale(percentage) hue-rotate(degree) drop-shadow(x-axis y-axis blur color) invert(percentage) sepia(percentage) opacity(upto 1) saturate(percentage | upto 1);

/* example */
filter: url("https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png") blur(0.5px) contrast(10%) hue-rotate(3deg) drop-shadow(1px 1px 1px green) sepia(3%) invert(3%) opacity(1) saturate(0.1);
```

Thank you for reading my docs.  
If you feel anything can be updated, please create pull request.
